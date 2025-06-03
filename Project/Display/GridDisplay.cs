using Models;
namespace Display
{
    public partial class GridDisplay : Form
    {
        public GridDisplay()
        {
            InitializeComponent();
        }
        int selectedAutomata;
        Grid automata;
        int[,] cells;

        private void btnInitGrid_Click(object sender, EventArgs e)
        {
            switch (selectedAutomata)
            {
                case 0: 
                    //intialisation for game of life grid
                    return;
                case 1:
                    //initalisation for brian's brain grid
                    return; 
                case 2:
                    automata = new Forest((int)nudColumns.Value, (int)nudRows.Value, (int)nudTree.Value, (int)nudFire.Value);
                    return;
                case 3:
                    //intialisation for langton's ant grid
                    return;
                default:
                    return;
            }

            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            rtxtDisplay.Text = "";
            cells = automata.BackStep();
            for (int x = 0; x < (int)nudColumns.Value; x++)
            {
                for (int y = 0; y < (int)nudRows.Value; y++)
                {
                    rtxtDisplay.AppendText(cells[x, y] + "  ");
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
                    rtxtDisplay.AppendText(cells[x, y] + "  ");
                }
                rtxtDisplay.AppendText(Environment.NewLine);
            }
        }

        private void cbAutomataSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectedAutomata = cbAutomataSelect.SelectedIndex;
            if (selectedAutomata == 2)
            {
                lblTreeProb.Show();
                nudTree.Show();
                lblTreePercent.Show();
                lblFireProb.Show();
                nudFire.Show();
                lblFirePercent.Show();
            }
            else
            {
                lblTreeProb.Hide();
                nudTree.Hide();
                lblTreePercent.Hide();
                lblFireProb.Hide();
                nudFire.Hide();
                lblFirePercent.Hide();
            }
        }
    }
}
