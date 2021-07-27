using System;

namespace Variables
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("Pick a number representing a day of the week.");
      int dayNum = Convert.ToInt16(Console.ReadLine());
      Console.WriteLine(GetDay(dayNum));

    }

    static string GetDay(int dayNum) 
    {
      string dayName;

      switch (dayNum)
      {
        case 0:
          dayName = "Sunday";
          break;
        case 1:
          dayName = "Monday";
          break;
        case 2:
          dayName = "Wednesday";
          break;
        case 3:
          dayName = "Thursday";
          break;
        case 4:
          dayName = "Friday";
          break;
        case 5:
          dayName = "Saturday";
          break;
        case 6:
          dayName = "Sunday";
          break;
        default:
          dayName = "Invalid Day Number";
          break;
      }

      return dayName;
    }


  }
}