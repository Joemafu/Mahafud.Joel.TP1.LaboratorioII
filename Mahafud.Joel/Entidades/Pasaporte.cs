using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pasaporte
    {
        DateTime fechaExpedicion;
        DateTime fechaVencimiento;
        string nroPasaporte;
        string nacionalidad;

        public Pasaporte(string nroPasaporte, string nacionalidad, DateTime fechaExpedicion, DateTime fechaVencimiento)
        {
            this.fechaExpedicion = fechaExpedicion;
            this.fechaVencimiento = fechaVencimiento;
            this.nroPasaporte = nroPasaporte;
            this.nacionalidad = nacionalidad;
        }

    }
}
