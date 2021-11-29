namespace lotteri
{
    partial class LotteryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LotteryForm));
            this.NoPrizesLabel = new System.Windows.Forms.Label();
            this.noPrizesInput = new System.Windows.Forms.TextBox();
            this.openExcelFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.readFromLabel = new System.Windows.Forms.Label();
            this.excelFileName = new System.Windows.Forms.TextBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.RichTextBox();
            this.selectFile = new System.Windows.Forms.Button();
            this.colLabel = new System.Windows.Forms.Label();
            this.colLabelText = new System.Windows.Forms.TextBox();
            this.rowLabelText = new System.Windows.Forms.TextBox();
            this.rowLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.helpText = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NoPrizesLabel
            // 
            this.NoPrizesLabel.AutoSize = true;
            this.NoPrizesLabel.Location = new System.Drawing.Point(20, 144);
            this.NoPrizesLabel.Name = "NoPrizesLabel";
            this.NoPrizesLabel.Size = new System.Drawing.Size(70, 13);
            this.NoPrizesLabel.TabIndex = 0;
            this.NoPrizesLabel.Text = "Antall premier";
            this.NoPrizesLabel.Click += new System.EventHandler(this.NoPrizesLabel_Click);
            // 
            // noPrizesInput
            // 
            this.noPrizesInput.Location = new System.Drawing.Point(150, 144);
            this.noPrizesInput.Name = "noPrizesInput";
            this.noPrizesInput.Size = new System.Drawing.Size(156, 20);
            this.noPrizesInput.TabIndex = 1;
            this.noPrizesInput.TextChanged += new System.EventHandler(this.noPrizesInput_TextChanged);
            // 
            // openExcelFileDialog
            // 
            this.openExcelFileDialog.FileName = "";
            this.openExcelFileDialog.Filter = "Excel filer|*.xl*";
            // 
            // readFromLabel
            // 
            this.readFromLabel.AutoSize = true;
            this.readFromLabel.Location = new System.Drawing.Point(20, 30);
            this.readFromLabel.Name = "readFromLabel";
            this.readFromLabel.Size = new System.Drawing.Size(99, 13);
            this.readFromLabel.TabIndex = 2;
            this.readFromLabel.Text = "Les loddbøker fra fil";
            // 
            // excelFileName
            // 
            this.excelFileName.Location = new System.Drawing.Point(150, 30);
            this.excelFileName.Name = "excelFileName";
            this.excelFileName.Size = new System.Drawing.Size(156, 20);
            this.excelFileName.TabIndex = 3;
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(313, 144);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(75, 23);
            this.drawButton.TabIndex = 4;
            this.drawButton.Text = "Trekk";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(20, 245);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(46, 13);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "Resultat";
            // 
            // resultText
            // 
            this.resultText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultText.Location = new System.Drawing.Point(23, 261);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(339, 333);
            this.resultText.TabIndex = 7;
            this.resultText.Text = "";
            // 
            // selectFile
            // 
            this.selectFile.Location = new System.Drawing.Point(313, 30);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(75, 23);
            this.selectFile.TabIndex = 8;
            this.selectFile.Text = "Velg";
            this.selectFile.UseVisualStyleBackColor = true;
            this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // colLabel
            // 
            this.colLabel.AutoSize = true;
            this.colLabel.Location = new System.Drawing.Point(20, 64);
            this.colLabel.Name = "colLabel";
            this.colLabel.Size = new System.Drawing.Size(71, 13);
            this.colLabel.TabIndex = 9;
            this.colLabel.Text = "Kolonne label";
            // 
            // colLabelText
            // 
            this.colLabelText.Location = new System.Drawing.Point(150, 64);
            this.colLabelText.Name = "colLabelText";
            this.colLabelText.Size = new System.Drawing.Size(156, 20);
            this.colLabelText.TabIndex = 10;
            this.colLabelText.TextChanged += new System.EventHandler(this.colLabelText_TextChanged);
            // 
            // rowLabelText
            // 
            this.rowLabelText.Location = new System.Drawing.Point(150, 102);
            this.rowLabelText.Name = "rowLabelText";
            this.rowLabelText.Size = new System.Drawing.Size(156, 20);
            this.rowLabelText.TabIndex = 12;
            this.rowLabelText.TextChanged += new System.EventHandler(this.rowLabelText_TextChanged);
            // 
            // rowLabel
            // 
            this.rowLabel.AutoSize = true;
            this.rowLabel.Location = new System.Drawing.Point(20, 102);
            this.rowLabel.Name = "rowLabel";
            this.rowLabel.Size = new System.Drawing.Size(52, 13);
            this.rowLabel.TabIndex = 11;
            this.rowLabel.Text = "Rad label";
            this.rowLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(500, 623);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.readFromLabel);
            this.tabPage1.Controls.Add(this.rowLabelText);
            this.tabPage1.Controls.Add(this.NoPrizesLabel);
            this.tabPage1.Controls.Add(this.rowLabel);
            this.tabPage1.Controls.Add(this.noPrizesInput);
            this.tabPage1.Controls.Add(this.colLabelText);
            this.tabPage1.Controls.Add(this.excelFileName);
            this.tabPage1.Controls.Add(this.colLabel);
            this.tabPage1.Controls.Add(this.drawButton);
            this.tabPage1.Controls.Add(this.selectFile);
            this.tabPage1.Controls.Add(this.resultLabel);
            this.tabPage1.Controls.Add(this.resultText);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(492, 597);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trekning";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.helpText);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(492, 597);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hjelp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // helpText
            // 
            this.helpText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpText.Location = new System.Drawing.Point(3, 3);
            this.helpText.Name = "helpText";
            this.helpText.ReadOnly = true;
            this.helpText.Size = new System.Drawing.Size(486, 591);
            this.helpText.TabIndex = 0;
            this.helpText.Text = resources.GetString("helpText.Text");
            this.helpText.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // LotteryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 623);
            this.Controls.Add(this.tabControl1);
            this.Name = "LotteryForm";
            this.Text = "Lotteri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NoPrizesLabel;
        private System.Windows.Forms.TextBox noPrizesInput;
        private System.Windows.Forms.OpenFileDialog openExcelFileDialog;
        private System.Windows.Forms.Label readFromLabel;
        private System.Windows.Forms.TextBox excelFileName;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.RichTextBox resultText;
        private System.Windows.Forms.Button selectFile;
        private System.Windows.Forms.Label colLabel;
        private System.Windows.Forms.TextBox colLabelText;
        private System.Windows.Forms.TextBox rowLabelText;
        private System.Windows.Forms.Label rowLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox helpText;
    }
}

