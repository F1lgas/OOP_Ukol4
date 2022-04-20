using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ukol4
{
    class Zboží
    {
        private string nazev;
        private double cena;
        private DateTime datum_vyroby;
        private int min_trvanlivost;

        public Zboží(string nazev, int cena, DateTime datum_vyroby, int min_trvanlivost)
        {
            this.nazev = nazev;
            this.cena = cena;
            this.datum_vyroby = datum_vyroby;
            this.min_trvanlivost = min_trvanlivost;
        }

        public bool Splň_min_trv()
        {
            if((DateTime.Now.DayOfYear - datum_vyroby.DayOfYear) > min_trvanlivost)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public virtual double DPH()
        {
            return (cena * 1.21);
        }

        public override string ToString()
        {
            if (Splň_min_trv() == true)
            {
                return string.Format("Zboží {0}, které stojí {1} a bylo vyrobeno {2}, ještě neprošlo min. trvanlivostí (zbývá {3} dní). Jeho cena s DPH je {4}.", nazev, Convert.ToDouble(cena), Convert.ToString(datum_vyroby.Date), (DateTime.Now.DayOfYear - datum_vyroby.DayOfYear), DPH());
            }
            else
            {
                return string.Format("Zboží {0}, které stojí {1} a bylo vyrobeno {2}, už prošlo min. trvanlivostí. Jeho cena s DPH a se slevou je {3}.", nazev, Convert.ToDouble(cena), Convert.ToString(datum_vyroby.Date), DPH());
            }
        }
    }
}
