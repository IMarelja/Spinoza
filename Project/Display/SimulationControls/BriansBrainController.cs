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
            SetInfoBalloonTooltipForControl(ttTable, pbTableInfo, "Table Configuration",
            "Defines the size of the simulation grid.\n\n" +
            "• Rows: vertical cells\n" +
            "• Columns: horizontal cells\n" +
            "Total squares = Rows × Columns.");

            SetInfoBalloonTooltipForControl(ttStartingSquare, pbStartingSquareInfo, "Starting Square",
                "Select the square from which the simulation will begin execution.\n\n" +
                "It defines the origin point of state changes or propagation logic.");

            SetInfoBalloonTooltipForControl(ttInitGrid, pbInitializeGrid, "Initialize Grid",
                "Click to create an empty grid based on defined dimensions.\n\n" +
                "All cells will be set to their initial default state.");

            SetInfoBalloonTooltipForControl(ttImportGrid, pbImportGridInfo, "Import Grid",
                "Import a previously saved grid layout.\n\n" +
                "Useful for continuing simulations or loading predefined patterns.");

            SetInfoBalloonTooltipForControl(ttRandomGrid, pbRandomGridInfo, "Random Grid",
                "Generate a randomized grid layout.\n\n" +
                "Cells will be randomly activated to create diverse simulation states.");


            CreateCellStateTooltip(ttOnInfo, gbOnInfo, panelOnColor, "Cells currently alive.");
            CreateCellStateTooltip(ttOffInfo, gbOffInfo, panelOffColor, "Cells not active.");
            CreateCellStateTooltip(ttDyingInfo, gbDyingInfo, panelDyingColor , "Cell is transitioning to dying");
        }


        /*
         * ================================================================
         * 🎛️ℹ️ Creates Informational Tool tips balloon for a Control ℹ️🎛️
         * ================================================================
         */
        private void SetInfoBalloonTooltipForControl(System.Windows.Forms.ToolTip tooltip, Control control, string title, string description)
        {
            tooltip.IsBalloon = true;
            tooltip.ToolTipIcon = ToolTipIcon.Info;
            tooltip.ToolTipTitle = title;
            tooltip.SetToolTip(control, description);
        }


        /*
         * ===============================================================================
         * 🦠ℹ️ Creates Informational Tool tips balloon only for CELL state Controls 🦠ℹ️
         * ===============================================================================
         */
        private void CreateCellStateTooltip(System.Windows.Forms.ToolTip tt, Control target, Panel panelColor, string message)
        {
            tt.IsBalloon = true;
            tt.ToolTipIcon = ToolTipIcon.None; // No default icon
            tt.ToolTipTitle = target.Text; // Optional, leave empty or add something like "Status: Alive"

            // Use owner draw for custom image/icon
            tt.OwnerDraw = true;
            tt.Popup += (s, e) => { e.ToolTipSize = new Size(200, 80); };

            tt.Draw += (s, e) =>
            {
                // Draw background
                e.DrawBackground();
                // Draw color icon
                using (SolidBrush brush = new SolidBrush(panelColor.BackColor))
                {
                    e.Graphics.FillRectangle(brush, new Rectangle(10, 10, 20, 20));
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(10, 10, 20, 20));
                }

                // Draw message
                using (Font font = new Font("Segoe UI", 9))
                {
                    e.Graphics.DrawString(message, font, Brushes.Black, new RectangleF(40, 10, 150, 60));
                }
            };

            tt.SetToolTip(target, message); // Needed to trigger the draw event
            tt.SetToolTip(panelColor, message);
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
