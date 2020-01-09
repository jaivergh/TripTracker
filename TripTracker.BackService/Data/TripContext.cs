using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripTracker.BackService.Models;

namespace TripTracker.BackService.Data
{
	public class TripContext : DbContext
	{
		public TripContext(DbContextOptions<TripContext> options) : base(options)
		{
			
		}
		public DbSet<Trip> Trips { get; set; }

		public static void SeedData(IServiceProvider serviceProvider)
		{
			using (var serviceScope = serviceProvider
				.GetRequiredService<IServiceScopeFactory>().CreateScope())
			{
				var context = serviceScope
					.ServiceProvider.GetService<TripContext>();

				context.Database.EnsureCreated();

				if (context.Trips.Any())
				{
					return;
				}

				context.Trips.AddRange(new Trip[]
					{
					new Trip
					{
						Id = 1,
						Name = "Primera reunion",
						StartDate = new DateTime(2018, 3, 5),
						EndDate = new DateTime(2018,3, 8)
					},
					new Trip
					{
						Id = 2,
						Name = "Segunda reunion",
						StartDate = new DateTime(2018, 3, 25),
						EndDate = new DateTime(2018,3, 27)
					},
					new Trip
					{
						Id = 3,
						Name = "Tercera reunion",
						StartDate = new DateTime(2018, 4, 10),
						EndDate = new DateTime(2018, 4, 13)
					}
					});


				context.SaveChanges();
			}

		}
	}
}
