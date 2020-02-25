using System;
using CalculationLogic;
namespace CalculatorUI
{
	class Calculator
	{
		static void Main()
		{
			int a = 10;
			int b = 20;
			int addRes = Calculation.Add(a,b);
			int subRes = Calculation.Subtract(a,b);	
			Console.WriteLine("Addition Result: " + addRes);
			Console.WriteLine("Subtraction Result: " + subRes);
		}
	}
}
