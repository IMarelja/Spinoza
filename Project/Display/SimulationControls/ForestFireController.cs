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

        }

        private void btnImportGrid_Click(object sender, EventArgs e)
        {

        }
    }
}
