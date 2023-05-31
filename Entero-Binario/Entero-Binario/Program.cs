using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entero_Binario
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stopwatch time = Stopwatch.StartNew();
            time.Start();
            try
            {
                Console.WriteLine("Ingrese un número entero:");
                        
                string binary = Convert.ToString(Int64.Parse(Console.ReadLine()),2);

                string[] zeros = binary.Split('1');

                Console.WriteLine($"El número binario es {binary}");
                Console.WriteLine($"El número mayor de 0´s consecutivos es: {zeros.Max().Length}");

            }catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            time.Stop();
            TimeSpan ts = time.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",ts.Hours, ts.Minutes, ts.Seconds,ts.Milliseconds / 10);
            Console.WriteLine($"Tiempo de ejecución {elapsedTime}");

            Console.ReadKey();

        }
    }
}
