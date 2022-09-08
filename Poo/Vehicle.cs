using System;

namespace Poo
{
    public class Vehicle
    {
        private string placa;
        private string marca;
  
        public string Marca {
            get { return marca; }
            set { marca = value; }
        }
        private string modelo;
        private string tipo;
        private double precio;
  
        public Vehicle(){
            this.placa = "3086xch";
            this.marca = "toyota";
            this.modelo = "hilux";
            this.tipo = "minibus";
            this.precio = 18.500;
  
   
        }
        public Vehicle(string placa, string marca){
            this.placa = placa;
            this.marca = marca;
            this.modelo = "corolla";
            this.tipo = "automovil";
            this.precio = 21.200;
   
        }
        public Vehicle(string placa, string marca,string modelo){
            this.placa = placa;
            this.marca = marca;
            this.modelo = modelo;
            this.tipo = "Camioneta";
            this.precio = 14.200;
        }
        public void Mostrar(){
            Console.WriteLine("\nDatos del vehiculo");
            Console.WriteLine("placa = "+ this.placa);
            Console.WriteLine("marca = "+ this.marca);
            Console.WriteLine("modelo = "+ this.modelo);
            Console.WriteLine("tipo = "+ this.tipo);
            Console.WriteLine("precio = "+ this.precio);

        }  
        public void Leer(){
            Console.WriteLine("Ingresar datos del vehiculo: placa,marca,modelo,tipo, precio");
            this.placa = Console.ReadLine();
            this.marca = Console.ReadLine();
            this.modelo = Console.ReadLine();
            this.tipo = Console.ReadLine();
            this.precio = double.Parse(Console.ReadLine());  
        }
  
  
   
        public string Tipo {
            get { return tipo; }
            set { tipo = value; }
        }
  
        public string Placa {
            get { return placa; }
            set { placa = value; }
        }

    }
}