using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using Excel = Microsoft.Office.Interop.Excel;

namespace lotteri
{
    public class LotteryVM
    {
        public int NoPrizes { get; set; }
        public string FileName { get; set; }

        public string ColumnLabel { get; set; }
        public string RowLabel { get; set; }

        private Excel.Application xlApp;
        private Excel.Workbook xlWorkBook;
        private Excel._Worksheet xlWorkSheet;
        private Excel.Range xlRange;
        private List<Tuple<string, string>> cellValues;
        private List<int> randomIndices;


        public string DrawPrize()
        {
            string errorMessage="";
            xlRange = FetchXlRange(ref errorMessage);
            cellValues = FetchCellValues(ref errorMessage);
            string warningMessage = "";
            randomIndices = FetchRandomIndices(ref warningMessage);
            if (!string.IsNullOrWhiteSpace(errorMessage))
            {
                return errorMessage;
            }
            StringBuilder resultBuilder=new StringBuilder(warningMessage);
            for (int i = 0; i < NoPrizes; ++i)
            {
                var idx = randomIndices[i];
                var winner = cellValues[idx].Item1 + ", " + cellValues[idx].Item2;
                resultBuilder.AppendLine((i+1).ToString() + ". premie: " + winner);
            }
            CleanUp();
            return resultBuilder.ToString();
        }

        private List<int> FetchRandomIndices(ref string warningMsg)
        {
            if (cellValues == null)
            {
                return null;
            }
            var random=new Random();
            var noLots = cellValues.Count;
            List<int> indices=new List<int>();
            int lotsDrawn = 0;
            if (NoPrizes >= noLots)
            {
                warningMsg = "Advarsel: Minst like mange premiser som solgte lodd, setter antall premier lik antall lodd\n";
                NoPrizes = noLots;
            }

            while (lotsDrawn < NoPrizes)
            {
                var idx = random.Next(0, noLots);
                if (!indices.Contains(idx))
                {
                    indices.Add(idx);
                    ++lotsDrawn;
                }
            }

            return indices;
        }

        private List<Tuple<string, string>> FetchCellValues(ref string errorMsg)
        {
            if (xlRange == null)
            {
                return null;
            }
            var rowCount = xlRange.Rows.Count;
            var colCount = xlRange.Columns.Count;
            if (rowCount < 3 || colCount < 2)
            {
                errorMsg += "Finner ingen gyldige loddbøker";
                return null;
            }

            try
            {
                var cellValues = new List<Tuple<string, string>>();
                for (int j = 1; j <= colCount; ++j)
                { 
                    var colText = ColumnLabel + xlRange.Cells[1, j].Value2.ToString();
                    for (int i = 2; i <= rowCount; ++i)
                    {
                        var cellValue = xlRange.Cells[i, j].Value2?.ToString();

                        if (!string.IsNullOrWhiteSpace(cellValue))
                        {
                            var rowText = RowLabel + cellValue;
                            cellValues.Add(Tuple.Create(colText, rowText));
                        }
                    }
                }
                return cellValues;
            }
            catch (Exception e)
            {
                errorMsg += "Feil ved lesing av Excel fil";
                return null;
            }

        }

        private Excel.Range FetchXlRange(ref string errorMsg)
        {
            try
            {
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(FileName);
            xlWorkSheet = xlWorkBook.Sheets[1];
            return xlWorkSheet.UsedRange;
            }
            catch (Exception e)
            {
                errorMsg = "Failed to open Excel and fetch data";
                return null;
            }

        }

        private void CleanUp()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            //release com objects to fully kill excel process from running in the background
            Marshal.ReleaseComObject(xlRange);
            Marshal.ReleaseComObject(xlWorkSheet);

            //close and release
            xlWorkBook.Close();
            Marshal.ReleaseComObject(xlWorkBook);

            //quit and release
            xlApp.Quit();
            Marshal.ReleaseComObject(xlApp);
        }
    }
}
