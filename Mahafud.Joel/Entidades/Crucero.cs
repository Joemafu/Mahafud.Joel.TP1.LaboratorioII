using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Crucero
    {
        private string nombre;
        private string matricula;
        //private int cantidadCamarotes;
        private Dictionary<string, int> salones;
        private int capacidadBodegaKgs;
        private List<Camarote> camarotesTurista;
        private List<Camarote> camarotesPremium;

        private Crucero(int cantidadCamarotes)
        {
            int i;
            int cantCamarotesPremium = (int)Math.Round(cantidadCamarotes * 0.35);
            int cantCamarotesTurista = (int)Math.Round(cantidadCamarotes * 0.65); 

            this.camarotesPremium = new List<Camarote>();
            this.camarotesTurista = new List<Camarote>();

            for (i=0; i < cantCamarotesPremium;i++)
            {
                this.camarotesPremium.Add(new Camarote(true,i+1));
            }

            for (i = 0; i < cantCamarotesTurista; i++)
            {
                this.camarotesTurista.Add(new Camarote(false, i+1));
            }
        }
        internal Crucero (int cantidadCamarotes, string matricula,string nombre, int piletas,int casinos, int restaurantes, int capacidadBodegaKgs) : this(cantidadCamarotes)
        {
            //this.cantidadCamarotes = cantidadCamarotes;
            this.matricula = matricula;
            this.nombre = nombre;

            this.salones = new Dictionary<string, int>();

            this.salones["piletas"] = piletas;
            this.salones["casinos"] = casinos;
            this.salones["restaurantes"] = restaurantes;

            this.capacidadBodegaKgs = capacidadBodegaKgs;

        }

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
                return this.camarotesPremium.Count;
            }
            //set { }
        }

        public int CantidadCamarotesTurista
        {
            get
            {
                return this.camarotesTurista.Count;
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

        internal List<Camarote> CamarotesPremium
        {
            get
            {
                return this.camarotesPremium;
            }
            //set { }
        }

        internal List<Camarote> CamarotesTurista
        {
            get
            {
                return this.camarotesTurista;
            }
            //set { }
        }

        /*internal override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.Nombre);
            sb.Append(" - "); 
            sb.Append(this.Matricula);
            sb.Append(" - "); 
            sb.Append(this.CapacidadBodegaKgs);
            sb.Append(" - "); 
            sb.Append(this.Salones);

            return "";
        }*/

        /*internal static implicit operator string(Crucero crucero)
        {
            return crucero.ToString();
        }*/

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

    }
}
