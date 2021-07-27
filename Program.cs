using System;

namespace Variables
{
  class Program
  {
    static void Main(string[] args)
    {
      bool isMale = true;
      bool isTall = true;
      if (isMale && isTall)
      {
        Console.WriteLine("You are a tall male");
      } else if (isMale && !isTall) 
      {
        Console.WriteLine("You are a short male");
      } else if (!isMale && isTall) 
      {
        Console.WriteLine("You are not a male and you are not tall");
      } else
      {
        Console.WriteLine("You are not male and you are not tall");
      }
    }

  }
}