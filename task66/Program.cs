/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.*/
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
int SumNumber(int m, int n)
{
    // Базовый случай
    if (m > n) return 0; 
         
    // Рекурсивный случай
    return (m + SumNumber(m+1, n));
}
Console.WriteLine(SumNumber(M, N));







/*Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6*/
// [1;N] = 1,2,3,4,5
/// Комментарии к методу
/// start - начало, то есть, число 1 по условию
/// end - конец или число N
/*int N = Convert.ToInt32(Console.ReadLine());
string PrintNumbers(int start, int end)
{
    // Базовый случай
    if (start == end) return start.ToString(); // start - int, а метод возращает строчку
    // Рекурсивный случай
    return (start + ", " + PrintNumbers(start + 1, end));
}

Console.WriteLine(PrintNumbers(1, N));*/

/*Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"*/

/*int N = Convert.ToInt32(Console.ReadLine());
int M = Convert.ToInt32(Console.ReadLine());
string PrintNumbers(int start, int end)
{
    // Базовый случай
    if (start == end) return start.ToString(); // start - int, а метод возращает строчку
    // Рекурсивный случай
    return (start + ", " + PrintNumbers(start + 1, end));
}

Console.WriteLine(PrintNumbers(M, N));*/

/* Задача 67: Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int num)
{
    // Базовый случай
    if (num == 0) return 0; // 45 -> 4+5+0 = 9; sum + 0 = sum
    // Рекурсивный случай
    return (num % 10 + SumNumber(num / 10)); // num%10 => ПОСЛЕДНЯЯ цифра числа

}*/

/*возведение в степень*/
/*int number = Convert.ToInt32(Console.ReadLine()); // A

int degree = Convert.ToInt32(Console.ReadLine()); // B

int Power(int number, int power)
{
    // Базовый случай
    if (power == 0) return 1;
    if (power == 1) return number;
    // Рекурсивный случай
    return (number * Power(number, power - 1));
}

Console.WriteLine(Power(number, degree));*/







