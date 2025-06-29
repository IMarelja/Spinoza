using Display.SimulationControls;
using Display.Utilities;
using Models;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Display
{
    public partial class GridSimulationForm : Form
    {
        private List<Control> autoStartControls;

        private Grid gridLayoutFromUserControl;
        private UserControl simulationController;
        private int currentStep = 0;

        public GridSimulationForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            clearForm();
            addingSimulationSelectionToCombobox();
            initControlGroupingsInAList();
            changedEnablilityAutoStartControls();

            /*
             * ------------------------------------------------------------------------
             * For configuring the grid to look nice and for the blocks to be places
             * ------------------------------------------------------------------------
             */
            typeof(Panel).InvokeMember("DoubleBuffered",
            System.Reflection.BindingFlags.SetProperty |
            System.Reflection.BindingFlags.Instance |
            System.Reflection.BindingFlags.NonPublic,
            null, panelSimulationGrid, new object[] { true });

        }

        private void initControlGroupingsInAList()
        {
            autoStartControls = new List<Control> {
                chbEnableAutoNumber ,
                btnAutoStepsStartPause ,
                nudAutoNumberOfSteps
            };
        }

        private void addingSimulationSelectionToCombobox()
        {
            foreach (Grid grid in Utility.approvedSimulationsGrids)
            {
                cbAutomataSelect.Items.Add(grid);

            }
        }

        private void clearForm()
        {
            cbAutomataSelect.Items.Clear();
            panelControls.Controls.Clear();
            cbAutomataSelect.SelectedIndex = -1;
            ttSimulationDescription.RemoveAll(); // Removes all tooltips assigned
            ttSimulationDescription.IsBalloon = true;
            ttSimulationDescription.ToolTipTitle = "Please select a simulation";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (gridLayoutFromUserControl == null) return;

            gridLayoutFromUserControl.NextStep();
            panelSimulationGrid.Invalidate();

            currentStep++;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (gridLayoutFromUserControl == null) return;

            gridLayoutFromUserControl.BackStep();
            panelSimulationGrid.Invalidate();

            if (currentStep > 0)
                currentStep--;

        }

        private void cbAutomataSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
                switch ((Grid)cbAutomataSelect.SelectedItem)
                {
                    case Brain brain:
                        LoadSimulationUserControlInsideControlPanel(new BriansBrainController());
                        Utility.SetInfoBalloonTooltipForControl(ttSimulationDescription,pbSimulationInfo,brain.Name,brain.Description);
                        break;

                    case Forest forest:
                        LoadSimulationUserControlInsideControlPanel(new ForestFireController());
                        Utility.SetInfoBalloonTooltipForControl(ttSimulationDescription, pbSimulationInfo, forest.Name, forest.Description);
                        break;

                    case LangtonsGrid langtons:
                        LoadSimulationUserControlInsideControlPanel(new LangtonsAntController());
                        Utility.SetInfoBalloonTooltipForControl(ttSimulationDescription, pbSimulationInfo, langtons.Name, langtons.Description);
                        break;
                    case Life life:
                        LoadSimulationUserControlInsideControlPanel(new GameOfLifeController());
                        Utility.SetInfoBalloonTooltipForControl(ttSimulationDescription, pbSimulationInfo, life.Name, life.Description);
                        break;
                    default:
                        // Optional: handle unknown type
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                clearForm();
            }
        }

        /*
         * ===========================================================================================
         * Loads User control inside a panel, checks if it is derived class of INotifyPropertyChanged
         * ===========================================================================================
         */
        private void LoadSimulationUserControlInsideControlPanel(UserControl simulationUserControl)
        {

            if (simulationUserControl is not INotifyPropertyChanged notifyControl)
                throw new Exception("The User Control being called is not a derivitive of the abstract class INotifyPropertyChanged");

            notifyControl.PropertyChanged += OnUserControlPropertyChanged; 
            simulationController = simulationUserControl;

            panelControls.Controls.Clear();
            simulationController.Dock = DockStyle.Fill;
            panelControls.Controls.Add(simulationController);
        }


        /*
         * ===============================================================================================================
         * 🧇 Fetches data from User Controls PropertyChangedEventHandler that are stored in SimulationControls  🧇
         * ===============================================================================================================
         */

        private void OnUserControlPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (sender)
            {
                case BriansBrainController controlBrain 
                when e.PropertyName == nameof(BriansBrainController.brian):
                    gridLayoutFromUserControl = controlBrain.brian;
                    panelSimulationGrid.Invalidate();
                    break;

                case LangtonsAntController controlAnt 
                when e.PropertyName == nameof(LangtonsAntController.Grid):
                    gridLayoutFromUserControl = controlAnt.Grid;
                    panelSimulationGrid.Invalidate();
                    break;

                case ForestFireController controlForest 
                when e.PropertyName == nameof(ForestFireController.Grid):
                    gridLayoutFromUserControl = controlForest.Grid;
                    panelSimulationGrid.Invalidate();
                    break;
                case GameOfLifeController controlLife
                when e.PropertyName == nameof(GameOfLifeController.Simulation):
                    gridLayoutFromUserControl = controlLife.Simulation;
                    panelSimulationGrid.Invalidate();
                    break;

                default:
                    break;
            }

            stepsTakenAutoStart = 0;
        }




        private void btnGoBackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var homeForm = new HomeForms(false);

            Cursor.Current = Cursors.Default;
            homeForm.Closed += (object_sender, EventArgs_e) => this.Close();
            homeForm.Show();
        }


        private void panelSimulationGrid_Paint(object sender, PaintEventArgs e)
        {

            if (gridLayoutFromUserControl == null)
                return;


            switch (gridLayoutFromUserControl)
            {
                case Brain brain:
                    InitBrainTable(sender, e);
                    break;

                case Forest forest:
                    InitForestFire(sender, e);
                    break;

                case LangtonsGrid langtons:
                    InitLangtonsAnt(sender, e);
                    break;
                case Life life:
                    InitGameOfLifeGrid(sender, e);
                    break;

                default:
                    // Optional: handle unknown type
                    break;
            }


        }

        private void InitBrainTable(object sender, PaintEventArgs e)
        {
            int[,] data = gridLayoutFromUserControl.CurrentState();

            Graphics g = e.Graphics;
            int rows = data.GetLength(0);
            int cols = data.GetLength(1);

            int cellWidth = panelSimulationGrid.Width / cols;
            int cellHeight = panelSimulationGrid.Height / rows;

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    Rectangle rect = new Rectangle(y * cellWidth, x * cellHeight, cellWidth, cellHeight);
                    Color color;

                    switch ((BrainsStatus)data[x, y])
                    {
                        case BrainsStatus.On:
                            color = Color.CadetBlue;
                            break;
                        case BrainsStatus.Dying:
                            color = Color.LightBlue;
                            break;
                        default:
                            color = Color.Gray;
                            break;
                    }

                    using (Brush brush = new SolidBrush(color))
                    {
                        g.FillRectangle(brush, rect);
                    }
                }
            }
        }

        private void InitLangtonsAnt(object sender, PaintEventArgs e)
        {
            currentStep = 0;
            int[,] data = gridLayoutFromUserControl.CurrentState();

            Graphics g = e.Graphics;
            int rows = data.GetLength(0);
            int cols = data.GetLength(1);

            int cellWidth = panelSimulationGrid.Width / cols;
            int cellHeight = panelSimulationGrid.Height / rows;

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    Rectangle rect = new Rectangle(y * cellWidth, x * cellHeight, cellWidth, cellHeight);
                    Color color;

                    if (data[x, y] == -1)
                    {
                        // Ant position
                        color = Color.Red;
                    }
                    else if (data[x, y] == 0)
                    {
                        // White cell
                        color = Color.White;
                    }
                    else
                    {
                        // Black cell
                        color = Color.Black;
                    }

                    using (Brush brush = new SolidBrush(color))
                    {
                        g.FillRectangle(brush, rect);
                    }

                    g.DrawRectangle(Pens.Gray, rect); // Optional grid lines
                }
            }
        }

        private void InitForestFire(object sender, PaintEventArgs e)
        {
            currentStep = 0;
            int[,] data = gridLayoutFromUserControl.CurrentState();

            Graphics g = e.Graphics;
            int rows = data.GetLength(0);
            int cols = data.GetLength(1);

            int cellWidth = panelSimulationGrid.Width / cols;
            int cellHeight = panelSimulationGrid.Height / rows;

            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    Rectangle rect = new Rectangle(x * cellWidth, y * cellHeight, cellWidth, cellHeight);
                    Color color;

                    switch (data[x, y])
                    {
                        case 0: color = Color.Silver; break;
                        case 1: color = Color.Green; break;
                        case 2: color = Color.Maroon; break;
                        default: color = Color.White; break;
                    }
                    using (Brush brush = new SolidBrush(color))
                    {
                        g.FillRectangle(brush, rect);
                    }

                    g.DrawRectangle(Pens.Black, rect); // Optional grid lines
                }
            }
        }
        private void InitGameOfLifeGrid(object sender, PaintEventArgs e)
        {
            currentStep = 0;
            int[,] data = gridLayoutFromUserControl.CurrentState();

            Graphics g = e.Graphics;
            int rows = data.GetLength(0);
            int cols = data.GetLength(1);

            int cellWidth = panelSimulationGrid.Width / cols;
            int cellHeight = panelSimulationGrid.Height / rows;

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    Rectangle rect = new Rectangle(y * cellWidth, x * cellHeight, cellWidth, cellHeight);
                    Color color = data[x, y] == 1 ? Color.LimeGreen : Color.LightCoral;

                    using (Brush brush = new SolidBrush(color))
                    {
                        g.FillRectangle(brush, rect);
                    }

                    g.DrawRectangle(Pens.Black, rect);
                }
            }
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            // 1. Capture the entire Form as Bitmap
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

            // 2. Prepare PrintDocument
            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.Landscape = true; // Optional: landscape orientation
            pd.PrintPage += (s, ev) =>
            {
                // 2a. Draw step number
                Font font = new Font("Arial", 16);
                string stepText = $"Simulation Step: {currentStep}";
                ev.Graphics.DrawString(stepText, font, Brushes.Black, new PointF(50, 30));

                // 2b. Calculate scale to fit the form image to the printable area
                RectangleF printableArea = ev.MarginBounds;

                float scaleX = printableArea.Width / bmp.Width;
                float scaleY = printableArea.Height / bmp.Height;
                float scale = Math.Min(scaleX, scaleY); // Preserve aspect ratio

                int newWidth = (int)(bmp.Width * scale);
                int newHeight = (int)(bmp.Height * scale);

                // 2c. Center the image
                float x = printableArea.X + (printableArea.Width - newWidth) / 2;
                float y = printableArea.Y + 50; // Leave space for step text

                ev.Graphics.DrawImage(bmp, x, y, newWidth, newHeight);
            };

            // 3. Save as PDF
            pd.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            pd.PrinterSettings.PrintToFile = true;

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                sfd.FileName = $"Simulation_Export_Step{currentStep}.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    pd.PrinterSettings.PrintFileName = sfd.FileName;

                    try
                    {
                        pd.Print();
                        MessageBox.Show("PDF export successful!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Export failed: {ex.Message}");
                    }
                }
            }

        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            // Create and show the HomeForms form
            HomeForms homeForm = new HomeForms(true);
            homeForm.Show();

            // Close the current form (the form that contains this button)
            this.Hide();
        }

        private void chbEnableAutoNumber_CheckedChanged(object sender, EventArgs e)
        {
            changedEnablilityAutoStartControls();
        }


        /*
         * ============================================
         * Will disable/enable Auto start controls ❌✔️
         * ============================================
         */
        private void changedEnablilityAutoStartControls()
        {
            if (chbEnableAutoNumber.Checked == true)
            {
                foreach (Control control in autoStartControls)
                {
                    if (control == chbEnableAutoNumber) continue;

                    control.Enabled = true;
                }
            }
            if (chbEnableAutoNumber.Checked == false)
            {
                foreach (Control control in autoStartControls)
                {
                    if (control == chbEnableAutoNumber) continue;

                    control.Enabled = false;
                }
            }
        }

        private bool isAutoStartingCounting = false;
        private int stepsTakenAutoStart = 0;
        private void btnAutoStepsStartPause_Click(object sender, EventArgs e)
        {
            if (!isAutoStartingCounting)
            {
                StartAutoStepping();
            }
            else
            {
                StopAutoStepping();
            }
        }

        private void StartAutoStepping()
        {
            isAutoStartingCounting = true;
            btnAutoStepsStartPause.Text = "Stop";
            timerAutoSteps.Start();
        }

        private void StopAutoStepping()
        {
            isAutoStartingCounting = false;
            btnAutoStepsStartPause.Text = "Start";
            timerAutoSteps.Stop();
        }

        /*
         * --------------------------------------------------------------
         * Auto steps for simulations that happen every 1 second 
         * --------------------------------------------------------------
         */

        private void timerAutoSteps_Tick(object sender, EventArgs e)
        {
            if (!(stepsTakenAutoStart == (int)nudAutoNumberOfSteps.Value))
            {
                gridLayoutFromUserControl.NextStep();
                panelSimulationGrid.Invalidate();
                stepsTakenAutoStart++;
            }
            else
            {
                StopAutoStepping();
            }
        }
    }
}