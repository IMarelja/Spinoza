namespace Display
{
    partial class GameOfLifeController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOfLifeController));
            nudRows = new NumericUpDown();
            nudColumns = new NumericUpDown();
            pbInfoRows = new PictureBox();
            pbInfoCols = new PictureBox();
            lblRows = new Label();
            label2 = new Label();
            btnInit = new Button();
            btnRandom = new Button();
            btnImport = new Button();
            label1 = new Label();
            pbInfoInit = new PictureBox();
            pbInfoRandom = new PictureBox();
            pbInfoImport = new PictureBox();
            btnStart = new Button();
            btnPause = new Button();
            pbInfoStart = new PictureBox();
            pbInfoPause = new PictureBox();
            ttRows = new ToolTip(components);
            ttCols = new ToolTip(components);
            ttSeed = new ToolTip(components);
            ttInit = new ToolTip(components);
            ttRandom = new ToolTip(components);
            ttImport = new ToolTip(components);
            ttStart = new ToolTip(components);
            pnlAlive = new Panel();
            pnlDead = new Panel();
            lblAlive = new Label();
            lblDead = new Label();
            ttPause = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)nudRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudColumns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInfoRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInfoCols).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInfoInit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInfoRandom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInfoImport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInfoStart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInfoPause).BeginInit();
            SuspendLayout();
            // 
            // nudRows
            // 
            nudRows.Location = new Point(99, 55);
            nudRows.Name = "nudRows";
            nudRows.Size = new Size(132, 27);
            nudRows.TabIndex = 0;
            // 
            // nudColumns
            // 
            nudColumns.Location = new Point(99, 88);
            nudColumns.Name = "nudColumns";
            nudColumns.Size = new Size(132, 27);
            nudColumns.TabIndex = 1;
            // 
            // pbInfoRows
            // 
            pbInfoRows.Image = (Image)resources.GetObject("pbInfoRows.Image");
            pbInfoRows.Location = new Point(240, 55);
            pbInfoRows.Name = "pbInfoRows";
            pbInfoRows.Size = new Size(25, 27);
            pbInfoRows.SizeMode = PictureBoxSizeMode.Zoom;
            pbInfoRows.TabIndex = 3;
            pbInfoRows.TabStop = false;
            // 
            // pbInfoCols
            // 
            pbInfoCols.Location = new Point(240, 88);
            pbInfoCols.Name = "pbInfoCols";
            pbInfoCols.Size = new Size(25, 27);
            pbInfoCols.SizeMode = PictureBoxSizeMode.Zoom;
            pbInfoCols.TabIndex = 4;
            pbInfoCols.TabStop = false;
            // 
            // lblRows
            // 
            lblRows.AutoSize = true;
            lblRows.Location = new Point(15, 55);
            lblRows.Name = "lblRows";
            lblRows.Size = new Size(44, 20);
            lblRows.TabIndex = 6;
            lblRows.Text = "Rows";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 88);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 7;
            label2.Text = "Columns";
            // 
            // btnInit
            // 
            btnInit.Location = new Point(17, 445);
            btnInit.Name = "btnInit";
            btnInit.Size = new Size(94, 29);
            btnInit.TabIndex = 9;
            btnInit.Text = "Initialize";
            btnInit.UseVisualStyleBackColor = true;
            btnInit.Click += btnInit_Click;
            // 
            // btnRandom
            // 
            btnRandom.Location = new Point(17, 480);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(94, 29);
            btnRandom.TabIndex = 10;
            btnRandom.Text = "Randomize";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandomize_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(17, 515);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(94, 29);
            btnImport.TabIndex = 11;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 12;
            label1.Text = "Game Of Life";
            // 
            // pbInfoInit
            // 
            pbInfoInit.Location = new Point(117, 447);
            pbInfoInit.Name = "pbInfoInit";
            pbInfoInit.Size = new Size(25, 27);
            pbInfoInit.SizeMode = PictureBoxSizeMode.Zoom;
            pbInfoInit.TabIndex = 13;
            pbInfoInit.TabStop = false;
            // 
            // pbInfoRandom
            // 
            pbInfoRandom.Location = new Point(117, 480);
            pbInfoRandom.Name = "pbInfoRandom";
            pbInfoRandom.Size = new Size(25, 27);
            pbInfoRandom.SizeMode = PictureBoxSizeMode.Zoom;
            pbInfoRandom.TabIndex = 14;
            pbInfoRandom.TabStop = false;
            // 
            // pbInfoImport
            // 
            pbInfoImport.Location = new Point(117, 517);
            pbInfoImport.Name = "pbInfoImport";
            pbInfoImport.Size = new Size(25, 27);
            pbInfoImport.SizeMode = PictureBoxSizeMode.Zoom;
            pbInfoImport.TabIndex = 15;
            pbInfoImport.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(88, 141);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(51, 28);
            btnStart.TabIndex = 16;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            btnPause.Location = new Point(144, 141);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(56, 28);
            btnPause.TabIndex = 17;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = true;
            // 
            // pbInfoStart
            // 
            pbInfoStart.Image = (Image)resources.GetObject("pbInfoStart.Image");
            pbInfoStart.Location = new Point(103, 175);
            pbInfoStart.Name = "pbInfoStart";
            pbInfoStart.Size = new Size(25, 27);
            pbInfoStart.SizeMode = PictureBoxSizeMode.Zoom;
            pbInfoStart.TabIndex = 19;
            pbInfoStart.TabStop = false;
            // 
            // pbInfoPause
            // 
            pbInfoPause.Image = (Image)resources.GetObject("pbInfoPause.Image");
            pbInfoPause.Location = new Point(163, 175);
            pbInfoPause.Name = "pbInfoPause";
            pbInfoPause.Size = new Size(25, 27);
            pbInfoPause.SizeMode = PictureBoxSizeMode.Zoom;
            pbInfoPause.TabIndex = 20;
            pbInfoPause.TabStop = false;
            // 
            // pnlAlive
            // 
            pnlAlive.BackColor = Color.FromArgb(128, 255, 128);
            pnlAlive.Location = new Point(77, 337);
            pnlAlive.Name = "pnlAlive";
            pnlAlive.Size = new Size(38, 39);
            pnlAlive.TabIndex = 21;
            // 
            // pnlDead
            // 
            pnlDead.BackColor = Color.FromArgb(255, 192, 192);
            pnlDead.Location = new Point(77, 382);
            pnlDead.Name = "pnlDead";
            pnlDead.Size = new Size(38, 39);
            pnlDead.TabIndex = 22;
            // 
            // lblAlive
            // 
            lblAlive.AutoSize = true;
            lblAlive.Location = new Point(13, 344);
            lblAlive.Name = "lblAlive";
            lblAlive.Size = new Size(42, 20);
            lblAlive.TabIndex = 23;
            lblAlive.Text = "Alive";
            // 
            // lblDead
            // 
            lblDead.AutoSize = true;
            lblDead.Location = new Point(13, 391);
            lblDead.Name = "lblDead";
            lblDead.Size = new Size(45, 20);
            lblDead.TabIndex = 24;
            lblDead.Text = "Dead";
            // 
            // GameOfLifeController
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDead);
            Controls.Add(lblAlive);
            Controls.Add(pnlDead);
            Controls.Add(pnlAlive);
            Controls.Add(pbInfoPause);
            Controls.Add(pbInfoStart);
            Controls.Add(btnPause);
            Controls.Add(btnStart);
            Controls.Add(pbInfoImport);
            Controls.Add(pbInfoRandom);
            Controls.Add(pbInfoInit);
            Controls.Add(label1);
            Controls.Add(btnImport);
            Controls.Add(btnRandom);
            Controls.Add(btnInit);
            Controls.Add(label2);
            Controls.Add(lblRows);
            Controls.Add(pbInfoCols);
            Controls.Add(pbInfoRows);
            Controls.Add(nudColumns);
            Controls.Add(nudRows);
            Name = "GameOfLifeController";
            Size = new Size(276, 569);
            ((System.ComponentModel.ISupportInitialize)nudRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudColumns).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInfoRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInfoCols).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInfoInit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInfoRandom).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInfoImport).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInfoStart).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInfoPause).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudRows;
        private NumericUpDown nudColumns;
        private PictureBox pbInfoRows;
        private PictureBox pbInfoCols;
        private Label lblRows;
        private Label label2;
        private Button btnInit;
        private Button btnRandom;
        private Button btnImport;
        private Label label1;
        private PictureBox pbInfoInit;
        private PictureBox pbInfoRandom;
        private PictureBox pbInfoImport;
        private Button btnStart;
        private Button btnPause;
        private PictureBox pbInfoStart;
        private PictureBox pbInfoPause;
        private ToolTip ttRows;
        private ToolTip ttCols;
        private ToolTip ttSeed;
        private ToolTip ttInit;
        private ToolTip ttRandom;
        private ToolTip ttImport;
        private ToolTip ttStart;
        private Panel pnlAlive;
        private Panel pnlDead;
        private Label lblAlive;
        private Label lblDead;
        private ToolTip ttPause;
    }
}
