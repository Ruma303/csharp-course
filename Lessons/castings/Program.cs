using System;

namespace castings;

class Program
{
  static void Main(string[] args)
  {
    //% Implicit casting
    Console.WriteLine("\n\nImplicit casting");

    int a = 10;
    double b = a; // int → double (conversione implicita)
    Console.WriteLine($"a: {a}, b: {b}");

    byte c = 100;
    int d = c; // byte → int (conversione implicita)
    Console.WriteLine($"c: {c}, d: {d}");

    int x = 10;
    double y = 2.5;
    double z = x + y; // x è convertito implicitamente in double
    Console.WriteLine($"Type Coercion: x: {x}, y: {y}, z: {z} promosso a double");


    //% Explicit casting
    Console.WriteLine("\n\nExplicit casting");

    double e = 9.7;
    int f = (int)e; // f = 9 (parte decimale persa)
    Console.WriteLine($" e: {e}, i: {f}");

    int g = 300;
    byte h = (byte)g; // h = 44 (overflow, byte max = 255)
    Console.WriteLine($" g: {g}, h: {h}");


    //% Casting tra tipi riferimento (reference types)
    Console.WriteLine("\n\nCasting tra tipi riferimento");

    Console.WriteLine("\nUpcasting implicito");
    string s1 = "Hello, World!";
    object o1 = s1; // implicito
    Console.WriteLine($"s1: {s1}, o1: {o1}");

    Console.WriteLine("\nDowncasting esplicito");
    object o2 = "ciao";
    string s2 = (string)o2; // valido
    Console.WriteLine($"s2: {s2}, o2: {o2}");

    // object x = 42;
    // string y = (string)x; // InvalidCastException a runtime

    //# Operatori di verifica per cast sicuro
    Console.WriteLine("\n\nOperatori di verifica per cast sicuro");

    string s3 = "Hello, World!";
    object o3 = s3;

    if (o3 is string)
    {
      Console.WriteLine($"o3 {o3} è di tipo string");
    }

    if (o3 is string s4)
    {
      Console.WriteLine($"s4 {s4} è di tipo string");
    }

    string s5 = o3 as string; // null se non è un string (non genera eccezioni)
    Console.WriteLine($"s5 {s5} è di tipo string");

    object o4 = 123;
    string s6 = o4 as string ?? "Non è un tipo string";
    Console.WriteLine($"s6 {s6}");


    //% Convert
    Console.WriteLine("\n\nConvert casting");
    string i = "10";
    int j = Convert.ToInt32(i);
    Console.WriteLine($" i: {i}, j: {j}");
  }
}
