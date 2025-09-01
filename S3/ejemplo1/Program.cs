string entrada = string.Empty;
bool entradaValida = false;
while (!entradaValida)
{
    Console.Write("Ingrese un numero positivo: ");
    entrada = Console.ReadLine();

    if (int.TryParse(entrada, out int numero) && numero > 0)
    {
        entradaValida = true;
    }
    else
    {
        Console.WriteLine("Entrada invalida. Intente de nuevo.");
    }
}
Console.WriteLine($"Numero ingresado: {entrada} (positivo)");