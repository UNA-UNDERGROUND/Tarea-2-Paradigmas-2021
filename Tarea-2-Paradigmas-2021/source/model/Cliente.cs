namespace Tarea_2_Paradigmas_2021.model
{
    class Cliente
    {
        private string nombre;
        private string id;
        private string metodoDePago;
        private string telefono;
        private string numeroCuenta;
        private int edad;

        public Cliente(string nombre, string id, string metodoDePago, string telefono, string numeroCuenta, int edad)
        {
            this.Nombre = nombre;
            this.Id = id;
            this.MetodoDePago = metodoDePago;
            this.Telefono = telefono;
            this.numeroCuenta = numeroCuenta;
            this.edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Id { get => id; set => id = value; }
        public string MetodoDePago { get => metodoDePago; set => metodoDePago = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string NumeroCuenta { get => numeroCuenta; set => numeroCuenta = value; }
    }
}