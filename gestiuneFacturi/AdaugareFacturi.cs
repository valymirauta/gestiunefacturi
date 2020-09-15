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
            
            DataTable dt=ferFact.listaFacturi.DataSource as DataTable;

            dt.Rows.Add(txtSerieNr.Text, txtExplicatii.Text,
                txtDataEmitere.Text, txtSuma.Text);

           
            /*
            dt = ferFact.listaFacturi.DataSource as DataTable;

            DataRow row = dt.NewRow();
            row[0] = txtSerieNr.Text;
            row[1] = txtExplicatii.Text;
            row[2] = txtDataEmitere.Text;
            row[3] = txtSuma.Text;

            dt.Rows.Add(row);
            
            
            ferFact.listaFacturi.Rows.Add(txtSerieNr.Text, txtExplicatii.Text,
                txtDataEmitere.Text, txtSuma.Text);*/
            
    
            

        }
    }
}
