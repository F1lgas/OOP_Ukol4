using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ukol4
{
    class Produkt : Zboží
    {
        bool lze_slevit;

        public Produkt(string nazev, int cena, DateTime datum_vyroby, int min_trvanlivost, bool lze_slevit) : base(nazev, cena, datum_vyroby, min_trvanlivost)
        {
            if (Splň_min_trv() == true)
            {
                lze_slevit = false;
            }
            else
            {
                lze_slevit = true;
            }

            this.lze_slevit = lze_slevit;
        }

        public override double DPH()
        {
            if (Splň_min_trv() == true)
            {
                return base.DPH();
            }
            else
            {
                return base.DPH() * 0.4;
            }
        }
    }
}
