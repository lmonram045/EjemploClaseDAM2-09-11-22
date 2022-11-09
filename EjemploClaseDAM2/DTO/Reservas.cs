using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClaseDAM2.DTO
{
    // la cambio de internal a public
    public class Reservas
    {
        
        // Constructor por defecto
        public Reservas()
        {

        }

        private string profesor;
        public string Profesor
        {
            get { return profesor; }
            set { profesor = value; }
        }

        private string aula;
        public string Aula
        {
            get { return aula; }
            set { aula = value; }
        }

        private int alumnos;
        public int Alumnos
        {
            get { return alumnos; }
            set { alumnos = value; }
        }

        public DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
    }
}
