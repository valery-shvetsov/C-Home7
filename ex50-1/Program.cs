// Напишите программу, которая на вход принимает число 
// и возвращает позицию (i, j) этого элемента 
// или же указание, что такого элемента нет.

int ReadDate(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}
int[,] InitArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rnd.Next(-10, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
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

//main
int m = ReadDate("Введите количество строк массива: ");
int n = ReadDate("Введите количество столбцов массива: ");
int checknamber = ReadDate("Введите проверяемое число: ");
int[,] RealArray = InitArray(m, n);
PrintArray(RealArray);

int cont = 0;
//int[,] arrayNew = new int[arrayNew.GetLength(0), arrayNew.GetLength(1)]; 

for (int i = 0; i < RealArray.GetLength(0); i++)
{
    for (int j = 0; j < RealArray.GetLength(1); j++)
    {
        if (RealArray[i, j] == checknamber)
        {
            Console.WriteLine($"Число {checknamber} есть в этом массиве");
            Console.WriteLine($"строка {i + 1} столбец {j + 1}");
        }
        else
        {
            cont = cont + 1;
        }
    }
}
if (cont == RealArray.GetLength(0) * RealArray.GetLength(1))
{
    Console.WriteLine($"Число {checknamber} в этом массиве отсутствует");
}




