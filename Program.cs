// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.
//example:
          //a = 5; b = 7 ->  max = 7
          //a = 2 b = 10 -> max = 10
          //a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите число:");
// int Number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число:");
// int Number2 = Convert.ToInt32(Console.ReadLine());

// if (Number2>Number1)
// {
//   Console.Write("являеться большим:");
//   Console.WriteLine(Number2);
//   Console.Write("являеться меньшим:");
//   Console.WriteLine(Number1);
// }
// else
// {
//   Console.Write("являеться большим:");
//   Console.WriteLine(Number1);
//   Console.Write("являеться меньшим:");
//   Console.WriteLine(Number2);
// }



// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.

// Console.WriteLine("Введите число:");
// int Number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число:");
// int Number2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число:");
// int Number3 = Convert.ToInt32(Console.ReadLine());
// int NumberMax = Number1;
// if (Number2>NumberMax)
// {
//   NumberMax = Number2;
// }
// if (Number3>NumberMax)
// {
//   NumberMax = Number3;
// }
// Console.Write("максимальное число: ");
// Console.WriteLine(NumberMax);


//Задача 6: Напишите программу, которая на вход принимает число и выдает, 
//является ли число четным (делится ли оно на два без остатка).


// Console.WriteLine("Введите число:");
// int Number1 = Convert.ToInt32(Console.ReadLine());
// if (Number1%2==0)
//  {
//     Console.Write(Number1);
//     Console.WriteLine(" - четное");
//  }
//  else 
//  {
//      Console.Write(Number1);
//      Console.WriteLine(" - не четное");
//  }
 



//  Задача 8: Напишите программу, которая на вход принимает число (N),
//   а на выходе показывает все чётные числа от 1 до N.


Console.WriteLine("Введите число:");
int Number1 = Convert.ToInt32(Console.ReadLine());
int N = 0;
int NumberZnak=Number1;
Number1=Math.Abs(Number1);
while(N<Number1)
{
  N=N+1;
 if (N%2==0)
 {
    if (NumberZnak>0)
    { 
    Console.Write(N);
    Console.Write(" ");
    }
    else 
    {
      Console.Write(-N);
      Console.Write(" ");
    }
 }
}
if (Number1<=1)
{
 Console.WriteLine("Чётные числа соответствующие условию от 1 до N отсутствуют"); 
}



