using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Viaje
    {
        private DateTime fechaPartida;
        private DateTime fechaRegreso;
        private Crucero crucero;
        private List<Pasajero> pasajeros;

        private List<Camarote> camarotesPremium;
        private List<Camarote> camarotesTurista;
        private int cantidadCamarotesPremium;
        private int cantidadCamarotesTurista;

        private EDestino destino;
        private bool regional;
        private double tarifaPremium;
        private double tarifaTurista;
        private int duracionEnHs;
        private int id;
        private static int ultimoIdUsado;

        static Viaje()
        {
            Viaje.ultimoIdUsado = 0;
        }

        public Viaje(DateTime fechaPartida, Crucero crucero, EDestino destino)
        {
            Viaje.ultimoIdUsado++;
            this.id = Viaje.ultimoIdUsado;
            Random random = new Random();

            this.pasajeros = new List<Pasajero>();

            this.camarotesPremium = new List<Camarote>();
            this.camarotesTurista = new List<Camarote>();

            this.fechaPartida = fechaPartida;
            this.crucero = crucero;
            this.destino = destino;
            
            if (((int)this.destino)<10)
            {
                this.regional = true;
                this.duracionEnHs = random.Next(72, 361);
                this.tarifaTurista = this.duracionEnHs * 57;
                this.tarifaPremium = Math.Round(this.tarifaTurista * 1.2, 2);
            }
            else
            {
                this.regional = false;
                this.duracionEnHs = random.Next(480, 720);
                this.tarifaTurista = this.duracionEnHs * 120;
                this.tarifaPremium = Math.Round(this.tarifaTurista * 1.2, 2);
            }

            this.fechaRegreso = this.fechaPartida.AddHours(this.duracionEnHs);
        }

        public int Id { get { return this.id; }
            //set { }
        }

        public DateTime FechaPartida { get { return this.fechaPartida; }
            //set { }
        }

        public DateTime FechaRegreso {  get  {  return this.fechaRegreso;  }
            //set { }
        }

        public int DuracionEnHs { get { return this.duracionEnHs; }
            //set { }
        }

        public string Destino { get { return this.FormatearDestino(); }
            //set { }
        }

        public Crucero Crucero { get { return this.crucero; }
            //set { }
        }

        public List<Pasajero> Pasajeros
        {
            get { return this.pasajeros; }
            //set { }
        }

        public double TarifaPremium { get { return this.tarifaPremium; }
            //set { }
        }

        public double TarifaTurista { get { return this.tarifaTurista; }
            //set { }
        }

        public int CamarotesPremiumDisponibles
        {
            get { return this.ActualizarDisponibilidadPasajeros(true, this.crucero.CantidadCamarotesPremium); }
            //set { }
        }

        public int CamarotesTuristaDisponibles
        {
            get { return this.ActualizarDisponibilidadPasajeros(false, this.crucero.CantidadCamarotesTurista); }
            //set { }
        }

        public EDisponibilidad DisponibilidadPremium { get { return CalcularDisponibilidad(this.CamarotesPremiumDisponibles, this.crucero.CantidadCamarotesPremium); }
            //set { }
        }

        public EDisponibilidad DisponibilidadTurista { get { return CalcularDisponibilidad(this.CamarotesTuristaDisponibles, this.crucero.CantidadCamarotesTurista); }
            //set { }
        }

        public int DisponibilidadBodegaKgs { get { return this.crucero.CapacidadBodegaKgs - this.CalcularCargaEnBodega(); }
            //set { }
        }

        public static Viaje operator+(Viaje viaje, Pasajero pasajero)
        {
            bool esPremium = pasajero.EsPremium;
            int kgsDespacho = pasajero.GetDespachadoEnKgs;
            
            if((esPremium && viaje.CamarotesPremiumDisponibles > 0 || !esPremium && viaje.CamarotesTuristaDisponibles > 0) && kgsDespacho<viaje.DisponibilidadBodegaKgs && viaje!=pasajero)
            {
                viaje.pasajeros.Add(pasajero);
            }
            return viaje;
        }

        public static bool operator == (Viaje viaje, Pasajero pasajero)
        {
            bool ret = false;

            foreach(Pasajero p in viaje.Pasajeros)
            {
                if (pasajero.Dni==p.Dni)
                {
                    ret = true;
                    break;
                }
            }

            return ret;
        }

        public static bool operator !=(Viaje viaje, Pasajero pasajero)
        {
            return !(viaje == pasajero);
        }

        public override bool Equals(object obj)
        {
            bool ret=false;
            if (obj is not null && obj is Viaje)
            {
                ret = this == obj;
            }
            return ret;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        private string FormatearDestino()
        {
            string ret;

            switch ((int)this.destino)
            {
                case 5:
                    {
                        ret = "Isla de Pascua";
                        break;
                    }
                case 6:
                    {
                        ret = "Isla Galápagos";
                        break;
                    }
                case 7:
                    {
                        ret = "Puerto Madryn";
                        break;
                    }
                case 8:
                    {
                        ret = "Río de Janeiro";
                        break;
                    }
                case 10:
                    {
                        ret = "La Habana";
                        break;
                    }
                case 14:
                    {
                        ret = "Nueva York";
                        break;
                    }
                default:
                    {
                        ret = this.destino.ToString();
                        break;
                    }
            }
            return ret;
        }

        private int ActualizarDisponibilidadPasajeros(bool esPremium, int capacidadMaxima)
        {
            int capacidadActual = capacidadMaxima;

            foreach (Pasajero item in this.pasajeros)
            {
                if (item.EsPremium == esPremium)
                {
                    capacidadActual--;
                }
            }           

            return capacidadActual;
        }

        private EDisponibilidad CalcularDisponibilidad(int capacidadActual, int capacidadMaxima)
        {
            EDisponibilidad ret = EDisponibilidad.Alta;

            if (capacidadActual < capacidadMaxima * 0.65)
            {
                ret = EDisponibilidad.Media;

                if (capacidadActual < capacidadMaxima * 0.30)
                {
                    ret = EDisponibilidad.Baja;

                    if (capacidadActual == 0)
                    {
                        ret = EDisponibilidad.Agotado;
                    }
                }                
            }

            return ret;
        }

        private int CalcularCargaEnBodega()
        {
            int ret = -100;

            foreach (Pasajero item in this.pasajeros)
            {
                ret += item.GetDespachadoEnKgs;
            }
            
            return ret;
        }

        public static Viaje BuscarViajePorId(List<Viaje>listaViajes, int idViaje)
        {
            Viaje auxViaje = null;

            foreach (Viaje item in listaViajes)
            {
                if (item.Id == idViaje)
                {
                    auxViaje = item;
                    break;
                }
            }
            return auxViaje;
        }
    }
}
