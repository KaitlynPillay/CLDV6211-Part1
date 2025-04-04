using EventEase.Data;
using EventEase.Models;

public static class DbInitializer
{
    public static void Initialize(ApplicationDbContext context)
    {
        if (!context.Venues.Any())
        {
            var venues = new Venue[]
            {
                new Venue{VenueName="Grand Ballroom", Location="Main Building", Capacity=500, ImageUrl="https://example.com/ballroom.jpg"},
                new Venue{VenueName="Conference Hall A", Location="East Wing", Capacity=200, ImageUrl="https://example.com/hallA.jpg"},
                new Venue{VenueName="Outdoor Garden", Location="South Lawn", Capacity=300, ImageUrl="https://example.com/garden.jpg"}
            };
            context.Venues.AddRange(venues);
            context.SaveChanges();
        }

        if (!context.Events.Any())
        {
            var events = new Event[]
            {
                new Event{EventName="Tech Conference", Description="Annual technology conference", StartDate=DateTime.Now.AddDays(30), EndDate=DateTime.Now.AddDays(32)},
                new Event{EventName="Wedding Expo", Description="Wedding planning exhibition", StartDate=DateTime.Now.AddDays(45), EndDate=DateTime.Now.AddDays(47)},
                new Event{EventName="Music Festival", Description="Summer music festival", StartDate=DateTime.Now.AddDays(60), EndDate=DateTime.Now.AddDays(62)}
            };
            context.Events.AddRange(events);
            context.SaveChanges();
        }
    }
}
