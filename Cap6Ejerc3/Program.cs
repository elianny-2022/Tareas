namespace Cap6Ejerc3;

public class Program
{
        static void Main(string[] args)
        {

            int cantidad = 0; 
            int n = 0; 
            string valor = "";
       
            float suma = 0.0f;
            float promedio = 0.0f;
            float minima = 10.0f;
            float maxima = 0.0f; 

        Console.WriteLine("Ingrese la cantidad de alumnos");
        valor = Console.ReadLine();
        cantidad = Convert.ToInt32(valor);
       
        float[] calif = new float[cantidad];
        
        for (n = 0; n < cantidad; n++)
        {
            Console.Write("Ingrese la calificación ");
            valor = Console.ReadLine();
            calif[n] = Convert.ToSingle(valor);
        }
         for (n = 0; n < cantidad; n++)
            {
            suma += calif[n];
            }
            promedio = suma / cantidad;

        for (n = 0; n < cantidad; n++)
        {
        if (calif[n] < minima)
        minima = calif[n];
        }

        for (n = 0; n < cantidad; n++)
        {
        if (calif[n] > maxima)
        maxima = calif[n];
        }

            Console.WriteLine("El promedio es {0}", promedio);
            Console.WriteLine("La calificación mínima es {0}", minima);
            Console.WriteLine("La calificación máxima es {0}", maxima);
} 
}
