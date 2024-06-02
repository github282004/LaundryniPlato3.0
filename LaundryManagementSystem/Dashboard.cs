using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
           
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
          
            UserControl1 userControl1 = new UserControl1();
            this.Show();
            userControl1.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl1);
            userControl1.BringToFront();
        }        
        


        private void MenuButton_Click(object sender, EventArgs e)
        {

        }

        private void ButtonPayment_Click(object sender, EventArgs e)
        {
            UserControl3payment UserControl3payment = new UserControl3payment();
            this.Show();
            UserControl3payment.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(UserControl3payment);
            UserControl3payment.BringToFront();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            UClogout UClogout = new UClogout();
            this.Show();
            UClogout.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(UClogout);
            UClogout.BringToFront();
        }

        private void machineIconHome_Click(object sender, EventArgs e)
        {
            UserControl1 userControl1 = new UserControl1();
            this.Show();
            userControl1.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl1);
            userControl1.BringToFront();
;        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {

        }

        private void AdminButton_Click(object sender, EventArgs e)
        {

        }

        private void ClientButton_Click(object sender, EventArgs e)
        {

        }
    }
}
