namespace Display.SimulationControls
{
    partial class BriansBrainController
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
            nudAreaStartingSquare = new NumericUpDown();
            nudNumberOfCellsStartingSquare = new NumericUpDown();
            nudColumnsTable = new NumericUpDown();
            nudRowsTable = new NumericUpDown();
            lblFireProb = new Label();
            lblTreeProb = new Label();
            btnInitGrid = new Button();
            label2 = new Label();
            label1 = new Label();
            btnRandomGrid = new Button();
            btnImportGrid = new Button();
            label3 = new Label();
            chbAutoNumberOfSteps = new CheckBox();
            label4 = new Label();
            nudAutoNumberOfSteps = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudAreaStartingSquare).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfCellsStartingSquare).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudColumnsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRowsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAutoNumberOfSteps).BeginInit();
            SuspendLayout();
            // 
            // nudAreaStartingSquare
            // 
            nudAreaStartingSquare.Location = new Point(143, 259);
            nudAreaStartingSquare.Margin = new Padding(4, 5, 4, 5);
            nudAreaStartingSquare.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAreaStartingSquare.Name = "nudAreaStartingSquare";
            nudAreaStartingSquare.Size = new Size(110, 31);
            nudAreaStartingSquare.TabIndex = 32;
            // 
            // nudNumberOfCellsStartingSquare
            // 
            nudNumberOfCellsStartingSquare.Location = new Point(143, 206);
            nudNumberOfCellsStartingSquare.Margin = new Padding(4, 5, 4, 5);
            nudNumberOfCellsStartingSquare.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudNumberOfCellsStartingSquare.Name = "nudNumberOfCellsStartingSquare";
            nudNumberOfCellsStartingSquare.Size = new Size(110, 31);
            nudNumberOfCellsStartingSquare.TabIndex = 31;
            // 
            // nudColumnsTable
            // 
            nudColumnsTable.Location = new Point(127, 113);
            nudColumnsTable.Margin = new Padding(4, 5, 4, 5);
            nudColumnsTable.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudColumnsTable.Name = "nudColumnsTable";
            nudColumnsTable.Size = new Size(128, 31);
            nudColumnsTable.TabIndex = 30;
            // 
            // nudRowsTable
            // 
            nudRowsTable.Location = new Point(127, 65);
            nudRowsTable.Margin = new Padding(4, 5, 4, 5);
            nudRowsTable.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudRowsTable.Name = "nudRowsTable";
            nudRowsTable.Size = new Size(128, 31);
            nudRowsTable.TabIndex = 29;
            // 
            // lblFireProb
            // 
            lblFireProb.AutoSize = true;
            lblFireProb.Location = new Point(55, 261);
            lblFireProb.Margin = new Padding(4, 0, 4, 0);
            lblFireProb.Name = "lblFireProb";
            lblFireProb.Size = new Size(48, 25);
            lblFireProb.TabIndex = 26;
            lblFireProb.Text = "Area";
            // 
            // lblTreeProb
            // 
            lblTreeProb.AutoSize = true;
            lblTreeProb.Location = new Point(55, 212);
            lblTreeProb.Margin = new Padding(4, 0, 4, 0);
            lblTreeProb.Name = "lblTreeProb";
            lblTreeProb.Size = new Size(48, 25);
            lblTreeProb.TabIndex = 25;
            lblTreeProb.Text = "Cells";
            // 
            // btnInitGrid
            // 
            btnInitGrid.Location = new Point(4, 596);
            btnInitGrid.Margin = new Padding(4, 5, 4, 5);
            btnInitGrid.Name = "btnInitGrid";
            btnInitGrid.Size = new Size(131, 38);
            btnInitGrid.TabIndex = 24;
            btnInitGrid.Text = "Intialise Grid";
            btnInitGrid.UseVisualStyleBackColor = true;
            btnInitGrid.Click += btnInitGrid_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 113);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 23;
            label2.Text = "Columns";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 22;
            label1.Text = "Rows";
            // 
            // btnRandomGrid
            // 
            btnRandomGrid.Location = new Point(143, 596);
            btnRandomGrid.Margin = new Padding(4, 5, 4, 5);
            btnRandomGrid.Name = "btnRandomGrid";
            btnRandomGrid.Size = new Size(128, 38);
            btnRandomGrid.TabIndex = 34;
            btnRandomGrid.Text = "Random Grid";
            btnRandomGrid.UseVisualStyleBackColor = true;
            btnRandomGrid.Click += btnRandomGrid_Click;
            // 
            // btnImportGrid
            // 
            btnImportGrid.Location = new Point(69, 554);
            btnImportGrid.Name = "btnImportGrid";
            btnImportGrid.Size = new Size(143, 34);
            btnImportGrid.TabIndex = 35;
            btnImportGrid.Text = "Import Grid";
            btnImportGrid.UseVisualStyleBackColor = true;
            btnImportGrid.Click += btnImportGrid_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 161);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 25);
            label3.TabIndex = 36;
            label3.Text = "Starting square";
            // 
            // chbAutoNumberOfSteps
            // 
            chbAutoNumberOfSteps.AutoSize = true;
            chbAutoNumberOfSteps.Location = new Point(21, 327);
            chbAutoNumberOfSteps.Name = "chbAutoNumberOfSteps";
            chbAutoNumberOfSteps.Size = new Size(124, 29);
            chbAutoNumberOfSteps.TabIndex = 38;
            chbAutoNumberOfSteps.Text = "Auto steps";
            chbAutoNumberOfSteps.UseVisualStyleBackColor = true;
            chbAutoNumberOfSteps.CheckedChanged += chbAutoNumberOfSteps_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 20);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 40;
            label4.Text = "Table";
            // 
            // nudAutoNumberOfSteps
            // 
            nudAutoNumberOfSteps.Location = new Point(21, 364);
            nudAutoNumberOfSteps.Margin = new Padding(4, 5, 4, 5);
            nudAutoNumberOfSteps.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAutoNumberOfSteps.Name = "nudAutoNumberOfSteps";
            nudAutoNumberOfSteps.Size = new Size(232, 31);
            nudAutoNumberOfSteps.TabIndex = 41;
            // 
            // BriansBrainController
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(nudAutoNumberOfSteps);
            Controls.Add(label4);
            Controls.Add(chbAutoNumberOfSteps);
            Controls.Add(label3);
            Controls.Add(btnImportGrid);
            Controls.Add(btnRandomGrid);
            Controls.Add(nudAreaStartingSquare);
            Controls.Add(nudNumberOfCellsStartingSquare);
            Controls.Add(nudColumnsTable);
            Controls.Add(nudRowsTable);
            Controls.Add(lblFireProb);
            Controls.Add(lblTreeProb);
            Controls.Add(btnInitGrid);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BriansBrainController";
            Size = new Size(275, 648);
            ((System.ComponentModel.ISupportInitialize)nudAreaStartingSquare).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfCellsStartingSquare).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudColumnsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRowsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAutoNumberOfSteps).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown nudAreaStartingSquare;
        private NumericUpDown nudNumberOfCellsStartingSquare;
        private NumericUpDown nudColumnsTable;
        private NumericUpDown nudRowsTable;
        private Label lblFireProb;
        private Label lblTreeProb;
        private Button btnInitGrid;
        private Label label2;
        private Label label1;
        private Button btnRandomGrid;
        private Button btnImportGrid;
        private Label label3;
        private CheckBox chbAutoNumberOfSteps;
        private Label label4;
        private NumericUpDown nudAutoNumberOfSteps;
    }
}
