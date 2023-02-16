//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/*void ShowNums(int num)
{
     Console.Write(num + " ");

    if(num > 1) ShowNums(num - 1);
    Console.Write(num + " ");
}
ShowNums(5)*/


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/* int GetSum(int m, int n)
{
    int x = m;
	int y = n;
	if(m > n)
		{
			x = n;
			y = m;
		}
	return (y + x)*(y - x + 1)/2; 
}
		
Console.WriteLine(GetSum(1, 15));

 */


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akk(int m, int n)
{
    if (m == 0)
        return n + 1;
    
    else
      if ((m != 0) && (n == 0))
        return Akk(m - 1, 1);
    else
        return Akk(m - 1, Akk(m, n - 1));
      
}

Console.WriteLine("введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("A(n,m) = " + Akk(m,n));