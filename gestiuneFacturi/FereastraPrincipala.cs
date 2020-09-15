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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = initializareTabelDate(initializareFacturi());
        }

        private Hashtable initializareFacturi()
        {

            Hashtable facturi = new Hashtable();
            facturi.Add("1", new Facturi("TM / 1234", "apa rece", "25-08-2020", 895.35));

            return facturi;
        }

        private DataTable initializareTabelDate( Hashtable ht)
        {

            DataTable table = new DataTable();
            
            table.Columns.Add("Nr/serie");
            table.Columns.Add("Explicatii");
            table.Columns.Add("Data_emitere");
            table.Columns.Add("Suma");

            Facturi fact;

            foreach (var facturi in ht.Values)
            {
                fact = (Facturi)facturi;
                table.Rows.Add(fact.Nr_serie, fact.Explicatii, fact.Data_emitere, fact.Suma);
            }

            return table;
        }
    }
}

