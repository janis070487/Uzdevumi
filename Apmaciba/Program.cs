using System;

namespace Apmaciba // OK
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] arr;
			int size = 0;
			while (!(size > 0))
			{
				Console.WriteLine("Ievadi elementu skaitu");
				try
				{
					size = int.Parse(Console.ReadLine());
				}
				catch (Exception)
				{
					Console.WriteLine(" Ievadiet vesalu pozitīvu skaitli");
				}
			}
			arr = new int[size];
			Console.WriteLine();
			for (int i = 0; i < arr.Length; i++)
			{
				bool status = true;
				while (status)
				{
					Console.WriteLine("ievadi " + (i + 1) + ". elementu");
					try
					{
						arr[i] = int.Parse(Console.ReadLine());
						status = false;
					}
					catch (Exception)
					{
						Console.WriteLine(" Ievadi tikai pozitīvus veselus skaitlus");
						//status = false;
					}
					//
					
				}
			}
			Console.WriteLine("___________REZULTĀTS_______");
			Console.WriteLine();
			int summ = 0;
			int min = arr[0];

			for (int ii = arr.Length; ii > 0; ii--)
			{
				Console.WriteLine(arr[ii - 1]);
				if(arr[ii - 1] % 2 == 0)
                {
					summ = summ + arr[ii - 1];
                }

                if (arr[ii - 1] < min)
                {
					min = arr[ii - 1];
                }
			}

			Console.WriteLine("Pāra skaitļu summa masīvā = " + summ);
			Console.WriteLine();
			Console.WriteLine("Mazākais elements masīvā = " + min);
			Console.ReadLine();
			//_________________________________________________________________
		}
    }
}
