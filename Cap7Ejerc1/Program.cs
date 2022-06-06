using System;
using System.Collections.Generic;


namespace  Califiaciones;

class Program
{
    static void Main(string[] args)
    {
        //Variables necesarias
        int salones;
        int cantidad;

        int C;
        int R;

        
        float[][] calif;
        float suma = 0;
        float minima = 10;
        float maxima = 0;

        //Pedimos salones
        Console.WriteLine("Dime cuantos salones: ");
        salones = Convert.ToInt32(Console.ReadLine());

 
        calif = new float [salones][];

    
        for (C = 0; C<salones;C++)
        {
            Console.WriteLine("Cuantos alumnos ahi en este salon:");
            cantidad = Convert.ToInt32(Console.ReadLine());
            
            //Creamos un arreglo para almacenar la cantidad de alumnos
            calif[C] = new float[cantidad];

        }
        
          
            for (C = 0; C < salones; C++)
            {
                Console.WriteLine("Salon {0}", C);
               
                for (R = 0; R < calif[C].Length; R++)
                {
                    //Pedimos la calificacion
                    Console.WriteLine("Dame la calificacion:");
                    calif[C][R] = Convert.ToSingle(Console.ReadLine());

                }

            } 
            
            for (C = 0; C < salones; C++)
            {
                for (R = 0; R < calif[C].Length; R++)
                {
                    suma = calif[C][R] + suma;
                }
                
            } 
            //Calificacion minima
            for (C = 0; C < salones; C++ )
            {
                for (R = 0; R < calif[C].Length; R++)
                {
                    if (calif[C][R] < minima)
                        minima = calif[C][R];
                }
            }
            //Calificacion maxima
            for (C = 0; C < salones; C++)
            {
                for (R = 0; R < calif[C].Length; R++)
                {
                    if (calif[C][R] > maxima)
                        maxima = calif[C][R];
                }
            }
                
                Console.WriteLine("Suma total : {0}", suma);
                Console.WriteLine("La nota minima es: {0}", minima);
                Console.WriteLine("La nota maxima es: {0}", maxima);


    }
}