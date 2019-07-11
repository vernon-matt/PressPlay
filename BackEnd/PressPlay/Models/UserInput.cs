using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressPlay.Models
{
    public class UserInput
    {
        public int UserInputId { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }

        public int AlbumId { get; set; }

        public UserInput(int userInputId, int rating, string review)
        {
            UserInputId = userInputId;
            Rating = rating;
            Review = review;
        }

        public UserInput()
        {

        }
    }
}
