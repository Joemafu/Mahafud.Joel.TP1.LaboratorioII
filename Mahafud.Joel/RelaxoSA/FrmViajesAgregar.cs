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
    public partial class FrmViajesAgregar : FrmViajesBase
    {
        public FrmViajesAgregar()
        {
            InitializeComponent();
            FrmViajesBase.ListarViajesEnDGV(Hardcodeo.ListaViajesActuales, this.dgvViajes);
        }

        public override void SetearMensajeAyuda()
        {
            this.chkAyuda.Text = "Desde acá podemos dar de alta un nuevo viaje.";
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

        private void btnAltaviaje_Click(object sender, EventArgs e)
        {
            FrmAltaViaje frmAltaViaje = new FrmAltaViaje();

            frmAltaViaje.ShowDialog();

            if(frmAltaViaje.DialogResult==DialogResult.OK)
            {
                FrmViajesBase.ListarViajesEnDGV(Hardcodeo.ListaViajesActuales, this.dgvViajes);
            }
        }
    }
}
