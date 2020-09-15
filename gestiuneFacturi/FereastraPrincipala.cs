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

    }
}

