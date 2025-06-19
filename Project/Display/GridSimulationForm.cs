using Display.SimulationControls;
using Models;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Windows.Forms;
namespace Display
{
    public partial class GridSimulationForm : Form
    {

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
            typeof(Panel).InvokeMember("DoubleBuffered",
            System.Reflection.BindingFlags.SetProperty |
            System.Reflection.BindingFlags.Instance |
            System.Reflection.BindingFlags.NonPublic,
            null, panelSimulationGrid, new object[] { true });


        }

        private void addingSimulationSelectionToCombobox()
        {
            cbAutomataSelect.Items.Add("Brians Brain");
            cbAutomataSelect.Items.Add("Forest Fire");
            cbAutomataSelect.Items.Add("Langtons Ant");
            cbAutomataSelect.Items.Add("Game of Life");
        }

        private void clearForm()
        {
            cbAutomataSelect.Items.Clear();
            panelControls.Controls.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (gridLayoutFromUserControl is Brain)
            {

            }
            if (currentStep > 0)
                currentStep--;

        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            currentStep++;
        }

        private void cbAutomataSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

            if ((String)cbAutomataSelect.SelectedItem == "Brians Brain")
            {
                BriansBrainController brainControl = new BriansBrainController();
                brainControl.PropertyChanged += OnUserControlPropertyChanged;
                simulationController = brainControl;
            }
            else if ((String)cbAutomataSelect.SelectedItem == "Langtons Ant")
            {
                LangtonsAntController langtonAnt = new LangtonsAntController();
                langtonAnt.PropertyChanged += OnUserControlPropertyChanged;
                simulationController = langtonAnt;
            }
            else if ((String)cbAutomataSelect.SelectedItem == "Forest Fire")
            {
                // Add your own
            }
            else if ((String)cbAutomataSelect.SelectedItem == "Game of Life")
            {
                // Add your own
            }


            if (simulationController != null)
            {
                panelControls.Controls.Clear();

                simulationController.Dock = DockStyle.Fill;

                panelControls.Controls.Add(simulationController);
            }
        }

        private void OnUserControlPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(BriansBrainController.brian))
            {
                if (sender is BriansBrainController control)
                {
                    Grid receivedGrid = control.brian;
                    gridLayoutFromUserControl = receivedGrid;
                    panelSimulationGrid.Invalidate();
                    /*
                    int[,] data = gridLayoutFromUserControl.CurrentState();
                    String message = "";
                    int rows = data.GetLength(0);
                    int cols = data.GetLength(1);

                    for (int x = 0; x < rows; x++)
                    {
                        for (int y = 0; y < cols; y++)
                        {

                            message += $"{data[x, y]}";

                        }
                        message += "\n";
                    }
                    MessageBox.Show(message);
                    */
                }
            }
            else if (e.PropertyName == nameof(LangtonsAntController.Grid))
            {
                if (sender is LangtonsAntController control)
                {
                    Grid receivedGrid = control.Grid;
                    gridLayoutFromUserControl = receivedGrid;
                    panelSimulationGrid.Invalidate();
                }
            }
            // Add your own if (e.PropertyName == nameof(BriansBrainController.brian))
        }




        private void btnGoBackToMenu_Click(object sender, EventArgs e)
        {

        }

        private void panelSimulationGrid_Paint(object sender, PaintEventArgs e)
        {

            if (gridLayoutFromUserControl == null)
                return;


            //if (gridLayoutFromUserControl is Brain)
            //{
            //    InitBrainTable(sender, e);
            //}
            //else if(gridLayoutFromUserControl is Forest)
            //{

            //}
            //else if (gridLayoutFromUserControl is LangtonsGrid)
            //{

            //}

            switch (gridLayoutFromUserControl)
            {
                case Brain brain:
                    InitBrainTable(sender, e);
                    break;

                case Forest forest:
                    // TODO: Add Forest-specific logic here
                    break;

                case LangtonsGrid langtons:
                    InitLangtonsAnt(sender, e);
                    break;

                default:
                    // Optional: handle unknown type
                    break;
            }


        }

        private void InitBrainTable(object sender, PaintEventArgs e)
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

                    switch ((BrainsStatus)data[x, y])
                    {
                        case BrainsStatus.On:
                            color = Color.Cyan;
                            break;
                        case BrainsStatus.Dying:
                            color = Color.Red;
                            break;
                        default:
                            color = Color.Black;
                            break;
                    }

                    using (Brush brush = new SolidBrush(color))
                    {
                        g.FillRectangle(brush, rect);
                    }

                    g.DrawRectangle(Pens.Gray, rect); // Optional: draw grid lines
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
    }
}