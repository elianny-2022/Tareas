namespace Cap8Ejerc5
{
    
    public class Cadenas
    {
    
        static void Main(string[] args)
        {
            string cadena1, cadena2;
            int comparacion;

            Console.WriteLine("Digite la cadena 1");
            cadena1 = Console.ReadLine();
            Console.WriteLine("Digite la cadena 2");
            cadena2 = Console.ReadLine();

            comparacion = String.Compare(cadena1, cadena2);
            Console.Clear();
            if (comparacion > 0)
                Console.WriteLine(cadena2 + "  " + cadena1);
            else
                Console.WriteLine(cadena1 + "  " + cadena2);

        }
    }
}