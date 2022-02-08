
namespace Practica_Metodos 
{
    class Program
    {
        static void Main(string[] args)
        {
            mensajeEnPantalla();

            Console.WriteLine("Mensaje desde el main");
        }

        static void mensajeEnPantalla()
        {
            Console.WriteLine("Mensaje desde el método mensajeEnPatalla");
        }
    }
}
