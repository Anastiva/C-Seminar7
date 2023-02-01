//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArrayRandomNumbers(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
        }
    }
}

void PrintArray(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
            Console.WriteLine("");
    }
}

Console.WriteLine("Введите число столбцов m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, m];
FillArrayRandomNumbers(matrix);

Console.WriteLine();
PrintArray(matrix);
Console.WriteLine(" ");

for (int j = 0; j < matrix.GetLength(1); j++)
{
    double average = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        average = (average + matrix[i, j]);
    }
    average = average / n;
    Console.Write(average + "; ");
}


