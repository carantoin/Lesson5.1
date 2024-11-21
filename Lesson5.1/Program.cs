char[,] matrix = new char[4, 4]
       {
            { '1', '2', '3', '4' },
            { '5', '6', '7', '8' },
            { '9', '0', '2', '3' },
            { '4', '5', '6', '7' }
       };


Console.WriteLine("Матрица символов:");
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}


int sum = 0;
for (int i = 0; i < 4; i++)
{
    sum += matrix[i, i];
}

Console.WriteLine($"Сумма кодов символов элементов главной диагонали: {sum}");