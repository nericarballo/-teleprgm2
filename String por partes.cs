using System;
					
public class Program
{
	public static void Main(string[] args)
	{
		
	
		String cadena = Console.ReadLine ();
		int i = 0;
		while (i != cadena.Length) 
		{ 
		if (Char.IsWhiteSpace(cadena[i]) == false) 
		{Console.Write(cadena[i]);}  
		else
		{Console.WriteLine();}
		 i++;
		}	
	}
}
