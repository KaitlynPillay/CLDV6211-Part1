using System.ComponentModel.DataAnnotations;

namespace EventEase.Models;

    public class Venue
{
    public int VenueId { get; set; }

    [Required]
    public required string VenueName { get; set; }

    [Required]
    public required string Location { get; set; }

    [Required]
    [Range(1, int.MaxValue)]
    public int Capacity { get; set; }

    public string? ImageUrl { get; set; }

    public ICollection<Booking>? Bookings { get; set; }
}