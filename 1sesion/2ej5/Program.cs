using System;

Console.Write("Introduce el volumen promedio de leche por vaca (en litros): ");
double volumenPorVaca = Convert.ToDouble(Console.ReadLine());

Console.Write("Introduce el número total de vacas ordeñadas: ");
int numeroVacas = Convert.ToInt32(Console.ReadLine());

double totalLeche = volumenPorVaca * numeroVacas;

int baldesCompletos = (int)(totalLeche / 20);
double lecheSobrante = totalLeche % 20;

Console.WriteLine($"\nCantidad total de baldes completos: {baldesCompletos}");
Console.WriteLine($"Leche sobrante que no llena un balde completo: {lecheSobrante} litros");