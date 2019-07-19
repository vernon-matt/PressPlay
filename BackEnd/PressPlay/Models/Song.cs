
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressPlay.Models
{
    public class Song
    {
        public int SongId { get; set; }
        public string SongTitle { get; set; }
        public string Link { get; set; }
        public int Duration { get; set; }
        public virtual Album Album { get; set; }
        public virtual int AlbumId {get; set;}

        public Song()
        {

        }


    }
}
