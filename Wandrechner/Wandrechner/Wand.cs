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
        public double bewehrungsmenge, schalungsmenge;

        public Wand()
        {
            this.laenge = 0.0;
            this.breite = 0.0;
            this.hoehe = 0.0;
            this.material = "";
            this.istTragend = false;

            this.bewehrungsmenge = 0.0;
            this.schalungsmenge = 0.0;
        }

        public void BerechneSchalungsflaeche()
        {
            if (this.material.Equals("Mauerwerk") == false)
            {
                this.schalungsmenge = laenge * hoehe * 2;
            }
            else
            {
                this.schalungsmenge = 0.0;
            }
        }

        public void BerechneBewehrungsmenge()
        {
            int bewehrungsgrad = 0;

            if (this.material.Equals("Stahlbeton"))
            {
                if (this.istTragend == true)
                {
                    bewehrungsgrad = 60;
                }
                else
                {
                    bewehrungsgrad = 20;
                }
            }

            double ergebnis = this.hoehe * this.laenge * this.breite * bewehrungsgrad;

            this.bewehrungsmenge = Math.Round(ergebnis, 2);
        }

        public string GebeWandinfosAus()
        {
            return
                $"Masse (b * l * h): {this.breite} m * {this.laenge} m * {this.hoehe} m\n" +
                $"Material: {this.material}\n" +
                $"Bewehrungsmenge: {this.bewehrungsmenge} kg\n" +
                $"Schalungsmenge: {this.schalungsmenge} m2";
        }
    }
}
