using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace Display
{
    public partial class HomeForms : Form
    {
        public HomeForms()
        {
            Init();
            InitializeComponent();
        }

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
            Login login = new Login();
            login.Show();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }

        private void btnLangtonsAnt_Click(object sender, EventArgs e)
        {
            GridDisplay gd = new GridDisplay();
            gd.ShowDialog();
            this.Close();
        }

        private void btnForestFire_Click(object sender, EventArgs e)
        {
            GridDisplay gd = new GridDisplay();
            gd.ShowDialog();
            this.Close();
        }

        private void btnBriansBrain_Click(object sender, EventArgs e)
        {
            GridDisplay gd = new GridDisplay();
            gd.ShowDialog();
            this.Close();
        }

        private void btnGameOfLife_Click(object sender, EventArgs e)
        {
            GridDisplay gd = new GridDisplay();
            gd.ShowDialog();
            this.Close();
        }
    }
}
