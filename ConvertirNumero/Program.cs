using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertirNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero,numCeros;
            string binario;

            try{
                while (true)
                {
                    Console.WriteLine("Ingresa un número: ");
                    numero = Int32.Parse(Console.ReadLine());

                    binario = convertirBinario(numero);
                    numCeros = ContarCeros(binario);

                    Console.WriteLine($"\nEl número {numero} en binario es: {binario}");
                    Console.WriteLine($"\nLa maxima cantidad de ceros consecutivos es de: {numCeros}");
                    Console.ReadLine();
                }
            }catch(Exception ex) { }
            
        }

        public static string convertirBinario(int numero)
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

        public static int ContarCeros(string cadena)
        {
            int ini = 0, fin = 0, cont = 0, contAux = 0; ;

            for(int i = 0; i<cadena.Count(); i++){
                if (cadena[i] == '0'){
                    contAux += 1;
                }
                if(cadena[i] == '1' || i==cadena.Count()-1){
                    if (cont < contAux){
                        cont = contAux;
                    }
                    contAux = 0;
                }
            }
            return cont;
        }
    }
}
