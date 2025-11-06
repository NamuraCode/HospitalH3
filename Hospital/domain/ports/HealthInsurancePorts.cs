using Hospital.domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.domain.ports
{
    internal interface HealthInsurancePorts
    {
        public HealthInsurance GetHealthInsuranceByIdPatient(ulong userId)
        {
            return new HealthInsurance
            {
                Name = "Salud Total",
                NumberPolicy = "123456789",
                StatusPolicy = true,
                Discount = 10,
                ValidityPolicy = DateTime.Now.AddYears(1)

            };
        }
    }
}
