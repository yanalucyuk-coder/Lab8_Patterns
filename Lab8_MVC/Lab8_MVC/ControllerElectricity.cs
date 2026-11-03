using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_MVC
{
    class ControllerElectricity
    {
        public double Question(double p, double h, double t)
        {
            var electricity = new Electricity(p, h, t);
            return electricity.Cost;
        }
    }
}
