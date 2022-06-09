using kolokwium2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Dto
{
    public class PatientDto
    {
        public int IdPatient { get; set; }
      
        public string FirstName { get; set; }
      
        public string LastName { get; set; }
      
        public DateTime Birthdate { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
    }
}
