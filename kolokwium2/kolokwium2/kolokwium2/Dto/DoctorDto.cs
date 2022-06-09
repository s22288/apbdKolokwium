using kolokwium2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Dto
{
    public class DoctorDto
    {
        public int IdDoctor { get; set; }
      
        public string FirstName { get; set; }
    
        public string LastName { get; set; }
       
        public string Email { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
    }
}
