//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


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

void ChangeArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
            }   }
        }
    }
      
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
ChangeArray(newArray);
Show2dArray(newArray);*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int NumberRowMinSumElements(int[,] array)
    
{
    int row = 0;
    int minsum = 0;
    for (int i = 0, j = 0; j < array.GetLength(1); j++)
        minsum = minsum + array[i, j];
      
       for (int i = 1; i < array.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
                sum += array[i,j];
            if (sum < minsum)
            {
                minsum = sum;
                row = i;
            }
        }
         return row + 1;
   
}
      
int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

Console.WriteLine("Number of row with minimum sum of elements: " + NumberRowMinSumElements(newArray))*/


//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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


int [,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB)
    {
      int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
      if(arrayA.GetLength(1) == arrayB.GetLength(0))
      {
        for (int i = 0; i < arrayA.GetLength(0); i++)
            for (int j = 0; j < arrayB.GetLength(1); j++)
        {       
            arrayC[i, j] = 0;
            for (int k = 0; k < arrayA.GetLength(1); k++)
                
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            
        }
      }
      return arrayC;
    }
  
int[,] arrayA = CreateRandom2dArray();
int[,] arrayB = CreateRandom2dArray();
Show2dArray(arrayA);
Show2dArray(arrayB);

Show2dArray(GetMultiplicationMatrix(arrayA, arrayB));*/


//Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*int[,,] CreateRandom3dArray()
{   
    
    Console.Write("Input a numbers of first element:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a numbers of second element:");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a numbers of third element:");
    int c = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Input a min possible value:");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value:");
    int maxValue = Convert.ToInt32(Console.ReadLine());


    int[,,] array = new int[a, b, c];
    for (int i = 0; i < a; i++)
    
        for (int j = 0; j < b; j++)
        
            for (int x = 0; x < c; x++)
            
              array[i, j, x] = new Random().Next(minValue,maxValue + 1);  
            
        
    
    return array;
}

void Show3dArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)

        for(int x = 0; x < array.GetLength(1); x++)     
            Console.Write (array[i, j, x] + $"({i}, {j}, {x})");
        Console.WriteLine();
    }
    Console.WriteLine();
}

 int[,,] newArray = CreateRandom3dArray();
Show3dArray(newArray);*/  

