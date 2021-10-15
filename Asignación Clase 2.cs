using System;

public abstract class empleado {
    private string nombre;
    private int edad;
    private float salario;
	
	/* Getters y setters */
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public int Edad
    {
       get { return edad; }
       set { edad = value;}
    }
    public float Salario
    {get { return salario; }
       set { salario = value;}}
	
	 public abstract string función
    {get;}
	}

class Dealmacen : empleado {
      private int paquetellega;
      private int paqueteva;
	  private string desempeño;
      private int inventario; 
    
      public int Pll {
          get { return paquetellega; }
          set { paquetellega = value; }
      }

      public int Pv {
          get { return paqueteva; }
          set { paqueteva = value; }
      } 
	
	   public string Dp {
          get { return desempeño; }
          set { desempeño = value; }
      } 
     
     
      public int Inventario {
          get { return inventario; }
          set { inventario = value; }
      }
	 public override string función {get {return "mantenerse al tanto de la mercancia poseida, la que llega y que se va";}}
 }
    public class newguy {
    public void Main(string [] args) {
         Dealmacen r = new Dealmacen();
         Console.WriteLine("Buen día, quién sería el nuevo empleado? (es decir, cual es su nombre)");
         r.Nombre = Console.ReadLine();
         Console.WriteLine("Su edad? ");
         r.Edad = System.Convert.ToInt32(Console.ReadLine());
		 if (r.Edad <= 15){Console.WriteLine("shhh, que la lopna no se entere");
		 }
		 else {Console.WriteLine();}
         Console.WriteLine("Cuanto gana?");
		 r.Salario = System.Convert.ToSingle(Console.ReadLine());
		 while (r.Salario<= 0) {Console.WriteLine("aja, esclavitud o servidumbre, dame un Salario real");
							   r.Salario=System.Convert.ToSingle(Console.ReadLine());}
		 Console.WriteLine("Cuanta mercancia ha visto llegar?");
         r.Pll = System.Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Cuanta mercancia ha enviado?");
         r.Pv = System.Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Que adjetivo usarias para describir su labor hasta el momento?");
         r.Dp = Console.ReadLine();
         Console.WriteLine("Cuanta Mercancia queda en el almacen?: ");
         r.Inventario = System.Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("El empleado es {0}, quien ha vivido {1} años en esta tierra, y recibe por su esfuerzo tan solo unas miseras {2} [unidades monetarias]. Su función como empleado es " + r.función + "\nSe dice que fue {3} al cumplirla.", r.Nombre, r.Edad, r.Salario, r.Dp);
		 Console.WriteLine("Ha visto llegar {0} piezas de mercancia, y {1} de estas se han ido en su vigilia, dejando {2} en el almacén actualmente, contando las que ya estuvieran ahí. Esperemos que el resto de su tiempo aquí sea igual de productivo.", r.Pll,  r.Pv, r.Inventario);
     
     /* Aquí el link a dotnetfiddle donde con seguridad corre: https://dotnetfiddle.net/xnLYnY */
