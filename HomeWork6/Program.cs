//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*int Numbers(int size)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        int numb = Convert.ToInt32(Console.ReadLine());
        if(numb > 0) count++;
    }
    return count;
  
}

 Console.Write("Imput a numbers of elements: ");
 int size = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine();
 Console.WriteLine($"Count elements > 0 = " + Numbers(size));*/




 

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/*void Intersections(double k1, double b1,double k2, double b2)
{   

    if (b1==b2 & k1==k2) Console.WriteLine("Прямые совпадают");
        else if (k1==k2) Console.WriteLine("Прямые параллельны друг другу");
            else 
        {
            double x =(b2-b1)/(k1-k2);
            double y =k1*x+b1;
            Console.WriteLine("точка пересечения "+" ("+ x+" ;"+y+ ")");
        }
}

Console.WriteLine("input b1:");
double b1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input k1:");
double k1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input b2:");
double b2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input k2:");
double k2=Convert.ToDouble(Console.ReadLine());

Intersections (k1,b2,k1,b2);*/