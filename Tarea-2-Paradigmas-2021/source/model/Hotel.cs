using System.Collections.Generic;

namespace Tarea_2_Paradigmas_2021.model
{
    class Hotel
    {
        private int nPisos;
        private int nHabitaciones;
        private List<List<Habitacion>> habitaciones = new List<List<Habitacion>>();
        public Hotel(int pisos, int habitaciones)
        {
			nPisos = pisos;
			nHabitaciones = habitaciones;
            inicializarHabitaciones();
        }

        private void inicializarHabitaciones(){
            for (int i = 0; i < nPisos; i++){
				habitaciones[i] = new List<Habitacion>();
                for (int j = 0; j < nHabitaciones; j++){

                }
            }
        }
        public Habitacion this[int piso, int numero]
        {
            get
            {
                return habitaciones[piso][numero];
            }
        }

		public int numPisos{
			get;
		}
		public int numHabitaciones{
			get;
		}

    }
}