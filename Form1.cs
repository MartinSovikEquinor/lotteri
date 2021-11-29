using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lotteri
{
    public partial class LotteryForm : Form
    {
        private LotteryVM lotteryVM_;
        public LotteryForm(LotteryVM lotteryVm)
        {
            lotteryVM_ = lotteryVm;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void noPrizesInput_TextChanged(object sender, EventArgs e)
        {
            var prizeTextBox = sender as TextBox;
            lotteryVM_.NoPrizes = int.Parse(prizeTextBox.Text.ToString());
        }

        private void selectFile_Click(object sender, EventArgs e)
        {
            if (openExcelFileDialog.ShowDialog() == DialogResult.OK)
            {
                lotteryVM_.FileName = openExcelFileDialog.FileName;
                excelFileName.Text = openExcelFileDialog.FileName;
            }
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            resultText.Text = lotteryVM_.DrawPrize();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NoPrizesLabel_Click(object sender, EventArgs e)
        {

        }

        private void colLabelText_TextChanged(object sender, EventArgs e)
        {
            var colTextBox = sender as TextBox;
            lotteryVM_.ColumnLabel = colTextBox.Text;
        }

        private void rowLabelText_TextChanged(object sender, EventArgs e)
        {
            var rowTextBox = sender as TextBox;
            lotteryVM_.RowLabel = rowTextBox.Text;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
