using System;

namespace _5_loops
{
  class Program
  {
    static void Main(string[] args)
    {

      // While
      int i = 0;
      while (i < 10)
      {
        Console.WriteLine(i);
        i++;
      }

      // Do-while
      int j = 0;
      do
      {
        Console.WriteLine(j);
        j++;
      } while (j < 10);

      // For
      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine(i);
      }

      // Break e continue
      for (int i = 0; i < 10; i++)
      {
        if (i == 5)
        {
          continue;
        }

        if (i == 7)
        {
          break;
        }
        Console.WriteLine(i);
      }
    }
  }
}