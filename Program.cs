using System;
using System.Collections.Generic;
// Test commit from studio
namespace Practic
{

	class Program
	{
		static void Main(string[] args)
		{
			MyClass ticket = new MyClass();
			ticket.IsLuckyTicket(Console.ReadLine());
		}

		class MyClass
		{
			public MyClass()
            {
				Dictionary<int, string> country = new Dictionary<int, string>();
				country.Add(1, "Russia");
				country.Add(2, "USA");
				
			}

			public bool IsLuckyTicket(string ticket)
			{
				int Ticket = Convert.ToInt32(ticket);
				int firstThree = Ticket / 1000;
				int secondTree = Ticket % 1000;
				int result1 = 0;
				int result2 = 0;
				for (int i = 0; i < 3; i++)
                {
				    result1 += firstThree % 10;
					firstThree /= 10;
					result2 += secondTree % 10;
					secondTree /= 10;
				}
				if (result1 == result2)
				{
					Console.WriteLine("Lucky");
					return true;
				}
				else
				{
					Console.WriteLine("Not lucky");
					return false;
				}
			}
		}
	}
}
