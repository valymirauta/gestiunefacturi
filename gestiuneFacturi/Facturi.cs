using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestiuneFacturi
{
    class Facturi
    {
        
        private string nr_serie;
        private string explicatii;
        private string data_emitere;
        private double suma;

        public Facturi( string nr_serie, string explicatii, string data_emitere, double suma)
        {
            
            this.nr_serie = nr_serie;
            this.explicatii = explicatii;
            this.data_emitere = data_emitere;
            this.suma = suma;
        }

        public string Nr_serie {
            get { return nr_serie; }
        }
        public string Explicatii  {
            get => explicatii;
        }
        public string Data_emitere {
            get => data_emitere;
        }
        public double Suma {
            get => suma;  }
    }
}
