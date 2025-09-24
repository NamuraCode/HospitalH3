using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.domain.model;

namespace Hospital.domain.ports
{
    internal interface MedicalHistoryPorts
    {
        public List<MedicalHistory> GetMedicalHistories();
        public void AddMedicalHistory();
        public void UpdateMedicalHistory();
        public void DeleteMedicalHistory();
    }
}
