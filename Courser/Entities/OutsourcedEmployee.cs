using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        
        public double Additionacharge { get; set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHours, double additionacharge)
            : base(name, hours, valuePerHours)
        {
            Additionacharge = additionacharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * Additionacharge;

        }

    }
}
