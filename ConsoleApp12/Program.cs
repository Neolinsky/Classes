using System;

namespace ConsoleApp12
{
	class Program
	{
		static void Main(string[] args)
		{

			Transport[] transport = new Transport[5];

			transport[0] = new Car("Black", 123543.54, 300.1, 9.0);

			transport[1] = new Bycicle("Purpul", 12382.12, "MBX");

			transport[2] = new Holicopter("Fast", 123000, "Invisible", 0);

			transport[3] = new SpaceShatel("White", 1982391823, "Dragon", "SpaceX");

			foreach (Transport t in transport)
			{
				t.Move();
			}
		}
	}


	class Car : Transport
	{
		
		

		public double MaxSpeed;
		

		public double AccelerationPerSecond;
		public double CurrentSpeed = 0;

		public Car(
			string color,
			double price,
			double maxSpeed,
			double accelerationPerSecond
			) : base (color, price)
		{
			this.color = color;
			this.price = price;
			MaxSpeed = maxSpeed;
			AccelerationPerSecond = accelerationPerSecond;
		}

		
		public double Accelerate(double currentSpeed, double maxSpeed)
		{
			double timeToAccelerateToTopSpeed;

			timeToAccelerateToTopSpeed = (maxSpeed - currentSpeed) / AccelerationPerSecond;

			return timeToAccelerateToTopSpeed;
		}


		public override void Move()
		{
			Console.WriteLine("I'm moving: Beep-beep!!");
		}
	}

	class Bycicle : Transport
	{		
		string Weight;
		string type;

		public Bycicle(
			string color,
			double price,
			string type
			) : base (color, price)
		{
			this.type = type;
			this.color = color;
			this.price = price;
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

		public override void Move()
		{
			Console.WriteLine("I'm moving: Horn-Horn!");
		}

	}

	class Holicopter : Transport
	{
		
		string Type;
		double TopSpeed;


		public Holicopter
			(
			string type,
			double topspeed,
			string color,
			double price
			) : base(color, price)

		{
			this.color = color;
			this.price = price;
			this.Type = type;
			this.TopSpeed = topspeed;
		}

		public override void Move()
		{
			Console.WriteLine("I'm Flying: Whzuh-Whzuh!");
		}

		


	}

	class SpaceShatel : Transport
	{
		string Destination;
		string Name;

		double MaxSpeed;
		string WhoCreated;

		public SpaceShatel(string color, double price, string name, string whoCreated) : base(color,price)
		{
			Name = name;
			WhoCreated = whoCreated;
			this.color = color;
			this.price = price;
		}

		public string GetDestination()
		{
			return Destination;
		}


		public void SetDestination(string destination)
		{
			Destination = destination;
		}

		public override void Move()
		{
			Console.WriteLine("Zoom-zoom-zoom, I'm going to the Moon!");
		}
	}
}
