namespace DefenseOne
{
    public class AplicacionMensajeria
    {
        private string nom;
        private int nroGrupos;
        private string[,] grupos = new string[50, 4];
        private int nroContactos;
        private string[,] contactos = new string[50, 2];

        public AplicacionMensajeria(string nom, int nroGrupos, int nroContactos)
        {
            this.nom = nom;
            this.nroGrupos = nroGrupos;
            this.nroContactos = nroContactos;
        }

        public AplicacionMensajeria(string nom)
        {
            this.nom = nom;
        }
    }
}