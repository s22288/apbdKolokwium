using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Models
{
    public class Musician_Track
    {
       
      
        public int IdMusician { get; set; }
        
        public int IdTrack { get; set; }
        
        [ForeignKey("IdMusician")]
        public virtual Patient Patient { get; set; }
       
        [ForeignKey("IdTrack")]
        public virtual Doctor Doctor { get; set; }
    }
}
