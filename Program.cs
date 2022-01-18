using System;

namespace AB05
{
	class Program
	{
		public static void Main(string[] args)
		{
			double prozentsatz, zinsen, kapital;

			prozentsatz = 0;
			zinsen = 0;
			kapital = 0;

			Console.WriteLine("Willkommen zum Prozentsatzrechner! :) \n");
			Console.WriteLine("Geben Sie das Kapital ein: ");
			kapital = double.Parse(Console.ReadLine());
			//Convert.ToDouble(Console.ReadLine);
			Console.WriteLine("Geben Sie nun die Zinsen ein: ");
			zinsen = double.Parse(Console.ReadLine());
			//Convert.ToDouble(Console.ReadLine);
			prozentsatz = (zinsen * 100) / kapital;
			Console.WriteLine("Der Prozentsatz für das Kapital von {0:F2} beträgt: {1:F2}", kapital, prozentsatz);
		}
	}
}