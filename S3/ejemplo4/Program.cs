//Contar las vocales de una cadena usando foreach

Console.Write("INgrese una frase: ");
string frase = Console.ReadLine().ToLower();
int contadorVocales = 0;

foreach (char c in frase)
{
    if (c == 'a'  c == 'e'  c == 'i'  c == 'o'  c == 'u')
    {
        contadorVocales++;
    }
}

Console.WriteLine($"La frase tiene {contadorVocales} vocales");






