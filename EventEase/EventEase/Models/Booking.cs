using System.ComponentModel.DataAnnotations;

namespace EventEase.Models;

public class Booking
{
    public int BookingId { get; set; }

    [Required]
    public int EventId { get; set; }

    [Required]
    public int VenueId { get; set; }

    [Required]
    [Display(Name = "Booking Date")]
    public DateTime BookingDate { get; set; } = DateTime.Now;

    public Event? Event { get; set; }
    public Venue? Venue { get; set; }
}
