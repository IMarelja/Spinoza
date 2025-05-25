using Models;
namespace Display
{
    public partial class GridDisplay : Form
    {
        public GridDisplay()
        {
            InitializeComponent();
        }
        Grid automata;
        Cell[,] cells;

        private void btnInitGrid_Click(object sender, EventArgs e)
        {
            automata = new Forest((int)nudColumns.Value, (int)nudRows.Value, (int)nudTree.Value, (int)nudFire.Value);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            rtxtDisplay.Text = "";
            cells = automata.BackStep();
            for (int x = 0; x < (int)nudColumns.Value; x++)
            {
                for (int y = 0; y < (int)nudRows.Value; y++)
                {
                    rtxtDisplay.AppendText(cells[x, y].Print() + "  ");
                }
                rtxtDisplay.AppendText(Environment.NewLine);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            rtxtDisplay.Text = "";
            cells = automata.NextStep();
            for (int x = 0; x < (int)nudColumns.Value; x++)
            {
                for (int y = 0; y < (int)nudRows.Value; y++)
                {
                    rtxtDisplay.AppendText(cells[x, y].Print() + "  ");
                }
                rtxtDisplay.AppendText(Environment.NewLine);
            }
        }
    }
}
