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
    internal partial class FrmPasajeros : Form
    {
        internal FrmPasajeros()
        {
            InitializeComponent();
        }

        internal FrmPasajeros(List<Viaje> viajes) :this()
        {
            FrmPasajeros.ListarPasajerosEnDGV(viajes, this.dgvPasajeros);
        }

        private void FrmPasajeros_Load(object sender, EventArgs e)
        {

        }

        internal static void ListarPasajerosEnDGV(List<Viaje> viajes, DataGridView dgv)
        {
            string clase;
            dgv.Rows.Clear();
            foreach (Viaje v in viajes)
            {
                foreach (Pasajero p in v.Pasajeros)
                {
                    clase = "Turista";
                    if(p.EsPremium)
                    {
                        clase = "Premium";
                    }
                    dgv.Rows.Add(
                    //p.NumeroDeCamarote,
                    p.Nombre,
                    p.Apellido,
                    p.Dni,
                    p.Edad,
                    p.FechaDeNacimiento.ToShortDateString(),
                    p.Pasaporte.NroPasaporte,
                    p.Pasaporte.FechaExpedicion.ToShortDateString(),
                    p.Pasaporte.FechaVencimiento.ToShortDateString(),
                    clase,
                    p.Equipaje["deMano"],
                    p.Equipaje["despachado"]);
                }                
            }
        }
    }
}
