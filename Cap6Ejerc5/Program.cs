
namespace CapEjerc5;

public class Jagged
{
  

    static void Main(int [][] jagged)
    
    {
       
        for (int n = 0; n < jagged.Length; n++)
        {
            for (int m = 0; m < jagged[n].GetLength(0); m++)
            {
                Console.WriteLine(jagged[n][m]);
            }
            
        }
    }
}