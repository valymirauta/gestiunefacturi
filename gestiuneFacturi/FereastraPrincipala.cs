using System;
using System.Collections;
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
    public partial class FereastraPrincipala : Form
    {
        public FereastraPrincipala()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();


        private void FereastraPrincipala_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FereastraFacturi ferFact = new FereastraFacturi();
            ferFact.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Aplicatia se va inchide. Sunteti sigur?", "Exit",MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            } else if(dialog == DialogResult.No)
            {
                ((FormClosingEventArgs)e).Cancel = true;
            }
        }
    }
}

