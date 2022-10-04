using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace RelaxoSA
{
    internal partial class FrmPasajerosBase : Form
    {
        internal FrmPasajerosBase()
        {
            InitializeComponent();
        }

        internal FrmPasajerosBase(List<Viaje> viajes) :this()
        {
            FrmPasajerosBase.ListarPasajerosEnDGV(viajes, this.dgvPasajeros);
        }

        private void FrmPasajeros_Load(object sender, EventArgs e)
        {

        }

        internal static void ListarPasajerosEnDGV(List<Viaje> viajes, DataGridView dgv)
        {
            FrmPasajerosBase.ListarPasajerosEnDGVConFiltro(viajes, dgv, "Traigo Todo", -1);
        }

        internal static void ListarPasajerosEnDGVConFiltro(List<Viaje> viajes, DataGridView dgv, string palabraFiltro, int criterioBusqueda)
        {
            dgv.Rows.Clear();
            bool noFiltrar=false;
            string auxDatoAComparar="";
            palabraFiltro = palabraFiltro.ToLower();
            foreach (Viaje v in viajes)
            {
                foreach (Pasajero p in v.Pasajeros)
                {
                    switch(criterioBusqueda)
                    {
                        case 1: //Nombre
                            {
                                auxDatoAComparar = p.Nombre;
                                break;
                            }
                        case 2: //Apellido
                            {
                                auxDatoAComparar = p.Apellido;
                                break;
                            }
                        case 3: //DNI
                            {
                                auxDatoAComparar = p.Dni;
                                break;
                            }
                        case 4: //Edad
                            {
                                auxDatoAComparar = p.Edad.ToString();
                                break;
                            }
                        case 5: //Pasaporte
                            {
                                auxDatoAComparar = p.Pasaporte.NroPasaporte;
                                break;
                            }
                        default: //traer todo sin filtro
                            {
                                noFiltrar = true;
                                break;
                            }
                    }
                    auxDatoAComparar = auxDatoAComparar.ToLower();

                    if(noFiltrar || palabraFiltro == auxDatoAComparar)
                    {
                        dgv.Rows.Add(
                        v.Id,
                        p.NumeroDeCamarote,
                        p.Nombre,
                        p.Apellido,
                        p.Dni,
                        p.Edad,
                        p.FechaDeNacimiento.ToString("yyyy/MM/dd"),
                        p.Pasaporte.NroPasaporte,
                        p.Pasaporte.FechaExpedicion.ToString("yyyy/MM/dd"),
                        p.Pasaporte.FechaVencimiento.ToString("yyyy/MM/dd"),
                        p.Clase,
                        p.Equipaje["deMano"],
                        p.Equipaje["despachado"]);
                    }
                }
            }
        }
    }
}
