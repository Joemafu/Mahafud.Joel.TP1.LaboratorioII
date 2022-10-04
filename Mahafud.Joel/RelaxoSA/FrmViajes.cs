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
    internal partial class FrmViajes : Form
    {
        internal FrmViajes()
        {
            InitializeComponent();
            FrmViajes.ListarViajesEnDGV(Hardcodeo.ListaViajes, this.dgvViajes);
            SetearBotonesVenta(false);
        }

        private void dgvViajes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarInfoViajeSeleccionado();
        }

        private void dgvViajes_KeyUp(object sender, KeyEventArgs e)
        {
            MostrarInfoViajeSeleccionado();
        }

        private void btnVentaPremium_Click(object sender, EventArgs e)
        {
            this.VenderPasaje(true);
        }

        private void btnVentaTurista_Click(object sender, EventArgs e)
        {
            this.VenderPasaje(false);
        }

        private void btnPasajeros_Click(object sender, EventArgs e)
        {
            Viaje auxViaje = ObtenerViajePorFilaSeleccionada();
            List<Viaje> auxListViajes = new List<Viaje>();

            auxListViajes.Add(auxViaje);
            FrmPasajeros frmPasajeros = new FrmPasajeros(auxListViajes);

            frmPasajeros.ShowDialog();
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

        private void MostrarInfoViajeSeleccionado()
        {
            Viaje auxViaje = this.ObtenerViajePorFilaSeleccionada();
            StringBuilder sb = new StringBuilder();

            this.SetearBotonesVenta(true);


            if (DateTime.Today > auxViaje.FechaPartida)
            {
                sb.Append("Este crucero ya zarpó.\n\n");
                this.SetearBotonesVenta(false);
            }
            else if (auxViaje.DisponibilidadPremium == EDisponibilidad.Agotado &&
               auxViaje.DisponibilidadTurista == EDisponibilidad.Agotado ||
               auxViaje.DisponibilidadBodegaKgs < 50)
            {
                sb.Append("No hay disponibilidad para este crucero.\n\n");
                this.SetearBotonesVenta(false);
            }
            else
            {
                if (auxViaje.DisponibilidadPremium == EDisponibilidad.Agotado)
                {
                    sb.Append("Solo quedan camarotes de clase Turista para este crucero.\n\n");
                    this.btnVentaPremium.Enabled = false;
                }
                if (auxViaje.DisponibilidadTurista == EDisponibilidad.Agotado)
                {
                    sb.Append("Solo quedan camarotes de clase Premium para este crucero.\n\n");
                    this.btnVentaTurista.Enabled = false;
                }

                sb.AppendLine($"Con destino a {auxViaje.Destino}, y con una duración de {auxViaje.DuracionEnHs} hs. el crucero {auxViaje.Crucero.Nombre} " +
                $"zarpará desde Buenos Aires hacia {auxViaje.Destino} el día {auxViaje.FechaPartida.ToShortDateString()}, regresando el {auxViaje.FechaRegreso.ToShortDateString()}." +
                $"\nÉste cuenta con las siguientes comodidades:\n* {auxViaje.Crucero.Salones["piletas"]} Piletas" +
                $"\n* {auxViaje.Crucero.Salones["casinos"]} Casinos.\n* {auxViaje.Crucero.Salones["restaurantes"]} Restaurantes.");

            }
            this.lblDetalle.Text = sb.ToString();
        }

        private void SetearBotonesVenta(bool habilitado)
        {
            this.btnVentaPremium.Enabled = habilitado;
            this.btnVentaTurista.Enabled = habilitado;
        }

        private int BuscarIdDeViajePorIndiceDeFila(int indice)
        {
            int idViaje;

            DataGridViewRow row = dgvViajes.Rows[indice];

            idViaje = int.Parse(row.Cells[0].Value.ToString());

            return idViaje;
        }

        private void VenderPasaje(bool esPremium)
        {
            int indice = FrmViajes.LocalizarIndiceFilaSeleccionada(this.dgvViajes);

            int idViaje = this.BuscarIdDeViajePorIndiceDeFila(indice);

            Viaje auxViaje = Viaje.BuscarViajePorId(Hardcodeo.ListaViajes, idViaje);

            FrmAltaPasajero frmAltaPasajero = new FrmAltaPasajero(esPremium, auxViaje);

            frmAltaPasajero.ShowDialog();

            if (frmAltaPasajero.DialogResult == DialogResult.OK)
            {
                FrmViajes.ListarViajesEnDGV(Hardcodeo.ListaViajes, this.dgvViajes);
                this.SetearBotonesVenta(false);
            }
        }

        private Viaje ObtenerViajePorFilaSeleccionada()
        {
            int indiceFilaSeleccionada = FrmViajes.LocalizarIndiceFilaSeleccionada(this.dgvViajes);
            int idViaje = this.BuscarIdDeViajePorIndiceDeFila(indiceFilaSeleccionada);
            Viaje auxViaje = null; ;

            if (indiceFilaSeleccionada >= 0)
            {
                auxViaje = Viaje.BuscarViajePorId(Hardcodeo.ListaViajes, idViaje);
            }

            return auxViaje;
        }

        internal static int LocalizarIndiceFilaSeleccionada(DataGridView dgv)
        {
            int i = 0;
            bool encontrado = false;

            for (; i < dgv.RowCount; i++)
            {
                if (dgv.Rows[i].Selected)
                {
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                i = -1;
            }

            return i;
        }
    }
}
