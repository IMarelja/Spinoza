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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Display.SimulationControls
{
    public partial class BriansBrainController : UserControl, INotifyPropertyChanged
    {
        private Grid _brain;
        public Grid brian {

            get => _brain;
            set
            {
                _brain = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(brian)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public BriansBrainController()
        {
            
            InitializeComponent();
            Init();
            
        }

        private void Init()
        {
            if (chbAutoNumberOfSteps.Checked == false)
            {
                nudAutoNumberOfSteps.Enabled = false;
            }
            if (chbAutoNumberOfSteps.Checked == true)
            {
                nudAutoNumberOfSteps.Enabled = true;
            }
        }

        private void btnInitGrid_Click(object sender, EventArgs e)
        {
            if (formValidation())
            {
                brian = new Brain((int)nudRowsTable.Value, (int)nudColumnsTable.Value, (int)nudAreaStartingSquare.Value, (int)nudNumberOfCellsStartingSquare.Value);
            }
            
        }

        private bool formValidation()
        {
            if ((int)nudRowsTable.Value > (int)nudAreaStartingSquare.Value && (int)nudColumnsTable.Value > (int)nudAreaStartingSquare.Value)
            {
                if (((int)nudAreaStartingSquare.Value * (int)nudAreaStartingSquare.Value) > (int)nudNumberOfCellsStartingSquare.Value)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Number of cells in starting area is larger then area can contain");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Starting square area is larger then the Table");
                return false;
            }
                
        }

        private void btnImportGrid_Click(object sender, EventArgs e)
        {

        }

        private void btnRandomGrid_Click(object sender, EventArgs e)
        {

        }

        private void chbAutoNumberOfSteps_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAutoNumberOfSteps.Checked == false)
            {
                nudAutoNumberOfSteps.Enabled = false;
            }
            if (chbAutoNumberOfSteps.Checked == true)
            {
                nudAutoNumberOfSteps.Enabled = true;
            }
        }


    }
}
