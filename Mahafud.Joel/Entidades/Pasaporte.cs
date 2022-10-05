using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Pasaporte
    {
        #region Atributos
        DateTime fechaExpedicion;
        DateTime fechaVencimiento;
        string nroPasaporte;
        string nacionalidad;
        #endregion

        #region Constructor
        public Pasaporte(string nroPasaporte, string nacionalidad, DateTime fechaExpedicion, DateTime fechaVencimiento)
        {
            this.fechaExpedicion = fechaExpedicion;
            this.fechaVencimiento = fechaVencimiento;
            this.nroPasaporte = nroPasaporte;
            this.nacionalidad = nacionalidad;
        }
        #endregion

        #region Propiedades
        public string NroPasaporte
        {
            get
            {
                return this.nroPasaporte;
            }
            //set;
        }

        public string Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            //set;
        }

        public DateTime FechaExpedicion
        {
            get
            {
                return this.fechaExpedicion;
            }
            //set;
        }

        public DateTime FechaVencimiento
        {
            get
            {
                return this.fechaVencimiento;
            }
            //set;
        }
        #endregion

        #region Sobreescritura de métodos heredados de Object
        public override bool Equals(object obj)
        {
            bool ret = false;

            if (this is null && obj is null)
            {
                ret = true;
            }
            else if (obj is not null && obj is Pasaporte)
            {
                ret = this == (Pasaporte)obj;
            }

            return ret;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"{this.Nacionalidad} Pasaporte Nº {this.NroPasaporte} Vence el  {this.FechaVencimiento.ToShortDateString()}";
        }
        #endregion

        #region Sobrecarga de operadores
        public static bool operator ==(Pasaporte p1, Pasaporte p2)
        {
            bool ret = false;

            if (p1.NroPasaporte == p2.NroPasaporte)
            {
                ret = true;
            }

            return ret;
        }

        public static bool operator !=(Pasaporte c1, Pasaporte c2)
        {
            return !(c1 == c2);
        }
        #endregion
    }
}
