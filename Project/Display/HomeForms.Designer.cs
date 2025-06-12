namespace Display
{
    partial class HomeForms
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForms));
            btnGameOfLife = new Button();
            btnBriansBrain = new Button();
            btnForestFire = new Button();
            btnLangtonsAnt = new Button();
            btnLogOut = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGameOfLife
            // 
            btnGameOfLife.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGameOfLife.Image = Properties.Resources.GameOfLife;
            btnGameOfLife.ImageAlign = ContentAlignment.TopCenter;
            btnGameOfLife.Location = new Point(34, 27);
            btnGameOfLife.Name = "btnGameOfLife";
            btnGameOfLife.Size = new Size(248, 211);
            btnGameOfLife.TabIndex = 0;
            btnGameOfLife.Text = "Game Of Life";
            btnGameOfLife.TextAlign = ContentAlignment.BottomCenter;
            btnGameOfLife.UseVisualStyleBackColor = true;
            btnGameOfLife.Click += btnGameOfLife_Click;
            // 
            // btnBriansBrain
            // 
            btnBriansBrain.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBriansBrain.Image = Properties.Resources.BriansBrain;
            btnBriansBrain.Location = new Point(334, 27);
            btnBriansBrain.Name = "btnBriansBrain";
            btnBriansBrain.Size = new Size(248, 211);
            btnBriansBrain.TabIndex = 1;
            btnBriansBrain.Text = "Brian's Brain";
            btnBriansBrain.TextAlign = ContentAlignment.BottomCenter;
            btnBriansBrain.UseVisualStyleBackColor = true;
            btnBriansBrain.Click += btnBriansBrain_Click;
            // 
            // btnForestFire
            // 
            btnForestFire.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnForestFire.Image = Properties.Resources.ForestFire;
            btnForestFire.ImageAlign = ContentAlignment.TopCenter;
            btnForestFire.Location = new Point(649, 27);
            btnForestFire.Name = "btnForestFire";
            btnForestFire.Size = new Size(248, 211);
            btnForestFire.TabIndex = 2;
            btnForestFire.Text = "Forest Fire";
            btnForestFire.TextAlign = ContentAlignment.BottomCenter;
            btnForestFire.TextImageRelation = TextImageRelation.ImageAboveText;
            btnForestFire.UseVisualStyleBackColor = true;
            btnForestFire.Click += btnForestFire_Click;
            // 
            // btnLangtonsAnt
            // 
            btnLangtonsAnt.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLangtonsAnt.Image = Properties.Resources.LangtonAnt;
            btnLangtonsAnt.ImageAlign = ContentAlignment.TopCenter;
            btnLangtonsAnt.Location = new Point(970, 27);
            btnLangtonsAnt.Name = "btnLangtonsAnt";
            btnLangtonsAnt.Size = new Size(248, 211);
            btnLangtonsAnt.TabIndex = 3;
            btnLangtonsAnt.Text = "Langton's Ant";
            btnLangtonsAnt.TextAlign = ContentAlignment.BottomCenter;
            btnLangtonsAnt.UseVisualStyleBackColor = true;
            btnLangtonsAnt.Click += btnLangtonsAnt_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnLogOut.Location = new Point(1243, 27);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(145, 83);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 397);
            label1.Name = "label1";
            label1.Size = new Size(1588, 25);
            label1.TabIndex = 6;
            label1.Text = resources.GetString("label1.Text");
            // 
            // HomeForms
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 1032);
            Controls.Add(label1);
            Controls.Add(btnLogOut);
            Controls.Add(btnLangtonsAnt);
            Controls.Add(btnForestFire);
            Controls.Add(btnBriansBrain);
            Controls.Add(btnGameOfLife);
            Name = "HomeForms";
            Text = "Spinosa: Cellular Automata";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGameOfLife;
        private Button btnBriansBrain;
        private Button btnForestFire;
        private Button btnLangtonsAnt;
        private Button btnLogOut;
        private Label label1;
    }
}