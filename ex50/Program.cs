// Напишите программу, которая на вход принимает число 
// и возвращает позицию (i, j) этого элемента 
// или же указание, что такого элемента нет.

int ReadDate(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}
int[,] InitArray(int n, int m)
{
    int[,] array = new int[n, m];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
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

void CheckArray(int[,] arrayNew, int number)
{
    int cont = 0;

    for (int i = 0; i < arrayNew.GetLength(0); i++)
    {
        for (int j = 0; j < arrayNew.GetLength(1); j++)
        {
            if (arrayNew[i, j] == number)
            {
                Console.WriteLine($"Число {number} есть в этом массиве");
                Console.WriteLine($"строка {i + 1} столбец {j + 1}");
            }
            else
            {
                cont = cont + 1;
            }
        }
    }
    if (cont == arrayNew.GetLength(0) * arrayNew.GetLength(1))
    {
        Console.WriteLine($"Число {number} в этом массиве отсутствует");
    }
}

//main
Console.Clear();
int n = ReadDate("Введите количество строк массива: ");
int m = ReadDate("Введите количество столбцов массива: ");
int checknamber = ReadDate("Введите проверяемое число: ");
int[,] RealArray = InitArray(n, m);
PrintArray(RealArray);
CheckArray(RealArray, checknamber);


