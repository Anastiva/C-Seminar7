//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7(ввод индексов) -> такого числа в массиве нет
//1, 1 -> 9
void FillArrayWithRandom(int[,] matrix, int m, int n)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            matrix[i,j] = new Random().Next(-10,11);
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[m,n];
FillArrayWithRandom(matrix, m, n);

Console.WriteLine("Введите число i: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число j: ");
int j = Convert.ToInt32(Console.ReadLine());
if (i > m && j > n)
{
    Console.WriteLine("Такого числа в массиве нет");
}
else
{
    object c = matrix.GetValue(i,j);
    Console.WriteLine($"Значение искомого элемента: {c}");
}

