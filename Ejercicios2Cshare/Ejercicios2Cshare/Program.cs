using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2Cshare
{
    class Program
    {
        static void Main(string[] args)
        {

            //Crear un programa que pida al usuario su nombre, y le diga "Hola" si se 
            //llama "Alejandro", o bien le diga "No te conozco" si teclea otro nombre. 
            //tener en cuenta, que el la validación no es case sensitive, es decir que si 
            //escriben "alejandro" ,"Alejandro", "aleJANdrO" serán valores validos.

            Console.WriteLine("Introduce un nombre");
            var nombre = Console.ReadLine();

            if (nombre.ToLower() == "alejandro")
            {
                Console.WriteLine("Hola");
            }
            else
            {
                Console.WriteLine("No te conozco");
            }

            Console.ReadKey();

            //Escribir un programa que pida una palabra, y la escriba a su inversa , 
            //por ejemplo si se introduce Paris, devolverá "Sirap".

            Console.WriteLine("Introduce un nombre");
            var nombre2 = Console.ReadLine();

            var nombreAlrevesArray = nombre2.Reverse();

            string nombreAlReves = string.Empty;

            foreach (var item in nombreAlrevesArray)
            {
                nombreAlReves = nombreAlReves + item;
            }

            Console.WriteLine(nombreAlReves);
            Console.ReadKey();

            //Crea un programa que pida una frase de al menos 20 caracteres y al menos 4 palabras por consola y se muestre la siguiente información de esa cadena(usa funciones para cada caso) , se deberá validar que la cadena tiene al menos 20 caracteres y la frase consta al menos de 4 palabras
            //* longitud de la cadena
            //* pinta la cadena, remplazando la letra "a" por "x", la "A" podrá ser mayúscula o minúscula en cuyo caso si es "a" se cambiara por una "x" y si es "A" se cambiara por una "X"
            //* pinta la cadena en mayúsculas
            //* pinta la cadena en minúsculas
            //* pinta la cadena, removiendo las 3 primeras letras
            //* pinta la cadena, extrayendo las letras en las posiciones de la 5 a la 10
            //* escribe el numero de palabras que tiene la frase
            //* escribe únicamente la tercera palabra

            Console.WriteLine("Introduce una frase con al menos 4 plabras y 20 caracteres de longitud");
            var frase = Console.ReadLine();

            if (CumpleValidacion(frase))
            {
                Console.WriteLine($"la longitud de la cadena es {frase.Length}");
                Console.WriteLine($"{frase.Replace("a", "x").Replace("A", "X")}");
                Console.WriteLine($"{frase.ToUpper()}");
                Console.WriteLine($"{frase.ToLower()}");
                Console.WriteLine($"{frase.Remove(0, 3)}");
                Console.WriteLine($"{frase.Substring(5, 5)}");
                Console.WriteLine($"la frase tiene {frase.Split(' ').Length} palabras");
                Console.WriteLine($"la tercera palabra es {frase.Split(' ')[2]}");


            }

            //Escribir un programa que pida 4 números por consola, y escriba la siguiente frase, 
            //"El primer numero introducido es el <numero1> , despues han introducido el <numero2> y 
            //<numero3> y por ultimo el <numero4>"  utilizar StringBuilder para realizar el ejercicio.

            StringBuilder sb = new StringBuilder();

            List<string> listCadenas = new List<string>();

            for (int c = 0; c < 4; c++)
            {
                Console.WriteLine("introduce un numero");
                listCadenas.Add(Console.ReadLine());
            }

            sb.Append($"El primer numero introducido es el {listCadenas[0]} ,");
            sb.Append($"despues han introducido el {listCadenas[1]} y {listCadenas[2]}");
            sb.Append($" y por ultimo el {listCadenas[3]}");

            Console.WriteLine(sb.ToString());
            Console.ReadKey();

            //Crear un programa que muestre las letras de la Z (mayúscula) a la A (mayúscula, descendiendo)
            int i;
            Console.Write("ABECEDARIO DESCENDENTE");
            Console.WriteLine();

            //Se recorren los numero de conversion de char segun su numero

            for (i = 90; i >= 65; i--)
            {
                Console.WriteLine("LETRA: " + Convert.ToString((char)i));
            }
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
        public static bool CumpleValidacion(string frase)
        {
            if (frase.Length < 20 || frase.Split(' ').Length < 4)
            {
                Console.WriteLine("Tienes que introducir al menos 4 palabras y 20 caracteres de longitud");
                return false;
            }

            return true;
        }
    }
}
