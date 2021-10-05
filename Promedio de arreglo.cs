using System; 
using System.Linq;

//conseguí que System.Linq tenía método average justo para esto, así que elo aquí:
					
public class Program
{
	public static void Main(string[] args)
	{		 
	double[] personaspa = {20, 35, 85, 10, 15, 43, 100, 23};
	double promedio = personaspa.Average();  
	Console.WriteLine("Promedio: " + promedio);
	}
}
