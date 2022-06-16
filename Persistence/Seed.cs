using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context){
            if(context.Activities.Any()) return;

            var activities = new List<Activity>{
                new Activity{
                    Title = "Past Activity 1",
                    Date = DateTime.Now.AddMonths(-2),
                    Description = "Activity 1 months ago",
                    Category = "drinks",
                    City = "London",
                    Venue = "Pub",
                },
                new Activity{
                    Title = "Past Activity 2",
                    Date = DateTime.Now.AddMonths(-1),
                    Description = "Activity 2 months ago",
                    Category = "music",
                    City = "London",
                    Venue = "02 Arena",
                },
                new Activity{
                    Title = "Past Activity 3",
                    Date = DateTime.Now.AddMonths(-3),
                    Description = "Activity 3 months ago",
                    Category = "drinks",
                    City = "London",
                    Venue = "Another Pub",
                },
                new Activity{
                    Title = "Past Activity 4",
                    Date = DateTime.Now.AddMonths(-4),
                    Description = "Activity 4 months ago",
                    Category = "drinks",
                    City = "London",
                    Venue = "Yet Another Pub",
                },
                new Activity{
                    Title = "Past Activity 5",
                    Date = DateTime.Now.AddMonths(-5),
                    Description = "Activity 5 months ago",
                    Category = "drinks",
                    City = "London",
                    Venue = "Just another Pub",
                },
                new Activity{
                    Title = "Past Activity 6",
                    Date = DateTime.Now.AddMonths(-6),
                    Description = "Activity 6 months ago",
                    Category = "music",
                    City = "London",
                    Venue = "RoundHouse Camden",
                },
                new Activity{
                    Title = "Past Activity 7",
                    Date = DateTime.Now.AddMonths(-7),
                    Description = "Activity 7 months ago",
                    Category = "travel",
                    City = "London",
                    Venue = "Somewhere on the Thames",
                },
                new Activity{
                    Title = "Past Activity 8",
                    Date = DateTime.Now.AddMonths(-8),
                    Description = "Activity 8 months ago",
                    Category = "film",
                    City = "London",
                    Venue = "Cinmea",
                },
            };
            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
        
    }
}