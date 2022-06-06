namespace Cap6Ejerc1;

public class Program
{

    static void Main(string[] args){

        int cantidad = 0; 
        int n = 0;
        string valor = "";

        float suma = 0.0f;
        float promedio = 0.0f;


            Console.WriteLine("Ingresar la cantidad de alumnos");
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);

            float[] calif = new float[cantidad];

                for (n = 0; n < cantidad; n++)
                {
                Console.Write("Ingresar la calificación ");
                valor = Console.ReadLine();
                calif[n] = Convert.ToSingle(valor);
                }

                for (n = 0; n < cantidad; n++)
                {
                suma += calif[n];
                }
                promedio = suma / cantidad;



                Console.WriteLine("El promedio es {0}", promedio);

                } 
} 
