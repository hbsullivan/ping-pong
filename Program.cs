using System;
using System.Collections.Generic;

class PingPong
{
  static void Main()
  {
    Console.WriteLine("Please input a number:");

    int input = Int32.Parse(Console.ReadLine());

    for (int counter = 1; counter <= input; counter ++)
    {
    if (counter % 3 == 0 && counter % 5 == 0)
    {
      Console.WriteLine("Ping-Pong");
    }
    else if (counter % 3 == 0)
    {
      Console.WriteLine("Ping");
    }
    else if (counter % 5 == 0)
    {
      Console.WriteLine("Pong");
    }
    else 
    {
      Console.WriteLine(counter);
    }

    }
  }
} 