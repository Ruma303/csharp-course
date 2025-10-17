
string[] cibiPreferiti = new string[5] { "Pizza", "Sushi", "Mortadella", "Nutella", "Tiramisù"};
Console.WriteLine($"Lunghezza array : {cibiPreferiti.Length}"); // Lunghezza array

for(int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine($"Posizione {i+1} : {cibiPreferiti[i]}"); // Lista cibi
}


Console.WriteLine($"Il mio cibo preferito: {cibiPreferiti[0]}"); // Cibo Top

Console.WriteLine($"Il mio cibo preferito, ma non troppo: {cibiPreferiti[cibiPreferiti.Length-1]}"); // Cibo meno preferito

Console.WriteLine($"Il mio cibo preferito, ma non troppo: {cibiPreferiti[(cibiPreferiti.Length - 1)/2]}"); // Cibo a centro classifica