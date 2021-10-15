using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystemEmreAyhan.Models
{
    public class Room
    {
        public int RoomId { get; set; }

        public string RoomName { get; set; }
        public string Size { get; set; }
        public int Price { get; set; }
        public double Rating { get; set; }
    }
}
