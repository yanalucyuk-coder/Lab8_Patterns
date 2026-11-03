using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_MVVM
{
    class Electricity
    {
        double power;
        double hours;
        double tarif;

        public Electricity(double pp, double hh, double tt)
        {
            power = pp;
            hours = hh;
            tarif = tt;
        }

        public Electricity()
        {
            power = 2;
            hours = 5;
            tarif = 4.32;
        }

        public double Power { get; set; }
        public double Hours { get; set; }
        public double Tarif { get; set; }

        public double Cost
        {
            get { return power * hours * tarif; }
        }
    }
}
