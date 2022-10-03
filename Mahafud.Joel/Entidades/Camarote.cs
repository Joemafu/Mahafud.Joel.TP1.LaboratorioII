using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camarote
    {
        private List<Pasajero> pasajeros;
        private static int capacidad;
        private bool esPremium;
        private bool estaLleno;
        private int id;
        
        static Camarote()
        {
            Camarote.capacidad = 4;
        }
        public Camarote(bool esPremium,int id)
        {
            this.esPremium = esPremium;
            this.pasajeros = new List<Pasajero>();
            this.estaLleno = false;
        }
        /*public Camarote(bool esPremium, int id, Pasajero p1) : this(esPremium, id)
        {
            pasajeros.Add(p1);
        }
        public Camarote(bool esPremium, int id, Pasajero p1, Pasajero p2) : this(esPremium, id, p1)
        {
            pasajeros.Add(p2);
        }
        public Camarote(bool esPremium, int id, Pasajero p1, Pasajero p2, Pasajero p3) : this(esPremium, id, p1, p2)
        {
            pasajeros.Add(p3);
        }
        public Camarote(bool esPremium, int id, Pasajero p1, Pasajero p2, Pasajero p3, Pasajero p4) : this(esPremium, id, p1, p2, p3)
        {
            pasajeros.Add(p4);
            estaLleno = true;
        }*/
    }
}
