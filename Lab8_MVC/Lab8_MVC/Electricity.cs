using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Обчислення витрат на електроенергію для домогосподарства:
//Витрати = Споживана потужність(кВт) × Час використання(год) × Тариф

namespace Lab8_MVC
{
    class Electricity
    {
        double power;
        double hours;
        double tarif;

        public Electricity()
        {
            power = 2;
            hours = 5;
            tarif = 4.32;
        }

        public Electricity(double pp, double hh, double tt)
        {
            power = pp;
            hours = hh;
            tarif = tt;
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
