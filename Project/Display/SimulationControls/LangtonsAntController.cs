using Display.Utilities;
using Models;  // Your simulation logic namespace
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Display.SimulationControls
{
    public partial class LangtonsAntController : UserControl, INotifyPropertyChanged
    {
        private LangtonsGrid _grid;

        public LangtonsGrid Grid
        {
            get => _grid;
            private set
            {
                _grid = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Grid)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public LangtonsAntController()
        {
            InitializeComponent();
            Init();
            HookEvents();
        }

        private void Init()
        {
            // Set default values if needed
            nudRowsTable.Value = 10;
            nudColumnsTable.Value = 10;
            cbIsDefault.Checked = true;
            cbDirection.Items.Clear();
            cbDirection.Items.AddRange(Enum.GetNames(typeof(Direction)));
            cbDirection.SelectedItem = Direction.Up.ToString();
            cbDirection.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void HookEvents()
        {
            btnInitGrid.Click += BtnInitGrid_Click;
            // Additional buttons (RandomGrid, ImportGrid) can be wired similarly if implemented
        }


        private void BtnInitGrid_Click(object? sender, EventArgs e)
        {
            // Validate inputs
            if (!ValidateInput()) return;

            int rows = (int)nudRowsTable.Value;
            int cols = (int)nudColumnsTable.Value;

            int antX, antY;

            if (cbIsDefault.Checked)
            {
                // Use center by default
                antX = cols / 2;
                antY = rows / 2;
            }
            else
            {
                antX = (int)nudNumberOfCellsStartingSquare.Value;
                antY = (int)nudAreaStartingSquare.Value;

                // Clamp ant position inside grid
                antX = Math.Max(0, Math.Min(antX, cols - 1));
                antY = Math.Max(0, Math.Min(antY, rows - 1));
            }
            Direction direction;

            if (cbDirection.SelectedItem != null &&
                Enum.TryParse(cbDirection.SelectedItem.ToString(), out Direction parsedDirection))
            {
                direction = parsedDirection;
            }
            else
            {
                direction = Direction.Up;
            }

            Grid = new LangtonsGrid(cols, rows, antX, antY, direction);

        }

        private bool ValidateInput()
        {
            if (nudRowsTable.Value <= 0 || nudColumnsTable.Value <= 0)
            {
                MessageBox.Show("Rows and Columns must be positive numbers.");
                return false;
            }

            if (!cbIsDefault.Checked)
            {
                if (nudNumberOfCellsStartingSquare.Value < 0 || nudNumberOfCellsStartingSquare.Value >= nudColumnsTable.Value
                    || nudAreaStartingSquare.Value < 0 || nudAreaStartingSquare.Value >= nudRowsTable.Value)
                {
                    MessageBox.Show("Ant position must be within the grid bounds.");
                    return false;
                }
            }

            return true;
        }


        private Color GetColorForValue(int value)
        {
            return value switch
            {
                0 => Color.White,
                1 => Color.Black,
                2 => Color.Red
            };
        }

        private void btnRandomGrid_Click(object sender, EventArgs e)
        {

            Random rand = new Random();

            // Randomize grid size (square grid, 5–50 range as example)
            int size = rand.Next(10, 101); // Change range as needed

            int rows = size;
            int cols = size;

            // Set randomized size to UI
            nudRowsTable.Value = rows;
            nudColumnsTable.Value = cols;

            // Random ant position within bounds
            int antX = rand.Next(cols); // 0 to cols - 1
            int antY = rand.Next(rows); // 0 to rows - 1

            // Set ant position to UI fields (optional)
            nudNumberOfCellsStartingSquare.Value = antX;
            nudAreaStartingSquare.Value = antY;

            // Disable default checkbox to use manual position
            cbIsDefault.Checked = false;

            // Optionally: random direction
            Direction randomDirection = (Direction)rand.Next(4);
            cbDirection.SelectedItem = randomDirection.ToString();

            // Create grid with randomized parameters
            LangtonsGrid grid = new LangtonsGrid(cols, rows, antX, antY, randomDirection);

        }

        private void btnImportGrid_Click(object sender, EventArgs e)
        {
            try
            {
                Grid loadedGrid = Utility.ImportGridFromAFile<LangtonsGrid>();
                Grid = (LangtonsGrid)loadedGrid;
            }
            catch (OperationCanceledException ex)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                "Warning",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }
    }
}
