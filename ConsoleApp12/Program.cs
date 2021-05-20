using System;

namespace ConsoleApp12
{
	class Program
	{
		static void Main(string[] args)
		{


			Car car = new Car("Mersedes", 250000, 280, 8);

			Console.WriteLine($"Time to get to top speed: {car.Accelerate(0, car.MaxSpeed)}");

			car.Beep();

			Console.WriteLine();
			Console.WriteLine();


			Bycicle bycicle = new Bycicle("Red");

			Console.WriteLine($"I'm {bycicle.GetColor()}");
			Console.WriteLine($"My price is: {bycicle.getPrice((bycicle.Color))}");

			Holicopter holicopter = new Holicopter("Cion", 1000000.74);

			Console.WriteLine();
			Console.WriteLine();

			Console.WriteLine($"Look {holicopter.Fliying()}");
			Console.WriteLine($"The price is: {holicopter.GetPrice()}");

			Console.WriteLine();
			Console.WriteLine();

			SpaceShatel spaceShatel = new SpaceShatel("Bruuahh", "SpaceX");

			spaceShatel.SetDestination("Mars");
			Console.WriteLine($"Destenation is the {spaceShatel.GetDestination()}");

		}
	}


	class Car
	{
		string Color;
		string Mark;

		public double MaxSpeed;
		double Price;

		public double AccelerationPerSecond;
		public double CurrentSpeed = 0;

		public Car(string mark, double price, double maxSpeed, double accelerationPerSecond)
		{
			Mark = mark;
			Price = price;
			MaxSpeed = maxSpeed;
			AccelerationPerSecond = accelerationPerSecond;
		}

		
		public double Accelerate(double currentSpeed, double maxSpeed)
		{
			double timeToAccelerateToTopSpeed;

			timeToAccelerateToTopSpeed = (maxSpeed - currentSpeed) / AccelerationPerSecond;

			return timeToAccelerateToTopSpeed;
		}


		public void Beep()
		{
			Console.WriteLine("Beep-beep!!");
		}
	}

	class Bycicle
	{
		public string Color;
		string Weight;

		double Price;
		string Type;

		public Bycicle(string color)
		{
			Color = color;
		
		}

		public  string GetColor()
		{
			return Color;
		}

		public double getPrice(string color)
		{
			double price;

			if(color.ToLower() == "white")
			{
				price = 10000;
			}
			else
			{
				price = 15000;
			}

			return price;
		}

	}

	class Holicopter
	{
		string Color;
		string Type;


		double Price;
		double TopSpeed;


		public Holicopter(string color, double price)
		{
			Price = price;
			Color = color;
		}

		public string Fliying()
		{
			return "The holicopter is flying *Loud noise!*";
		}

		public double GetPrice()
		{
			return Price;
		}


	}

	class SpaceShatel
	{
		string Destination;
		string Name;

		double MaxSpeed;
		string WhoCreated;

		public SpaceShatel(string name, string whoCreated)
		{
			Name = name;
			WhoCreated = whoCreated;
		}

		public string GetDestination()
		{
			return Destination;
		}


		public void SetDestination(string destination)
		{
			Destination = destination;
		}
	}
}
