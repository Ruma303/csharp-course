namespace _3_operators;

class Program
{
  static void Main()
  {
    int a = 10;
    int b = 6;

    // Operatori aritmetici
    Console.WriteLine($"Somma: {a + b}");
    Console.WriteLine($"Sottrazione: {a - b}");
    Console.WriteLine($"Moltiplicazione: {a * b}");
    Console.WriteLine($"Divisione intera: {a / b}");
    Console.WriteLine($"Modulo: {a % b}");

    // Floating-point
    double x = 10.0;
    double y = 6.0;
    Console.WriteLine($"Divisione reale: {x / y}");

    // Operatore unario
    int c = -a;
    Console.WriteLine($"Negazione: {c}");

    // Precedenza
    Console.WriteLine($"Default precedence: {10 + 5 * 2}");      // 20
    Console.WriteLine($"Con parentesi: {(10 + 5) * 2}");         // 30

    // Ternario
    int età = 15;
    string verifica = età >= 18 ? "Maggiorenne" : "Minorenne";
    Console.WriteLine(verifica);
  }
}

