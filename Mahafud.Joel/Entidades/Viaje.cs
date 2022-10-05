using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public sealed class Viaje
    {
        #region Atributos de instancia
        private DateTime fechaPartida;
        private DateTime fechaRegreso;
        private Crucero crucero;
        private List<Pasajero> pasajeros;
        private EDestino destino;
        private bool esRegional;
        private double tarifaPremium;
        private double tarifaTurista;
        private int duracionEnHs;
        private int id;
        #endregion

        #region Atributo estático
        private static int ultimoIdUsado;
        #endregion

        #region Constructor estático
        static Viaje()
        {
            Viaje.ultimoIdUsado = 0;
        }
        #endregion

        #region Constructor de instancia
        public Viaje(DateTime fechaPartida, Crucero crucero, EDestino destino)
        {
            Viaje.ultimoIdUsado++;
            this.id = Viaje.ultimoIdUsado;
            Random random = new Random();

            this.pasajeros = new List<Pasajero>();

            this.fechaPartida = fechaPartida;
            this.crucero = crucero;
            this.destino = destino;

            if (((int)this.destino) < 10)
            {
                this.esRegional = true;
                this.duracionEnHs = random.Next(72, 361);
                this.tarifaTurista = this.duracionEnHs * 57;
                this.tarifaPremium = Math.Round(this.tarifaTurista * 1.2, 2);
            }
            else
            {
                this.esRegional = false;
                this.duracionEnHs = random.Next(480, 720);
                this.tarifaTurista = this.duracionEnHs * 120;
                this.tarifaPremium = Math.Round(this.tarifaTurista * 1.2, 2);
            }

            this.fechaRegreso = this.fechaPartida.AddHours(this.duracionEnHs);
        }
        #endregion

        #region Propiedades
        public int Id
        {
            get { return this.id; }
            //set { }
        }
        public bool EsRegional
        {
            get { return this.esRegional; }
            //set { }
        }

        public DateTime FechaPartida { get { return this.fechaPartida; }
            //set { }
        }

        public DateTime FechaRegreso { get { return this.fechaRegreso; }
            //set { }
        }

        public int DuracionEnHs { get { return this.duracionEnHs; }
            //set { }
        }

        public string Destino { get { return this.FormatearDestino(); }
            //set { }
        }
        public EDestino EDestino
        {
            get { return this.destino; }
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
        #endregion

        #region Metodos de instancia

        private string FormatearDestino()
        {
            return Viaje.FormatearDestino(this.destino);
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

        #endregion

        #region Metodos estáticos
        public static string FormatearDestino(EDestino destino)
        {
            string ret;

            switch ((int)destino)
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
                        ret = destino.ToString();
                        break;
                    }
            }
            return ret;
        }

        public static Viaje BuscarViajePorId(List<Viaje> listaViajes, int idViaje)
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

        public static List<KeyValuePair<int, double>> CalcularDestinosMasFacturados()
        {
            Dictionary<int, double> destinoYRecaudacion = new Dictionary<int, double>();
            List<KeyValuePair<int, double>> listaDestinoYFacturacion = new List<KeyValuePair<int, double>>();

            int premiumVendidos;
            int turistaVendidos;
            double recaudado;

            foreach (Viaje v in Hardcodeo.ListaViajesHistoricos)
            {
                premiumVendidos = v.Crucero.CantidadCamarotesPremium - v.CamarotesPremiumDisponibles;
                turistaVendidos = v.Crucero.CantidadCamarotesTurista - v.CamarotesTuristaDisponibles;
                recaudado = premiumVendidos * v.TarifaPremium + turistaVendidos * v.TarifaTurista;

                if (!destinoYRecaudacion.ContainsKey((int)v.EDestino))
                {
                    destinoYRecaudacion.Add((int)v.EDestino, recaudado);
                }
                else
                {
                    destinoYRecaudacion[(int)v.EDestino] += recaudado;
                }
            }

            listaDestinoYFacturacion = destinoYRecaudacion.ToList();

            return listaDestinoYFacturacion;
        }

        public static List<KeyValuePair<string, int>> CalcularPasajerosMasFrecuentes()
        {
            Dictionary<string, int> pasajerosFrecuentes = new Dictionary<string, int>();

            List<KeyValuePair<string, int>> listaPasajerosFrecuentes = new List<KeyValuePair<string, int>>();

            foreach (Viaje v in Hardcodeo.ListaViajesHistoricos)
            {
                foreach (Pasajero p in v.Pasajeros)
                {
                    if (!pasajerosFrecuentes.ContainsKey(p.Dni))
                    {
                        pasajerosFrecuentes.Add(p.Dni, 1);
                    }
                    else
                    {
                        pasajerosFrecuentes[p.Dni]++;
                    }
                }
            }

            listaPasajerosFrecuentes = pasajerosFrecuentes.ToList();

            return listaPasajerosFrecuentes;
        }

        public static List<KeyValuePair<string, int>> CalcularCrucerosConMasHorasViajadas()
        {
            Dictionary<string, int> crucerosConMasHorasViajadas = new Dictionary<string, int>();
            List<KeyValuePair<string, int>> listaCrucerosConHorasViaajadas = new List<KeyValuePair<string, int>>();

            foreach (Viaje v in Hardcodeo.ListaViajesHistoricos)
            {
                if (!crucerosConMasHorasViajadas.ContainsKey(v.Crucero.Nombre))
                {
                    crucerosConMasHorasViajadas.Add(v.Crucero.Nombre, v.DuracionEnHs);
                }
                else
                {
                    crucerosConMasHorasViajadas[v.Crucero.Nombre] += v.DuracionEnHs;
                }
            }

            listaCrucerosConHorasViaajadas = crucerosConMasHorasViajadas.ToList();

            return listaCrucerosConHorasViaajadas;
        }

        public static List<KeyValuePair<int, int>> CalcularDestinoMasVendido()
        {
            Dictionary<int, int> destinoYPasajesVendidos = new Dictionary<int, int>();
            List<KeyValuePair<int, int>> listaDestinoYPasajesVendidos = new List<KeyValuePair<int, int>>();

            foreach (Viaje v in Hardcodeo.ListaViajesHistoricos)
            {

                if (!destinoYPasajesVendidos.ContainsKey((int)v.EDestino))
                {
                    destinoYPasajesVendidos.Add((int)v.EDestino, v.Pasajeros.Count);
                }
                else
                {
                    destinoYPasajesVendidos[(int)v.EDestino] += v.Pasajeros.Count;
                }
            }

            listaDestinoYPasajesVendidos = destinoYPasajesVendidos.ToList();

            return listaDestinoYPasajesVendidos;
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
            else if (obj is not null && obj is Viaje)
            {
                ret = this == (Viaje)obj;
            }

            return ret;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"ID {this.Id} - Destino {FormatearDestino(this.EDestino)} - Duración {this.DuracionEnHs} - Fecha partida {this.FechaPartida.ToShortDateString()} - Fecha regreso {this.FechaRegreso.ToShortDateString()}";
        }

        #endregion

        #region Sobrecarga de operadores

        public static Viaje operator +(Viaje viaje, Pasajero pasajero)
        {
            bool esPremium = pasajero.EsPremium;
            int kgsDespacho = pasajero.GetDespachadoEnKgs;

            if ((esPremium && viaje.CamarotesPremiumDisponibles > 0 || !esPremium && viaje.CamarotesTuristaDisponibles > 0) && kgsDespacho < viaje.DisponibilidadBodegaKgs && viaje != pasajero)
            {
                viaje.pasajeros.Add(pasajero);
            }
            return viaje;
        }

        public static bool operator ==(Viaje viaje, Pasajero pasajero)
        {
            bool ret = false;

            foreach (Pasajero p in viaje.Pasajeros)
            {
                if (pasajero.Dni == p.Dni)
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

        public static bool operator ==(Viaje p1, Viaje p2)
        {
            bool ret = false;

            if (p1.Id == p2.Id)
            {
                ret = true;
            }

            return ret;
        }

        public static bool operator !=(Viaje c1, Viaje c2)
        {
            return !(c1 == c2);
        }

        #endregion
    }
}
