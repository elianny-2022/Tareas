using System.Collections;

namespace TablaHash
{
    public class Program
    {
        static void Main(string[] args)
        {

            
            Hashtable miDiccio = new Hashtable();

            miDiccio.Clear();
            
            miDiccio.Add("byte", "8 bits");
            miDiccio.Add("pc", "personal computer");
            miDiccio.Add("PC", "ordenador personal");
            miDiccio.Add("kilobyte", "1024 bytes");
            miDiccio.Add("bit", "");

            miDiccio.Remove("PC");

            Console.WriteLine("Cantidad de palabras en el diccionario: {0}",
            miDiccio.Count);
            if (miDiccio.ContainsKey("pc")) {
           
                Console.WriteLine("El significado de pc es: {0}",
                miDiccio["pc"]);
            }
            else
            {
                Console.WriteLine("No existe esa palabra!");
            }

            Console.ReadKey();
        }
    }
}