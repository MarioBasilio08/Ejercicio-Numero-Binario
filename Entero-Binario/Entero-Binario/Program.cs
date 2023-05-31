using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Entero_Binario
{
    public class Program
    {
        static void Main(string[] args)
        {
            string binary = "1";
            Int64 number = 1;
            int zerosMax = 0;
            Stopwatch time = Stopwatch.StartNew();
            Stopwatch time2 = Stopwatch.StartNew();

            try
            {
                time.Start();
                Console.WriteLine("Primera version funciones de C#");
                Console.WriteLine("Ingrese un número entero:");
                        
                binary = Convert.ToString(Int64.Parse(Console.ReadLine()),2);

                string[] zeros = binary.Split('1');

                Console.WriteLine($"El número binario es {binary}");
                Console.WriteLine($"El número mayor de 0´s consecutivos es: {zeros.Max().Length}");
                time.Stop();
                MuestreoTiempo(time);

                Console.WriteLine();


                Console.WriteLine("Segunda version funciones creadas");
                time2.Start();
                Console.WriteLine("Ingrese un número entero:");
                number = Convert.ToInt64(Console.ReadLine());
                binary = DecimalABinario(number);

                zerosMax = ConteoZeros(binary);
               
                Console.WriteLine($"El número binario es {binary}");
                Console.WriteLine($"El número mayor de 0´s consecutivos es: {zerosMax}");
                time2.Stop();
                MuestreoTiempo(time2);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadKey();

        }

        public static void MuestreoTiempo(Stopwatch time)
        {
            TimeSpan ts = time.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine($"Tiempo de ejecución {elapsedTime}");
        }

        public static int ConteoZeros(string binary)
        {
            int zerosMax = 0;
            int countBinary = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '0')
                {
                    countBinary++;
                }
                else
                {
                    if (countBinary > zerosMax)
                    {
                        zerosMax = countBinary;
                    }
                    countBinary = 0;
                }
            }
            return zerosMax;
        }

        public static string DecimalABinario(Int64 num)
        {
            string binary = "";
            Int64 residuo;

            while (num > 0)
            {
                residuo = num % 2;
                binary = residuo.ToString() + binary;
                num = num / 2;
            }


            return binary;
        }

    }
}
