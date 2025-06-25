using System;
using System.ComponentModel;
using System.Windows.Forms;
using Models;  // Your simulation logic namespace

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

            Grid = new LangtonsGrid(cols, rows, antX, antY);

            // You can raise a notification or trigger a redraw here
            // For example: OnGridUpdated(Grid.CurrentState());
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


    }
}
