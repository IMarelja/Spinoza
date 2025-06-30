using Display.Utilities;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;

namespace Display.SimulationControls
{
    public partial class ForestFireController : UserControl, INotifyPropertyChanged
    {

        private Forest _grid;

        public Forest Grid
        {
            get => _grid;
            set
            {
                _grid = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Grid)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public ForestFireController()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            Utility.SetInfoBalloonTooltipForControl(ttGrid, pbGrid, "Grid Configuration",
            "Defines the size of the simulation grid.\n\n" +
            " - Rows: number of vertical cells\n" +
            " - Columns: number of horizontal cells");


            Utility.SetInfoBalloonTooltipForControl(ttSettings, pbSettings, "Random Grid",
                "Generate a randomized grid layout.\n\n" +
                " - Chance of Tree: the chance a tree will grow in a empty cell\n" +
                " - Chance of Fire: the chance a fire will start in a tree cell"); 

            Utility.SetInfoBalloonTooltipForControl(ttRandom, pbRandom, "Randomise Cells",
                "Randomise the starting cells of the grid.");

            btnRandomGrid.Visible = false;
            pbRandom.Visible = false;
        }

        private void btnInitGrid_Click(object sender, EventArgs e)
        {
            if (FormValid())
            {
                int rows = (int)nudRows.Value;
                int cols = (int)nudColumns.Value;

                int tree = (int)nudTreeChance.Value;
                int fire = (int)nudFireChance.Value;

                Grid = new Forest(cols, rows, tree, fire);

                btnRandomGrid.Visible = true;
                pbRandom.Visible=true;
            }

        }

        private bool FormValid()
        {
            bool valid = true;
            if (nudColumns.Value == 0 || nudRows.Value == 0) 
                valid = false;

            return valid;
        }

        private void btnRandomGrid_Click(object sender, EventArgs e)
        {
            Grid.SetRandomCells();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Grid)));
        }

        private void btnImportGrid_Click(object sender, EventArgs e)
        {
            try
            {
                Grid loadedGrid = Utility.ImportGridFromAFile<Forest>();
                Grid = (Forest)loadedGrid;
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
