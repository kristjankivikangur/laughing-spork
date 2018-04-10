using System;

namespace TereMaailm
{
	internal class Tervitaja
	{
		/// <summary>
		/// Kuvab ekraanile tervitus teksti
		/// </summary>
		/// <param name="keda">nimi, keda tervitatakse</param>
		internal static void Tervita(string keda)
		{
			Console.WriteLine("Tere {0}.", keda);
		}
	}
}