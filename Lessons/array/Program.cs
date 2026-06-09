class Program
{
  static void Main(string[] args)
  {
    int[] x = new int[10] {1,2,3,45,76,0,8,53,3,5};

    for (int i = 0; i < x.Length; i++)
    {
      Console.WriteLine(x[i]);
    }

    foreach (int value in x)
    {
        Console.WriteLine(value);
    }
  }
}