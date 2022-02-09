
namespace Practica_Metodos 
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine(Suma(5, 6, 22));
        }

        //Parámetro opcionales
        private static double Suma(int v1, double v2, double v3 = 0) => v1 + v2 + v3;
    }
}
 