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
            label3 = new Label();
            pbInfoSeedLife = new PictureBox();
            nudLifeSeed = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudColumns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInfoRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInfoCols).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInfoInit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInfoRandom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInfoImport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInfoSeedLife).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLifeSeed).BeginInit();
            SuspendLayout();
            // 
            // nudRows
            // 
            nudRows.Location = new Point(63, 41);
            nudRows.Margin = new Padding(3, 2, 3, 2);
            nudRows.Name = "nudRows";
            nudRows.Size = new Size(102, 23);
            nudRows.TabIndex = 0;
            // 
            // nudColumns
            // 
            nudColumns.Location = new Point(64, 68);
            nudColumns.Margin = new Padding(3, 2, 3, 2);
            nudColumns.Name = "nudColumns";
            nudColumns.Size = new Size(101, 23);
            nudColumns.TabIndex = 1;
            // 
            // pbInfoRows
            // 
            pbInfoRows.Location = new Point(168, 44);
            pbInfoRows.Margin = new Padding(3, 2, 3, 2);
            pbInfoRows.Name = "pbInfoRows";
            pbInfoRows.Size = new Size(22, 20);
            pbInfoRows.SizeMode = PictureBoxSizeMode.Zoom;
            pbInfoRows.TabIndex = 3;
            pbInfoRows.TabStop = false;
            pbInfoRows.Image = SystemIcons.Information.ToBitmap();
            // 
            // pbInfoCols
            // 
            pbInfoCols.Location = new Point(168, 71);
            pbInfoCols.Margin = new Padding(3, 2, 3, 2);
            pbInfoCols.Name = "pbInfoCols";
            pbInfoCols.Size = new Size(22, 20);
            pbInfoCols.SizeMode = PictureBoxSizeMode.Zoom;
            pbInfoCols.TabIndex = 4;
            pbInfoCols.TabStop = false;
            pbInfoCols.Image = SystemIcons.Information.ToBitmap();
            // 
            // lblRows
            // 
            lblRows.AutoSize = true;
            lblRows.Location = new Point(3, 41);
            lblRows.Name = "lblRows";
            lblRows.Size = new Size(35, 15);
            lblRows.TabIndex = 6;
            lblRows.Text = "Rows";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 68);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 7;
            label2.Text = "Columns";
            // 
            // btnInit
            // 
            btnInit.Location = new Point(15, 334);
            btnInit.Margin = new Padding(3, 2, 3, 2);
            btnInit.Name = "btnInit";
            btnInit.Size = new Size(82, 22);
            btnInit.TabIndex = 9;
            btnInit.Text = "Initialize";
            btnInit.UseVisualStyleBackColor = true;
            btnInit.Click += btnInit_Click;
            // 
            // btnRandom
            // 
            btnRandom.Location = new Point(15, 360);
            btnRandom.Margin = new Padding(3, 2, 3, 2);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(82, 22);
            btnRandom.TabIndex = 10;
            btnRandom.Text = "Randomize";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandomize_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(15, 386);
            btnImport.Margin = new Padding(3, 2, 3, 2);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(82, 22);
            btnImport.TabIndex = 11;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 12;
            label1.Text = "Game Of Life";
            // 
            // pbInfoInit
            // 
            pbInfoInit.Location = new Point(102, 335);
            pbInfoInit.Margin = new Padding(3, 2, 3, 2);
            pbInfoInit.Name = "pbInfoInit";
            pbInfoInit.Size = new Size(22, 20);
            pbInfoInit.SizeMode = PictureBoxSizeMode.Zoom;
            pbInfoInit.TabIndex = 13;
            pbInfoInit.TabStop = false;
            pbInfoInit.Image = SystemIcons.Information.ToBitmap(); 
            // 
            // pbInfoRandom
            // 
            pbInfoRandom.Location = new Point(102, 360);
            pbInfoRandom.Margin = new Padding(3, 2, 3, 2);
            pbInfoRandom.Name = "pbInfoRandom";
            pbInfoRandom.Size = new Size(22, 20);
            pbInfoRandom.SizeMode = PictureBoxSizeMode.Zoom;
            pbInfoRandom.TabIndex = 14;
            pbInfoRandom.TabStop = false;
            pbInfoRandom.Image = SystemIcons.Information.ToBitmap();
            // 
            // pbInfoImport
            // 
            pbInfoImport.Location = new Point(102, 388);
            pbInfoImport.Margin = new Padding(3, 2, 3, 2);
            pbInfoImport.Name = "pbInfoImport";
            pbInfoImport.Size = new Size(22, 20);
            pbInfoImport.SizeMode = PictureBoxSizeMode.Zoom;
            pbInfoImport.TabIndex = 15;
            pbInfoImport.TabStop = false;
            pbInfoImport.Image = SystemIcons.Information.ToBitmap();
            // 
            // pnlAlive
            // 
            pnlAlive.BackColor = Color.FromArgb(128, 255, 128);
            pnlAlive.Location = new Point(67, 253);
            pnlAlive.Margin = new Padding(3, 2, 3, 2);
            pnlAlive.Name = "pnlAlive";
            pnlAlive.Size = new Size(33, 29);
            pnlAlive.TabIndex = 21;
            // 
            // pnlDead
            // 
            pnlDead.BackColor = Color.FromArgb(255, 192, 192);
            pnlDead.Location = new Point(67, 286);
            pnlDead.Margin = new Padding(3, 2, 3, 2);
            pnlDead.Name = "pnlDead";
            pnlDead.Size = new Size(33, 29);
            pnlDead.TabIndex = 22;
            // 
            // lblAlive
            // 
            lblAlive.AutoSize = true;
            lblAlive.Location = new Point(11, 258);
            lblAlive.Name = "lblAlive";
            lblAlive.Size = new Size(33, 15);
            lblAlive.TabIndex = 23;
            lblAlive.Text = "Alive";
            // 
            // lblDead
            // 
            lblDead.AutoSize = true;
            lblDead.Location = new Point(11, 293);
            lblDead.Name = "lblDead";
            lblDead.Size = new Size(34, 15);
            lblDead.TabIndex = 24;
            lblDead.Text = "Dead";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 125);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 27;
            label3.Text = "Life";
            // 
            // pbInfoSeedLife
            // 
            pbInfoSeedLife.Image = Properties.Resources.notify;
            pbInfoSeedLife.Location = new Point(168, 128);
            pbInfoSeedLife.Margin = new Padding(3, 2, 3, 2);
            pbInfoSeedLife.Name = "pbInfoSeedLife";
            pbInfoSeedLife.Size = new Size(22, 20);
            pbInfoSeedLife.SizeMode = PictureBoxSizeMode.Zoom;
            pbInfoSeedLife.TabIndex = 26;
            pbInfoSeedLife.TabStop = false;
            pbInfoSeedLife.Image = SystemIcons.Information.ToBitmap();
            // 
            // nudLifeSeed
            // 
            nudLifeSeed.Location = new Point(64, 125);
            nudLifeSeed.Margin = new Padding(3, 2, 3, 2);
            nudLifeSeed.Name = "nudLifeSeed";
            nudLifeSeed.Size = new Size(101, 23);
            nudLifeSeed.TabIndex = 25;
            // 
            // GameOfLifeController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(pbInfoSeedLife);
            Controls.Add(nudLifeSeed);
            Controls.Add(lblDead);
            Controls.Add(lblAlive);
            Controls.Add(pnlDead);
            Controls.Add(pnlAlive);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "GameOfLifeController";
            Size = new Size(192, 427);
            ((System.ComponentModel.ISupportInitialize)nudRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudColumns).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInfoRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInfoCols).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInfoInit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInfoRandom).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInfoImport).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInfoSeedLife).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLifeSeed).EndInit();
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
        private Label label3;
        private PictureBox pbInfoSeedLife;
        private NumericUpDown nudLifeSeed;
    }
}
