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
    internal partial class FrmHome : Form
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

        internal void setearBienvenida(string nombreDelOperario)
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
            FrmViajes frmViajes = new FrmViajes();

            frmViajes.ShowDialog();
        }

        private void btnPasajeros_Click(object sender, EventArgs e)
        {
            FrmPasajeros frmPasajeros = new FrmPasajeros();

            frmPasajeros.ShowDialog();
        }

        private void btnCruceros_Click(object sender, EventArgs e)
        {
            FrmCruceros frmCruceros = new FrmCruceros(Hardcodeo.ListaCruceros);

            frmCruceros.ShowDialog();
        }        

        
    }
}