using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystemEmreAyhan.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public User User { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
