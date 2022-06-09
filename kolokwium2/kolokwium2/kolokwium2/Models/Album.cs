using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace kolokwium2.Models
{
    public class Album
    {
        [Key]
        public int IdAlbum { get; set; }
        [Required]
        [MaxLength(30)]
        public string AlbumName { get; set; }
        [Required]
       public DateTime PublishDate { get; set; }
        public int IdMusicLabel { get; set; }
        [ForeignKey("IdMusicLabel")]
        public virtual MusicLabel MusicLabel { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }

        public static implicit operator List<object>(Album v)
        {
            throw new NotImplementedException();
        }
    }
}
