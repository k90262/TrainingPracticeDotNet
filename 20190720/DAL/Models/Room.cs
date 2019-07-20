using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public int Number { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; }
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();

        // [ForeignKey("Traveler")]
        // public int TravelerId { get; set; }
    }
}