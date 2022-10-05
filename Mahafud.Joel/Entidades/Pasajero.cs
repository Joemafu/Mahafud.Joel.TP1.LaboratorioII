using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Pasajero : Persona
    {
        #region Atributos de instancia
        private Pasaporte pasaporte;
        private DateTime fechaDeNacimiento;
        private int edad;
        private Dictionary<string, int> equipaje;
        private bool esPremium;
        private string numeroDeCamarote;
        #endregion

        #region Atributos estáticos
        private static int numAsignacíonCamarotePremium; 
        private static int numAsignacíonCamaroteTurista;
        #endregion

        #region Constructor estático
        static Pasajero()
        {
            Pasajero.numAsignacíonCamarotePremium = 1; 
            Pasajero.numAsignacíonCamaroteTurista = 1; 
        }
        #endregion

        #region Constructores de instancia
        public Pasajero(string nombre, string apellido, string dni, DateTime fechaDeNacimiento, Pasaporte pasaporte, bool esPremium, int equipajeDeMano, int equipajeDespachado) : base(nombre, apellido, dni)
        {
            this.pasaporte = pasaporte;
            this.esPremium = esPremium;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.edad = Pasajero.CalcularEdad(fechaDeNacimiento);

            this.equipaje = new Dictionary<string, int>();

            this.equipaje["deMano"] = equipajeDeMano;
            this.equipaje["despachado"] = equipajeDespachado;

            string auxNumCamarote = "P" + Pasajero.numAsignacíonCamarotePremium.ToString("00");

            if (esPremium)
            {
                Pasajero.numAsignacíonCamarotePremium++;
            }
            else
            {
                auxNumCamarote = "T" + Pasajero.numAsignacíonCamaroteTurista.ToString("00");
                Pasajero.numAsignacíonCamaroteTurista++;
            }

            this.numeroDeCamarote = auxNumCamarote;
        }

        public Pasajero(string nombre, string apellido, string dni, DateTime fechaDeNacimiento, Pasaporte pasaporte, bool esPremium, int equipajeDeMano, int equipajeDespachado,string numeroDeCamarote) : this(nombre, apellido, dni,fechaDeNacimiento,pasaporte,esPremium,equipajeDeMano,equipajeDespachado)
        {
            this.numeroDeCamarote = numeroDeCamarote;
            if(esPremium)
            {
                numAsignacíonCamarotePremium--;
            }
            else
            {
                numAsignacíonCamaroteTurista--;
            }
        }

            //Constructor sólo para Hardcodeo, Randomiza equipajes
        internal Pasajero(bool esHardcodeado,  string nombre, string apellido, string dni, DateTime fechaDeNacimiento, Pasaporte pasaporte, bool esPremium) : this(nombre, apellido, dni,fechaDeNacimiento,pasaporte,esPremium,0,0)
        {
            Random random = new Random();
            this.edad = Pasajero.CalcularEdad(fechaDeNacimiento);
            this.equipaje["deMano"] = random.Next(0,2);
            int maxDespachados=3;
            string auxNumCamarote = "P"+ Pasajero.numAsignacíonCamarotePremium.ToString("00");

            if (this.esPremium)
            {
                Pasajero.numAsignacíonCamarotePremium++;
            }
            else
            {
                maxDespachados = 2;
                auxNumCamarote = "T"+ Pasajero.numAsignacíonCamaroteTurista.ToString("00");
                Pasajero.numAsignacíonCamaroteTurista++;
            }

            this.equipaje["despachado"] = random.Next(0, maxDespachados);
            this.numeroDeCamarote = auxNumCamarote;
        }
        #endregion

        #region Propiedades
        public string NumeroDeCamarote
        {
            get
            {
                return this.numeroDeCamarote;
            }
            //set { }
        }

        public string Clase
        {
            get
            {
                string clase = "Turista";
                if (this.esPremium)
                {
                    clase = "Premium";
                }
                return clase;
            }
            //set { }
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

        public DateTime FechaDeNacimiento
        {
            get
            {
                return this.fechaDeNacimiento;
            }
            //set { }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
            //set { }
        }

        public Pasaporte Pasaporte
        {
            get
            {
                return this.pasaporte;
            }
            //set { }
        }

        public Dictionary<string, int> Equipaje
        {
            get
            {
                return this.equipaje;
            }
            //set { }
        }

        public bool EsPremium
        {
            get
            {
                return this.esPremium;
            }
            //set { }
        }

        public int GetDespachadoEnKgs 
        {
            get
            {
                return this.equipaje["despachado"]*25;
            }
            //set { }
        }
        #endregion

        #region Métodos estáticos
        private static int CalcularEdad(DateTime fechaDeNacimiento)
        {
            int i = 0;
            fechaDeNacimiento = fechaDeNacimiento.AddYears(1);
            while (fechaDeNacimiento < DateTime.Today)
            {
                i++;
                fechaDeNacimiento = fechaDeNacimiento.AddYears(1);
            }

            return i;
        }
        #endregion

        #region Sobreescritura de métodos heredados de object
        public override bool Equals(object obj)
        {
            bool ret = false;

            if (this is null && obj is null)
            {
                ret = true;
            }
            else if (obj is not null && obj is Pasajero)
            {
                ret = this == (Pasajero)obj;
            }

            return ret;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"{this.Nombre} {this.Apellido} - {this.Dni}";
        }

        #endregion

        #region Sobrecarga de operadores
        public static bool operator ==(Pasajero p1, Pasajero p2)
        {
            bool ret = false;

            if (p1.Dni == p2.Dni)
            {
                ret = true;
            }

            return ret;
        }

        public static bool operator !=(Pasajero c1, Pasajero c2)
        {
            return !(c1 == c2);
        }
        #endregion
    }
}
