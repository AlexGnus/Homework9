/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
int AkkerFunction(int m, int n)
		{
			if(m == 0)
			{
				return n + 1;
			}
			if(m > 0 && n == 0)
			{
				return AkkerFunction(m - 1, 1);
			}
			return AkkerFunction(m - 1, AkkerFunction(m, n - 1));
		}
		
		Console.WriteLine(AkkerFunction(M,N));
	
