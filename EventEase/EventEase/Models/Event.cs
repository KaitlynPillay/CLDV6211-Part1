using System.ComponentModel.DataAnnotations;

namespace EventEase.Models;

    public class Event
{
    public int EventId { get; set; }

    [Required]
    public required string EventName { get; set; }

    public string? Description { get; set; }

    [Required]
    [Display(Name = "Start Date")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
    public DateTime StartDate { get; set; }

    [Required]
    [Display(Name = "End Date")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
    public DateTime EndDate { get; set; }
    public ICollection<Booking>? Bookings { get; set; }
}