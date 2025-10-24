namespace _3_operators;

class Program
{
  static void Main()
  {
    //% Operatori unari
    Console.WriteLine("\n\nOperatori unari");
    int a = 10;
    Console.WriteLine($"Negazione logica: {a}");
    int b = -a; // -10
    Console.WriteLine($"Inversione di segno: {a}");
    int c = ++a; // 11
    Console.WriteLine($"Pre-incremento: {a}");
    int d = --a; // 10
    Console.WriteLine($"Pre-decremento: {a}");
    int e = a++; // 10
    Console.WriteLine($"Post-incremento: {a}");
    int f = a--; // 11
    Console.WriteLine($"Post-decremento: {a}");
    bool neg_bool = !false; // true
    Console.WriteLine($"Conversione a booleano: {neg_bool}");


    //% Operatori binari
    int g = 10;
    int h = 6;
    double x = 10.0;
    double y = 6.0;

    //# Operatori aritmetici
    Console.WriteLine("\n\nOperatori aritmetici");
    Console.WriteLine($"Somma: {g + h}"); // 16
    Console.WriteLine($"Sottrazione: {g - h}"); // 4
    Console.WriteLine($"Moltiplicazione: {g * h}"); // 60
    Console.WriteLine($"Divisione intera: {g / h}"); // 1
    Console.WriteLine($"Divisione reale: {x / y}"); // 1.66667
    Console.WriteLine($"Modulo: {g % h}"); // 4


    //# Operatori logici
    Console.WriteLine("\n\nOperatori logici");
    Console.WriteLine($"And: {true && true}"); // true
    Console.WriteLine($"Or: {true || false}"); // true
    Console.WriteLine($"Negazione: {!true}"); // false


    //# Operatori di confronto
    Console.WriteLine("\n\nOperatori di confronto");
    Console.WriteLine($"Maggiore: {g > h}"); // true
    Console.WriteLine($"Maggiore o uguale: {g >= h}"); // true
    Console.WriteLine($"Minore: {g < h}"); // false
    Console.WriteLine($"Minore o uguale: {g <= h}"); // false
    Console.WriteLine($"Uguale: {g == h}"); // false
    Console.WriteLine($"Diverso: {g != h}"); // true


    //# Operatori di assegnamento
    Console.WriteLine("\n\nOperatori di assegnamento");
    x += 5;   // 15
    Console.WriteLine($"x += {x}");
    x *= 2;   // 30
    Console.WriteLine($"x *= {x}");
    x /= 3;   // 10
    Console.WriteLine($"x /= {x}");
    x %= 2;   // 0
    Console.WriteLine($"x %= {x}");
    x = 1;   // 1
    Console.WriteLine($"x = {x}");

    
    //# Espressioni complesse
    Console.WriteLine("\n\nEspressioni complesse");
    Console.WriteLine($"Espressione complessa: {(g + h) * 2}"); // 32


    //# Precedenza operatori
    Console.WriteLine("\n\nPrecedenza operatori");
    Console.WriteLine($"Default precedence: {10 + 5 * 2}");      // 20
    Console.WriteLine($"Con parentesi: {(10 + 5) * 2}");         // 30


    //# Null coalescing
    Console.WriteLine("\n\nOperatore Null coalescing");
    string nome = null;
    nome ??= "Sconosciuto";
    Console.WriteLine($"Null coalescing: {nome}");


    //% Operatore Ternario
    Console.WriteLine("\n\nOperatore ternario");
    int età = 15;
    string verifica = età >= 18 ? "Maggiorenne" : "Minorenne";
    Console.WriteLine(verifica);
  }
}

