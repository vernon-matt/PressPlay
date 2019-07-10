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

        public int AlbumId { get; set; }
        public int ArtistId { get; set; }

        public Song(int songId, string songTitle, string link, int duration)
        {
            SongId = songId;
            SongTitle = songTitle;
            Link = link;
            Duration = duration;
        }


    }
}
