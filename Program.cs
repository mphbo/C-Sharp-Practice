using System;

namespace Variables
{
  class Program
  {
    static void Main(string[] args)
    {
      SayHi("Logan", 27);
    }

    static void SayHi(string name, int age) 
    {
      Console.WriteLine("Hello " + name + " you are " + age + " today!");
    }
  }
}