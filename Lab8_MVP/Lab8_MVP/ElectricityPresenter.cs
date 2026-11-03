using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_MVP
{
    class ElectricityPresenter
    {
        private readonly IElectricityView view;
        private readonly IElectricityModel model;

        public ElectricityPresenter(IElectricityView view, IElectricityModel model)
        {
            this.view = view;
            this.model = model;
        }

        public void LoadElectricity(double p, double h, double t)
        {
            var electricity = new Electricity(p, h, t);
            view.SetCost(electricity.Cost());
        }
    }
}
