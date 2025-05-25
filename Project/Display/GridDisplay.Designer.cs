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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            nudRows = new NumericUpDown();
            nudColumns = new NumericUpDown();
            nudTree = new NumericUpDown();
            nudFire = new NumericUpDown();
            btnNext = new Button();
            btnBack = new Button();
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
            label1.Location = new Point(7, 35);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 4;
            label1.Text = "Rows";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 64);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "Columns";
            // 
            // btnInitGrid
            // 
            btnInitGrid.Location = new Point(99, 165);
            btnInitGrid.Name = "btnInitGrid";
            btnInitGrid.Size = new Size(100, 23);
            btnInitGrid.TabIndex = 6;
            btnInitGrid.Text = "Intialise Grid";
            btnInitGrid.UseVisualStyleBackColor = true;
            btnInitGrid.Click += btnInitGrid_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 106);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 7;
            label3.Text = "Chance of Tree";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 135);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 10;
            label4.Text = "Chance of Fire";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(182, 106);
            label5.Name = "label5";
            label5.Size = new Size(17, 15);
            label5.TabIndex = 11;
            label5.Text = "%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(182, 135);
            label6.Name = "label6";
            label6.Size = new Size(17, 15);
            label6.TabIndex = 12;
            label6.Text = "%";
            // 
            // nudRows
            // 
            nudRows.Location = new Point(99, 33);
            nudRows.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudRows.Name = "nudRows";
            nudRows.Size = new Size(100, 23);
            nudRows.TabIndex = 13;
            // 
            // nudColumns
            // 
            nudColumns.Location = new Point(99, 64);
            nudColumns.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudColumns.Name = "nudColumns";
            nudColumns.Size = new Size(100, 23);
            nudColumns.TabIndex = 14;
            // 
            // nudTree
            // 
            nudTree.Location = new Point(99, 104);
            nudTree.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudTree.Name = "nudTree";
            nudTree.Size = new Size(77, 23);
            nudTree.TabIndex = 15;
            // 
            // nudFire
            // 
            nudFire.Location = new Point(99, 133);
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
            // GridDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 619);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Controls.Add(nudFire);
            Controls.Add(nudTree);
            Controls.Add(nudColumns);
            Controls.Add(nudRows);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
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
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown nudRows;
        private NumericUpDown nudColumns;
        private NumericUpDown nudTree;
        private NumericUpDown nudFire;
        private Button btnNext;
        private Button btnBack;
    }
}
