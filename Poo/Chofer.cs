using System;

namespace Poo
{
    public class Chofer
    {
        private int ci;
        private string nombre;
        private int nroVehiculo;
        private string[] placasV = new string[50];
  
        public Chofer(){
            this.ci = 12423998;
            this.nombre = "Carlos";
            this.nroVehiculo = 2;
            this.placasV[0] ="1425DHS";
            this.placasV[1] ="200000";
        }
        public Chofer(int ci, string nom){
            this.ci = ci;
            this.nombre = nom;
            this.nroVehiculo = 4;
            this.placasV[0] ="1111111";
            this.placasV[1] ="2222222";
            this.placasV[2] ="3086xch";
            this.placasV[3] ="4444444";
        }
        public void Mostrar(){
            Console.WriteLine("\nDatos del chofer");
            Console.WriteLine("ci = "+ this.ci);
            Console.WriteLine("nombre = "+ this.nombre);
            Console.WriteLine("nroVehiculo = "+ this.nroVehiculo);
            Console.WriteLine("placaV " );
            for (int i = 0; i < nroVehiculo; i++) {
                Console.WriteLine(this.placasV[i]);
            }
        }
  
  
        public bool MostrarVehiculo(Vehicle v, int X)
        {
            //Console.WriteLine("ingrese ci del conductor");
            //x = int.Parse(Console.ReadLine());
            //int CIx = Int32.Parse(x);
            //int CI = int.Parse(Console.ReadLine());
            bool sw=true;
            if (ci == X) {
                for (int i = 0; i < nroVehiculo; i++) {
                    if (placasV[i].Equals(v.Placa)) {
                        sw=false;
                        //v.Mostrar();
                    }
                }
            }
            return sw;
        }
        public bool placax(String x){
            for (int i = 0; i < nroVehiculo; i++) {
                if (placasV[i].Equals(x)) {
                    return true;
                }
            }
            return false;
        }
        public bool VeriCix(Vehicle v, int X,string t)
        {
            bool sw=true;
            if (ci == X) {
                for (int i = 0; i < nroVehiculo; i++) {
                    if (placasV[i].Equals(v.Placa)) {
                        if (v.Tipo.Equals(t)) {
                            Console.WriteLine("Verificado");
                            sw = false;
                        }
                    }
                }
            }
            return sw;
        }
    }
}