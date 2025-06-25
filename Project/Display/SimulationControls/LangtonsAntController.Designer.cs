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
            label4.Location = new Point(102, 18);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 45;
            label4.Text = "Table";
            // 
            // nudColumnsTable
            // 
            nudColumnsTable.Location = new Point(125, 111);
            nudColumnsTable.Margin = new Padding(4, 5, 4, 5);
            nudColumnsTable.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudColumnsTable.Name = "nudColumnsTable";
            nudColumnsTable.Size = new Size(128, 31);
            nudColumnsTable.TabIndex = 44;
            // 
            // nudRowsTable
            // 
            nudRowsTable.Location = new Point(125, 63);
            nudRowsTable.Margin = new Padding(4, 5, 4, 5);
            nudRowsTable.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudRowsTable.Name = "nudRowsTable";
            nudRowsTable.Size = new Size(128, 31);
            nudRowsTable.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 111);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 42;
            label2.Text = "Columns";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 63);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 41;
            label1.Text = "Rows";
            // 
            // btnImportGrid
            // 
            btnImportGrid.Location = new Point(34, 509);
            btnImportGrid.Name = "btnImportGrid";
            btnImportGrid.Size = new Size(143, 34);
            btnImportGrid.TabIndex = 50;
            btnImportGrid.Text = "Import Grid";
            btnImportGrid.UseVisualStyleBackColor = true;
            // 
            // btnRandomGrid
            // 
            btnRandomGrid.Location = new Point(31, 551);
            btnRandomGrid.Margin = new Padding(4, 5, 4, 5);
            btnRandomGrid.Name = "btnRandomGrid";
            btnRandomGrid.Size = new Size(146, 38);
            btnRandomGrid.TabIndex = 49;
            btnRandomGrid.Text = "Random Grid";
            btnRandomGrid.UseVisualStyleBackColor = true;
            // 
            // btnInitGrid
            // 
            btnInitGrid.Location = new Point(34, 463);
            btnInitGrid.Margin = new Padding(4, 5, 4, 5);
            btnInitGrid.Name = "btnInitGrid";
            btnInitGrid.Size = new Size(143, 38);
            btnInitGrid.TabIndex = 48;
            btnInitGrid.Text = "Intialise Grid";
            btnInitGrid.UseVisualStyleBackColor = true;
            btnInitGrid.Click += BtnInitGrid_Click;
            // 
            // cbIsDefault
            // 
            cbIsDefault.AutoSize = true;
            cbIsDefault.Location = new Point(19, 214);
            cbIsDefault.Name = "cbIsDefault";
            cbIsDefault.Size = new Size(158, 29);
            cbIsDefault.TabIndex = 51;
            cbIsDefault.Text = "Default (center)";
            cbIsDefault.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 174);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(172, 25);
            label3.TabIndex = 56;
            label3.Text = "Choose ant position";
            // 
            // nudAreaStartingSquare
            // 
            nudAreaStartingSquare.Location = new Point(116, 304);
            nudAreaStartingSquare.Margin = new Padding(4, 5, 4, 5);
            nudAreaStartingSquare.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAreaStartingSquare.Name = "nudAreaStartingSquare";
            nudAreaStartingSquare.Size = new Size(110, 31);
            nudAreaStartingSquare.TabIndex = 55;
            // 
            // nudNumberOfCellsStartingSquare
            // 
            nudNumberOfCellsStartingSquare.Location = new Point(116, 251);
            nudNumberOfCellsStartingSquare.Margin = new Padding(4, 5, 4, 5);
            nudNumberOfCellsStartingSquare.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudNumberOfCellsStartingSquare.Name = "nudNumberOfCellsStartingSquare";
            nudNumberOfCellsStartingSquare.Size = new Size(110, 31);
            nudNumberOfCellsStartingSquare.TabIndex = 54;
            // 
            // lblColumn
            // 
            lblColumn.AutoSize = true;
            lblColumn.Location = new Point(28, 306);
            lblColumn.Margin = new Padding(4, 0, 4, 0);
            lblColumn.Name = "lblColumn";
            lblColumn.Size = new Size(74, 25);
            lblColumn.TabIndex = 53;
            lblColumn.Text = "Column";
            // 
            // lblRow
            // 
            lblRow.AutoSize = true;
            lblRow.Location = new Point(28, 257);
            lblRow.Margin = new Padding(4, 0, 4, 0);
            lblRow.Name = "lblRow";
            lblRow.Size = new Size(46, 25);
            lblRow.TabIndex = 52;
            lblRow.Text = "Row";
            // 
            // gbWhiteInfo
            // 
            gbWhiteInfo.BackColor = SystemColors.ButtonFace;
            gbWhiteInfo.Controls.Add(panelOffColor);
            gbWhiteInfo.Location = new Point(100, 362);
            gbWhiteInfo.Margin = new Padding(4, 5, 4, 5);
            gbWhiteInfo.Name = "gbWhiteInfo";
            gbWhiteInfo.Padding = new Padding(4, 5, 4, 5);
            gbWhiteInfo.Size = new Size(77, 78);
            gbWhiteInfo.TabIndex = 59;
            gbWhiteInfo.TabStop = false;
            gbWhiteInfo.Text = "Right";
            // 
            // panelOffColor
            // 
            panelOffColor.BackColor = Color.White;
            panelOffColor.Location = new Point(14, 33);
            panelOffColor.Margin = new Padding(4, 5, 4, 5);
            panelOffColor.Name = "panelOffColor";
            panelOffColor.Size = new Size(30, 35);
            panelOffColor.TabIndex = 1;
            // 
            // gbAntInfo
            // 
            gbAntInfo.BackColor = SystemColors.ButtonFace;
            gbAntInfo.Controls.Add(panelDyingColor);
            gbAntInfo.Location = new Point(187, 362);
            gbAntInfo.Margin = new Padding(4, 5, 4, 5);
            gbAntInfo.Name = "gbAntInfo";
            gbAntInfo.Padding = new Padding(4, 5, 4, 5);
            gbAntInfo.Size = new Size(79, 78);
            gbAntInfo.TabIndex = 58;
            gbAntInfo.TabStop = false;
            gbAntInfo.Text = "Ant";
            // 
            // panelDyingColor
            // 
            panelDyingColor.BackColor = Color.OrangeRed;
            panelDyingColor.Location = new Point(23, 33);
            panelDyingColor.Margin = new Padding(4, 5, 4, 5);
            panelDyingColor.Name = "panelDyingColor";
            panelDyingColor.Size = new Size(30, 35);
            panelDyingColor.TabIndex = 1;
            // 
            // gbgoLeftInfo
            // 
            gbgoLeftInfo.BackColor = SystemColors.ButtonFace;
            gbgoLeftInfo.Controls.Add(panelOnColor);
            gbgoLeftInfo.Location = new Point(14, 362);
            gbgoLeftInfo.Margin = new Padding(4, 5, 4, 5);
            gbgoLeftInfo.Name = "gbgoLeftInfo";
            gbgoLeftInfo.Padding = new Padding(4, 5, 4, 5);
            gbgoLeftInfo.Size = new Size(77, 78);
            gbgoLeftInfo.TabIndex = 57;
            gbgoLeftInfo.TabStop = false;
            gbgoLeftInfo.Text = "Left";
            // 
            // panelOnColor
            // 
            panelOnColor.BackColor = Color.Black;
            panelOnColor.Location = new Point(17, 33);
            panelOnColor.Margin = new Padding(4, 5, 4, 5);
            panelOnColor.Name = "panelOnColor";
            panelOnColor.Size = new Size(30, 35);
            panelOnColor.TabIndex = 1;
            // 
            // LangtonsAntController
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Name = "LangtonsAntController";
            Size = new Size(275, 648);
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
    }
}
