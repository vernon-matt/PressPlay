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

        public int AlbumId { get; set; }

        public Artist(int artistId, string artistName, string imageUrl)
        {
            ArtistId = artistId;
            ArtistName = artistName;
            ImageUrl = imageUrl;
        }

        public Artist()
        {

        }
    }
}
