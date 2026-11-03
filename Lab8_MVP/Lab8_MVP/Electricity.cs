using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_MVP
{
    class Electricity : IElectricityModel
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

        public double Cost()
        {
            return power * hours * tarif;
        }

    }
}
