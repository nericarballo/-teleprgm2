using System;
	
	//inicio de modelo
	public abstract class moneda{
		private decimal a = 0;
		public decimal A
        {	get { return this.a; }
            set { this.a = value; }}
		
		public abstract decimal cambio {get;}
	}
	public class dolar:moneda {
		public dolar(decimal eso)
   {
      A = eso;
   }
		public override decimal cambio {get { return (Decimal.Multiply(A, 4123867.96M));}}	
	}
	public class cpeso:moneda {
		public cpeso(decimal eso)
   {
      A = eso;
   }
		public override decimal cambio {get { return (Decimal.Multiply(A, 860.39M));}}	
	}
	public class psol:moneda {
		public psol (decimal eso)
   {
      A = eso;
   }
		public override decimal cambio {get { return (Decimal.Multiply(A, 998649.58M));}}	
	}  //final de Modelo

	//inicio de controlador
	public class controlador {
		
		private decimal final;
		public decimal Final
        {	get { return this.final; }
            set { this.final = value; }}
		
		
		public static void Main () {	
		controlador si = new controlador ();	
		pantalla war = new pantalla ();
		
		if (war.Tipo ==1) {
			dolar alas = new dolar (war.Cantidad);
			
			si.Final= alas.cambio;
		}	
		else if (war.Tipo ==2) {
			psol alas = new psol (war.Cantidad);
			
			si.Final= alas.cambio;
		}	
		else if (war.Tipo ==3) {
			cpeso alas = new cpeso (war.Cantidad);
			
			si.Final= alas.cambio;
		}	
		
			pantalla peace = new pantalla (si.Final);
		
		}
		} //final de controlador
		

	//inicia vista
	public class pantalla {
		private int tipo = 0;
		private decimal cantidad;
		
		public decimal Cantidad
		{get { return this.cantidad; }
            set { this.cantidad = value; }}
		
		public int Tipo
        {	get { return this.tipo; }
            set { this.tipo = value; }}
		
		public pantalla (){
			this.interactI();
		}
		
		public pantalla (decimal k){
			this.interactII(k);
		}
		
		private void interactI (){
			 Console.WriteLine("Buen día, por favor seleccione el tipo de moneda a intercambiar: \n1)Dolar estadounidense \n2)Sol \n3)Peso colombiano");
			Tipo= Int32.Parse(Console.ReadLine ());
			if (Tipo==1){
			Console.WriteLine ("ha seleccionado dolares, cuantos cambiará?"); }
			else if (Tipo==2){
			Console.WriteLine ("ha seleccionado Soles, cuantos cambiará?"); }
			else if (Tipo==3){
			Console.WriteLine ("ha seleccionado Pesos Colombianos, cuantos cambiará?"); }
			else {Console.WriteLine ("Por favor vuelva a intentarlo, e inserte una de las opciones dadas");
				 Console.ReadLine ();
				 Environment.Exit(0);}
			Cantidad = Decimal.Parse (Console.ReadLine());					  
		}
		public void interactII (decimal k){
			Console.WriteLine (String.Format("Con esa cantidad, tendria {0} Bolívares", k));}
	} //final de vista
