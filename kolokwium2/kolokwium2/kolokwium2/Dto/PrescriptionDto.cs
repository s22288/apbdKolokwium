using kolokwium2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Dto
{
    public class PrescriptionDto
    {
        public int IdPrescription { get; set; }
     
        public DateTime Date { get; set; }
        
        public DateTime DueDate { get; set; }

        public int IdPatient { get; set; }
        public int IdDoctor { get; set; }
        
        public virtual Patient Patient { get; set; }
        
        public virtual Doctor Doctor { get; set; }
    }
}
