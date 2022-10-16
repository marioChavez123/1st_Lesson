using System;
namespace _1st_Lesson
{
	class Excercises
	{
        public static double Fact(int num)
        {
            if (num == 0 || num == 1)
                return 1;
            return num * Fact(num - 1);
        }
        static void Main(string[] args)
			{
				#region Excercise first level number 4
				Console.Write("Introduce the value of x: ");
				double sumatory = 0;
				double x = Double.Parse(Console.ReadLine());
				for (int i = 1; i <= 9; i++)
				{
					double k = i - 1;
					double s = Math.Cos(x * i) / Math.Pow(x, k);
					s = Math.Round(s, 2);
					sumatory += s;
					Console.WriteLine($"S{i} = {s}");
					if (i >= 9)
					{
						Console.WriteLine("The sum is: " + Math.Round(sumatory, 2));
					}
				}
				#endregion
				#region Excercise first level number 9 
				double sum = 0;
				for (int i = 1; i <= 6; i++)
				{
					//Console.WriteLine(Fact(i));
					double s = Math.Pow(-1, i) * (Math.Pow(5, i) / Fact(i));
					Console.WriteLine($"S{i} = {s}");
					sum += s;
					if (i >= 6)
					{
						Console.WriteLine(sum);
					}
				}
				#endregion
				#region Excercise first level number 15
				Console.Write("Introduce the n term: ");
				double dividend, divisor = 1;
				int n = Int32.Parse(Console.ReadLine());
				for (int i = 1; i <= n; i++)
				{
					dividend = i;
					if (i % 2 == 0)
					{
						divisor++;
					}
					Console.WriteLine($"n{i}: {dividend} / {divisor}");
				}
				#endregion
				#region Excercise first level number 16
        double SumGrains = 1.0;
        int gram = 15;
        double AmountOfGrainGrams;
        for(int NumberCell = 0; NumberCell < 64; NumberCell++){
        SumGrains += Math.Pow(2,NumberCell);
        }
        AmountOfGrainGrams = SumGrains / gram; 
        Console.WriteLine($"Task16 {AmountOfGrainGrams}");
				#endregion
				#region Excercise first level number 18
				int cells = 10;
				for (int h = 3; h <= 24; h += 3)
				{
					cells *= 2;
					Console.WriteLine(cells);
				}
                #endregion
		}	
	}
}
