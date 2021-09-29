using System;

namespace Clase_10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Class1.Metodo();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Gracias por venir a esta clase");
            }
        }

    }
}
