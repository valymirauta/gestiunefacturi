﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text=="ADMIN" && txtPass.Text == "admin")
            {
                Form1 frm1 = new Form1();
                this.Hide();
                frm1.Show();
            }
            else if (txtUser.Text != "ADMIN" || txtPass.Text != "admin")
            {
                MessageBox.Show("Username or password is incorrect");
            }
        }
    }
}
