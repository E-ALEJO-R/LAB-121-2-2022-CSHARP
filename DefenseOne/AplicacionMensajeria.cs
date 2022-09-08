using System;

namespace DefenseOne
{
    public class AplicacionMensajeria
    {
        private string nom;
        private int nroGrupos;
        private string[,] grupos = new string[50, 4];
        private int nroContactos;
        private string[,] contactos = new string[50, 2];

        public AplicacionMensajeria()
        {
            nom = "signal";
            nroGrupos = 3;
            grupos[0, 0] = "Lab-121 F"; grupos[0, 1] = "110"; grupos[0, 2] = "2/08/2022"; grupos[0, 3] = "701003";
            grupos[1, 0] = "wally"; grupos[1, 1] = "22"; grupos[1, 2] = "15/03/2022"; grupos[1, 3] = "605252";
            grupos[2, 0] = "info"; grupos[2, 1] = "5"; grupos[2, 2] = "15/03/2022"; grupos[2, 3] = "701003";
            nroContactos = 5;
            contactos[0, 0] = "rodrigo"; contactos[0, 1] = "601020";
            contactos[1, 0] = "adrian"; contactos[1, 1] = "706414";
            contactos[2, 0] = "lupe"; contactos[2, 1] = "605252";
            contactos[3, 0] = "maría"; contactos[3, 1] = "701003";
            contactos[4, 0] = "daniel"; contactos[4, 1] = "705555";
        }

        public AplicacionMensajeria(string nombre)
        {
            nom = nombre;
            nroGrupos = 2;
            grupos[0, 0] = "Arduino"; grupos[0, 1] = "10"; grupos[0, 2] = "22/01/2022"; grupos[0, 3] = "123456";
            grupos[1, 0] = "full joda"; grupos[1, 1] = "8"; grupos[1, 2] = "23/04/2022"; grupos[1, 3] = "605252";
            nroContactos = 3;
            contactos[0, 0] = "rodrigo"; contactos[0, 1] = "601020";
            contactos[1, 0] = "josé"; contactos[1, 1] = "455321";
        }

        public void mostrar()
        {
            Console.WriteLine("Aplicación: " + nom);
            Console.WriteLine("Número de grupos: " + nroGrupos);
            Console.WriteLine("-------------------------------------------------------------------------");
            for (int i = 0; i < nroGrupos; i++)
            {
                Console.WriteLine("grupo:" + grupos[i,0] + "    participantes:" + grupos[i,1] + "    creación:" + grupos[i,2] + "    admin:" + grupos[i,3]);
            }
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Número de contactos: " + nroContactos);
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < nroContactos; i++)
            {
                Console.WriteLine("nombre:" + contactos[i,0] + "    celular:" + contactos[i,1]);
            }
            Console.WriteLine("-------------------------------------");
        }

        public void a()
        {
            int cantidad = 0;
            int pos = 0;
            int tmp;
            for (int i = 0; i < nroGrupos; i++)
            {
                tmp = Int32.Parse(grupos[i, 1]);
                if (tmp > cantidad)
                {
                    cantidad = tmp;
                    pos = i;
                }
            }

            for (int i = 0; i < nroContactos; i++)
            {
                if (contactos[i, 1].Equals(grupos[pos, 3]))
                {
                    Console.WriteLine("Administrador del grupo " + grupos[pos, 0] + contactos[i, 0]);
                    Console.WriteLine("Fecha de creación del grupo " + grupos[pos, 0] + "es: " + grupos[pos, 2]);
                }
            }
        }

        public void b()
        {
            
        }
    }
}