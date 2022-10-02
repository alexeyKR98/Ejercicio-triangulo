using System;

class Ejercicio_triangulo{

	static void Main(){
	
		int anchura, i, j, space;
		Console.Write("Introduce la anchura del triángulo que sea >=3 e impar: ");
		anchura=Convert.ToInt32(Console.ReadLine());
		while(anchura<3||anchura%2==0){
			Console.WriteLine();
			Console.Write("Valor introducido incorrecto, repita de nuevo: ");
			anchura=Convert.ToInt32(Console.ReadLine());
		}
		for(j=anchura; j>0; j-=2){
			for(space=anchura; space>j; space-=2)
				Console.Write(" ");
			for(i=j; i>0; i--)
				Console.Write("*");
			Console.WriteLine();
		}
	}	
}
