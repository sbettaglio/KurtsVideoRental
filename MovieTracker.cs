using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KurtsVideoRental
{
  public class MovieTracker
  {
    //Connect to your database
    public void AddNewMovie(string name, string tagline, DateTime releasedDate, int screenings, double pricePerTicket, double totalRevenue, double cost, double budget)
    {

      var db = new MovieContext();
      var newMovie = new Movie
      {
        Name = name,
        Tagline = tagline,
        ReleasedDate = releasedDate,
        Screenings = screenings,
        PricePerTicket = pricePerTicket,
        TotalRevenue = totalRevenue,
        Cost = cost,
        Budget = budget
      };
      db.Movies.Add(newMovie);
      db.SaveChanges();
    }
  }
}