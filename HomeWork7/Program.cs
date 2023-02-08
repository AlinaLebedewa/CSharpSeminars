//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*int[,] CreateRandom2dArray()
{   
    
    Console.Write("Input a numbers of rows:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a numbers of columns:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value:");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value:");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue,maxValue + 1);
    
    return array;
        
    }

    void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)

            Console.Write (array[i,j] + " ");
        Console.WriteLine();
    }
      Console.WriteLine();
}

void ArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next()) / 10;
        }
    }
}

Console.WriteLine("введите количество строк:");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[lines, columns];
ArrayRandomNumbers(numbers);
Show2dArray(numbers);*/


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*int[,] CreateRandom2dArray()
{   
    
    Console.Write("Input a numbers of rows:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a numbers of columns:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value:");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value:");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue,maxValue + 1);
    
    return array;
        
    }

   void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)

            Console.Write (array[i,j] + " ");
        Console.WriteLine();
    }
      Console.WriteLine();
}

int Elements(int[,] array, int m, int n)
{
    int number = 0;
   
        if (m <= array.GetLength(0) || n <= array.GetLength(1))
        {
            number = array[m,n];
            Console.WriteLine("Значение элемента: " + number);

            
        }
        
            else Console.WriteLine("число отсутствует");
        
    
    return number;
     
}


Console.Write("введите первую цифру :");
int m= Convert.ToInt32(Console.ReadLine());
Console.Write("введите вторую цифру позиции :");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

int result = Elements(myArray, m, n);
Console.WriteLine(result);*/


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*int[,] CreateRandom2dArray()
{   
    
    Console.Write("Input a numbers of rows:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a numbers of columns:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value:");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value:");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue,maxValue + 1);
    
    return array;
        
    }

    void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)

            Console.Write (array[i,j] + " ");
        Console.WriteLine();
    }
      Console.WriteLine();
}


double[] AverageOfElements (int[,] array)
{  
double[] result = new double[array.GetLength(1)];
for(int j = 0; j < array.GetLength(1); j++)
    
    {
        for(int i = 0; i < array.GetLength(0); i++)
            result[j] += array[i,j];
        result[j] = result[j] / array.GetLength(0);
    }
    return result;
}

void ShowAverageOfElements(double[] elements)
{
    for(int i = 0; i < elements.GetLength(0); i++)
            Console.Write (elements[i] + " ");
        Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

double[] getAverage = AverageOfElements(myArray);
Console.WriteLine("Среднее арифметическое элементов в каждом столбце: ");
ShowAverageOfElements(getAverage);*/