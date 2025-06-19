using Models;
using System.Drawing.Printing;
namespace Display
{
    public partial class GridDisplay : Form
    {
        public GridDisplay(HomeForms hf)
        {
            InitializeComponent();
            this.hf = hf;
            btnBack.Hide();
            btnNext.Hide();
        }
        int selectedAutomata;
        Grid automata;
        int[,] cells;
        HomeForms hf;
        Panel[,] panels;
        private int currentStep = 0;
        public void setSelectAutomata(int i)
        {
            selectedAutomata = i;
            cbAutomataSelect.SelectedIndex = i;
        }
        private void btnInitGrid_Click(object sender, EventArgs e)
        {
            flpGrid.Controls.Clear();
            panels = new Panel[(int)nudColumns.Value, (int)nudRows.Value];
            switch (selectedAutomata)
            {
                case 0:
                    //intialisation for game of life grid
                    break;
                case 1:
                    //initalisation for brian's brain grid
                    break;
                case 2:
                    automata = new Forest((int)nudColumns.Value, (int)nudRows.Value, (int)nudTree.Value, (int)nudFire.Value);
                    break;
                case 3:
                    // do if default and then if not default
                    automata = new LangtonsGrid((int)nudColumns.Value, (int)nudRows.Value);
                    break;
                default:
                    return;
            }
            btnBack.Show();
            btnNext.Show();
            double sizeWidth = flpGrid.Size.Width / ((int)nudColumns.Value);
            double sizeHeight = flpGrid.Size.Height / ((int)nudRows.Value);
            if (sizeWidth == 0) sizeWidth = 1;
            if (sizeHeight == 0) sizeHeight = 1;
            for (int i = 0; i < nudRows.Value; i++)
            {
                for (int j = 0; j < nudColumns.Value; j++)
                {
                    panels[j, i] = new Panel()
                    {
                        Size = new Size((int)sizeWidth, (int)sizeHeight),
                        BorderStyle = BorderStyle.FixedSingle,
                        Padding = new Padding(0),
                        Margin = new Padding(0)
                    };
                    flpGrid.Controls.Add(panels[j, i]);
                    panels[j, i].Show();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            cells = automata.BackStep();
            for (int x = 0; x < nudColumns.Value; x++)
            {
                for (int y = 0; y < nudRows.Value; y++)
                {
                    UpdateBackColor(cells[x, y], panels[x, y]);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentStep++;
            cells = automata.NextStep();
            for (int y = 0; y < nudRows.Value; y++)
            {
                for (int x = 0; x < nudColumns.Value; x++)
                {
                    UpdateBackColor(cells[x, y], panels[x, y]);
                }
            }

        }

        private void cbAutomataSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAutomata = cbAutomataSelect.SelectedIndex;
            lblTreeProb.Hide();
            nudTree.Hide();
            lblTreePercent.Hide();
            lblFireProb.Hide();
            nudFire.Hide();
            lblFirePercent.Hide();


            switch (selectedAutomata)
            {
                case 0:
                    return;
                case 1:
                    return;
                case 2:
                    ForestFireForm();
                    return;
                case 3:
                    return;
                default:
                    return;
            }
        }

        private void ForestFireForm()
        {
            lblTreeProb.Show();
            nudTree.Show();
            lblTreePercent.Show();
            lblFireProb.Show();
            nudFire.Show();
            lblFirePercent.Show();
            lblCell1.Text = "Empty";
            lblCell2.Text = "Tree";
            lblCell3.Text = "Fire";
            pnlCell1.BackColor = Color.White;
            pnlCell2.BackColor = Color.Green;
            pnlCell3.BackColor = Color.Red;
        }

        private void btnGoBackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            hf.Show();
        }

        private void UpdateBackColor(int num, Panel pnl)
        {
            switch (num)
            {
                case 0: pnl.BackColor = pnlCell1.BackColor; break;
                case 1: pnl.BackColor = pnlCell2.BackColor; break;
                case 2: pnl.BackColor = pnlCell3.BackColor; break;
            }
        }

        private void btnSelectColour1_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            pnlCell1.BackColor = colorDialog.Color;
        }

        private void btnSelectColour2_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            pnlCell2.BackColor = colorDialog.Color;
        }

        private void btnSelectColour3_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            pnlCell3.BackColor = colorDialog.Color;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // 1. Capture the screen image of the form (visible part only)
            Bitmap bmp = new Bitmap(this.Bounds.Width, this.Bounds.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(this.Location, Point.Empty, this.Size);
            }

            // 2. Prepare PrintDocument
            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.Landscape = true;
            pd.PrintPage += (s, ev) =>
            {
                Font font = new Font("Arial", 16);
                string stepText = $"Simulation Step: {currentStep}";
                ev.Graphics.DrawString(stepText, font, Brushes.Black, new PointF(50, 30));

                RectangleF printableArea = ev.MarginBounds;

                float scaleX = printableArea.Width / bmp.Width;
                float scaleY = printableArea.Height / bmp.Height;
                float scale = Math.Min(scaleX, scaleY);

                int newWidth = (int)(bmp.Width * scale);
                int newHeight = (int)(bmp.Height * scale);

                float x = printableArea.X + (printableArea.Width - newWidth) / 2;
                float y = printableArea.Y + 50;

                ev.Graphics.DrawImage(bmp, x, y, newWidth, newHeight);
            };

            // 3. Save as PDF
            pd.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            pd.PrinterSettings.PrintToFile = true;

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                sfd.FileName = $"Simulation_Export_Step{currentStep}.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    pd.PrinterSettings.PrintFileName = sfd.FileName;

                    try
                    {
                        pd.Print();
                        MessageBox.Show("PDF export successful!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Export failed: {ex.Message}");
                    }
                }
            }
        }
    }
}
