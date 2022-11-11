// ДЗ 9. Итоговое

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Console.Write("Введите целое число M ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите целое число N ");
// int n = Convert.ToInt32(Console.ReadLine());

// int Akkerman(int m, int n)
// {
//     if (m == 0) return n + 1;
//     if (m != 0 && n == 0) return Akkerman(m - 1, 1);
//     if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
// return Akkerman(m, n);
// }

// Console.WriteLine( Akkerman(m, n));

// Подсказка по ф-и Аккермана: при рекурсивном вызове этой функции надо в один из аргументов 
// подать рекурсивный вызов

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке
//  от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write ("Введите целое число ");
// int n = Convert.ToInt32(Console.ReadLine());
// int counter = 1;

// void PrintNumbers(int n, int counter)
// {
//     {
//     if (counter > n) return;
//     PrintNumbers(n, counter + 1);
//     Console.Write(counter + ", ");
//     }
// }

// PrintNumbers(n, counter);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write ("Введите целое число M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите целое число N ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = 0;

void SummOfElements(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов равна {sum} ");
    return;
  }
  SummOfElements(m, n - 1, sum);
}
SummOfElements(m, n, sum);
