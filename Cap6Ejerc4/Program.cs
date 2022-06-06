
namespace Cap6Ejerc4;

public class Program
{


    static void Main(string[] args)
    {
     
        int cantidad = 0; 
        int salones = 0; 
        int n = 0; 
        int m = 0; 
        string valor = "";
       
        float suma = 0.0f;
        float promedio = 0.0f;
        float minima = 10.0f; 
        float maxima = 0.0f; 

        Console.WriteLine("Dame la cantidad de salones");
        valor = Console.ReadLine();
        salones = Convert.ToInt32(valor);

  
        float[][] calif = new float[salones][];
       

        for (n = 0; n < salones; n++)
        {
            Console.WriteLine("Dame la cantidad de estdudiantes para el salon "+n);
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);
           
            calif[n] = new float[cantidad];
        }

        for(n=0;n<salones;n++) 
        {
            Console.WriteLine("Salon {0}",n);
            for(m=0;m<calif[n].GetLength(0);m++){
                Console.Write("Dame la calificación ");
                valor=Console.ReadLine();
                calif [n][m]=Convert.ToSingle(valor);
            }
        }
     
        Console.WriteLine("—— Información ——");
        for (n = 0; n<salones; n++) 
        {
            Console.WriteLine("Salon {0}", n+1);
            suma = 0.0f;
            for (m = 0; m<calif[n].GetLength(0); m++) 
            {
                Console.WriteLine("El alumno {0} tiene {1} ", m+1, calif[n][m]);
                suma += calif[n][m];

                if (calif[n][m] < minima)
                    minima = calif[n][m];

                if (calif[n][m] > maxima)
                    maxima = calif[n][m];

            }
            promedio += (suma / m );
        }
        promedio /= n;
        Console.WriteLine("El promedio es {0}", n); 
        Console.WriteLine("La calificacion minima es {0}", minima); 
        Console.WriteLine("La calificacion maxima es {0}", minima);


    }
}
 