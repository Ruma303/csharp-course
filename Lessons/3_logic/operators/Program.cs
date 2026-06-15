namespace operators;

class Program
{
  static void Main()
  {
    //% Operatori unari
    Console.WriteLine("\n\nOperatori unari");
    int a = 10;
    Console.WriteLine($"Negazione logica: {a}");
    int b = -a; // -10
    Console.WriteLine($"Inversione di segno: {b}");
    bool neg_bool = !false; // true
    Console.WriteLine($"Conversione a booleano: {neg_bool}");


    a = 10;
    int c = ++a * 2; // a = 11, c = 22
    Console.WriteLine($"Pre-incremento: a = {a}, c = {c}");
    // avviene prima l'incremento di a, che diventa 11, poi la moltiplicazione * 2, c = 22
    a = 10;
    int d = --a + 2; // a = 9, d = 11
    Console.WriteLine($"Pre-decremento: a = {a}, d = {d}");
    // avviene prima il decremento di a, che diventa 9, poi la somma + 2, d = 11
    a = 10;
    int e = a++ - 5;  // a = 11, e = 5
    Console.WriteLine($"Post-incremento: a = {a}, e = {e}");
    // avviene la sottrazione e = 10 - 5, quindi 5; poi a viene incrementata, a = 11
    a = 10;
    int f = a-- / 5; // a = 9, f = 2
    Console.WriteLine($"Post-decremento: a = {a}, f = {f}");
    // avviene la divisione f = 10 / 5, quindi 2; poi a viene decrementata, a = 9


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


    //# Null coalescing assignment
    Console.WriteLine("\n\nOperatore Null coalescing");
    string nome = null;
    nome ??= "Sconosciuto";
    Console.WriteLine($"Null coalescing: {nome}");

    //# Equivalente a Null coalescing se il valore è null
    nome = null;
    nome = nome ?? "Nessun valore";
    Console.WriteLine($"Null coalescing: {nome}");


    //% Operatori speciali

    //# nameof
    int valore = 5;
    string nomeVar = nameof(valore);
    Console.WriteLine($"Nome variabile = {nomeVar} | con valore = {valore}");

    //# nameof
    Type tipoInt = typeof(int); // System.Int32
    Console.WriteLine($"{tipoInt}");
    Type tipoString = typeof(string); // System.String
    Console.WriteLine($"{tipoString}");

    //# sizeof
    int intSize = sizeof(int); // 4
    Console.WriteLine($"Lunghezza in bytes di {nameof(intSize)} = {intSize}");
    int decimalSize = sizeof(decimal); // 16
    Console.WriteLine($"Lunghezza in bytes di {nameof(decimalSize)} = {decimalSize}");

    //# checked e unchecked
    int x1 = int.MaxValue;
    try
    {
      Console.WriteLine("Eccezione OverflowException");
      int y1 = checked(x1 + 1); // genera OverflowException
    }
    catch
    {
      Console.WriteLine("Eccezione catturata");
      int z1 = unchecked(x1 + 1); // nessuna eccezione, wrapping
      Console.WriteLine($"{z1}");
    }

    //# default
    int x2 = default;    // 0
    bool y2 = default;   // false
    string z2 = default; // null (come tutti i tipi riferimento)
    string[] w2 = default; // null (come tutti i tipi riferimento)
    Console.WriteLine($"Valori di default:\n"
      + $"\t- int = {x2}\n"
      + $"\t- bool = {y2}\n"
      + $"\t- string = {z2} (null)\n"
      + $"\t- string = {w2} (null)"
    );


    //% Operatore Ternario
    Console.WriteLine("\n\nOperatore ternario");
    int età = 15;
    string verifica = età >= 18 ? "Maggiorenne" : "Minorenne";
    Console.WriteLine(verifica);
  }
}

