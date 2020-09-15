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
            table.Columns.Add("ID", typeof(int)); 
            table.Columns.Add("Furnizor", typeof(string)); 
            table.Columns.Add("Nr/serie", typeof(string)); 
            table.Columns.Add("Explicatii", typeof(string)); 
            table.Columns.Add("Data_emitere", typeof(string)); 
            table.Columns.Add("Suma", typeof(double));

            dataGridView1.DataSource = table;


        }
    }
}
