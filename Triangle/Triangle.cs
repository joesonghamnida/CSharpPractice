using System;
namespace Triangle
{
	public class Triangle
	{
		double height = 0.0;
		double triangleBase = 0.0;

		public void setArea() {
			height = 8;
			triangleBase = 10;
		}

		public double calculateArea()
		{
			return (height * triangleBase) / 2;
		}

		public void display() {
			Console.WriteLine("Height: {0}", height);
			Console.WriteLine("Base: {0}", triangleBase);
			Console.WriteLine("Area : {0}", calculateArea());
		}
	}

	public class executeTriangle{
		public static void Main(string[] args) {
			Triangle t = new Triangle();
			t.setArea();
			t.setArea();
			t.display();
		}
	}
}
