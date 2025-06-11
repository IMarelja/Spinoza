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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            colorDialog1 = new ColorDialog();
            btnGoBackToMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)nudRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudColumns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFire).BeginInit();
            SuspendLayout();
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Margin = new Padding(4, 5, 4, 5);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(297, 1032);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // rtxtDisplay
            // 
            rtxtDisplay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            rtxtDisplay.Location = new Point(293, 0);
            rtxtDisplay.Margin = new Padding(4, 5, 4, 5);
            rtxtDisplay.Name = "rtxtDisplay";
            rtxtDisplay.Size = new Size(1107, 961);
            rtxtDisplay.TabIndex = 1;
            rtxtDisplay.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 97);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 4;
            label1.Text = "Rows";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 145);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 5;
            label2.Text = "Columns";
            // 
            // btnInitGrid
            // 
            btnInitGrid.Location = new Point(142, 314);
            btnInitGrid.Margin = new Padding(4, 5, 4, 5);
            btnInitGrid.Name = "btnInitGrid";
            btnInitGrid.Size = new Size(143, 38);
            btnInitGrid.TabIndex = 6;
            btnInitGrid.Text = "Intialise Grid";
            btnInitGrid.UseVisualStyleBackColor = true;
            btnInitGrid.Click += btnInitGrid_Click;
            // 
            // lblTreeProb
            // 
            lblTreeProb.AutoSize = true;
            lblTreeProb.Location = new Point(11, 215);
            lblTreeProb.Margin = new Padding(4, 0, 4, 0);
            lblTreeProb.Name = "lblTreeProb";
            lblTreeProb.Size = new Size(127, 25);
            lblTreeProb.TabIndex = 7;
            lblTreeProb.Text = "Chance of Tree";
            // 
            // lblFireProb
            // 
            lblFireProb.AutoSize = true;
            lblFireProb.Location = new Point(11, 264);
            lblFireProb.Margin = new Padding(4, 0, 4, 0);
            lblFireProb.Name = "lblFireProb";
            lblFireProb.Size = new Size(124, 25);
            lblFireProb.TabIndex = 10;
            lblFireProb.Text = "Chance of Fire";
            // 
            // lblTreePercent
            // 
            lblTreePercent.AutoSize = true;
            lblTreePercent.Location = new Point(261, 215);
            lblTreePercent.Margin = new Padding(4, 0, 4, 0);
            lblTreePercent.Name = "lblTreePercent";
            lblTreePercent.Size = new Size(27, 25);
            lblTreePercent.TabIndex = 11;
            lblTreePercent.Text = "%";
            // 
            // lblFirePercent
            // 
            lblFirePercent.AutoSize = true;
            lblFirePercent.Location = new Point(261, 264);
            lblFirePercent.Margin = new Padding(4, 0, 4, 0);
            lblFirePercent.Name = "lblFirePercent";
            lblFirePercent.Size = new Size(27, 25);
            lblFirePercent.TabIndex = 12;
            lblFirePercent.Text = "%";
            // 
            // nudRows
            // 
            nudRows.Location = new Point(142, 94);
            nudRows.Margin = new Padding(4, 5, 4, 5);
            nudRows.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudRows.Name = "nudRows";
            nudRows.Size = new Size(143, 31);
            nudRows.TabIndex = 13;
            // 
            // nudColumns
            // 
            nudColumns.Location = new Point(142, 145);
            nudColumns.Margin = new Padding(4, 5, 4, 5);
            nudColumns.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudColumns.Name = "nudColumns";
            nudColumns.Size = new Size(143, 31);
            nudColumns.TabIndex = 14;
            // 
            // nudTree
            // 
            nudTree.Location = new Point(142, 212);
            nudTree.Margin = new Padding(4, 5, 4, 5);
            nudTree.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudTree.Name = "nudTree";
            nudTree.Size = new Size(110, 31);
            nudTree.TabIndex = 15;
            // 
            // nudFire
            // 
            nudFire.Location = new Point(142, 260);
            nudFire.Margin = new Padding(4, 5, 4, 5);
            nudFire.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudFire.Name = "nudFire";
            nudFire.Size = new Size(110, 31);
            nudFire.TabIndex = 16;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(1276, 973);
            btnNext.Margin = new Padding(4, 5, 4, 5);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(107, 38);
            btnNext.TabIndex = 17;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(306, 973);
            btnBack.Margin = new Padding(4, 5, 4, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(107, 38);
            btnBack.TabIndex = 18;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // cbAutomataSelect
            // 
            cbAutomataSelect.FormattingEnabled = true;
            cbAutomataSelect.Items.AddRange(new object[] { "Game Of Life", "Brian's Brain", "Forest Fire Model", "Langton's Ant" });
            cbAutomataSelect.Location = new Point(21, 34);
            cbAutomataSelect.Margin = new Padding(4, 5, 4, 5);
            cbAutomataSelect.Name = "cbAutomataSelect";
            cbAutomataSelect.Size = new Size(264, 33);
            cbAutomataSelect.TabIndex = 19;
            cbAutomataSelect.SelectedIndexChanged += cbAutomataSelect_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Location = new Point(11, 374);
            panel1.Name = "panel1";
            panel1.Size = new Size(54, 46);
            panel1.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.Location = new Point(12, 426);
            panel2.Name = "panel2";
            panel2.Size = new Size(54, 46);
            panel2.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.Location = new Point(11, 478);
            panel3.Name = "panel3";
            panel3.Size = new Size(54, 46);
            panel3.TabIndex = 21;
            // 
            // btnGoBackToMenu
            // 
            btnGoBackToMenu.Location = new Point(11, 891);
            btnGoBackToMenu.Name = "btnGoBackToMenu";
            btnGoBackToMenu.Size = new Size(274, 54);
            btnGoBackToMenu.TabIndex = 22;
            btnGoBackToMenu.Text = "Go back to menu";
            btnGoBackToMenu.UseVisualStyleBackColor = true;
            btnGoBackToMenu.Click += btnGoBackToMenu_Click;
            // 
            // GridDisplay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 1032);
            Controls.Add(btnGoBackToMenu);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
            Margin = new Padding(4, 5, 4, 5);
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
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ColorDialog colorDialog1;
        private Button btnGoBackToMenu;
    }
}
