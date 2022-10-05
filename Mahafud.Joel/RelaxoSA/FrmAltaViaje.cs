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
    internal partial class FrmAltaViaje : FrmAltaAbstracta
    {
        public FrmAltaViaje()
        {
            InitializeComponent();
            this.dtpFecha.MinDate = DateTime.Today.AddDays(1);
            this.dtpFecha.MaxDate = DateTime.Today.AddYears(2);
            this.dtpFecha.Value = this.dtpFecha.MinDate;

            foreach (Crucero item in Hardcodeo.ListaCruceros)
            {
                this.cmbxCrucero.Items.Add(item.Nombre);
            }

            for (int i = 0;i<18;i++)
            {
                this.cmbxDestino.Items.Add(Viaje.FormatearDestino((EDestino)i));
            }

            this.cmbxDestino.SelectedIndex = 13;
            this.cmbxCrucero.SelectedIndex = 2;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool puedeViajar=false;
            Crucero crucero=Hardcodeo.ListaCruceros[0];
            foreach (Crucero item in Hardcodeo.ListaCruceros)
            {
                if (this.cmbxCrucero.Text==item.Nombre)
                {
                    puedeViajar = item.EstaLibre(this.dtpFecha.Value);
                    crucero = item;
                    break;
                }
            }

            if(puedeViajar)
            {
                if (MessageBox.Show("Está a punto de dar de alta un viaje nuevo. ¿Desea continuar?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Viaje viaje = new Viaje(this.dtpFecha.Value, crucero, (EDestino)this.cmbxDestino.SelectedIndex);
                    Hardcodeo.ListaViajesActuales.Add(viaje);
                    Hardcodeo.ListaViajesHistoricos.Add(viaje);

                    MessageBox.Show("El viaje se dio de alta con éxito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("El crucero está ocupado en esa fecha.\nCambie de crucero o cambie de fecha.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        public override void SetearMensajeAyuda()
        {
            this.chkAyuda.Text = "Dar de alta un nuevo viaje";
        }

        private void chkAyuda_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkAyuda.Checked)
            {
                this.SetearMensajeAyuda();
            }
            else
            {
                this.SetearMensajeAyudaADefault();
            }
        }
    }
}
