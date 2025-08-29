const double varas_manzana = 1428.8;

double ancho = 5; 

Console.WriteLine("Ingrese la longitud del terreno en varas");
double longitud = Conver.ToDouble (Console.ReadLine());

double area_varas2 = longitud * ancho;
double area_manzanas = area_varas2 * ancho;
Console.WriteLine($"El area del terreno en manzanas es: {area_manzanas*f4} manzanas");
