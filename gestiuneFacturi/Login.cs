using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestiuneFacturi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text=="ADMIN" && txtPass.Text == "admin")
            {
                
                this.Hide();
                FereastraPrincipala ferPrin = new FereastraPrincipala();
                ferPrin.Show();
            }
            else if (txtUser.Text != "ADMIN" || txtPass.Text != "admin")
            {
                MessageBox.Show("Username or password is incorrect");
            }
        }
    }
}
