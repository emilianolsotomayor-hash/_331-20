using System;
namespace SE1 // Oscar López

{
    class Program_SE1
    {
        static void Main(string[]args)
        {
            // 1
            bool a;
            int número;
            // 3 Interpolación
            a = true;
            número = 10;
            Console.WriteLine($"Booleano: {a}");
            Console.WriteLine($"Número: {número}");

            // 4 Incrementos y decrementos
            int m = 0;
            int n = -1;
            // 5 Operador resto(modúlo)
            int residuo = 40 % 16;
            Console.WriteLine($"Residúo: {residuo}");
            // 6 Operadores aritmeticos
            double operación = 0;
            operación = (( 30 + 8 -2)/2)*-1;

            // 7. Interruptores
            bool interruptor_1 = false;
            bool interruptor_2 = true;
            bool bombilla = false;
            if(interruptor_1 && interruptor_2)
            {
                bombilla = true;
                
            }
            else
            {
                bombilla = false;
                
            }
            Console.WriteLine($"Bombilla: {bombilla}");
            // 8 asueto
            int dia = 16;
            string mes = "septiembre";
            if(dia == 16 && mes == "septiembre")
            {
                Console.WriteLine("Asueto");
            }
            else
            {
              Console.WriteLine("Sin definir");  
            }
            // 9 Almacenar true
            bool resultado = (7 < 11) && 9 != 0;
            Console.WriteLine($"Expresión : {resultado}");


        }   

    }
}
