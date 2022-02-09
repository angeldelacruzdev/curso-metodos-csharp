
namespace Practica_Metodos 
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Random numero = new();
            
            int aleatorio = numero.Next(0, 100);

            int mi_numero;

            int intentos = 0;

            Console.WriteLine("Intentos un  número entre 0 y 100");

            do
            {
                intentos++;

                try {
                    mi_numero = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("No has introducido un valor numérico válido");
                    mi_numero = 0;
                }

            

                if (mi_numero > aleatorio) Console.WriteLine("El número es más bajo");

                if (mi_numero < aleatorio) Console.WriteLine("El número es más alto");

            } while (aleatorio != mi_numero);

            Console.WriteLine($"Correcto! Has necesitado {intentos} intentos");
            Console.WriteLine("Apartir de esta línea de código el programa continuara");
        }

 
    }
}
 