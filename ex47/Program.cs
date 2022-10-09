// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

int ReadDate(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

double[,] InitArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.Next(-10,10);
            array[i, j] = Convert.ToDouble(array[i, j]);
            //array[i, j]=array[i, j]/2;

        }
    }
    return array;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int m = ReadDate("Введите количество строк массива: ");
int n = ReadDate("Введите количество столбцов массива: ");
double[,] RealArray = InitArray(m, n);
PrintArray(RealArray);






