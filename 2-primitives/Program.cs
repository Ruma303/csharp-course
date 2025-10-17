using System;

namespace _2_primitives;

class Program
{
  static void Main(string[] args)
  {

    // Integral
    int a = 500;
    short b = 100;
    sbyte c = -50;
    long d = 1_000_000L;
    int e = 0b10101010; // Notazione binaria
    ushort f = 0x0A56; // Notazione esadecimale

    // Format Strings
    // Console.WriteLine("int a: {0}, short b: {1}, sbyte c: {2}, long d: {3}, int e: {4}, ushort f: {5}", a, b, c, d, e, f);

    // Float
    float g = 10.45f;
    double h = 999_999.999_999d;
    decimal j = 12345678900987654321m; // m sta per money

    // Notazione scientifica
    double k = 1.6e6;
    double l = 1.4e-32;

    // String interpolation
    // Console.WriteLine($"float g: {g}, double h: {h}, decimal j: {j}, double k: {k}, decimal l: {l}");

    // Boolean
    bool m = true;
    bool n = false;

    //Console.WriteLine($"bool m: {m}, bool n: {n}");


    // Type inference
    var o = 10;
    var p = 3.14;
    var q = "Hello World";
    var r = true;

    // Console.WriteLine($"var o: {o}, var p: {p}, var q: {q}, var r: {r}");
  }
}