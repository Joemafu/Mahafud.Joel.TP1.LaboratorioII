using System;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string dni;

        internal Persona(string nombre, string apellido, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        internal string Nombre
        {
            get
            {
                return this.nombre;
            }
            //set;
        }

        internal string Apellido
        {
            get
            {
                return this.apellido;
            }
            //set;
        }

        internal string Dni
        {
            get
            {
                return this.dni;
            }
            //set;
        }
    }
}
