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
    internal partial class FrmEstadisticas : FrmViajesBase
    {
        internal FrmEstadisticas():base()
        {
            InitializeComponent();

        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            FrmViajesBase.ListarViajesEnDGV(Hardcodeo.ListaViajesHistoricos, dgvViajes);
        }

        public override void SetearMensajeAyuda()
        {
            this.chkAyuda.Text = "Aquí se lista un histórico de todos los viajes realizados y programados." +
                "\nPuede ver más estadísticas a continuación.";
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
