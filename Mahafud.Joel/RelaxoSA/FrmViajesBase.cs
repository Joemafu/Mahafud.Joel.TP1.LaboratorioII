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
    public partial class FrmViajesBase : FrmBase
    {
        public FrmViajesBase()
        {
            InitializeComponent();
        }

        private void FrmViajesBase_Load(object sender, EventArgs e)
        {

        }

        private void dgvViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvViajes_KeyUp(object sender, KeyEventArgs e)
        {

        }

        internal static void ListarViajesEnDGV(List<Viaje> viajes, DataGridView dgv)
        {
            dgv.Rows.Clear();
            foreach (Viaje v in viajes)
            {
                dgv.Rows.Add(
                    v.Id,
                    v.DisponibilidadPremium,
                    v.DisponibilidadTurista,
                    v.Destino,
                    "Buenos Aires", //Origen
                    "$" + v.TarifaPremium.ToString("N2"),
                    "$" + v.TarifaTurista.ToString("N2"),
                    v.DuracionEnHs,
                    v.FechaPartida,
                    v.FechaRegreso,
                    v.Crucero.Nombre,
                    v.CamarotesPremiumDisponibles,
                    v.CamarotesTuristaDisponibles,
                    v.Pasajeros.Count,
                    v.DisponibilidadBodegaKgs);
            }
        }        
    }
}
