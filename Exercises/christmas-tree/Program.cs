class Program
{
  static void Main()
  {
    while (true)
    {
      Console.Write("Creiamo un albero di natale.");
      Console.Write("Inserisci un numero di righe, oppure digita \"exit\" per uscire.: ");
      string input = Console.ReadLine();

      if (input == "exit")
        break;

      if (!int.TryParse(input, out int N))
      {
        Console.WriteLine("Invalid input. Please try again.");
        continue;
      }

      for (int i = 0; i < N; i++)
      {
        // Spazi a sinistra per centrare
        for (int s = 0; s < N - i - 1; s++)
          Console.Write(" ");

        // Asterischi
        for (int a = 0; a < 2 * i + 1; a++)
          Console.Write("*");

        Console.WriteLine();
      }
    }
  }
}