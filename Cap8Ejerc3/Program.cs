
namespace Cap8Ejerc3
{
    public class FechaHora
    {
        public FechaHora() { }

        static void Main(string[] args)
        {
            String formato;

            formato = String.Format("La hora y fecha es: {0:hh tt yyyy dd M}", DateTime.Now);
            Console.WriteLine(formato);
        }

    }
}