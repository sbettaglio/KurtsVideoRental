using System;
using System.Linq;
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
      Console.WriteLine("Thanks for adding a move to the database!");
    }
    public void MovieLookUp(string name)
    {
      var db = new MovieContext();
      var inSystem = db.Movies.Any(movie => movie.Name.ToLower() == name);
      var movieName = db.Movies.Where(movie => movie.Name.ToLower() == name);
      if (inSystem == true)
      {
        foreach (var movie in movieName)
        {
          Console.WriteLine($"{movie.Name} was released on {movie.ReleasedDate}, with {movie.Screenings} screenings, a ticket price of ${movie.PricePerTicket}, the total revenue was ${movie.TotalRevenue} with a production const of ${movie.Cost} and a budget of ${movie.Budget} ");
        }

      }
      else
      {
        Console.WriteLine("That name is not in our system. Please try again");
        name = Console.ReadLine().ToLower();
      }
    }
  }
}