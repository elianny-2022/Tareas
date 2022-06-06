using System;

namespace Cap5Ejerc4;

class Program
{
   
    public static void factorial(int numero)
    {
        double factorial;  
        factorial = 1;  

        if (numero == 0) factorial = 1;    
        else for (int i = 1; i <= numero; i++) factorial *= i;

        
        Console.WriteLine("\t{0}! = {1}\n", numero, factorial);
    }

   
    public static int validarValorEntero()
    {
        int valor;
        while ((!Int32.TryParse(Console.ReadLine(), out valor)) || (valor < 0) || (valor > 170))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Valor invalido, vuelva a interntar.\n");   
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" n = ");
        }
        return valor;  
    }

   
    static void Main(string[] args)
    {
       
        char opcion = 'y';
        int num;  
     
        while (opcion != 'n')
        {
            num = 0;

            Console.WriteLine("                     Calculo de Factoriales   ");
            Console.WriteLine("===========================================================");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine(" Ingrese el valor del factorial que desea calcular (solo es valido numeros enteros).");
            Console.WriteLine("-----------------------------------------------------------\n");
            Console.Write(" n = "); 
            num = validarValorEntero();
            Console.WriteLine("");

            factorial(num); 
            
            Console.Write("\n ¿Deseas calcular otro factorial? [y/n]: "); 
            
            while (!((Char.TryParse(Console.ReadLine().ToLower(), out opcion)) && ((opcion == 'n') || (opcion == 'y')))) 
                Console.Write("\n ¿Deseas calcular otro factorial? [y/n]: ");
            
            Console.Clear();
        }
    }
}
