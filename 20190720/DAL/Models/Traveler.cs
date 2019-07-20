using System.ComponentModel.DataAnnotations.Schema;
namespace DAL.Models
{
    public class Traveler
    {
        public int TravelerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        // [ForeignKey("Room")]
        // public int RoomId {get;set;}
    }
}