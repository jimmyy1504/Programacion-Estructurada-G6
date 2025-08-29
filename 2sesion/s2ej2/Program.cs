Console.WriteLine("Introduce un numero del 1 al 7: ");
int diaNumero = Convert.ToInt32(Console.ReadLine());

switch (diaNumero)
{
case 1:
    Console.WriteLine("Lunes");
    break;
case 2:
    Console.WriteLine("Martes");
    break;
case 3:
    Console.WriteLine("Miércoles");
    break;
case 4:
    Console.WriteLine("Jueves");
    break;
case 5:
    Console.WriteLine("Viernes");
    break;
case 6:
    Console.WriteLine("Sábado");
    break;
case 7:
    Console.WriteLine("Domingo");
    break;
default:
    Console.WriteLine("Número inválido, debe estar entre 1 y 7.");
    break;
}