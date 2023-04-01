/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
int m;
int n;
Console.WriteLine("vvedite kolichestvo strok: ");
int.TryParse(Console.ReadLine(), out m);
Console.WriteLine("vvedite kolichestvo stolbcov: ");
int.TryParse(Console.ReadLine(), out n);

double[,]massiv = new double[m, n];

for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        massiv[i,j] = new Random().Next(-10, 10) + Math.Round((new Random().NextDouble()), 1);
        Console.Write($"{(massiv[i, j]),5}");
    }
    Console.WriteLine();
}
Console.WriteLine();