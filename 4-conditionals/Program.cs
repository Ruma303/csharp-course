using System;

namespace _4_conditionals
{
  class Program
  {
    static void Main(string[] args)
    {
      // If-Else
      int temperatura = 20;

      if (temperatura > 25)
      {
        Console.WriteLine("L'aria è calda");
      }
      else if (temperatura < 10)
      {
        Console.WriteLine("L'aria è fredda");
      }
      else
      {
        Console.WriteLine("L'aria è confortevole");
      }

      // Operatori ternari
      int età = 15;
      string verifica = età >= 18 ? "Maggiorenne" : "Minorenne";
      Console.WriteLine(verifica);

      // Switch case
      string colore = "rosso";
      switch (colore)
      {
        case "rosso":
          Console.WriteLine("Il colore è rosso");
          break;
        case "verde":
          Console.WriteLine("Il colore è verde");
          break;
        case "blu":
          Console.WriteLine("Il colore è blu");
          break;
        default:
          Console.WriteLine("Colore sconosciuto");
          break;
      }
    }
  }
}