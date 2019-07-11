using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressPlay.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string AlbumTitle { get; set; }
        public string ImageUrl { get; set; }
        public string RecordLabel { get; set; }

        public int SongId { get; set; }

        public Album(int albumId, string albumTitle, string imageUrl)
        {
            AlbumId = albumId;
            AlbumTitle = albumTitle;
            ImageUrl = imageUrl;
        }

        public Album()
        {

        }

    }
}
