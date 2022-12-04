using System;

class HotelCost
{
  static void Main()
  {
    Console.WriteLine("What season are booking a stay?");
    string season = Console.ReadLine();

    Console.WriteLine("Weekend or weeknight");
    string dayOfWeek = Console.ReadLine();

    bool summer = season == "summer";
    bool weekend = dayOfWeek == "weekend";

    if (summer && weekend)
    {
      Console.WriteLine("Your stay is probably going to be pretty expensive. It's both peak travel season AND the weekend.");
    }
    else if (!(summer || weekend))
    {
      Console.WriteLine("Your stay will most likely be the cheapest price.");
    }
    else
    {
      Console.WriteLine("Your stay might be more expensive than usual.");
    }
  }
}