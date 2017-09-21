using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CristalleGanerLab02
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello Tim, Dillan!");
			Console.WriteLine("Hello \"World!\"");
			string name = "Jude";
			string greeting = "hello";
			Console.WriteLine("{0} {1}", greeting, name);
			Console.WriteLine(greeting + " " + name);
			Console.WriteLine(greeting + "{greeting} {name}");
			Console.WriteLine($"{greeting} {name}");

			int intPi = 22 / 7;
			float floatPi = 22f / 7f;
			double doublePi;
			decimal decimalPi; 
			doublePi = 22d / 7d;
			decimalPi = 22m / 7m;
			Console.WriteLine("int Pi" + intPi);
			Console.WriteLine("floatPi" + floatPi);
			Console.WriteLine("doublePi" + doublePi);
			Console.WriteLine("decimalPi" + decimalPi);
			Console.Write("Enter a name: ");
			string name = Console.ReadLine();
			string greeting;
			Console.Write("Enter a greeting: ");

		}
	}
}
