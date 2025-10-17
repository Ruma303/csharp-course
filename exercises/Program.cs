using System;

int[] numeri = { 2, 6, 7, 5, 3, 9 };


//? Stampare l’array di numeri fornito a video
Console.WriteLine("PRIMO ESERCIZIO ");
StampaArray(numeri);
void StampaArray(int[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i]);
    if (i < array.Length - 1)
    {
      Console.Write(", ");
    }
  }
  Console.WriteLine("]");
}
Console.WriteLine("");


//? Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato
Console.WriteLine("SECONDO ESERCIZIO ");

int[] numeriQuadrati = Quadrati(numeri);
int[] Quadrati(int[] numeri)
{
  int[] numeriQuadrati = new int[numeri.Length];

  for (int i = 0; i < numeri.Length; i++)
  {
    numeriQuadrati[i] = numeri[i] * numeri[i];
  }

  return numeriQuadrati;
}
Console.Write("Array con i quadrati: ");
foreach (int num in numeriQuadrati)
{
  Console.Write($"{num} ");
}
Console.WriteLine("");

Console.Write("Array originale: ");
foreach (int num in numeri)
{
  Console.Write($"{num} ");
}
Console.WriteLine("\n");


//? Stampare la somma di tutti i numeri
Console.WriteLine("TERZO ESERCIZIO ");
Somma(numeri);
int Somma(int[] numeri)
{
  int sum = 0;
  foreach (int num in numeri)
  {
    sum += num;
  }
  Console.WriteLine($"La somma di tutti i numeri é {sum}.");
  return sum;
}
Console.WriteLine("");


//? Stampare la somma di tutti i numeri elevati al quadrati
Console.WriteLine("QUARTO ESERCIZIO ");

SommaQuadrati(numeriQuadrati);
int SommaQuadrati(int[] numeriQuadrati)
{
  int sum = 0;
  foreach (int num in numeriQuadrati)
  {
    sum += num;
  }
  Console.WriteLine($"La somma di tutti i numeri al quadrato é {sum}.");
  return sum;
}
Console.WriteLine("");