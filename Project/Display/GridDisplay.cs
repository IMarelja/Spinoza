using Models;
namespace Display
{
    public partial class GridDisplay : Form
    {
        public GridDisplay(HomeForms hf)
        {
            InitializeComponent();
            this.hf = hf;
            //btnBack.Hide();
            //btnNext.Hide();
        }
        int selectedAutomata;
        Grid automata;
        int[,] cells;
        HomeForms hf;
        public void setSelectAutomata(int i)
        {
            selectedAutomata = i;
            cbAutomataSelect.SelectedIndex = i;
        }
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
                    automata = new LangtonsGrid((int)nudColumns.Value, (int)nudRows.Value);
                    return;
                default:
                    return;
            }
            //btnBack.Visible= true;
            //btnNext.Visible = true;


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
            int sizeWidth = rtxtDisplay.Size.Width / ((int)nudColumns.Value * 2);
            if (sizeWidth == 0) sizeWidth = 1;
            else if (sizeWidth > 20) sizeWidth = 20; //we can change this latter
            rtxtDisplay.Font = new Font(rtxtDisplay.Font.FontFamily, sizeWidth);
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

        private void btnGoBackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            hf.Show();
        }
    }
}
