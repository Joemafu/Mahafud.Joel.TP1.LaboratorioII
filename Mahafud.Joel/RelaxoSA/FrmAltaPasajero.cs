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
    internal partial class FrmAltaPasajero : FrmAltaModificacionAbs
    {
        private FrmAltaPasajero()
        {
            InitializeComponent();
        }

        internal FrmAltaPasajero(bool esPremium, Viaje viaje) : this()
        {
            this.lblDestino.Text = $"Destino a {viaje.Destino}";
            this.cmbxNacionalidad.Text = "Argentina";
            this.lblId.Text = viaje.Id.ToString();
            double precioNeto;
            double tasas;
            double iva;
            double precioBruto;

            if (esPremium)
            {
                this.lblClase.Text = $"Clase Premium - viaje ID";
                precioNeto = viaje.TarifaPremium;
                this.lblTotalPrecio.Text = $"${precioNeto.ToString("N2")}";
            }
            else
            {
                this.lblClase.Text = $"Clase Turista - viaje ID";
                precioNeto = viaje.TarifaTurista;
                this.lblTotalPrecio.Text = $"${precioNeto.ToString("N2")}";
                this.rbtnDosDespachos.Enabled = false;
            }

            
            precioBruto = precioNeto * 100 / 139;
            tasas = precioBruto * 0.18;
            iva = precioBruto * 0.21;

            this.lblTasasAdicionalesPrecio.Text = tasas.ToString("N2");
            this.lblIvaPrecio.Text = iva.ToString("N2");
            this.lblPrecioBase.Text = precioBruto.ToString("N2");

            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool nombreOk = Validacion.ValidarAlfabetico(this.txtNombre.Text);
            bool apellidoOk = Validacion.ValidarAlfabetico(this.txtApellido.Text);
            bool dniOk = Validacion.ValidarNumerico(this.txtDni.Text);
            bool pasaporteOk = Validacion.ValidarAlfanumerico(this.txtNumeroPasaporte.Text);
            bool equipajeOk = this.ValidarSeleccionEquipaje();
            int equipajeDeMano = 0;
            int equipajesAdicionales=0;

            foreach (Control item in this.gbxEquipajeDespachable.Controls)
            {
                if(item is RadioButton && ((RadioButton)item).Checked)
                {
                    equipajesAdicionales = Int32.Parse(((RadioButton)item).Text);
                }
            }

            if(this.chkbxEquipajeDeMano.Checked)
            {
                equipajeDeMano = 1;
            }

            if(nombreOk&&apellidoOk&&dniOk&&pasaporteOk&&equipajeOk)
            {
                Pasaporte pasaporte = new Pasaporte(this.txtNumeroPasaporte.Text,this.cmbxNacionalidad.Text,this.datepExpedicionPasaporte.Value,this.datepVencimientoPasaporte.Value);
                Pasajero pasajero = new Pasajero(this.txtNombre.Text, this.txtApellido.Text, this.txtDni.Text, this.datepFechaNacimiento.Value, pasaporte, this.lblClase.Text== "Clase Premium - viaje ID", equipajeDeMano, equipajesAdicionales);

                for(int i = 0; i<Hardcodeo.ListaViajesActuales.Count;i++)
                {
                    if (Hardcodeo.ListaViajesActuales[i].Id==Int32.Parse(this.lblId.Text))
                    {
                        Hardcodeo.ListaViajesActuales[i] = Hardcodeo.ListaViajesActuales[i] + pasajero;
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Pasajero agregado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Datos inválidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidarSeleccionEquipaje ()
        {
            return this.rbtnCeroDespachos.Checked || this.rbtnUnDespacho.Checked || this.rbtnDosDespachos.Checked;
        }
    }
}
