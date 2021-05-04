namespace Tarea_2_Paradigmas_2021.model
{
    class Habitacion
    {
        private string id;
        private char estado;
        private Cliente cliente;
        private Informacion informacion;
        private int camas;
        private string clasificacion;

        public Habitacion(string id, char estado, Cliente cliente, Informacion informacion, int camas, string clasificacion)
        {
            this.id = id;
            this.estado = estado;
            this.cliente = cliente;
            this.informacion = informacion;
            this.camas = camas;
            this.clasificacion = clasificacion;
        }

        public string Id { get => id; set => id = value; }
        public char Estado { get => estado; set => estado = value; }
        public int Camas { get => camas; set => camas = value; }
        public string Clasificacion { get => clasificacion; set => clasificacion = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        internal Informacion Informacion { get => informacion; set => informacion = value; }


    }
}