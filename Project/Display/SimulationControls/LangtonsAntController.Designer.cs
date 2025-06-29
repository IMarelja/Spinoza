namespace Display.SimulationControls
{
    partial class LangtonsAntController
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            nudColumnsTable = new NumericUpDown();
            nudRowsTable = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            btnImportGrid = new Button();
            btnRandomGrid = new Button();
            btnInitGrid = new Button();
            cbIsDefault = new CheckBox();
            label3 = new Label();
            nudAreaStartingSquare = new NumericUpDown();
            nudNumberOfCellsStartingSquare = new NumericUpDown();
            lblColumn = new Label();
            lblRow = new Label();
            gbWhiteInfo = new GroupBox();
            panelOffColor = new Panel();
            gbAntInfo = new GroupBox();
            panelDyingColor = new Panel();
            gbgoLeftInfo = new GroupBox();
            panelOnColor = new Panel();
            cbDirection = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudColumnsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRowsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAreaStartingSquare).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfCellsStartingSquare).BeginInit();
            gbWhiteInfo.SuspendLayout();
            gbAntInfo.SuspendLayout();
            gbgoLeftInfo.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 11);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 45;
            label4.Text = "Table";
            // 
            // nudColumnsTable
            // 
            nudColumnsTable.Location = new Point(88, 67);
            nudColumnsTable.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudColumnsTable.Name = "nudColumnsTable";
            nudColumnsTable.Size = new Size(90, 23);
            nudColumnsTable.TabIndex = 44;
            // 
            // nudRowsTable
            // 
            nudRowsTable.Location = new Point(88, 38);
            nudRowsTable.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudRowsTable.Name = "nudRowsTable";
            nudRowsTable.Size = new Size(90, 23);
            nudRowsTable.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 67);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 42;
            label2.Text = "Columns";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 38);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 41;
            label1.Text = "Rows";
            // 
            // btnImportGrid
            // 
            btnImportGrid.Location = new Point(10, 334);
            btnImportGrid.Margin = new Padding(2, 2, 2, 2);
            btnImportGrid.Name = "btnImportGrid";
            btnImportGrid.Size = new Size(100, 20);
            btnImportGrid.TabIndex = 50;
            btnImportGrid.Text = "Import Grid";
            btnImportGrid.UseVisualStyleBackColor = true;
            btnImportGrid.Click += btnImportGrid_Click;
            // 
            // btnRandomGrid
            // 
            btnRandomGrid.Location = new Point(8, 359);
            btnRandomGrid.Name = "btnRandomGrid";
            btnRandomGrid.Size = new Size(102, 23);
            btnRandomGrid.TabIndex = 49;
            btnRandomGrid.Text = "Random Grid";
            btnRandomGrid.UseVisualStyleBackColor = true;
            btnRandomGrid.Click += btnRandomGrid_Click;
            // 
            // btnInitGrid
            // 
            btnInitGrid.Location = new Point(10, 306);
            btnInitGrid.Name = "btnInitGrid";
            btnInitGrid.Size = new Size(100, 23);
            btnInitGrid.TabIndex = 48;
            btnInitGrid.Text = "Intialise Grid";
            btnInitGrid.UseVisualStyleBackColor = true;
            btnInitGrid.Click += BtnInitGrid_Click;
            // 
            // cbIsDefault
            // 
            cbIsDefault.AutoSize = true;
            cbIsDefault.Location = new Point(13, 128);
            cbIsDefault.Margin = new Padding(2, 2, 2, 2);
            cbIsDefault.Name = "cbIsDefault";
            cbIsDefault.Size = new Size(108, 19);
            cbIsDefault.TabIndex = 51;
            cbIsDefault.Text = "Default (center)";
            cbIsDefault.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 104);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 56;
            label3.Text = "Choose ant position";
            // 
            // nudAreaStartingSquare
            // 
            nudAreaStartingSquare.Location = new Point(81, 182);
            nudAreaStartingSquare.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAreaStartingSquare.Name = "nudAreaStartingSquare";
            nudAreaStartingSquare.Size = new Size(77, 23);
            nudAreaStartingSquare.TabIndex = 55;
            // 
            // nudNumberOfCellsStartingSquare
            // 
            nudNumberOfCellsStartingSquare.Location = new Point(81, 151);
            nudNumberOfCellsStartingSquare.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudNumberOfCellsStartingSquare.Name = "nudNumberOfCellsStartingSquare";
            nudNumberOfCellsStartingSquare.Size = new Size(77, 23);
            nudNumberOfCellsStartingSquare.TabIndex = 54;
            // 
            // lblColumn
            // 
            lblColumn.AutoSize = true;
            lblColumn.Location = new Point(20, 184);
            lblColumn.Name = "lblColumn";
            lblColumn.Size = new Size(50, 15);
            lblColumn.TabIndex = 53;
            lblColumn.Text = "Column";
            // 
            // lblRow
            // 
            lblRow.AutoSize = true;
            lblRow.Location = new Point(20, 154);
            lblRow.Name = "lblRow";
            lblRow.Size = new Size(30, 15);
            lblRow.TabIndex = 52;
            lblRow.Text = "Row";
            // 
            // gbWhiteInfo
            // 
            gbWhiteInfo.BackColor = SystemColors.ButtonFace;
            gbWhiteInfo.Controls.Add(panelOffColor);
            gbWhiteInfo.Location = new Point(71, 253);
            gbWhiteInfo.Name = "gbWhiteInfo";
            gbWhiteInfo.Size = new Size(54, 47);
            gbWhiteInfo.TabIndex = 59;
            gbWhiteInfo.TabStop = false;
            gbWhiteInfo.Text = "Right";
            // 
            // panelOffColor
            // 
            panelOffColor.BackColor = Color.White;
            panelOffColor.Location = new Point(10, 20);
            panelOffColor.Name = "panelOffColor";
            panelOffColor.Size = new Size(21, 21);
            panelOffColor.TabIndex = 1;
            // 
            // gbAntInfo
            // 
            gbAntInfo.BackColor = SystemColors.ButtonFace;
            gbAntInfo.Controls.Add(panelDyingColor);
            gbAntInfo.Location = new Point(132, 253);
            gbAntInfo.Name = "gbAntInfo";
            gbAntInfo.Size = new Size(55, 47);
            gbAntInfo.TabIndex = 58;
            gbAntInfo.TabStop = false;
            gbAntInfo.Text = "Ant";
            // 
            // panelDyingColor
            // 
            panelDyingColor.BackColor = Color.OrangeRed;
            panelDyingColor.Location = new Point(16, 20);
            panelDyingColor.Name = "panelDyingColor";
            panelDyingColor.Size = new Size(21, 21);
            panelDyingColor.TabIndex = 1;
            // 
            // gbgoLeftInfo
            // 
            gbgoLeftInfo.BackColor = SystemColors.ButtonFace;
            gbgoLeftInfo.Controls.Add(panelOnColor);
            gbgoLeftInfo.Location = new Point(11, 253);
            gbgoLeftInfo.Name = "gbgoLeftInfo";
            gbgoLeftInfo.Size = new Size(54, 47);
            gbgoLeftInfo.TabIndex = 57;
            gbgoLeftInfo.TabStop = false;
            gbgoLeftInfo.Text = "Left";
            // 
            // panelOnColor
            // 
            panelOnColor.BackColor = Color.Black;
            panelOnColor.Location = new Point(12, 20);
            panelOnColor.Name = "panelOnColor";
            panelOnColor.Size = new Size(21, 21);
            panelOnColor.TabIndex = 1;
            // 
            // cbDirection
            // 
            cbDirection.FormattingEnabled = true;
            cbDirection.Items.AddRange(new object[] { "Game Of Life", "Brian's Brain", "Forest Fire Model", "Langton's Ant" });
            cbDirection.Location = new Point(71, 222);
            cbDirection.Name = "cbDirection";
            cbDirection.Size = new Size(110, 23);
            cbDirection.TabIndex = 60;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 224);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 62;
            label5.Text = "Direction";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 204);
            label6.Name = "label6";
            label6.Size = new Size(117, 15);
            label6.TabIndex = 63;
            label6.Text = "Choose ant direction";
            // 
            // LangtonsAntController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cbDirection);
            Controls.Add(gbWhiteInfo);
            Controls.Add(gbAntInfo);
            Controls.Add(gbgoLeftInfo);
            Controls.Add(label3);
            Controls.Add(nudAreaStartingSquare);
            Controls.Add(nudNumberOfCellsStartingSquare);
            Controls.Add(lblColumn);
            Controls.Add(lblRow);
            Controls.Add(cbIsDefault);
            Controls.Add(btnImportGrid);
            Controls.Add(btnRandomGrid);
            Controls.Add(btnInitGrid);
            Controls.Add(label4);
            Controls.Add(nudColumnsTable);
            Controls.Add(nudRowsTable);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "LangtonsAntController";
            Size = new Size(192, 389);
            ((System.ComponentModel.ISupportInitialize)nudColumnsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRowsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAreaStartingSquare).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfCellsStartingSquare).EndInit();
            gbWhiteInfo.ResumeLayout(false);
            gbAntInfo.ResumeLayout(false);
            gbgoLeftInfo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private NumericUpDown nudColumnsTable;
        private NumericUpDown nudRowsTable;
        private Label label2;
        private Label label1;
        private Button btnImportGrid;
        private Button btnRandomGrid;
        private Button btnInitGrid;
        private CheckBox cbIsDefault;
        private Label label3;
        private NumericUpDown nudAreaStartingSquare;
        private NumericUpDown nudNumberOfCellsStartingSquare;
        private Label lblColumn;
        private Label lblRow;
        private GroupBox gbWhiteInfo;
        private Panel panelOffColor;
        private GroupBox gbAntInfo;
        private Panel panelDyingColor;
        private GroupBox gbgoLeftInfo;
        private Panel panelOnColor;
        private ComboBox cbDirection;
        private Label label5;
        private Label label6;
    }
}
