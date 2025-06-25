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

        GridDisplay gd;

        private void Init()
        {
            //if (User logdIN){
            //    btnLogin.Visible= false;
            //    btnLogOut.Visible = true;
            //} 
            //if (!user in logdIN){
            //    btnLogin.Visible = true;
            //    btnLogOut.Visible = false;
            //}
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Login login = new Login();
            //login.Show();

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
    }
}
