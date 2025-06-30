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
            btn_SaveGrid = new Button();
            label1 = new Label();
            label2 = new Label();
            nudStepInterval = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudAutoNumberOfSteps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSimulationInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStepInterval).BeginInit();
            SuspendLayout();
            // 
            // btnNextState
            // 
            btnNextState.Location = new Point(887, 581);
            btnNextState.Name = "btnNextState";
            btnNextState.Size = new Size(83, 32);
            btnNextState.TabIndex = 17;
            btnNextState.Text = "Next";
            btnNextState.UseVisualStyleBackColor = true;
            btnNextState.Click += btnNext_Click;
            // 
            // btnBackState
            // 
            btnBackState.Location = new Point(214, 580);
            btnBackState.Name = "btnBackState";
            btnBackState.Size = new Size(83, 32);
            btnBackState.TabIndex = 18;
            btnBackState.Text = "Back";
            btnBackState.UseVisualStyleBackColor = true;
            btnBackState.Click += btnBack_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(7, 581);
            btnLogOut.Margin = new Padding(2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(87, 32);
            btnLogOut.TabIndex = 22;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(113, 581);
            btnExport.Margin = new Padding(2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(87, 32);
            btnExport.TabIndex = 23;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // panelControls
            // 
            panelControls.BorderStyle = BorderStyle.FixedSingle;
            panelControls.Location = new Point(7, 72);
            panelControls.Margin = new Padding(2);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(193, 418);
            panelControls.TabIndex = 24;
            // 
            // btnBackToMenu
            // 
            btnBackToMenu.Location = new Point(7, 7);
            btnBackToMenu.Margin = new Padding(2);
            btnBackToMenu.Name = "btnBackToMenu";
            btnBackToMenu.Size = new Size(192, 36);
            btnBackToMenu.TabIndex = 26;
            btnBackToMenu.Text = "Back to menu";
            btnBackToMenu.UseVisualStyleBackColor = true;
            btnBackToMenu.Click += btnBackToMenu_Click;
            // 
            // cbAutomataSelect
            // 
            cbAutomataSelect.FormattingEnabled = true;
            cbAutomataSelect.Items.AddRange(new object[] { "Game Of Life", "Brian's Brain", "Forest Fire Model", "Langton's Ant" });
            cbAutomataSelect.Location = new Point(7, 48);
            cbAutomataSelect.Name = "cbAutomataSelect";
            cbAutomataSelect.Size = new Size(168, 23);
            cbAutomataSelect.TabIndex = 34;
            cbAutomataSelect.SelectedIndexChanged += cbAutomataSelect_SelectedIndexChanged;
            // 
            // panelSimulationGrid
            // 
            panelSimulationGrid.BorderStyle = BorderStyle.FixedSingle;
            panelSimulationGrid.Location = new Point(214, 7);
            panelSimulationGrid.Name = "panelSimulationGrid";
            panelSimulationGrid.Size = new Size(756, 566);
            panelSimulationGrid.TabIndex = 35;
            panelSimulationGrid.Paint += panelSimulationGrid_Paint;
            // 
            // nudAutoNumberOfSteps
            // 
            nudAutoNumberOfSteps.Location = new Point(114, 521);
            nudAutoNumberOfSteps.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAutoNumberOfSteps.Name = "nudAutoNumberOfSteps";
            nudAutoNumberOfSteps.Size = new Size(87, 23);
            nudAutoNumberOfSteps.TabIndex = 43;
            nudAutoNumberOfSteps.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // chbEnableAutoNumber
            // 
            chbEnableAutoNumber.AutoSize = true;
            chbEnableAutoNumber.Location = new Point(13, 494);
            chbEnableAutoNumber.Margin = new Padding(2);
            chbEnableAutoNumber.Name = "chbEnableAutoNumber";
            chbEnableAutoNumber.Size = new Size(82, 19);
            chbEnableAutoNumber.TabIndex = 42;
            chbEnableAutoNumber.Text = "Auto steps";
            chbEnableAutoNumber.UseVisualStyleBackColor = true;
            chbEnableAutoNumber.CheckedChanged += chbEnableAutoNumber_CheckedChanged;
            // 
            // btnAutoStepsStartPause
            // 
            btnAutoStepsStartPause.Location = new Point(113, 494);
            btnAutoStepsStartPause.Margin = new Padding(2);
            btnAutoStepsStartPause.Name = "btnAutoStepsStartPause";
            btnAutoStepsStartPause.Size = new Size(86, 20);
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
            pbSimulationInfo.Location = new Point(179, 48);
            pbSimulationInfo.Name = "pbSimulationInfo";
            pbSimulationInfo.Size = new Size(20, 20);
            pbSimulationInfo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSimulationInfo.TabIndex = 48;
            pbSimulationInfo.TabStop = false;
            // 
            // btn_SaveGrid
            // 
            btn_SaveGrid.Location = new Point(303, 579);
            btn_SaveGrid.Name = "btn_SaveGrid";
            btn_SaveGrid.Size = new Size(89, 32);
            btn_SaveGrid.TabIndex = 49;
            btn_SaveGrid.Text = "Save Grid";
            btn_SaveGrid.UseVisualStyleBackColor = true;
            btn_SaveGrid.Click += btn_SaveGrid_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 521);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 50;
            label1.Text = "Number of Steps";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 552);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 51;
            label2.Text = "Step Interval";
            // 
            // nudStepInterval
            // 
            nudStepInterval.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudStepInterval.Location = new Point(114, 550);
            nudStepInterval.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudStepInterval.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudStepInterval.Name = "nudStepInterval";
            nudStepInterval.Size = new Size(87, 23);
            nudStepInterval.TabIndex = 52;
            nudStepInterval.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // GridSimulationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 624);
            Controls.Add(nudStepInterval);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_SaveGrid);
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
            Name = "GridSimulationForm";
            Text = "Grid Display";
            ((System.ComponentModel.ISupportInitialize)nudAutoNumberOfSteps).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSimulationInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStepInterval).EndInit();
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
        private Button btn_SaveGrid;
        private Label label1;
        private Label label2;
        private NumericUpDown nudStepInterval;
    }
}
