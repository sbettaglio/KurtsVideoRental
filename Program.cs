using System;
using System.Linq;

namespace KurtsVideoRental
{
  class Program
  {
    static void Main(string[] args)
    {
      var tracker = new MovieTracker();
      Console.WriteLine("Do you want to add a new movie? y/n");
      var addNewMovie = Console.ReadLine().ToLower();
      while (addNewMovie != "y" && addNewMovie != "n")
      {
        Console.WriteLine("Invalid input. Please select (Y) or (N)");
        addNewMovie = Console.ReadLine().ToLower();
      }
      if (addNewMovie == "y")
      {
        Console.WriteLine("What is the name of the movie?");
        var name = Console.ReadLine();
        Console.WriteLine("What's the tagline?");
        var tagline = Console.ReadLine();
        Console.WriteLine("When was the movie released?");
        var releasedDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("How many screenings?");
        var screenings = int.Parse(Console.ReadLine());
        Console.WriteLine("What was the ticket price?");
        var pricePerTicket = double.Parse(Console.ReadLine());
        Console.WriteLine("What was the total revenue?");
        var totalRevenue = double.Parse(Console.ReadLine());
        Console.WriteLine("How much was the production cost?");
        var cost = double.Parse(Console.ReadLine());
        Console.WriteLine("What was the budget?");
        var budget = double.Parse(Console.ReadLine());
        tracker.AddNewMovie(name, tagline, releasedDate, screenings, pricePerTicket, totalRevenue, cost, budget);
      }



    }
  }
}
