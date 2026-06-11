using System;

namespace intro
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, World!");

      // Creazione variabili

      // Dichiarazione
      int a;

      // Assegnazione
      a = 10;

      // Ri-assegnazione
      a = 20;

      // Inizializzazione
      int b = 5;

      // Inizializzazione multipla
      int c = 1, d = 2, e = 3;

      // Copia (indipendente) per valore
      int f = e;

      Console.WriteLine($"a = {a}, b = {b}, c = {c}, d = {d}, e = {e}, f = {f}");
      // a = 20, b = 5, c = 1, d = 2, e = 3, f = 3

      // Modificare e oppure f non cambia il valore dell'altra variabile
      e = 74;

      Console.WriteLine($"e = {e}, f = {f}");
      // e = 74, f = 3


      // Dichiarazione implicita del tipo di dato con var

      var i = 50; // Implicitamente un int
      var j = "Hello"; // Implicitamente una string


      // Copia per riferimento (il valore è condiviso)
      // Istanziamo una oggetto di classe Persona (vedi sotto)
      Persona p1 = new Persona();
      p1.Nome = "Luca";
      Console.WriteLine($"p1.Nome = {p1.Nome}"); // Luca

      Persona p2 = p1; // copia per riferimento
      p2.Nome = "Anna";
      Console.WriteLine($"p1.Nome = {p1.Nome}"); // Anna


      // Costanti

      const double PI_GRECO = 3.141529; // Inizializzazione di una costante
      // PI_GRECO = 20; Impossibile riassegnare il valore

    }
  }

  class Persona
  {
      public string Nome;
  }
}

//# Sugar Syntax
// Console.WriteLine("Hello, World!");