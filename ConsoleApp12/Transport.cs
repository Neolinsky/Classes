using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
	class Transport
	{
		protected string color;
		protected double price;


		public Transport(string color, double price)
		{
			this.color = color;
			this.price = price;
		}

		public virtual void Move()
		{
			Console.WriteLine("I'm moving");
		}

	}
}
