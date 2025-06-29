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
        /// 

        private void InitializeComponent()
        {
            btnGameOfLife = new Button();
            btnBriansBrain = new Button();
            btnForestFire = new Button();
            btnLangtonsAnt = new Button();
            btnLogOut = new Button();
            lbWelcomeMessage = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGameOfLife
            // 
            btnGameOfLife.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGameOfLife.ImageAlign = ContentAlignment.TopCenter;
            btnGameOfLife.Location = new Point(22, 43);
            btnGameOfLife.Margin = new Padding(2);
            btnGameOfLife.Name = "btnGameOfLife";
            btnGameOfLife.Size = new Size(174, 119);
            btnGameOfLife.TabIndex = 0;
            btnGameOfLife.Text = "Game Of Life";
            btnGameOfLife.TextAlign = ContentAlignment.BottomCenter;
            btnGameOfLife.TextImageRelation = TextImageRelation.ImageAboveText;
            btnGameOfLife.UseVisualStyleBackColor = true;
            btnGameOfLife.Click += btnGameOfLife_Click;
            // 
            // btnBriansBrain
            // 
            btnBriansBrain.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBriansBrain.ImageAlign = ContentAlignment.TopCenter;
            btnBriansBrain.Location = new Point(232, 43);
            btnBriansBrain.Margin = new Padding(2);
            btnBriansBrain.Name = "btnBriansBrain";
            btnBriansBrain.Size = new Size(174, 119);
            btnBriansBrain.TabIndex = 1;
            btnBriansBrain.Text = "Brian's Brain";
            btnBriansBrain.TextAlign = ContentAlignment.BottomCenter;
            btnBriansBrain.TextImageRelation = TextImageRelation.ImageAboveText;
            btnBriansBrain.UseVisualStyleBackColor = true;
            btnBriansBrain.Click += btnBriansBrain_Click;
            // 
            // btnForestFire
            // 
            btnForestFire.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnForestFire.ImageAlign = ContentAlignment.TopCenter;
            btnForestFire.Location = new Point(452, 43);
            btnForestFire.Margin = new Padding(2);
            btnForestFire.Name = "btnForestFire";
            btnForestFire.Size = new Size(174, 119);
            btnForestFire.TabIndex = 2;
            btnForestFire.Text = "Forest Fire";
            btnForestFire.TextAlign = ContentAlignment.BottomCenter;
            btnForestFire.TextImageRelation = TextImageRelation.ImageAboveText;
            btnForestFire.UseVisualStyleBackColor = true;
            btnForestFire.Click += btnForestFire_Click;
            // 
            // btnLangtonsAnt
            // 
            btnLangtonsAnt.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLangtonsAnt.ImageAlign = ContentAlignment.TopCenter;
            btnLangtonsAnt.Location = new Point(677, 43);
            btnLangtonsAnt.Margin = new Padding(2);
            btnLangtonsAnt.Name = "btnLangtonsAnt";
            btnLangtonsAnt.Size = new Size(174, 119);
            btnLangtonsAnt.TabIndex = 3;
            btnLangtonsAnt.Text = "Langton's Ant";
            btnLangtonsAnt.TextAlign = ContentAlignment.BottomCenter;
            btnLangtonsAnt.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLangtonsAnt.UseVisualStyleBackColor = true;
            btnLangtonsAnt.Click += btnLangtonsAnt_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnLogOut.Location = new Point(865, 115);
            btnLogOut.Margin = new Padding(2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(102, 47);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // lbWelcomeMessage
            // 
            lbWelcomeMessage.AutoSize = true;
            lbWelcomeMessage.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbWelcomeMessage.ImageAlign = ContentAlignment.TopCenter;
            lbWelcomeMessage.Location = new Point(165, 257);
            lbWelcomeMessage.Margin = new Padding(2, 0, 2, 0);
            lbWelcomeMessage.Name = "lbWelcomeMessage";
            lbWelcomeMessage.Size = new Size(673, 172);
            lbWelcomeMessage.TabIndex = 6;
            lbWelcomeMessage.Text = "Welcome to SPINOZA \r\nSimulation application";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 18);
            label1.TabIndex = 7;
            label1.Text = "Simulations";
            // 
            // HomeForms
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 578);
            Controls.Add(label1);
            Controls.Add(lbWelcomeMessage);
            Controls.Add(btnLogOut);
            Controls.Add(btnLangtonsAnt);
            Controls.Add(btnForestFire);
            Controls.Add(btnBriansBrain);
            Controls.Add(btnGameOfLife);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2);
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
        private Label lbWelcomeMessage;
        private Label label1;
    }
}