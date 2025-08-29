const double varas_manzana = 1428.8;

double ancho = 5; 

Console.WriteLine("Ingrese la longitud del terreno en varas");
double longitud = Convert.ToDouble (Console.ReadLine());

double area_varas2 = longitud * ancho;
double area_manzanas = area_varas2 / varas_manzana;
Console.WriteLine($"El area del terreno en manzanas es: {area_manzanas:F4} manzanas");
