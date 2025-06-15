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
            btnNextState = new Button();
            btnBackState = new Button();
            colorDialog1 = new ColorDialog();
            btnLogOut = new Button();
            btnExport = new Button();
            panelControls = new Panel();
            btnBackToMenu = new Button();
            cbAutomataSelect = new ComboBox();
            panelSimulationGrid = new Panel();
            SuspendLayout();
            // 
            // btnNextState
            // 
            btnNextState.Location = new Point(887, 553);
            btnNextState.Name = "btnNextState";
            btnNextState.Size = new Size(83, 32);
            btnNextState.TabIndex = 17;
            btnNextState.Text = "Next";
            btnNextState.UseVisualStyleBackColor = true;
            btnNextState.Click += btnNext_Click;
            // 
            // btnBackState
            // 
            btnBackState.Location = new Point(214, 553);
            btnBackState.Name = "btnBackState";
            btnBackState.Size = new Size(83, 32);
            btnBackState.TabIndex = 18;
            btnBackState.Text = "Back";
            btnBackState.UseVisualStyleBackColor = true;
            btnBackState.Click += btnBack_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(8, 551);
            btnLogOut.Margin = new Padding(2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(87, 32);
            btnLogOut.TabIndex = 22;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnGoBackToMenu_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(113, 551);
            btnExport.Margin = new Padding(2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(87, 32);
            btnExport.TabIndex = 23;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // panelControls
            // 
            panelControls.BorderStyle = BorderStyle.FixedSingle;
            panelControls.Location = new Point(7, 72);
            panelControls.Margin = new Padding(2);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(193, 477);
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
            // 
            // cbAutomataSelect
            // 
            cbAutomataSelect.FormattingEnabled = true;
            cbAutomataSelect.Items.AddRange(new object[] { "Game Of Life", "Brian's Brain", "Forest Fire Model", "Langton's Ant" });
            cbAutomataSelect.Location = new Point(7, 47);
            cbAutomataSelect.Name = "cbAutomataSelect";
            cbAutomataSelect.Size = new Size(194, 23);
            cbAutomataSelect.TabIndex = 34;
            cbAutomataSelect.SelectedIndexChanged += cbAutomataSelect_SelectedIndexChanged;
            // 
            // panelSimulationGrid
            // 
            panelSimulationGrid.BorderStyle = BorderStyle.FixedSingle;
            panelSimulationGrid.Location = new Point(214, 7);
            panelSimulationGrid.Name = "panelSimulationGrid";
            panelSimulationGrid.Size = new Size(756, 542);
            panelSimulationGrid.TabIndex = 35;
            panelSimulationGrid.Paint += panelSimulationGrid_Paint;
            // 
            // GridSimulationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 593);
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
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtRows;
        private TextBox txtColumns;
        private Button btnNextState;
        private Button btnBackState;
        private ColorDialog colorDialog1;
        private Button btnLogOut;
        private Button btnExport;
        private Panel panelControls;
        private Button btnBackToMenu;
        private ComboBox cbAutomataSelect;
        private Panel panelSimulationGrid;
    }
}
