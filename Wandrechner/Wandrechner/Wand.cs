using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wandrechner
{
    internal class Wand
    {
        public double laenge, breite, hoehe;
        public string material;
        public bool istTragend;
        public double bewehrungsFlaeche, schalungsFlaeche;

        public Wand()
        {
            this.laenge = 0.0;
            this.breite = 0.0;
            this.hoehe = 0.0;
            this.material = "";
            this.istTragend = false;
            this.bewehrungsFlaeche = 0.0;
            this.schalungsFlaeche = 0.0;
        }

        public void BerechneSchalungsflaeche()
        {
            if (this.material.Equals("Mauerwerk"))
            {
                this.schalungsFlaeche = laenge * hoehe * 2;
            }
            else
            {
                this.schalungsFlaeche = 0.0;
            }
        }
    }
}
