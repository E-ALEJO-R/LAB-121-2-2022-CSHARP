using System;

namespace DefenseOne
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("a) █████████████████ Crear dos objetos de mensajeria...");
            AplicacionMensajeria telegram = new AplicacionMensajeria("telegram");
            AplicacionMensajeria whatsaap = new AplicacionMensajeria();
            telegram.mostrar();
            Console.WriteLine();
            whatsaap.mostrar();
            
            Console.WriteLine("\nb) █████████████████ Dado una apliación de mensajeria...");
            Console.WriteLine("Aplicación whatsapp");
            whatsaap.a();
            
            Console.WriteLine("\nc) █████████████████ Mostrar los nombres de contactos...");
            Console.ReadKey();
        }
    }
}