using System;
using System.Linq;

namespace KurtsVideoRental
{
  class Program
  {
    static void Main(string[] args)
    {
      var tracker = new MovieTracker();
      Console.WriteLine("Welcome to Kurt's Video Rental!");
      Console.WriteLine("Do you want to add a move (A), lookup the stats (L) or update a movie (U)?");
      var addNewMovie = Console.ReadLine().ToLower();
      //Validation
      while (addNewMovie != "a" && addNewMovie != "l" && addNewMovie != "u")
      {
        Console.WriteLine("Invalid input. Please select (A), (L) or (U) ");
        addNewMovie = Console.ReadLine().ToLower();
      }
      //If user select add
      if (addNewMovie == "a")
      {
        //input all items for list
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
        //runs move adding method
        tracker.AddNewMovie(name, tagline, releasedDate, screenings, pricePerTicket, totalRevenue, cost, budget);
      }
      else if (addNewMovie == "l")
      {
        Console.WriteLine("What is the name of the movie you want to lookup?");
        var name = Console.ReadLine().ToLower();
        tracker.MovieLookUp(name);
      }



    }
  }
}
