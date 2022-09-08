using System;

namespace Poo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nombre: Cinthia Molina Cutile");
            Console.WriteLine("Cedula: 9249179");
            Console.WriteLine("Paralelo: F");

            Vehicle v1 = new Vehicle();
            Vehicle v2 = new Vehicle("1425DHS", "toyota");
            Vehicle v3 = new Vehicle("1758KOS", "Susuki", "prius");
            Chofer c1 = new Chofer();
            Chofer c2 = new Chofer(777, "Juan");
            //a
            v1.Mostrar();
            v2.Mostrar();
            v3.Mostrar();

            c1.Mostrar();
            c2.Mostrar();
            //b
            Console.WriteLine("\n___________________________________________");
            int cix = 777;
            Console.WriteLine("INCISO B");
            if (c1.MostrarVehiculo(v1, cix))
            {
                Console.WriteLine("Vehiculo Encontardo");
                v1.Mostrar();
            }
            else
            {
                if (c1.MostrarVehiculo(v2, cix))
                {
                    Console.WriteLine("Vehiculo Encontardo");
                    v2.Mostrar();
                }
                else
                {
                    if (c1.MostrarVehiculo(v3, cix))
                    {
                        Console.WriteLine("Vehiculo Encontardo");
                        v3.Mostrar();
                    }
                    else
                    {
                        if (c2.MostrarVehiculo(v1, cix))
                        {
                            Console.WriteLine("Vehiculo Encontardo");
                            v1.Mostrar();
                        }
                        else
                        {
                            if (c2.MostrarVehiculo(v2, cix))
                            {
                                Console.WriteLine("Vehiculo Encontardo");
                                v2.Mostrar();
                            }
                            else
                            {
                                if (c2.MostrarVehiculo(v3, cix))
                                {
                                    Console.WriteLine("Vehiculo Encontardo");
                                    v3.Mostrar();
                                }
                            }
                        }
                    }
                }
            }

            //c
            Console.WriteLine("___________________________________________");
            Console.WriteLine("\nINCISO C");
            var px = "3086xch";
            if (c1.placax(px))
            {
                c1.Mostrar();
            }
            else
            {
                if (c2.placax(px))
                {
                    c2.Mostrar();
                }
            }

            //d
            Console.WriteLine("___________________________________________");
            Console.WriteLine("\nINCISO D");
            int carnetx = 777;
            string tip = "camioneta";
            if (c1.VeriCix(v1, carnetx, tip))
            {
                Console.WriteLine("si existe un vehiculo de tipo camioneta");
            }
            else
            {
                if (c1.VeriCix(v2, carnetx, tip))
                {
                    Console.WriteLine("si existe un vehiculo de tipo camioneta");
                }
                else
                {
                    if (c1.VeriCix(v3, carnetx, tip))
                    {
                        Console.WriteLine("si existe un vehiculo de tipo camioneta");
                    }

                    if (c2.VeriCix(v1, carnetx, tip))
                    {
                        Console.WriteLine("si existe un vehiculo de tipo camioneta");
                    }
                    else
                    {
                        if (c2.VeriCix(v2, carnetx, tip))
                        {
                            Console.WriteLine("si existe un vehiculo de tipo camioneta");
                        }
                        else
                        {
                            if (c2.VeriCix(v3, carnetx, tip))
                            {
                                Console.WriteLine("si existe un vehiculo de tipo camioneta");
                            }
                        }
                    }
                }
            }


            Console.ReadKey();
        }
    }
}