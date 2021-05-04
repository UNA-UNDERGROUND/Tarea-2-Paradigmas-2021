namespace Tarea_2_Paradigmas_2021.model
{
    class Informacion
    {

        private int numeroAdultos;
        private int numeroInfante;
        private int numeroDias;
        private int hora;
        private bool todoIncluido;

        public Informacion(int numeroAdultos, int numeroInfante, int numeroDias, int hora, bool todoIncluido)
        {
            this.numeroAdultos = numeroAdultos;
            this.numeroInfante = numeroInfante;
            this.numeroDias = numeroDias;
            this.hora = hora;
            this.todoIncluido = todoIncluido;
        }

        public int NumeroAdultos { get => numeroAdultos; set => numeroAdultos = value; }
        public int NumeroInfante { get => numeroInfante; set => numeroInfante = value; }
        public int NumeroDias { get => numeroDias; set => numeroDias = value; }
        public int Hora { get => hora; set => hora = value; }
        public bool TodoIncluido { get => todoIncluido; set => todoIncluido = value; }
    }
}