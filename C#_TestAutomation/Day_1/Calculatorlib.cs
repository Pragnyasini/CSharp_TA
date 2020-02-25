using System;
namespace CalculationLogic
{
	public class Calculation
	{
		public static int Add(int firstValue, int secondValue)
		{
			int result = firstValue + secondValue;
			
			return result;
		}
		
		public static int Subtract(int firstValue, int secondValue)
		{
			int result = secondValue - firstValue;
			
			return result;
		}
	}
}