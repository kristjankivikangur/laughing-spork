﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TereMaailm
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Tere Maailm.");
			Console.WriteLine("Tervitused GitHubist");
			Console.WriteLine("Minu poolt samuti. Tervist.");
			Tervitaja.Tervita("Maailm");
			Tervitaja.Tervita(new string[] { "Kristjan", "Jaan", "Toomas" });
		}
	}
}
