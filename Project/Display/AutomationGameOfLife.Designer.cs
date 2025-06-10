namespace Display
{
    partial class AutomationGameOfLife
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
            lblOptions = new Label();
            comboBox1 = new ComboBox();
            lblGridSize = new Label();
            checkboxGridSize = new CheckBox();
            lblChooseState = new Label();
            flpStates = new FlowLayoutPanel();
            btnState2 = new Button();
            btnState1 = new Button();
            btnState3 = new Button();
            cbRandomState = new CheckBox();
            btnResetStates = new Button();
            comboBoxGridSize = new ComboBox();
            flpStates.SuspendLayout();
            SuspendLayout();
            // 
            // lblOptions
            // 
            lblOptions.AutoSize = true;
            lblOptions.Location = new Point(35, 35);
            lblOptions.Name = "lblOptions";
            lblOptions.Size = new Size(61, 20);
            lblOptions.TabIndex = 0;
            lblOptions.Text = "Options";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(112, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(131, 28);
            comboBox1.TabIndex = 1;
            // 
            // lblGridSize
            // 
            lblGridSize.AutoSize = true;
            lblGridSize.Location = new Point(35, 239);
            lblGridSize.Name = "lblGridSize";
            lblGridSize.Size = new Size(68, 20);
            lblGridSize.TabIndex = 2;
            lblGridSize.Text = "Grid Size";
            // 
            // checkboxGridSize
            // 
            checkboxGridSize.AutoSize = true;
            checkboxGridSize.Location = new Point(112, 280);
            checkboxGridSize.Name = "checkboxGridSize";
            checkboxGridSize.Size = new Size(63, 24);
            checkboxGridSize.TabIndex = 4;
            checkboxGridSize.Text = "Auto";
            checkboxGridSize.UseVisualStyleBackColor = true;
            // 
            // lblChooseState
            // 
            lblChooseState.AutoSize = true;
            lblChooseState.Location = new Point(35, 305);
            lblChooseState.Name = "lblChooseState";
            lblChooseState.Size = new Size(43, 20);
            lblChooseState.TabIndex = 5;
            lblChooseState.Text = "State";
            // 
            // flpStates
            // 
            flpStates.Controls.Add(btnState1);
            flpStates.Controls.Add(btnState2);
            flpStates.Controls.Add(btnState3);
            flpStates.Location = new Point(35, 340);
            flpStates.Name = "flpStates";
            flpStates.Size = new Size(100, 105);
            flpStates.TabIndex = 6;
            // 
            // btnState2
            // 
            btnState2.Location = new Point(3, 36);
            btnState2.Name = "btnState2";
            btnState2.Size = new Size(94, 29);
            btnState2.TabIndex = 0;
            btnState2.Text = "State 2";
            btnState2.UseVisualStyleBackColor = true;
            // 
            // btnState1
            // 
            btnState1.Location = new Point(3, 3);
            btnState1.Name = "btnState1";
            btnState1.Size = new Size(94, 27);
            btnState1.TabIndex = 1;
            btnState1.Text = "State 1";
            btnState1.UseVisualStyleBackColor = true;
            // 
            // btnState3
            // 
            btnState3.Location = new Point(3, 71);
            btnState3.Name = "btnState3";
            btnState3.Size = new Size(94, 29);
            btnState3.TabIndex = 2;
            btnState3.Text = "State 3";
            btnState3.UseVisualStyleBackColor = true;
            // 
            // cbRandomState
            // 
            cbRandomState.AutoSize = true;
            cbRandomState.Location = new Point(35, 463);
            cbRandomState.Name = "cbRandomState";
            cbRandomState.Size = new Size(125, 24);
            cbRandomState.TabIndex = 7;
            cbRandomState.Text = "Random State";
            cbRandomState.UseVisualStyleBackColor = true;
            // 
            // btnResetStates
            // 
            btnResetStates.Location = new Point(75, 503);
            btnResetStates.Name = "btnResetStates";
            btnResetStates.Size = new Size(110, 33);
            btnResetStates.TabIndex = 8;
            btnResetStates.Text = "Reset States";
            btnResetStates.UseVisualStyleBackColor = true;
            // 
            // comboBoxGridSize
            // 
            comboBoxGridSize.FormattingEnabled = true;
            comboBoxGridSize.Location = new Point(112, 236);
            comboBoxGridSize.Name = "comboBoxGridSize";
            comboBoxGridSize.Size = new Size(131, 28);
            comboBoxGridSize.TabIndex = 9;
            // 
            // AutomationGameOfLife
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBoxGridSize);
            Controls.Add(btnResetStates);
            Controls.Add(cbRandomState);
            Controls.Add(flpStates);
            Controls.Add(lblChooseState);
            Controls.Add(checkboxGridSize);
            Controls.Add(lblGridSize);
            Controls.Add(comboBox1);
            Controls.Add(lblOptions);
            Name = "AutomationGameOfLife";
            Size = new Size(276, 569);
            flpStates.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOptions;
        private ComboBox comboBox1;
        private Label lblGridSize;
        private CheckBox checkboxGridSize;
        private Label lblChooseState;
        private FlowLayoutPanel flpStates;
        private Button btnState1;
        private Button btnState2;
        private Button btnState3;
        private CheckBox cbRandomState;
        private Button btnResetStates;
        private ComboBox comboBoxGridSize;
    }
}
