using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasajero : Persona
    {
        private Pasaporte pasaporte;
        private DateTime fechaDeNacimiento;
        private int edad;

        private Dictionary<string, int> equipaje;

        /*private bool equipajeDeMano;
        private int equipajeDespachado;*/

        private bool esPremium;

        private string numeroDeCamarote;
        private static int numAsignacíonCamarotePremium; //Solo para el Hardcodeo
        private static int numAsignacíonCamaroteTurista; //Solo para el Hardcodeo

        static Pasajero()
        {
            Pasajero.numAsignacíonCamarotePremium = 1; //Solo para el Hardcodeo
            Pasajero.numAsignacíonCamaroteTurista = 1; //Solo para el Hardcodeo
        }

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

        /*public int NumeroDeCamarote
        {
            get
            {
                return this.numeroDeCamarote;
            }
            //set { }
        }*/

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

    }
}
