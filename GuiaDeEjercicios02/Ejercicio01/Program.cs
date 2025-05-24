using System;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int numero;

            while (true)
            {
                Console.Write("Introduce un número: ");
                
                string input = Console.ReadLine();

                if (int.TryParse(input, out numero))
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("El valor introducido no es un número válido. Intentá de nuevo.\n");
                    Console.WriteLine("Recuerda que el número debe ser mayor o igual a 0.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            try
            {
                var (primo1, primo2) = PrimosMayoresQue(numero);
                Console.WriteLine($"Pareja de primos mayores que {numero}: {primo1}, {primo2}");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inesperado: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Fin del programa");
            }
        }

        public static bool EsPrimo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public static (int, int) PrimosMayoresQue(int numero)
        {
            int encontrados = 0;
            int candidato = numero + 1;
            int primero = 0, segundo = 0;

            while (encontrados < 2)
            {
                if (EsPrimo(candidato))
                {
                    if (encontrados == 0)
                        primero = candidato;
                    else
                        segundo = candidato;
                    encontrados++;
                }
                candidato++;
            }

            return (primero, segundo);
        }

    }
}
