using System.Collections.Generic;
using System;

namespace Tarea_2_Paradigmas_2021.model
{
    class HotelController
    {
        private int nPisos;
        private int nHabitaciones;
        private List<List<Habitacion>> habitaciones = new List<List<Habitacion>>();
        public HotelController(int pisos, int habitaciones)
        {
            nPisos = pisos;
            nHabitaciones = habitaciones;
            inicializarHabitaciones();
        }

        private void inicializarHabitaciones()
        {
            Random rng = new Random();
            for (int i = 0; i < nPisos; i++)
            {
                habitaciones.Add(new List<Habitacion>());
                for (int j = 0; j < nHabitaciones; j++)
                {
                    habitaciones[i].Add(new Habitacion(
                        string.Format("{0}/{1}", i, j),
                        'L',
                        null,
                        null,
                        rng.Next(2, 6),
                        new String(rng.Next(1, 4) switch
                        {
                            1 => "PC",
                            2 => "SC",
                            3 => "TC",
                            _ => "?"
                        })
                    ));
                }
            }
        }

        public List<Habitacion> habitacionesLibres(){
            List<Habitacion> libres = new List<Habitacion>();
            return libres;
        }

        public Habitacion this[int piso, int numero]
        {
            get
            {
                return habitaciones[piso][numero];
            }
        }
        public int numPisos
        {
            get;
        }
        public int numHabitaciones
        {
            get;
        }

    }
}