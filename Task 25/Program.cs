namespace ConsoleAppTask25
{
	internal class Program
	{
		static int powN(int A, int B)
		{
			int number = 1;
			for (int i = 1; i <= B; i++)
			{
				number *= A;
			}

			return number;
		}
		static void Main(string[] args)
		{
			int A, B;

			Console.Write("Введите число которое необходимо возвести в степень: ");

			while (!int.TryParse(Console.ReadLine(), out A))
			{
				Console.WriteLine("\nНеверный ввод, введите число!");
				Console.Write("\nВведите число которое необходимо возвести в степень: ");
			}

			Console.Write("Введите степень числа: ");

			while (!int.TryParse(Console.ReadLine(), out B))
			{
				Console.WriteLine("\nНеверный ввод, введите число!");
				Console.Write("\nВведите число которое необходимо возвести в степень: ");
			}

			Console.Write("\nЧисло " + A + " в степени " + B + " = " + powN(A, B));

			Console.ReadLine();
		}
	}
}

			




