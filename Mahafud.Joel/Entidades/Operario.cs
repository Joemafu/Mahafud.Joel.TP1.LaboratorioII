using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operario : Persona
    {
        private string usuario;
        private string contrasenia;

        public Operario(string nombre, string apellido, string dni, string usuario, string contrasenia) : base(nombre, apellido, dni)
        {
            this.usuario = usuario;
            this.contrasenia = contrasenia;
        }

        new public string Nombre
        {
            get
            {
                return base.Nombre;
            }
            //set { }
        }

        new public string Apellido
        {
            get
            {
                return base.Apellido;
            }
            //set { }
        }

        new public string Dni
        {
            get
            {
                return base.Dni;
            }
            //set { }
        }

        public static bool operator ==(Operario op1, Operario op2)
        {
            bool ret = false;

            if (op1 is not null && op2 is not null)
            {
                ret = op1.usuario == op2.usuario && op1.contrasenia == op2.contrasenia;
            }

            return ret;
        }

        public static bool operator !=(Operario op1, Operario op2)
        {

            return !(op1==op2);
        }

        public override bool Equals(object obj)
        {
            bool ret = false;

            if (obj is Operario)
            {
                ret = this == (Operario)obj;
            }
            return ret;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }

}
