bool equal = Calculator.AreEqual(4,4);
Console.WriteLine(equal);
//bool equal = Calculator.AreEqual(“Nepal”, “Switzerland”);

public class Calculator
	{
		public static bool AreEqual(int value1, int value2)
			{
				return value1.Equals(value2);
			}
	}
