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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BriansBrainController));
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
            label4 = new Label();
            pbImportGridInfo = new PictureBox();
            pbRandomGridInfo = new PictureBox();
            pbInitializeGrid = new PictureBox();
            pbStartingSquareInfo = new PictureBox();
            pbTableInfo = new PictureBox();
            ttTable = new ToolTip(components);
            ttStartingSquare = new ToolTip(components);
            ttInitGrid = new ToolTip(components);
            ttImportGrid = new ToolTip(components);
            ttRandomGrid = new ToolTip(components);
            gbOnInfo = new GroupBox();
            panelOnColor = new Panel();
            gbDyingInfo = new GroupBox();
            panelDyingColor = new Panel();
            gbOffInfo = new GroupBox();
            panelOffColor = new Panel();
            ttOnInfo = new ToolTip(components);
            ttOffInfo = new ToolTip(components);
            ttDyingInfo = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)nudAreaStartingSquare).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfCellsStartingSquare).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudColumnsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRowsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImportGridInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRandomGridInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInitializeGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStartingSquareInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTableInfo).BeginInit();
            gbOnInfo.SuspendLayout();
            gbDyingInfo.SuspendLayout();
            gbOffInfo.SuspendLayout();
            SuspendLayout();
            // 
            // nudAreaStartingSquare
            // 
            nudAreaStartingSquare.Location = new Point(143, 258);
            nudAreaStartingSquare.Margin = new Padding(4, 5, 4, 5);
            nudAreaStartingSquare.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudAreaStartingSquare.Name = "nudAreaStartingSquare";
            nudAreaStartingSquare.Size = new Size(110, 31);
            nudAreaStartingSquare.TabIndex = 32;
            nudAreaStartingSquare.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // nudNumberOfCellsStartingSquare
            // 
            nudNumberOfCellsStartingSquare.Location = new Point(143, 207);
            nudNumberOfCellsStartingSquare.Margin = new Padding(4, 5, 4, 5);
            nudNumberOfCellsStartingSquare.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudNumberOfCellsStartingSquare.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNumberOfCellsStartingSquare.Name = "nudNumberOfCellsStartingSquare";
            nudNumberOfCellsStartingSquare.Size = new Size(110, 31);
            nudNumberOfCellsStartingSquare.TabIndex = 31;
            nudNumberOfCellsStartingSquare.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // nudColumnsTable
            // 
            nudColumnsTable.Location = new Point(127, 113);
            nudColumnsTable.Margin = new Padding(4, 5, 4, 5);
            nudColumnsTable.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudColumnsTable.Name = "nudColumnsTable";
            nudColumnsTable.Size = new Size(129, 31);
            nudColumnsTable.TabIndex = 30;
            nudColumnsTable.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // nudRowsTable
            // 
            nudRowsTable.Location = new Point(127, 65);
            nudRowsTable.Margin = new Padding(4, 5, 4, 5);
            nudRowsTable.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudRowsTable.Name = "nudRowsTable";
            nudRowsTable.Size = new Size(129, 31);
            nudRowsTable.TabIndex = 29;
            nudRowsTable.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // lblFireProb
            // 
            lblFireProb.AutoSize = true;
            lblFireProb.Location = new Point(54, 262);
            lblFireProb.Margin = new Padding(4, 0, 4, 0);
            lblFireProb.Name = "lblFireProb";
            lblFireProb.Size = new Size(48, 25);
            lblFireProb.TabIndex = 26;
            lblFireProb.Text = "Area";
            // 
            // lblTreeProb
            // 
            lblTreeProb.AutoSize = true;
            lblTreeProb.Location = new Point(54, 212);
            lblTreeProb.Margin = new Padding(4, 0, 4, 0);
            lblTreeProb.Name = "lblTreeProb";
            lblTreeProb.Size = new Size(48, 25);
            lblTreeProb.TabIndex = 25;
            lblTreeProb.Text = "Cells";
            // 
            // btnInitGrid
            // 
            btnInitGrid.Location = new Point(21, 512);
            btnInitGrid.Margin = new Padding(4, 5, 4, 5);
            btnInitGrid.Name = "btnInitGrid";
            btnInitGrid.Size = new Size(131, 38);
            btnInitGrid.TabIndex = 24;
            btnInitGrid.Text = "Initialize Grid";
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
            btnRandomGrid.Location = new Point(21, 605);
            btnRandomGrid.Margin = new Padding(4, 5, 4, 5);
            btnRandomGrid.Name = "btnRandomGrid";
            btnRandomGrid.Size = new Size(131, 38);
            btnRandomGrid.TabIndex = 34;
            btnRandomGrid.Text = "Random Grid";
            btnRandomGrid.UseVisualStyleBackColor = true;
            btnRandomGrid.Click += btnRandomGrid_Click;
            // 
            // btnImportGrid
            // 
            btnImportGrid.Location = new Point(21, 558);
            btnImportGrid.Name = "btnImportGrid";
            btnImportGrid.Size = new Size(131, 38);
            btnImportGrid.TabIndex = 35;
            btnImportGrid.Text = "Import Grid";
            btnImportGrid.UseVisualStyleBackColor = true;
            btnImportGrid.Click += btnImportGrid_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 162);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 25);
            label3.TabIndex = 36;
            label3.Text = "Starting square";
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
            // pbImportGridInfo
            // 
            pbImportGridInfo.ErrorImage = null;
            pbImportGridInfo.Image = (Image)resources.GetObject("pbImportGridInfo.Image");
            pbImportGridInfo.InitialImage = null;
            pbImportGridInfo.Location = new Point(161, 558);
            pbImportGridInfo.Margin = new Padding(4, 5, 4, 5);
            pbImportGridInfo.Name = "pbImportGridInfo";
            pbImportGridInfo.Size = new Size(29, 33);
            pbImportGridInfo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImportGridInfo.TabIndex = 43;
            pbImportGridInfo.TabStop = false;
            // 
            // pbRandomGridInfo
            // 
            pbRandomGridInfo.ErrorImage = null;
            pbRandomGridInfo.Image = (Image)resources.GetObject("pbRandomGridInfo.Image");
            pbRandomGridInfo.InitialImage = null;
            pbRandomGridInfo.Location = new Point(163, 605);
            pbRandomGridInfo.Margin = new Padding(4, 5, 4, 5);
            pbRandomGridInfo.Name = "pbRandomGridInfo";
            pbRandomGridInfo.Size = new Size(29, 33);
            pbRandomGridInfo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRandomGridInfo.TabIndex = 44;
            pbRandomGridInfo.TabStop = false;
            // 
            // pbInitializeGrid
            // 
            pbInitializeGrid.ErrorImage = null;
            pbInitializeGrid.Image = (Image)resources.GetObject("pbInitializeGrid.Image");
            pbInitializeGrid.InitialImage = null;
            pbInitializeGrid.Location = new Point(161, 512);
            pbInitializeGrid.Margin = new Padding(4, 5, 4, 5);
            pbInitializeGrid.Name = "pbInitializeGrid";
            pbInitializeGrid.Size = new Size(29, 33);
            pbInitializeGrid.SizeMode = PictureBoxSizeMode.StretchImage;
            pbInitializeGrid.TabIndex = 45;
            pbInitializeGrid.TabStop = false;
            // 
            // pbStartingSquareInfo
            // 
            pbStartingSquareInfo.ErrorImage = null;
            pbStartingSquareInfo.Image = (Image)resources.GetObject("pbStartingSquareInfo.Image");
            pbStartingSquareInfo.InitialImage = null;
            pbStartingSquareInfo.Location = new Point(200, 158);
            pbStartingSquareInfo.Margin = new Padding(4, 5, 4, 5);
            pbStartingSquareInfo.Name = "pbStartingSquareInfo";
            pbStartingSquareInfo.Size = new Size(29, 33);
            pbStartingSquareInfo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbStartingSquareInfo.TabIndex = 46;
            pbStartingSquareInfo.TabStop = false;
            // 
            // pbTableInfo
            // 
            pbTableInfo.ErrorImage = null;
            pbTableInfo.Image = (Image)resources.GetObject("pbTableInfo.Image");
            pbTableInfo.InitialImage = null;
            pbTableInfo.Location = new Point(161, 17);
            pbTableInfo.Margin = new Padding(4, 5, 4, 5);
            pbTableInfo.Name = "pbTableInfo";
            pbTableInfo.Size = new Size(29, 33);
            pbTableInfo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTableInfo.TabIndex = 47;
            pbTableInfo.TabStop = false;
            // 
            // gbOnInfo
            // 
            gbOnInfo.BackColor = SystemColors.ButtonFace;
            gbOnInfo.Controls.Add(panelOnColor);
            gbOnInfo.Location = new Point(4, 340);
            gbOnInfo.Margin = new Padding(4, 5, 4, 5);
            gbOnInfo.Name = "gbOnInfo";
            gbOnInfo.Padding = new Padding(4, 5, 4, 5);
            gbOnInfo.Size = new Size(77, 78);
            gbOnInfo.TabIndex = 48;
            gbOnInfo.TabStop = false;
            gbOnInfo.Text = "On";
            // 
            // panelOnColor
            // 
            panelOnColor.BackColor = Color.CadetBlue;
            panelOnColor.Location = new Point(17, 33);
            panelOnColor.Margin = new Padding(4, 5, 4, 5);
            panelOnColor.Name = "panelOnColor";
            panelOnColor.Size = new Size(30, 35);
            panelOnColor.TabIndex = 1;
            // 
            // gbDyingInfo
            // 
            gbDyingInfo.BackColor = SystemColors.ButtonFace;
            gbDyingInfo.Controls.Add(panelDyingColor);
            gbDyingInfo.Location = new Point(177, 340);
            gbDyingInfo.Margin = new Padding(4, 5, 4, 5);
            gbDyingInfo.Name = "gbDyingInfo";
            gbDyingInfo.Padding = new Padding(4, 5, 4, 5);
            gbDyingInfo.Size = new Size(79, 78);
            gbDyingInfo.TabIndex = 49;
            gbDyingInfo.TabStop = false;
            gbDyingInfo.Text = "Dying";
            // 
            // panelDyingColor
            // 
            panelDyingColor.BackColor = Color.LightBlue;
            panelDyingColor.Location = new Point(23, 33);
            panelDyingColor.Margin = new Padding(4, 5, 4, 5);
            panelDyingColor.Name = "panelDyingColor";
            panelDyingColor.Size = new Size(30, 35);
            panelDyingColor.TabIndex = 1;
            // 
            // gbOffInfo
            // 
            gbOffInfo.BackColor = SystemColors.ButtonFace;
            gbOffInfo.Controls.Add(panelOffColor);
            gbOffInfo.Location = new Point(90, 340);
            gbOffInfo.Margin = new Padding(4, 5, 4, 5);
            gbOffInfo.Name = "gbOffInfo";
            gbOffInfo.Padding = new Padding(4, 5, 4, 5);
            gbOffInfo.Size = new Size(77, 78);
            gbOffInfo.TabIndex = 50;
            gbOffInfo.TabStop = false;
            gbOffInfo.Text = "Off";
            // 
            // panelOffColor
            // 
            panelOffColor.BackColor = Color.Gray;
            panelOffColor.Location = new Point(14, 33);
            panelOffColor.Margin = new Padding(4, 5, 4, 5);
            panelOffColor.Name = "panelOffColor";
            panelOffColor.Size = new Size(30, 35);
            panelOffColor.TabIndex = 1;
            // 
            // BriansBrainController
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbOffInfo);
            Controls.Add(gbDyingInfo);
            Controls.Add(gbOnInfo);
            Controls.Add(pbTableInfo);
            Controls.Add(pbStartingSquareInfo);
            Controls.Add(pbInitializeGrid);
            Controls.Add(pbRandomGridInfo);
            Controls.Add(pbImportGridInfo);
            Controls.Add(label4);
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
            Size = new Size(276, 697);
            ((System.ComponentModel.ISupportInitialize)nudAreaStartingSquare).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfCellsStartingSquare).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudColumnsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRowsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImportGridInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRandomGridInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInitializeGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStartingSquareInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTableInfo).EndInit();
            gbOnInfo.ResumeLayout(false);
            gbDyingInfo.ResumeLayout(false);
            gbOffInfo.ResumeLayout(false);
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
        private Label label4;
        private PictureBox pbImportGridInfo;
        private PictureBox pbRandomGridInfo;
        private PictureBox pbInitializeGrid;
        private PictureBox pbStartingSquareInfo;
        private PictureBox pbTableInfo;
        private ToolTip ttTable;
        private ToolTip ttStartingSquare;
        private ToolTip ttInitGrid;
        private ToolTip ttImportGrid;
        private ToolTip ttRandomGrid;
        private GroupBox gbOnInfo;
        private Panel panelOnColor;
        private GroupBox gbDyingInfo;
        private Panel panelDyingColor;
        private GroupBox gbOffInfo;
        private Panel panelOffColor;
        private ToolTip ttOnInfo;
        private ToolTip ttOffInfo;
        private ToolTip ttDyingInfo;
    }
}
