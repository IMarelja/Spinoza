using Display.SimulationControls;
using Models;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
namespace Display
{
    public partial class GridSimulationForm : Form
    {

        private Grid gridLayoutFromUserControl;
        private UserControl simulationController;

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

        }



        private void btnNext_Click(object sender, EventArgs e)
        {

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
                // Add your own
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

        }
    }
}
