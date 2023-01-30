namespace ConsoleAppTask29
{
	internal class Program
	{

		static int[] enterElementArray(int []array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write("Введите {0} элемент массива: ", i+1);
				while (!int.TryParse(Console.ReadLine(), out array[i]))
				{
					Console.WriteLine("\nНеверный ввод, введите число");
					Console.Write("\nВведите {0} элемент массива: ", i+1);
				}
			}

			return array;
		}

		static void printArrayFor(int []array) //Вывод с помощью цикла
		{
			Console.Write("\n\nВывод с помощью цикла: ");
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write(array[i] + " ");
			}
		}

		static void printArrayJoin(int[] array) //Вывод с помощью метода строки
		{
			Console.Write("\n\nВывод с помощью метода строки: ");
			Console.WriteLine("[{0}]", string.Join(", ", array));
		}

		static void Main(string[] args)
		{
			int[] array = new int[8];

			enterElementArray(array);
			printArrayFor(array);
			printArrayJoin(array);
			Console.ReadLine();
		}
	}
}
