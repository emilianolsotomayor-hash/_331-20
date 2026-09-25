using System;

namespace CS3
{
    class Program_CS3
    {
        static void Main(string[] args)
        {
            // Ssesión 6:
            // 1. Operadores aritméticos.
            double a = 1;
            double b = 2;
            float resultado = 0f;
            // a. Suma : +
            resultado = a + b;
            Console.WriteLine($"Suma: {resultado}");
            // b. resta : -
            resultado = a - b;
            Console.WriteLine($"Resta: {resultado}");
            // c. Multiplicación : *
            resultado = a * b; 
            Console.WriteLine($"Multiplicación {resultado}");
            // d. División : /
            resultado = a / b;
            Console.WriteLine($"División {resultado}");
            // e. Resto (módulo) = Residuo : %
            resultado = a % b;
            Console.WriteLine($"resto: {resultado}");
            // Incrementos y decrementos
            //resultado = resultado + 9;
            resultado *= 9; 
            resultado -= 5;
            /*
            2. operadores comparativos
            a. Igualdad : ==
            b. Diferencia : !=
            c. Menor que : <
            d. mayor que : >
            e: menor o igual que : <=
            f. mayor o igual que : >=
            */
            // SEsión 7 : Operadores comparativos
            bool m = false;
            // Igualdad
            m = 4 == 10;
            Console.WriteLine($"igualdad {m}");
            // Direfencia
            m = 5 != 5;
            Console.WriteLine($"Diferencia {m}");
            // Mayor que
            m = 5 > 4;
            Console.WriteLine($"Mayor a {m}");
            // menor que 
            m = 4 < 5;
            Console.WriteLine($"Menor a {m}");
            // Menor o igual 
            m = 3 <= 3;
            Console.WriteLine($"Menor o igual a {m}");
            // Mayor o igual
            m = 7 >= 6;
            Console.WriteLine($"Mayor o igual a {m}");
            // Operadores lógicos.
            // a. Y (AND) : &&
            // b. 0 (OR) :  ||
            bool e = false; // Entrada 1
            bool f = true; // Entrada 2
            bool d = false; // Resultado
            d = e && f;
            Console.WriteLine($"Y: {d}");
            d = e || f;
            Console.WriteLine($"O: {d}");


        } // termino de la función principal
    } // Termino de la clase principal.
} // Termino de la función principal
