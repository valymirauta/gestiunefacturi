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
    public partial class FereastraFacturi : Form
    {
        public FereastraFacturi()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        

        private void FereastraFacturi_Load(object sender, EventArgs e)
        {
            listaFacturi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listaFacturi.DataSource = initializareTabelDate(initializareFacturi());
        }

        private Hashtable initializareFacturi()
        {

            Hashtable facturi = new Hashtable();
            facturi.Add("1", new Facturi("TM / 1234", "apa rece", "25-08-2020", 895.35));
            facturi.Add("2", new Facturi("COL / 2222", "apa calda", "20-09-2020", 1000.00));
            facturi.Add("3", new Facturi("RE / 6254365", "salubritate", "31-07-2020", 264.12));

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

        private void btnInchidere_Click(object sender, EventArgs e)
        {
            FereastraPrincipala ferPrin = new FereastraPrincipala();
            ferPrin.Show();
            Visible = false;
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdaugareFacturi adFac = new AdaugareFacturi(this);
            adFac.Show();
        }
    }
}

