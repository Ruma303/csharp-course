class Program
{
    static void Main()
    {

     Console.Write("Scrivi un valore scegliendo tra rosso, verde o blu: ");
     string colore = Console.ReadLine();

        switch (colore)
        {
            case "rosso":
                Console.WriteLine("Il tuo colore preferito è il rosso");
                break;
            case "verde":
                Console.WriteLine("Il tuo colore preferito è il verde");
                break;
            case "blu":
                Console.WriteLine("Il tuo colore preferito è il blu");
                break;
            default:
                Console.WriteLine("Colore sconosciuto");
                break;
        }
    }
}