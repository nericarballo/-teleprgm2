using System;


public abstract class figura 
{
	public float pi = 3.14159F;
	private float a =0; 
	float b =0;
	float c =0;
	float d =0;
	float e =0; /*para asignar valores, no muy especifico de manera que se pueda usar en varias formas con mayor facilidad.
	5 valores porque es lo que necesita el que más necesita: Triangulo.
	*/
	 public float A
        {	get { return this.a; }
            set { this.a = value; }}
	public float B
        {	get { return this.b; }
            set { this.b = value; }}
	public float C
        {	get { return this.c; }
            set { this.c = value; }}
	public float D
        {	get { return this.d; }
            set { this.d = value; }}
	public float E
        {   get { return this.e; }
            set { this.e = value; }}
	
	public abstract float perimetro {get;}
	public abstract float area {get;}
	public override string ToString (){
	return string.Format("el perímetro de la figura es de {0} unidades y su área es de {1} unidades cuadradas\n", perimetro, area); 
	// oughta make a Perímetro and Area for each one, si queda tiempo no se te olvide revisar si le puedes dar un nombre a esto.
	}
}

public class triangulo:figura {
	public override float perimetro {get{return (A+B+C);}}
	public override float area {get{return ((D*E)/2);}}
	   public triangulo(float lado1, float lado2, float lado3, float piso, float altura)
   {
      A = lado1;
      B = lado2;
	  C = lado3;
	  D = piso;
	  E = altura;
   }

}
public class cuadrilatero:figura {
	public override float perimetro {get{return (2*A+2*B);}}
	public override float area {get{return (A*B);}}
	public cuadrilatero(float lado1, float lado2)
   {
	  A = lado1;
      B = lado2;	 
   }
}
public class circulo:figura {
	public override float perimetro {get{return (2*pi*A);}}
	public override float area {get{return ((float)Math.Pow(A, 2.0));}}
	public circulo (float radio)
   {
      A = radio;
   }
}
public class elipse:figura {
	public override float perimetro {get{return (pi*(3*(A+B)- (float)Math.Sqrt(((3*A)+B)*(A+(3*B)))));}} 
	public override float area {get{return (pi*A*B);}}
	public elipse(float radio1, float radio2)
   {
      A = radio1;
      B = radio2;
   }
}



public class Program
{
	public static void Main(String []args)
	{
		int 
		cuad=0, 
		rect=0,
		circ=0,
		elip=0, 
		trian=0; 
		
		 //contadores de figuras individuales
		
		
		Console.Write("Numero de figuras en la imagen:");
		int i = Int32.Parse(Console.ReadLine()); 
		
		figura [] figuras = new figura [i];
		int j=0;
		while (j<i)  //iniciador de bucle
			{
    		Console.Write("Tipo de figura: \n1) cuadrado \n2) rectangulo \n3) circulo  \n4) elipsis \n5) triangulo \n");
			int t= Int32.Parse(Console.ReadLine());
			
			if (t==1) {Console.WriteLine("Tamaño de sus lados:");
					  float lado = float.Parse(Console.ReadLine());
					  figuras [j] = new cuadrilatero (lado, lado);
					  Console.Write("con ese valor tenemos que ");
					  Console.Write(figuras [j]); 
					  cuad++;
					  }	
			else if (t==2){Console.WriteLine("Tamaño de sus lados:");
					  figuras [j] = new cuadrilatero (float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
					  Console.Write("con esos valores tenemos que ");
					  Console.Write(figuras [j]); 
					  rect++;   
					   }
			else if (t==3){Console.WriteLine("Tamaño de su radio:");
					  figuras [j] = new circulo (float.Parse(Console.ReadLine()));
					  Console.Write("con ese valor tenemos que ");
					  Console.Write(figuras [j]); 
					  circ++;
					   }
			else if (t==4){Console.WriteLine("Tamaño del semieje menor, y el semieje mayor:");
					  figuras [j] = new elipse (float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
					  Console.Write("con esos valores tenemos que ");
					  Console.Write(figuras [j]); 
					  elip++;	   
					   }
			else if (t==5){Console.WriteLine("Tamaño de sus 3 lados, seguido de su base y altura, en ese orden:");
					  figuras [j] = new triangulo (float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
					  Console.Write("con esos valores tenemos que ");
					  Console.Write(figuras [j]); 
					  trian++;
					   }
			else {Console.WriteLine("por favor, pruebe una de las opciones dadas.");} 
			// esto porque se supone que es un programa de prueba, la idea es que solo sean imagenes siendo analizadas.	
			j++;
            }
			Console.WriteLine("Con esto se analizaron las {0} figuras de la imagen, siendo de estas: \n{1} cuadrados \n{2} rectangulos \n{3} circulos  \n{4} elipsis \n{5} triangulo \nTenga un fantastico día!",
							 i, cuad, rect, circ, elip, trian); 
		
	}
}