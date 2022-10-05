using System;

namespace Entidades
{
    public abstract class Persona
    {
        #region Atributos
        private string nombre;
        private string apellido;
        private string dni;
        #endregion

        #region Constructor

        internal Persona(string nombre, string apellido, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        #endregion

        #region Propiedades
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
        #endregion

        #region Sobreescritura métodos heredados de Object
        public override bool Equals(object obj)
        {
            bool ret = false;

            if (this is null && obj is null)
            {
                ret = true;
            }
            else if (obj is not null && obj is Persona)
            {
                ret = this == (Persona)obj;
            }

            return ret;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"{this.Nombre} {this.Apellido} {this.Dni}";
        }
        #endregion

        #region Sobrecarga de operadores
        public static bool operator ==(Persona p1, Persona p2)
        {
            bool ret = false;

            if (p1.Dni == p2.Dni)
            {
                ret = true;
            }

            return ret;
        }

        public static bool operator !=(Persona c1, Persona c2)
        {
            return !(c1 == c2);
        }
        #endregion
    }
}
