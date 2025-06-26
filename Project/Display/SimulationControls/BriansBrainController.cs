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
            Utility.SetInfoBalloonTooltipForControl(ttTable, pbTableInfo, "Table Configuration",
            "Defines the size of the simulation grid.\n\n" +
            "• Rows: vertical cells\n" +
            "• Columns: horizontal cells\n" +
            "Total squares = Rows × Columns.");

            Utility.SetInfoBalloonTooltipForControl(ttStartingSquare, pbStartingSquareInfo, "Starting Square",
                "Select the square from which the simulation will begin execution.\n\n" +
                "It defines the origin point of state changes or propagation logic.");

            Utility.SetInfoBalloonTooltipForControl(ttInitGrid, pbInitializeGrid, "Initialize Grid",
                "Click to create an empty grid based on defined dimensions.\n\n" +
                "All cells will be set to their initial default state.");

            Utility.SetInfoBalloonTooltipForControl(ttImportGrid, pbImportGridInfo, "Import Grid",
                "Import a previously saved grid layout.\n\n" +
                "Useful for continuing simulations or loading predefined patterns.");

            Utility.SetInfoBalloonTooltipForControl(ttRandomGrid, pbRandomGridInfo, "Random Grid",
                "Generate a randomized grid layout.\n\n" +
                "Cells will be randomly activated to create diverse simulation states.");


            Utility.CreateCellStateTooltip(ttOnInfo, gbOnInfo, panelOnColor, "Cells currently alive.");
            Utility.CreateCellStateTooltip(ttOffInfo, gbOffInfo, panelOffColor, "Cells not active.");
            Utility.CreateCellStateTooltip(ttDyingInfo, gbDyingInfo, panelDyingColor , "Cell is transitioning to dying");
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
            if ((int)nudRowsTable.Value >= (int)nudAreaStartingSquare.Value && (int)nudColumnsTable.Value >= (int)nudAreaStartingSquare.Value)
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
    }
}
