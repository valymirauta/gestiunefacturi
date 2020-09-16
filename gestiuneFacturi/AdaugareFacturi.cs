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
    public partial class AdaugareFacturi : Form
    {
        FereastraFacturi ferFact;
        private DataTable dt;

        public AdaugareFacturi(FereastraFacturi ff)
        {
            InitializeComponent();
            this.ferFact = ff;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            dt = ferFact.listaFacturi.DataSource as DataTable;

            DataRow row = dt.NewRow();

            row[0] = txtSerieNr.Text;
            row[1] = txtExplicatii.Text;
            row[2] = txtDataEmitere.Text;
            row[3] = txtSuma.Text;

            Console.WriteLine(txtSerieNr.Text);
            Console.WriteLine(row[3]);
            dt.Rows.Add(row);

        }

        private void button2_Click(object sender, EventArgs e)
        {
                 Visible = false;
        }
    }
}
