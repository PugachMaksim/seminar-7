/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,]array = new int[3, 4];

array[0, 0] = 1;
array[1, 0] = 5;
array[2, 0] = 8;

array[0, 1] = 4;
array[1, 1] = 9;
array[2, 1] = 4;

array[0, 2] = 7;
array[1, 2] = 2;
array[2, 2] = 2;

array[0, 3] = 2;
array[1, 3] = 3;
array[2, 3] = 4;

Console.WriteLine("В массиве:");

void PrintArray(int[ , ] name)
{
for (int i = 0; i < name.GetLength(0); i++)
    {
        for (int j = 0; j < name.GetLength(1); j++) 
        {
            Console.Write(name[i, j]);
        }
        Console.WriteLine();
    }
}

PrintArray(array);

int a;
int b;
Console.Write("Введите номер строки: ");
int.TryParse(Console.ReadLine(), out a);
Console.Write("Введите номер столбца: ");
int.TryParse(Console.ReadLine(), out b);

void Poisk(int [,]massiv, int a, int b)
{

        if (a > (massiv.GetLength(0) -1) || b > (massiv.GetLength(1) -1))
    {
        Console.WriteLine($"[{a}],[{b}] --> Данного значения нет");
    }
        else
    Console.WriteLine($"В координатах [{a}],[{b}] --> {array[a,b]}");
}

Poisk(array, a, b);