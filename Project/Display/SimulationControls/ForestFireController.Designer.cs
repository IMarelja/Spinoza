namespace Display.SimulationControls
{
    partial class ForestFireController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForestFireController));
            label3 = new Label();
            nudFireChance = new NumericUpDown();
            nudTreeChance = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            nudColumns = new NumericUpDown();
            nudRows = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            lblFirePercent = new Label();
            lblTreePercent = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnImportGrid = new Button();
            btnRandomGrid = new Button();
            btnInitGrid = new Button();
            pbGrid = new PictureBox();
            pbSettings = new PictureBox();
            pbRandom = new PictureBox();
            ttGrid = new ToolTip(components);
            ttSettings = new ToolTip(components);
            ttRandom = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)nudFireChance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTreeChance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudColumns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSettings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRandom).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 107);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 67;
            label3.Text = "Simulation Settings";
            // 
            // nudFireChance
            // 
            nudFireChance.Location = new Point(88, 176);
            nudFireChance.Name = "nudFireChance";
            nudFireChance.Size = new Size(77, 23);
            nudFireChance.TabIndex = 66;
            nudFireChance.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // nudTreeChance
            // 
            nudTreeChance.Location = new Point(88, 142);
            nudTreeChance.Name = "nudTreeChance";
            nudTreeChance.Size = new Size(77, 23);
            nudTreeChance.TabIndex = 65;
            nudTreeChance.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 178);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 64;
            label6.Text = "Chance of Fire";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 144);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 63;
            label5.Text = "Chance of Tree";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 14);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 61;
            label4.Text = "Grid Size";
            // 
            // nudColumns
            // 
            nudColumns.Location = new Point(88, 70);
            nudColumns.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudColumns.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nudColumns.Name = "nudColumns";
            nudColumns.Size = new Size(90, 23);
            nudColumns.TabIndex = 60;
            nudColumns.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // nudRows
            // 
            nudRows.Location = new Point(88, 41);
            nudRows.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudRows.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            nudRows.Name = "nudRows";
            nudRows.Size = new Size(90, 23);
            nudRows.TabIndex = 59;
            nudRows.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 72);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 58;
            label2.Text = "Columns";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 41);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 57;
            label1.Text = "Rows";
            // 
            // lblFirePercent
            // 
            lblFirePercent.AutoSize = true;
            lblFirePercent.Location = new Point(171, 178);
            lblFirePercent.Name = "lblFirePercent";
            lblFirePercent.Size = new Size(17, 15);
            lblFirePercent.TabIndex = 69;
            lblFirePercent.Text = "%";
            // 
            // lblTreePercent
            // 
            lblTreePercent.AutoSize = true;
            lblTreePercent.Location = new Point(170, 144);
            lblTreePercent.Name = "lblTreePercent";
            lblTreePercent.Size = new Size(17, 15);
            lblTreePercent.TabIndex = 68;
            lblTreePercent.Text = "%";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Location = new Point(149, 258);
            panel1.Name = "panel1";
            panel1.Size = new Size(38, 38);
            panel1.TabIndex = 70;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Green;
            panel2.Location = new Point(78, 258);
            panel2.Name = "panel2";
            panel2.Size = new Size(38, 38);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Location = new Point(3, 258);
            panel3.Name = "panel3";
            panel3.Size = new Size(38, 38);
            panel3.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 240);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 71;
            label7.Text = "Empty";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(81, 240);
            label8.Name = "label8";
            label8.Size = new Size(29, 15);
            label8.TabIndex = 72;
            label8.Text = "Tree";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(156, 240);
            label9.Name = "label9";
            label9.Size = new Size(26, 15);
            label9.TabIndex = 73;
            label9.Text = "Fire";
            // 
            // btnImportGrid
            // 
            btnImportGrid.Location = new Point(95, 214);
            btnImportGrid.Margin = new Padding(2);
            btnImportGrid.Name = "btnImportGrid";
            btnImportGrid.Size = new Size(92, 23);
            btnImportGrid.TabIndex = 76;
            btnImportGrid.Text = "Import Grid";
            btnImportGrid.UseVisualStyleBackColor = true;
            btnImportGrid.Click += btnImportGrid_Click;
            // 
            // btnRandomGrid
            // 
            btnRandomGrid.Location = new Point(48, 311);
            btnRandomGrid.Name = "btnRandomGrid";
            btnRandomGrid.Size = new Size(92, 23);
            btnRandomGrid.TabIndex = 75;
            btnRandomGrid.Text = "Random Grid";
            btnRandomGrid.UseVisualStyleBackColor = true;
            btnRandomGrid.Click += btnRandomGrid_Click;
            // 
            // btnInitGrid
            // 
            btnInitGrid.Location = new Point(3, 214);
            btnInitGrid.Name = "btnInitGrid";
            btnInitGrid.Size = new Size(92, 23);
            btnInitGrid.TabIndex = 74;
            btnInitGrid.Text = "Initialize Grid";
            btnInitGrid.UseVisualStyleBackColor = true;
            btnInitGrid.Click += btnInitGrid_Click;
            // 
            // pbGrid
            // 
            pbGrid.ErrorImage = null;
            pbGrid.Image = (Image)resources.GetObject("pbGrid.Image");
            pbGrid.InitialImage = null;
            pbGrid.Location = new Point(126, 8);
            pbGrid.Margin = new Padding(4, 5, 4, 5);
            pbGrid.Name = "pbGrid";
            pbGrid.Size = new Size(21, 25);
            pbGrid.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGrid.TabIndex = 77;
            pbGrid.TabStop = false;
            // 
            // pbSettings
            // 
            pbSettings.ErrorImage = null;
            pbSettings.Image = (Image)resources.GetObject("pbSettings.Image");
            pbSettings.InitialImage = null;
            pbSettings.Location = new Point(149, 101);
            pbSettings.Margin = new Padding(4, 5, 4, 5);
            pbSettings.Name = "pbSettings";
            pbSettings.Size = new Size(21, 25);
            pbSettings.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSettings.TabIndex = 78;
            pbSettings.TabStop = false;
            // 
            // pbRandom
            // 
            pbRandom.ErrorImage = null;
            pbRandom.Image = (Image)resources.GetObject("pbRandom.Image");
            pbRandom.InitialImage = null;
            pbRandom.Location = new Point(149, 311);
            pbRandom.Margin = new Padding(4, 5, 4, 5);
            pbRandom.Name = "pbRandom";
            pbRandom.Size = new Size(21, 25);
            pbRandom.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRandom.TabIndex = 79;
            pbRandom.TabStop = false;
            // 
            // ForestFireController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pbRandom);
            Controls.Add(pbSettings);
            Controls.Add(pbGrid);
            Controls.Add(btnImportGrid);
            Controls.Add(btnRandomGrid);
            Controls.Add(btnInitGrid);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(lblFirePercent);
            Controls.Add(lblTreePercent);
            Controls.Add(label3);
            Controls.Add(nudFireChance);
            Controls.Add(nudTreeChance);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(nudColumns);
            Controls.Add(nudRows);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ForestFireController";
            Size = new Size(190, 349);
            ((System.ComponentModel.ISupportInitialize)nudFireChance).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTreeChance).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudColumns).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSettings).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRandom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private NumericUpDown nudFireChance;
        private NumericUpDown nudTreeChance;
        private Label label6;
        private Label label5;
        private Label label4;
        private NumericUpDown nudColumns;
        private NumericUpDown nudRows;
        private Label label2;
        private Label label1;
        private Label lblFirePercent;
        private Label lblTreePercent;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnImportGrid;
        private Button btnRandomGrid;
        private Button btnInitGrid;
        private PictureBox pbGrid;
        private PictureBox pbSettings;
        private PictureBox pbRandom;
        private ToolTip ttGrid;
        private ToolTip ttSettings;
        private ToolTip ttRandom;
    }
}
