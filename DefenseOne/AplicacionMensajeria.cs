using System;

namespace DefenseOne
{
    public class AplicacionMensajeria
    {
        private string _nom;
        private int _nroGrupos;
        private string[,] _grupos = new string[50, 4];
        private int _nroContactos;
        private string[,] _contactos = new string[50, 2];

        public AplicacionMensajeria()
        {
            _nom = "whatsaap";
            _nroGrupos = 3;
            _grupos[0, 0] = "Lab-121 F"; _grupos[0, 1] = "110"; _grupos[0, 2] = "2/08/2022"; _grupos[0, 3] = "701003";
            _grupos[1, 0] = "wally"; _grupos[1, 1] = "22"; _grupos[1, 2] = "15/03/2022"; _grupos[1, 3] = "605252";
            _grupos[2, 0] = "info"; _grupos[2, 1] = "5"; _grupos[2, 2] = "15/03/2022"; _grupos[2, 3] = "701003";
            _nroContactos = 5;
            _contactos[0, 0] = "rodrigo"; _contactos[0, 1] = "601020";
            _contactos[1, 0] = "adrian"; _contactos[1, 1] = "706414";
            _contactos[2, 0] = "lupe"; _contactos[2, 1] = "605252";
            _contactos[3, 0] = "maría"; _contactos[3, 1] = "701003";
            _contactos[4, 0] = "daniel"; _contactos[4, 1] = "705555";
        }

        public AplicacionMensajeria(string nombre)
        {
            _nom = nombre;
            _nroGrupos = 2;
            _grupos[0, 0] = "Arduino"; _grupos[0, 1] = "10"; _grupos[0, 2] = "22/01/2022"; _grupos[0, 3] = "123456";
            _grupos[1, 0] = "full joda"; _grupos[1, 1] = "8"; _grupos[1, 2] = "23/04/2022"; _grupos[1, 3] = "605252";
            _nroContactos = 3;
            _contactos[0, 0] = "rodrigo"; _contactos[0, 1] = "601020";
            _contactos[1, 0] = "josé"; _contactos[1, 1] = "455321";
        }

        public void mostrar()
        {
            Console.WriteLine("Aplicación: " + _nom);
            Console.WriteLine("Número de grupos: " + _nroGrupos);
            Console.WriteLine("-------------------------------------------------------------------------");
            for (var i = 0; i < _nroGrupos; i++)
            {
                Console.WriteLine("grupo:" + _grupos[i,0] + "    participantes:" + _grupos[i,1] + "    creación:" + _grupos[i,2] + "    admin:" + _grupos[i,3]);
            }
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Número de contactos: " + _nroContactos);
            Console.WriteLine("-------------------------------------");  
            for (var i = 0; i < _nroContactos; i++)
            {
                Console.WriteLine("nombre:" + _contactos[i,0] + "    celular:" + _contactos[i,1]);
            }
            Console.WriteLine("-------------------------------------");
        }

        public void a()
        {
            var cantidad = 0;
            var pos = 0;
            int tmp;
            for (var i = 0; i < _nroGrupos; i++)
            {
                tmp = Int32.Parse(_grupos[i, 1]);
                if (tmp > cantidad)
                {
                    cantidad = tmp;
                    pos = i; 
                }
            }

            for (var i = 0; i < _nroContactos; i++)
            {
                if (_contactos[i, 1].Equals(_grupos[pos, 3]))
                {
                    Console.WriteLine("Administrador del grupo " + _grupos[pos, 0] + " es: " + _contactos[i, 0]);
                    Console.WriteLine("Fecha de creación del grupo " + _grupos[pos, 0] + " es: " + _grupos[pos, 2]);
                }
            }
        }

        public void b(AplicacionMensajeria app)
        {
            for (var i = 0; i < _nroGrupos; i++)
            {
                Console.WriteLine(i);
                var c = _grupos[i, 3];
                Console.WriteLine(c);
                if (app.noEstaEnSegundo(_grupos[i, 3]))
                {
                    Console.WriteLine(nombreDelNumero(_grupos[i, 3]));
                } 
            }
        }

        public bool noEstaEnSegundo(string numero)
        {
            for (var i = 0; i < _nroContactos; i++)
            {
                if (_contactos[i, 1].Equals(numero))
                {
                    return false; 
                }
            }

            return true;
        }
        
        public string nombreDelNumero(string num)
        {
            for (var i = 0; i < _nroContactos; i++)
            {
                if (_contactos[i, 1].Equals(num))
                {
                    return _contactos[i, 0];
                }
            }

            return null;
        }
    }
}