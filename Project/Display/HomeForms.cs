using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Display.Utilities;
using Models;

namespace Display
{
    public partial class HomeForms : Form
    {
        private bool _registerOrFirstQuestion;
        public HomeForms(bool registerOrFirstQuestion)
        {
            _registerOrFirstQuestion = registerOrFirstQuestion;
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            registerInit();
            int imageHeight = 80;
            btnGameOfLife.Image = ResizeImage(Properties.Resources.GameOfLife, imageHeight);
            btnBriansBrain.Image = ResizeImage(Properties.Resources.BriansBrain, imageHeight);
            btnForestFire.Image = ResizeImage(Properties.Resources.ForestFire, imageHeight);
            btnLangtonsAnt.Image = ResizeImage(Properties.Resources.LangtonAnt, imageHeight);
        }

        private void registerInit()
        {
            if (_registerOrFirstQuestion)
            {
                lbWelcomeMessage.Visible = true;
                lbWelcomeMessage.Enabled = true;
            }
            else
            {
                lbWelcomeMessage.Visible = false;
                lbWelcomeMessage.Enabled = false;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Utility.DelteLoginOfFile();
            this.Close();
        }

        private void OpenSimulationForm(Grid selectedGrid)
        {
            this.Hide();
            GridSimulationForm gs = new GridSimulationForm(selectedGrid);
            gs.Closed += (s, args) => this.Close();
            gs.Show();
        }

        private void btnLangtonsAnt_Click(object sender, EventArgs e)
        {
            var grid = Utility.approvedSimulationsGrids.FirstOrDefault(g => g is LangtonsGrid);
            OpenSimulationForm(grid);

        }

        private void btnForestFire_Click(object sender, EventArgs e)
        {
            var grid = Utility.approvedSimulationsGrids.FirstOrDefault(g => g is Forest);
            OpenSimulationForm(grid);
        }

        private void btnBriansBrain_Click(object sender, EventArgs e)
        {
            var grid = Utility.approvedSimulationsGrids.FirstOrDefault(g => g is Brain);
            OpenSimulationForm(grid);
        }

        private void btnGameOfLife_Click(object sender, EventArgs e)
        {
            //var grid = Utility.approvedSimulationsGrids.FirstOrDefault(g => g is GameOfLife);
            //OpenSimulationForm(grid);
        }

        private Image ResizeImage(Image img, int maxHeight)
        {
            double scale = (double)maxHeight / img.Height;
            int newWidth = (int)(img.Width * scale);
            Bitmap bmp = new Bitmap(newWidth, maxHeight);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, 0, 0, newWidth, maxHeight);
            }
            return bmp;
        }
    }
}
