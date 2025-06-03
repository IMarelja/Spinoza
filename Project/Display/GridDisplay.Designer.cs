namespace Display
{
    partial class GridDisplay
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitter1 = new Splitter();
            rtxtDisplay = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            btnInitGrid = new Button();
            lblTreeProb = new Label();
            lblFireProb = new Label();
            lblTreePercent = new Label();
            lblFirePercent = new Label();
            nudRows = new NumericUpDown();
            nudColumns = new NumericUpDown();
            nudTree = new NumericUpDown();
            nudFire = new NumericUpDown();
            btnNext = new Button();
            btnBack = new Button();
            cbAutomataSelect = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudColumns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFire).BeginInit();
            SuspendLayout();
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(208, 619);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // rtxtDisplay
            // 
            rtxtDisplay.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            rtxtDisplay.Location = new Point(205, 0);
            rtxtDisplay.Name = "rtxtDisplay";
            rtxtDisplay.Size = new Size(776, 578);
            rtxtDisplay.TabIndex = 1;
            rtxtDisplay.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 57);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 4;
            label1.Text = "Rows";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 86);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "Columns";
            // 
            // btnInitGrid
            // 
            btnInitGrid.Location = new Point(99, 187);
            btnInitGrid.Name = "btnInitGrid";
            btnInitGrid.Size = new Size(100, 23);
            btnInitGrid.TabIndex = 6;
            btnInitGrid.Text = "Intialise Grid";
            btnInitGrid.UseVisualStyleBackColor = true;
            btnInitGrid.Click += btnInitGrid_Click;
            // 
            // lblTreeProb
            // 
            lblTreeProb.AutoSize = true;
            lblTreeProb.Location = new Point(7, 128);
            lblTreeProb.Name = "lblTreeProb";
            lblTreeProb.Size = new Size(86, 15);
            lblTreeProb.TabIndex = 7;
            lblTreeProb.Text = "Chance of Tree";
            // 
            // lblFireProb
            // 
            lblFireProb.AutoSize = true;
            lblFireProb.Location = new Point(7, 157);
            lblFireProb.Name = "lblFireProb";
            lblFireProb.Size = new Size(83, 15);
            lblFireProb.TabIndex = 10;
            lblFireProb.Text = "Chance of Fire";
            // 
            // lblTreePercent
            // 
            lblTreePercent.AutoSize = true;
            lblTreePercent.Location = new Point(182, 128);
            lblTreePercent.Name = "lblTreePercent";
            lblTreePercent.Size = new Size(17, 15);
            lblTreePercent.TabIndex = 11;
            lblTreePercent.Text = "%";
            // 
            // lblFirePercent
            // 
            lblFirePercent.AutoSize = true;
            lblFirePercent.Location = new Point(182, 157);
            lblFirePercent.Name = "lblFirePercent";
            lblFirePercent.Size = new Size(17, 15);
            lblFirePercent.TabIndex = 12;
            lblFirePercent.Text = "%";
            // 
            // nudRows
            // 
            nudRows.Location = new Point(99, 55);
            nudRows.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudRows.Name = "nudRows";
            nudRows.Size = new Size(100, 23);
            nudRows.TabIndex = 13;
            // 
            // nudColumns
            // 
            nudColumns.Location = new Point(99, 86);
            nudColumns.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudColumns.Name = "nudColumns";
            nudColumns.Size = new Size(100, 23);
            nudColumns.TabIndex = 14;
            // 
            // nudTree
            // 
            nudTree.Location = new Point(99, 126);
            nudTree.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudTree.Name = "nudTree";
            nudTree.Size = new Size(77, 23);
            nudTree.TabIndex = 15;
            // 
            // nudFire
            // 
            nudFire.Location = new Point(99, 155);
            nudFire.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudFire.Name = "nudFire";
            nudFire.Size = new Size(77, 23);
            nudFire.TabIndex = 16;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(893, 584);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 17;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(214, 584);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 18;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // cbAutomataSelect
            // 
            cbAutomataSelect.FormattingEnabled = true;
            cbAutomataSelect.Items.AddRange(new object[] { "Game Of Life", "Brian's Brain", "Forest Fire Model", "Langton's Ant" });
            cbAutomataSelect.Location = new Point(13, 12);
            cbAutomataSelect.Name = "cbAutomataSelect";
            cbAutomataSelect.Size = new Size(186, 23);
            cbAutomataSelect.TabIndex = 19;
            cbAutomataSelect.SelectedIndexChanged += cbAutomataSelect_SelectedIndexChanged;
            // 
            // GridDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 619);
            Controls.Add(cbAutomataSelect);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Controls.Add(nudFire);
            Controls.Add(nudTree);
            Controls.Add(nudColumns);
            Controls.Add(nudRows);
            Controls.Add(lblFirePercent);
            Controls.Add(lblTreePercent);
            Controls.Add(lblFireProb);
            Controls.Add(lblTreeProb);
            Controls.Add(btnInitGrid);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtxtDisplay);
            Controls.Add(splitter1);
            Name = "GridDisplay";
            Text = "Grid Display";
            ((System.ComponentModel.ISupportInitialize)nudRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudColumns).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTree).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFire).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Splitter splitter1;
        private RichTextBox rtxtDisplay;
        private TextBox txtRows;
        private TextBox txtColumns;
        private Label label1;
        private Label label2;
        private Button btnInitGrid;
        private Label lblTreeProb;
        private Label lblFireProb;
        private Label lblTreePercent;
        private Label lblFirePercent;
        private NumericUpDown nudRows;
        private NumericUpDown nudColumns;
        private NumericUpDown nudTree;
        private NumericUpDown nudFire;
        private Button btnNext;
        private Button btnBack;
        private ComboBox cbAutomataSelect;
    }
}
