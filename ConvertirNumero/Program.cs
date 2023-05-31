using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertirNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int64 numero;
            int numCeros;
            string binario;

            try{
                while (true)
                {
                    Console.WriteLine("Ingresa un número: ");
                    numero = Int64.Parse(Console.ReadLine());

                    Stopwatch timeMeasure = new Stopwatch();
                    timeMeasure.Start();
                    binario = convertirBinario(numero);
                    //binario = convertirBinario2(numero);
                    numCeros = ContarCeros(binario);
                    timeMeasure.Stop();
                    Console.WriteLine($"\nEl número {numero} en binario es: {binario}");
                    Console.WriteLine($"\nLa maxima cantidad de ceros consecutivos es de: {numCeros}");
                    Console.WriteLine($"Tiempo: {timeMeasure.Elapsed.TotalMilliseconds} ms");
                }
            }catch(Exception ex) {
                Console.WriteLine($"\nIngresaste un dato diferente a un número ");
            }
            
            Console.ReadLine();
        }

        public static string convertirBinario(Int64 numero)
        {
            string cad ="",binario="";
            while(numero!=1)
            {
                cad += (numero % 2);
                numero = numero / 2;
            }
            cad += numero;
            for(int i = cad.Count()-1; i>=0; i--)
            {
                binario += cad[i];
            }
            return binario;
        }

        public static string convertirBinario2(Int64 numero)
        {
            return Convert.ToString(numero, 2);
        }

        public static int ContarCeros(string cadena)
        {
           int contCeros = 0, contAux = 0; ;

            for(int i = 0; i<cadena.Count(); i++){
                if (cadena[i] == '0'){
                    contAux += 1;
                }
                if(cadena[i] == '1' || i==cadena.Count()-1){
                    if (contCeros < contAux){
                        contCeros = contAux;
                    }
                    contAux = 0;
                }
            }
            return contCeros;
        }
    }
}
