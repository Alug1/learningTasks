using System;

class Program
{
    static void Main()
    {
        // Задаем размеры матрицы
        int rows = 8; // Количество строк
        int columns = 8; // Количество столбцов

        // Создаем матрицу
        int[,] matrix = new int[rows, columns];

        // Генератор случайных чисел (диапазон от 0 до 255)
        Random random = new Random();

        // Заполняем матрицу случайными числами
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = random.Next(0, 255); // Диапазон можно изменить
            }
        }

        // Выводим матрицу на экран
        Console.WriteLine("\nМатрица:\n");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j].ToString().PadLeft(3) + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nМатрица повернута на 90 градусов: \n");
        for (int j = 0; j < columns; j++)
        {
            for (int i = 0; i < rows; i++)
            {
                Console.Write(matrix[i, j].ToString().PadLeft(3) + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nМатрица повернута на 180 градусов:\n");
        for (int i = rows - 1; i >= 0; i--)
        {
            for (int j = columns - 1; j >= 0; j--)
            {
                Console.Write(matrix[i, j].ToString().PadLeft(3) + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nМатрица повернута на 270 градусов:\n");
        for (int j = columns - 1; j >= 0; j--)
        {
            for (int i = rows - 1; i >= 0; i--)
            {
                Console.Write(matrix[i, j].ToString().PadLeft(3) + " ");
            }
            Console.WriteLine();

        }

    }
}
