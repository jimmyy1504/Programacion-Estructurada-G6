//Pedir al usuario un numero y mostrar su tabla de multiplicar del 1 al 10 
//Usando un bucle for

Console.Write("Ingrese un numero: ");
int numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Tabla de multiplicar del {numero}:");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
 }