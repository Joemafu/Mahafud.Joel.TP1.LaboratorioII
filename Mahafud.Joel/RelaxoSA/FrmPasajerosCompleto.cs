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
    internal partial class FrmPasajerosCompleto : FrmPasajerosBase
    {
        /*internal FrmPasajerosCompleto():base()
        {
            InitializeComponent();
        }*/

        public FrmPasajerosCompleto(List<Viaje> viajes):base(viajes)
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtValorDeBusqueda.PlaceholderText = "Ingrese " + this.cmbCriterioDeBusqueda.Text;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(Validacion.ValidarTexto(this.txtValorDeBusqueda.Text))
            {
                FrmPasajerosBase.ListarPasajerosEnDGVConFiltro(Hardcodeo.ListaViajesActuales, this.dgvPasajeros,this.txtValorDeBusqueda.Text,cmbCriterioDeBusqueda.SelectedIndex+1);
                if(this.dgvPasajeros.RowCount==0)
                {
                    this.lblCantidadResultados.Text = "No se encontraron coincidencias.";
                }
                else
                {
                    this.lblCantidadResultados.Text = this.dgvPasajeros.RowCount + " Resultados.";
                }
            }
            else
            {
                FrmPasajerosBase.ListarPasajerosEnDGVConFiltro(Hardcodeo.ListaViajesActuales, this.dgvPasajeros, "Traemos todo", -1);
                this.lblCantidadResultados.Text = "No se ingresaron datos para buscar. Mostrando todos los resultados";
            }
        }

        private void FrmPasajerosCompleto_Load(object sender, EventArgs e)
        {
            this.cmbCriterioDeBusqueda.SelectedItem = "Nombre";
        }

        public override void SetearMensajeAyuda()
        {
            this.chkAyuda.Text = "Aquí se listan todos los pasajeros de los cruceros actuales" +
                "\nSe puede filtrar los resultados con la herramienta de búsqueda.";
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
