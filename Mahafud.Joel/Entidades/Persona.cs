using System;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string dni;

        public Persona(string nombre, string apellido, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            //set;
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            //set;
        }

        public string Dni
        {
            get
            {
                return this.dni;
            }
            //set;
        }
    }
}
