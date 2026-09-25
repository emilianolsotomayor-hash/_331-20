using System.Transactions;
using Microsoft.VisualBasic;
using System;
// Espacio de nombres
namespace CS2
{
    class Program_CS2
    {
        static void Main(string[] args)
        {
            // Sesión 5: Tipos de datos.
            // Sintaxis para declarar variables.}
            // tipo de dato identificador_variable

            // 1. Entero
            int a;
            // 2. cadena de texto
            string s;
            // 3. flotante precisión sencilla
            float f;
            // 3.2 Flotante presición doble
            double d;
            // 4. boleano
            bool b;
            //Inicializadores
            a = 5;
            s = "Exactas";
            f = 8.5f; // Cuando es solo flotante tiene que contar con la f
            d = 9.5; // Al ser doble no es necesaria la d.
            b = true; // True es una palabra reservada ( Palabra con una función reservada en el programa )
            Console.WriteLine($"Entero: {a}");
            Console.WriteLine($"Flotante sencillo: {f}");
            Console.WriteLine($"Flotante doble: {d}");
            Console.WriteLine($"Cadena de texto: {s}");
            Console.WriteLine($"Booleano: {b}");
            // $ es para que tenga una extructura

        } // Término de la función principal.
    } // Termino de la clase principal.
} // Termino del espacio de nombres.
