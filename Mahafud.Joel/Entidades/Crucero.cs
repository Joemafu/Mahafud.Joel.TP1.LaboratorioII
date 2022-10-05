using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Crucero
    {
        #region Atributos
        private string nombre;
        private string matricula;
        private Dictionary<string, int> salones;
        private int capacidadBodegaKgs;
        int cantidadCamarotesPremium;
        int cantidadCamarotesTurista;
        #endregion

        #region Constructores
        private Crucero(int cantidadCamarotes)
        {
            this.cantidadCamarotesPremium = (int)Math.Round(cantidadCamarotes * 0.35);
            this.cantidadCamarotesTurista = (int)Math.Round(cantidadCamarotes * 0.65); 
        }
        internal Crucero (int cantidadCamarotes, string matricula,string nombre, int piletas,int casinos, int restaurantes, int capacidadBodegaKgs) : this(cantidadCamarotes)
        {
            this.matricula = matricula;
            this.nombre = nombre;

            this.salones = new Dictionary<string, int>();

            this.salones["piletas"] = piletas;
            this.salones["casinos"] = casinos;
            this.salones["restaurantes"] = restaurantes;

            this.capacidadBodegaKgs = capacidadBodegaKgs;
        }
        #endregion

        #region Propiedades
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            //set { }
        }

        public string Matricula
        {
            get
            {
                return this.matricula;
            }
            //set { }
        }

        public int CantidadCamarotesPremium
        {
            get
            {
                return this.cantidadCamarotesPremium;
            }
            //set { }
        }

        public int CantidadCamarotesTurista
        {
            get
            {
                return this.cantidadCamarotesTurista;
            }
            //set { }
        }

        public Dictionary<string, int> Salones
        {
            get
            {
                return this.salones;
            }
            //set { }
        }

        public int CapacidadBodegaKgs
        {
            get
            {
                return this.capacidadBodegaKgs;
            }
            //set { }
        }
        #endregion

        #region Métodos
        public bool EstaLibre(DateTime fecha)
        {
            bool ret = true;
            foreach(Viaje v in Hardcodeo.ListaViajesActuales)
            {
                if(v.Crucero.Matricula==this.Matricula)
                {
                    if (v.FechaPartida<=fecha && v.FechaRegreso>=fecha)
                    {
                        ret = false;
                        break;
                    }
                }
            }
            return ret;
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
            else if (obj is not null && obj is Crucero)
            {
                ret = this == (Crucero)obj;
            }

            return ret;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"Nombre {this.Nombre} - Matrícula {this.Matricula}";
        }
        #endregion

        #region Sobrecarga de operadores
        public static bool operator ==(Crucero c1, Crucero c2)
        {
            bool ret = false;

            if(c1.Matricula==c2.Matricula)
            {
                ret = true;
            }

            return ret;
        }

        public static bool operator !=(Crucero c1, Crucero c2)
        {
            return !(c1==c2);
        }
        #endregion
    }
}
