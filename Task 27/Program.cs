namespace ConsoleAppTask27
{
	internal class Program
	{
		static int sumNumbers(int N)
		{
			int ost, sum = 0;
			while (N != 0)
			{
				ost = N % 10;
				N = N / 10;
				sum += ost;
			}
			
			return sum;
		}
        

		static void Main(string[] args)
		{
			int N;

			Console.Write("Введите число: ");

			while(!int.TryParse(Console.ReadLine(), out N))
			{
				Console.WriteLine("\nНеверный ввод, введите число");
				Console.Write("\nВведите число: ");
			}

			Console.WriteLine("\nСумма цифр числа " + N + " = " + sumNumbers(N));

			Console.ReadLine();
		}
	}
}

