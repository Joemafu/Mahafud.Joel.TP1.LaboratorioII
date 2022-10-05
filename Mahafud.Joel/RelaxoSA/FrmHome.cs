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
    internal partial class FrmHome : FrmBase
    {
        private FrmIniciarSesion frmIniciarSesion;
       
        internal FrmHome()
        {
            InitializeComponent();
        }

        internal FrmHome(FrmIniciarSesion frmIniciarSesion) : this()
        {
            this.frmIniciarSesion = frmIniciarSesion;
        }

        internal void SetearBienvenida(string nombreDelOperario)
        {
            this.lblBienvenido.Text = $"Bienvenido {nombreDelOperario}! Hoy es {DateTime.Today.ToShortDateString()}";
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.frmIniciarSesion.Show();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Está seguro de que quiere salir de la aplicación?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)==DialogResult.OK)
            {
                this.frmIniciarSesion.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnViajes_Click(object sender, EventArgs e)
        {
            FrmViajesVenta frmViajes = new FrmViajesVenta();

            frmViajes.ShowDialog();
        }

        private void btnPasajeros_Click(object sender, EventArgs e)
        {
            FrmPasajerosCompleto frmPasajeros = new FrmPasajerosCompleto(Hardcodeo.ListaViajesActuales);

            frmPasajeros.ShowDialog();
        }

        private void btnCruceros_Click(object sender, EventArgs e)
        {
            FrmCruceros frmCruceros = new FrmCruceros(Hardcodeo.ListaCruceros);

            frmCruceros.ShowDialog();
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            FrmEstadisticas frmEstadisticas = new FrmEstadisticas();

            frmEstadisticas.ShowDialog();
        }

        public override void SetearMensajeAyuda()
        {
            this.chkAyuda.Text = "" +
                "Vender Pasajes : Lista los viajes programados. Permite vender pasajes y ver pasajeros asociados." +
                "\nAgregar Viaje: Permite Programar un nuevo viaje un crucero." +
                "\nBuscar Pasajeros: Filtrar resultados entre toda la base de datos de pasajeros." +
                "\nVer Flota: Permite consultar los cruceros de la Compañía." +
                "\nConsultar Estadísticas: Permite revisar datos históricos de la Empresa." +
                "\nCerrar Sesión: Cierra la sesión actual.";
        }

        private void chkAyuda_CheckedChanged(object sender, EventArgs e)
        {
            if(this.chkAyuda.Checked)
            {
                this.SetearMensajeAyuda();
            }
            else
            {
                this.SetearMensajeAyudaADefault();
            }
        }

        private void btnAgregarViaje_Click(object sender, EventArgs e)
        {
            FrmViajesAgregar frmAltaViaje = new FrmViajesAgregar();

            frmAltaViaje.ShowDialog();
        }
    }
}