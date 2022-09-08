using System;

namespace DefenseOne
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("a) █████████████████ Crear dos objetos de mensajeria...");
            AplicacionMensajeria telegram = new AplicacionMensajeria("telegram");
            AplicacionMensajeria signal = new AplicacionMensajeria();
            telegram.mostrar();
            Console.WriteLine();
            signal.mostrar();
            
            Console.WriteLine("\nb) █████████████████ Dado una apliación de mensajeria...");
            
            Console.WriteLine("\nc) █████████████████ Mostrar los nombres de contactos...");
            Console.ReadKey();
        }
    }
}