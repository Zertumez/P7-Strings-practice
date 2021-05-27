using System;

namespace P7_Strings_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1. "hola" -> "HOLA"
            string saludo = "hola";
            string saludoEnMayusculas = saludo.ToUpper();
            Console.WriteLine($"\"{saludo}\" -> \"{saludoEnMayusculas}\"");

            // Ejercicio 2. “John, Peter, Charlie” -> [“John”, “Peter”, Charlie”]
            string nombres = "John, Peter, Charlie";
            string[] nombresEnArray = nombres.Split(", ");
            Console.WriteLine($"\"{nombres}\" -> [\"{nombresEnArray[0]}\", \"{nombresEnArray[1]}\", \"{nombresEnArray[2]}\"] ");

            // Ejercicio 3. "Pizza" -> "azziP"
            string comida = "Pizza";
            char[] charArray = comida.ToCharArray();
            Array.Reverse(charArray);
            string comidaReversa = new string(charArray);
            Console.WriteLine($"\"{comida}\" -> \"{comidaReversa}\"");

            // Ejercicio 4. "Tacos > Hamburguesa" -> "Tacos &gt; Hamburguesa"
            string compararComida = "Tacos > Hamburguesa";
            string compararComidaConReplace = compararComida.Replace(">", "&gt;");
            Console.WriteLine($"\"{compararComida}\" -> \"{compararComidaConReplace}\"");

            // Ejercicio 5. "Pizza < Hamburguesa" -> "Pizza &lt; Hamburguesa"
            string compararComida2 = "Pizza < Hamburguesa";
            string compararComidaConReplace2 = compararComida2.Replace("<", "&lt;");
            Console.WriteLine($"\"{compararComida2}\" -> \"{compararComidaConReplace2}\"");

            // Ejercicio 6. "Azul, Verde, Morado" -> "Morado"
            string colores = "Azul, Verde, Morado";
            string colores2 = colores.Replace(" ", "");
            string[] coloresArray = colores2.Split(",");
            Console.WriteLine($"\"{colores}\" -> \"{coloresArray[(coloresArray.Length-1)]}\"");

            // Ejercicio 7. " ave, banco, comida, duda, ejercicio, fuente, girasol" -> FUENTE;EJERCICIO;DUDA;COMIDA;BANCO
            string palabras = " ave, banco, comida, duda, ejercicio, fuente, girasol";
            string palabrasMayus = palabras.ToUpper();
            string palabras2 = palabrasMayus.Replace(" ", "");
            string substringPalabras = palabras2.Substring(4, 34);
            string[] arraySubstringPalabras = substringPalabras.Split(",");
            Array.Reverse(arraySubstringPalabras);
            string reverseArraySubstringPalabras = string.Join(";", arraySubstringPalabras);
            Console.WriteLine($"\"{palabras}\" -> " + reverseArraySubstringPalabras);
        }
    }
}
