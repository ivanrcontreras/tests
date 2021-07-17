using System;

namespace Test4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int num_buscado;
            
            int[] num = new int[5];
            int posicion = -1;

            Console.WriteLine("Ingrese los número para colocar en su vector");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Digite su número para buscar");
            num_buscado = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == num_buscado)
                {
                    posicion = i;
                }
            }
            

            Console.WriteLine("la posición del número es: " + posicion);
            Console.ReadKey();
        }

    }
}
