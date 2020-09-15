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

        public Facturi( string SerieNr, string explicatii, string data_emitere, double suma)
        {
            
            this.Nr_serie = SerieNr;
            this.Explicatii = explicatii;
            this.Data_emitere = data_emitere;
            this.Suma = suma;
        }

        public string Nr_serie { get => nr_serie; set => nr_serie = value; }
        public string Explicatii { get => explicatii; set => explicatii = value; }
        public string Data_emitere { get => data_emitere; set => data_emitere = value; }
        public double Suma { get => suma; set => suma = value; }
    }
}
