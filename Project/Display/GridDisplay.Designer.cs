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
            pnlCell1 = new Panel();
            pnlCell2 = new Panel();
            pnlCell3 = new Panel();
            colorDialog = new ColorDialog();
            btnGoBackToMenu = new Button();
            flpGrid = new FlowLayoutPanel();
            lblCell1 = new Label();
            lblCell2 = new Label();
            lblCell3 = new Label();
            btnSelectColour1 = new Button();
            btnSelectColour2 = new Button();
            btnSelectColour3 = new Button();
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
            splitter1.Size = new Size(208, 761);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 58);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 4;
            label1.Text = "Rows";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 87);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "Columns";
            // 
            // btnInitGrid
            // 
            btnInitGrid.Location = new Point(99, 188);
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
            lblTreeProb.Location = new Point(8, 129);
            lblTreeProb.Name = "lblTreeProb";
            lblTreeProb.Size = new Size(86, 15);
            lblTreeProb.TabIndex = 7;
            lblTreeProb.Text = "Chance of Tree";
            // 
            // lblFireProb
            // 
            lblFireProb.AutoSize = true;
            lblFireProb.Location = new Point(8, 158);
            lblFireProb.Name = "lblFireProb";
            lblFireProb.Size = new Size(83, 15);
            lblFireProb.TabIndex = 10;
            lblFireProb.Text = "Chance of Fire";
            // 
            // lblTreePercent
            // 
            lblTreePercent.AutoSize = true;
            lblTreePercent.Location = new Point(183, 129);
            lblTreePercent.Name = "lblTreePercent";
            lblTreePercent.Size = new Size(17, 15);
            lblTreePercent.TabIndex = 11;
            lblTreePercent.Text = "%";
            // 
            // lblFirePercent
            // 
            lblFirePercent.AutoSize = true;
            lblFirePercent.Location = new Point(183, 158);
            lblFirePercent.Name = "lblFirePercent";
            lblFirePercent.Size = new Size(17, 15);
            lblFirePercent.TabIndex = 12;
            lblFirePercent.Text = "%";
            // 
            // nudRows
            // 
            nudRows.Location = new Point(99, 56);
            nudRows.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudRows.Name = "nudRows";
            nudRows.Size = new Size(100, 23);
            nudRows.TabIndex = 13;
            // 
            // nudColumns
            // 
            nudColumns.Location = new Point(99, 87);
            nudColumns.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudColumns.Name = "nudColumns";
            nudColumns.Size = new Size(100, 23);
            nudColumns.TabIndex = 14;
            // 
            // nudTree
            // 
            nudTree.Location = new Point(99, 127);
            nudTree.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudTree.Name = "nudTree";
            nudTree.Size = new Size(77, 23);
            nudTree.TabIndex = 15;
            // 
            // nudFire
            // 
            nudFire.Location = new Point(99, 156);
            nudFire.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudFire.Name = "nudFire";
            nudFire.Size = new Size(77, 23);
            nudFire.TabIndex = 16;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(1129, 727);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 17;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(214, 727);
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
            cbAutomataSelect.Location = new Point(15, 20);
            cbAutomataSelect.Name = "cbAutomataSelect";
            cbAutomataSelect.Size = new Size(186, 23);
            cbAutomataSelect.TabIndex = 19;
            cbAutomataSelect.SelectedIndexChanged += cbAutomataSelect_SelectedIndexChanged;
            // 
            // pnlCell1
            // 
            pnlCell1.Location = new Point(8, 224);
            pnlCell1.Margin = new Padding(2);
            pnlCell1.Name = "pnlCell1";
            pnlCell1.Size = new Size(40, 40);
            pnlCell1.TabIndex = 20;
            // 
            // pnlCell2
            // 
            pnlCell2.Location = new Point(8, 268);
            pnlCell2.Margin = new Padding(2);
            pnlCell2.Name = "pnlCell2";
            pnlCell2.Size = new Size(40, 40);
            pnlCell2.TabIndex = 21;
            // 
            // pnlCell3
            // 
            pnlCell3.Location = new Point(8, 312);
            pnlCell3.Margin = new Padding(2);
            pnlCell3.Name = "pnlCell3";
            pnlCell3.Size = new Size(40, 40);
            pnlCell3.TabIndex = 21;
            // 
            // btnGoBackToMenu
            // 
            btnGoBackToMenu.Location = new Point(9, 718);
            btnGoBackToMenu.Margin = new Padding(2);
            btnGoBackToMenu.Name = "btnGoBackToMenu";
            btnGoBackToMenu.Size = new Size(192, 32);
            btnGoBackToMenu.TabIndex = 22;
            btnGoBackToMenu.Text = "Go back to menu";
            btnGoBackToMenu.UseVisualStyleBackColor = true;
            btnGoBackToMenu.Click += btnGoBackToMenu_Click;
            // 
            // flpGrid
            // 
            flpGrid.Location = new Point(214, 2);
            flpGrid.Name = "flpGrid";
            flpGrid.Size = new Size(990, 719);
            flpGrid.TabIndex = 23;
            // 
            // lblCell1
            // 
            lblCell1.AutoSize = true;
            lblCell1.Location = new Point(53, 236);
            lblCell1.Name = "lblCell1";
            lblCell1.Size = new Size(58, 15);
            lblCell1.TabIndex = 24;
            lblCell1.Text = "CellType1";
            // 
            // lblCell2
            // 
            lblCell2.AutoSize = true;
            lblCell2.Location = new Point(53, 281);
            lblCell2.Name = "lblCell2";
            lblCell2.Size = new Size(58, 15);
            lblCell2.TabIndex = 25;
            lblCell2.Text = "CellType2";
            // 
            // lblCell3
            // 
            lblCell3.AutoSize = true;
            lblCell3.Location = new Point(53, 324);
            lblCell3.Name = "lblCell3";
            lblCell3.Size = new Size(58, 15);
            lblCell3.TabIndex = 26;
            lblCell3.Text = "CellType3";
            // 
            // btnSelectColour1
            // 
            btnSelectColour1.Location = new Point(110, 232);
            btnSelectColour1.Name = "btnSelectColour1";
            btnSelectColour1.Size = new Size(91, 23);
            btnSelectColour1.TabIndex = 27;
            btnSelectColour1.Text = "Select Colour";
            btnSelectColour1.UseVisualStyleBackColor = true;
            btnSelectColour1.Click += btnSelectColour1_Click;
            // 
            // btnSelectColour2
            // 
            btnSelectColour2.Location = new Point(110, 277);
            btnSelectColour2.Name = "btnSelectColour2";
            btnSelectColour2.Size = new Size(91, 23);
            btnSelectColour2.TabIndex = 28;
            btnSelectColour2.Text = "Select Colour";
            btnSelectColour2.UseVisualStyleBackColor = true;
            btnSelectColour2.Click += btnSelectColour2_Click;
            // 
            // btnSelectColour3
            // 
            btnSelectColour3.Location = new Point(110, 320);
            btnSelectColour3.Name = "btnSelectColour3";
            btnSelectColour3.Size = new Size(89, 23);
            btnSelectColour3.TabIndex = 29;
            btnSelectColour3.Text = "Select Colour";
            btnSelectColour3.UseVisualStyleBackColor = true;
            btnSelectColour3.Click += btnSelectColour3_Click;
            // 
            // GridDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 761);
            Controls.Add(btnSelectColour3);
            Controls.Add(btnSelectColour2);
            Controls.Add(btnSelectColour1);
            Controls.Add(lblCell3);
            Controls.Add(lblCell2);
            Controls.Add(lblCell1);
            Controls.Add(flpGrid);
            Controls.Add(btnGoBackToMenu);
            Controls.Add(pnlCell3);
            Controls.Add(pnlCell2);
            Controls.Add(pnlCell1);
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
        private Panel pnlCell1;
        private Panel pnlCell2;
        private Panel pnlCell3;
        private ColorDialog colorDialog;
        private Button btnGoBackToMenu;
        private FlowLayoutPanel flpGrid;
        private Label lblCell1;
        private Label lblCell2;
        private Label lblCell3;
        private Button btnSelectColour1;
        private Button btnSelectColour2;
        private Button btnSelectColour3;
    }
}
