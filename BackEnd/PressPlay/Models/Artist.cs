using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressPlay.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        public string ImageUrl { get; set; }
        public virtual List<Album> Albums {get; set;}


        public Artist()
        {

        }
    }
}
