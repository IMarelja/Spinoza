using Display.Utilities;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;

namespace Display
{
    public partial class GameOfLifeController : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private Life _simulation;
        private int _cellSize = 15;

        public Life Simulation
        {
            get => _simulation;
            set
            {
                _simulation = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Simulation)));
                Invalidate();
            }
        }

        public GameOfLifeController()
        {
            InitializeComponent();
            SetupTooltips();
        }

        private void SetupTooltips()
        {
            Utility.SetInfoBalloonTooltipForControl(ttRows, pbInfoRows, "Rows", "Number of vertical cells.");
            Utility.SetInfoBalloonTooltipForControl(ttCols, pbInfoCols, "Columns", "Number of horizontal cells.");

            Utility.SetInfoBalloonTooltipForControl(ttStart, pbInfoStart, "Start", "Start simulation.");
            Utility.SetInfoBalloonTooltipForControl(ttPause, pbInfoPause, "Pause", "Pause simulation.");

            Utility.SetInfoBalloonTooltipForControl(ttInit, pbInfoInit, "Initialize", "Create a new empty grid.");
            Utility.SetInfoBalloonTooltipForControl(ttRandom, pbInfoRandom, "Randomize", "Randomly seed live cells.");
            Utility.SetInfoBalloonTooltipForControl(ttImport, pbInfoImport, "Import", "Import a saved grid.");
        }


        public void InitializeGrid(int cols, int rows, int seedCells = 100)
        {
            Simulation = new Life(cols, rows, seedCells);
            Width = cols * _cellSize + 1;
            Height = rows * _cellSize + 1;
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            int rows = (int)nudRows.Value;
            int cols = (int)nudColumns.Value;

            if (rows <= 0 || cols <= 0)
            {
                MessageBox.Show("Rows and Columns must be greater than 0.", "Error");
                return;
            }

        }

        private void btnInit_Click(object sender, EventArgs e)
        {
                int rows = (int)nudRows.Value;
                int cols = (int)nudColumns.Value;

                Simulation = new Life(cols, rows, 0);
            
        }
    }
}
