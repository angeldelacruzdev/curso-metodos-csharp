
namespace Practica_Metodos 
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Suma de números");

            Console.WriteLine(SumaNumeros(5, 6));
            
            Console.WriteLine("Dividiendo números");

            Console.WriteLine(DividiendoNumeros(5, 2));

            Console.WriteLine(MultiplicaNumeros(5, 2));
        }

        //Retorna la suma de dos valores
       static int SumaNumeros(int num1, int num2)
        {
           return num1 + num2;
        }

        //Retorna dos números divididos
        static double DividiendoNumeros(double num1, int num2) => num1 / num2;

        //Retorna dos números multiplicados
        static int MultiplicaNumeros(int num1, int num2)
        {
            int resultado;
            resultado = num1 * num2;
            return resultado;
        }
    }
}
