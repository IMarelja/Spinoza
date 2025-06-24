namespace Display
{
    partial class GridSimulationForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridSimulationForm));
            btnNextState = new Button();
            btnBackState = new Button();
            btnLogOut = new Button();
            btnExport = new Button();
            panelControls = new Panel();
            btnBackToMenu = new Button();
            cbAutomataSelect = new ComboBox();
            panelSimulationGrid = new Panel();
            nudAutoNumberOfSteps = new NumericUpDown();
            chbEnableAutoNumber = new CheckBox();
            btnAutoStepsStartPause = new Button();
            timerAutoSteps = new System.Windows.Forms.Timer(components);
            pbSimulationInfo = new PictureBox();
            ttSimulationDescription = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)nudAutoNumberOfSteps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSimulationInfo).BeginInit();
            SuspendLayout();
            // 
            // btnNextState
            // 
            btnNextState.Location = new Point(1267, 922);
            btnNextState.Margin = new Padding(4, 5, 4, 5);
            btnNextState.Name = "btnNextState";
            btnNextState.Size = new Size(119, 53);
            btnNextState.TabIndex = 17;
            btnNextState.Text = "Next";
            btnNextState.UseVisualStyleBackColor = true;
            btnNextState.Click += btnNext_Click;
            // 
            // btnBackState
            // 
            btnBackState.Location = new Point(306, 922);
            btnBackState.Margin = new Padding(4, 5, 4, 5);
            btnBackState.Name = "btnBackState";
            btnBackState.Size = new Size(119, 53);
            btnBackState.TabIndex = 18;
            btnBackState.Text = "Back";
            btnBackState.UseVisualStyleBackColor = true;
            btnBackState.Click += btnBack_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(11, 918);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(124, 53);
            btnLogOut.TabIndex = 22;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnGoBackToMenu_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(161, 918);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(124, 53);
            btnExport.TabIndex = 23;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // panelControls
            // 
            panelControls.BorderStyle = BorderStyle.FixedSingle;
            panelControls.Location = new Point(10, 120);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(275, 695);
            panelControls.TabIndex = 24;
            // 
            // btnBackToMenu
            // 
            btnBackToMenu.Location = new Point(10, 12);
            btnBackToMenu.Name = "btnBackToMenu";
            btnBackToMenu.Size = new Size(274, 60);
            btnBackToMenu.TabIndex = 26;
            btnBackToMenu.Text = "Back to menu";
            btnBackToMenu.UseVisualStyleBackColor = true;
            btnBackToMenu.Click += btnBackToMenu_Click;
            // 
            // cbAutomataSelect
            // 
            cbAutomataSelect.FormattingEnabled = true;
            cbAutomataSelect.Items.AddRange(new object[] { "Game Of Life", "Brian's Brain", "Forest Fire Model", "Langton's Ant" });
            cbAutomataSelect.Location = new Point(10, 80);
            cbAutomataSelect.Margin = new Padding(4, 5, 4, 5);
            cbAutomataSelect.Name = "cbAutomataSelect";
            cbAutomataSelect.Size = new Size(238, 33);
            cbAutomataSelect.TabIndex = 34;
            cbAutomataSelect.SelectedIndexChanged += cbAutomataSelect_SelectedIndexChanged;
            // 
            // panelSimulationGrid
            // 
            panelSimulationGrid.BorderStyle = BorderStyle.FixedSingle;
            panelSimulationGrid.Location = new Point(306, 12);
            panelSimulationGrid.Margin = new Padding(4, 5, 4, 5);
            panelSimulationGrid.Name = "panelSimulationGrid";
            panelSimulationGrid.Size = new Size(1079, 902);
            panelSimulationGrid.TabIndex = 35;
            panelSimulationGrid.Paint += panelSimulationGrid_Paint;
            // 
            // nudAutoNumberOfSteps
            // 
            nudAutoNumberOfSteps.Location = new Point(20, 865);
            nudAutoNumberOfSteps.Margin = new Padding(4, 5, 4, 5);
            nudAutoNumberOfSteps.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAutoNumberOfSteps.Name = "nudAutoNumberOfSteps";
            nudAutoNumberOfSteps.Size = new Size(265, 31);
            nudAutoNumberOfSteps.TabIndex = 43;
            nudAutoNumberOfSteps.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // chbEnableAutoNumber
            // 
            chbEnableAutoNumber.AutoSize = true;
            chbEnableAutoNumber.Location = new Point(19, 823);
            chbEnableAutoNumber.Name = "chbEnableAutoNumber";
            chbEnableAutoNumber.Size = new Size(124, 29);
            chbEnableAutoNumber.TabIndex = 42;
            chbEnableAutoNumber.Text = "Auto steps";
            chbEnableAutoNumber.UseVisualStyleBackColor = true;
            chbEnableAutoNumber.CheckedChanged += chbEnableAutoNumber_CheckedChanged;
            // 
            // btnAutoStepsStartPause
            // 
            btnAutoStepsStartPause.Location = new Point(149, 823);
            btnAutoStepsStartPause.Name = "btnAutoStepsStartPause";
            btnAutoStepsStartPause.Size = new Size(136, 34);
            btnAutoStepsStartPause.TabIndex = 44;
            btnAutoStepsStartPause.Text = "Start";
            btnAutoStepsStartPause.UseVisualStyleBackColor = true;
            btnAutoStepsStartPause.Click += btnAutoStepsStartPause_Click;
            // 
            // timerAutoSteps
            // 
            timerAutoSteps.Interval = 1000;
            timerAutoSteps.Tick += timerAutoSteps_Tick;
            // 
            // pbSimulationInfo
            // 
            pbSimulationInfo.ErrorImage = null;
            pbSimulationInfo.Image = (Image)resources.GetObject("pbSimulationInfo.Image");
            pbSimulationInfo.InitialImage = null;
            pbSimulationInfo.Location = new Point(256, 80);
            pbSimulationInfo.Margin = new Padding(4, 5, 4, 5);
            pbSimulationInfo.Name = "pbSimulationInfo";
            pbSimulationInfo.Size = new Size(29, 33);
            pbSimulationInfo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSimulationInfo.TabIndex = 48;
            pbSimulationInfo.TabStop = false;
            // 
            // GridSimulationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 988);
            Controls.Add(pbSimulationInfo);
            Controls.Add(btnAutoStepsStartPause);
            Controls.Add(nudAutoNumberOfSteps);
            Controls.Add(chbEnableAutoNumber);
            Controls.Add(panelSimulationGrid);
            Controls.Add(cbAutomataSelect);
            Controls.Add(btnBackToMenu);
            Controls.Add(panelControls);
            Controls.Add(btnExport);
            Controls.Add(btnLogOut);
            Controls.Add(btnBackState);
            Controls.Add(btnNextState);
            Margin = new Padding(4, 5, 4, 5);
            Name = "GridSimulationForm";
            Text = "Grid Display";
            ((System.ComponentModel.ISupportInitialize)nudAutoNumberOfSteps).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSimulationInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtRows;
        private TextBox txtColumns;
        private Button btnNextState;
        private Button btnBackState;
        private Button btnLogOut;
        private Button btnExport;
        private Panel panelControls;
        private Button btnBackToMenu;
        private ComboBox cbAutomataSelect;
        private Panel panelSimulationGrid;
        private NumericUpDown nudAutoNumberOfSteps;
        private CheckBox chbEnableAutoNumber;
        private Button btnAutoStepsStartPause;
        private System.Windows.Forms.Timer timerAutoSteps;
        private PictureBox pbSimulationInfo;
        private ToolTip ttSimulationDescription;
    }
}
