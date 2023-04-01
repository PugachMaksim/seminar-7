/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


int a;
int b;
Console.WriteLine("Введите размер массива");
int.TryParse(Console.ReadLine(), out a);
int.TryParse(Console.ReadLine(), out b);
double[,]array = new double[a, b];
void NewArray(double[,]array)
{
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(11);
            Console.Write($"{array[i,j],-3}");
        }
        Console.WriteLine();
    }
}
NewArray(array);

void PoiskSredego(double[,]massiv)
{
    Console.Write("Среднее арифмитическое каждого столбца: ");    
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        int i = 0;
        double sum = 0;
        while (i < massiv.GetLength(0))
        {
            sum = sum + massiv[i,j];
            i++;
        }
        
        double sr = Math.Round(sum / massiv.GetLength(1), 1);
        Console.Write($" {sr}  ");
    }
    Console.WriteLine();
}
PoiskSredego(array);