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
    public partial class FrmEstadisticasAmpliadas : FrmBase
    {
        public FrmEstadisticasAmpliadas()
        {
            InitializeComponent();
        }

        public override void SetearMensajeAyuda()
        {
            this.chkAyuda.Text = "Aquí se puede navegar por distintas estadísticas históricas de la Compañía.";
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

        private void tabEstadisticas_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmEstadisticasAmpliadas_Load(object sender, EventArgs e)
        {
            this.tabPage1.Text = "Destinos más facturados";
            this.tabPage1.Name = "tDestinosPorFacturacion";

            this.tabPage2.Text = "Pasajeros más frecuentes";
            this.tabPage2.Name = "tPasajerosFrecuentes";
            
            this.tabPage3.Text = "Servicio más solicitado";
            this.tabPage3.Name = "tFacturacionPorServicio";
            
            this.tabPage4.Text = "Cruceros con más viaje (hs.)";
            this.tabPage4.Name = "tHorasDeViajePorCrucero";
            
            this.tabPage5.Text = "Destinos más vendidos";
            this.tabPage5.Name = "DestinosPorVentas";

            this.CargarDestinosMasFacturados();
            this.CargarPasajerosMasFrecuentes();
            this.CargarServicioMasFacturado();
            this.CargarCrucerosConMasHorasViaje();
            this.CargarDestinosMasVendidos();
        }

        private void CargarDestinosMasFacturados()
        {
            
            List<KeyValuePair<int, double>> listaDestinoYFacturacion = Viaje.CalcularDestinosMasFacturados();

            listaDestinoYFacturacion.Sort(Comparacion);


            foreach (KeyValuePair<int, double> item in listaDestinoYFacturacion)
            {
                this.dgvDestinoYFacturacion.Rows.Add((EDestino)item.Key, item.Value.ToString("N2"));
            }
        }

        private void CargarPasajerosMasFrecuentes()
        {
            List<KeyValuePair<string, int>> listaPasajerosFrecuentes = Viaje.CalcularPasajerosMasFrecuentes();

            listaPasajerosFrecuentes.Sort(Comparacion);

            foreach (KeyValuePair<string, int> item in listaPasajerosFrecuentes)
            {
                foreach(Viaje v in Hardcodeo.ListaViajesHistoricos)
                {
                    foreach (Pasajero p in v.Pasajeros)
                    {
                        if (item.Key==p.Dni)
                        {
                            this.dgvPasajerosFrecuentes.Rows.Add(p.Nombre, p.Apellido, p.Dni, item.Value);
                            break;
                        }
                    }
                    break;
                }
            }
        }
        
        private void CargarServicioMasFacturado()
        {
            double ventasPasajeRegional = 0;
            double ventasPasajeExtraRegional = 0;
            List<KeyValuePair<int, double>> listaDestinoYFacturacion = Viaje.CalcularDestinosMasFacturados();

            foreach (KeyValuePair<int, double> item in listaDestinoYFacturacion)
            {
                if (item.Key>9)
                {
                    ventasPasajeExtraRegional += item.Value;
                }
                else
                {
                    ventasPasajeRegional += item.Value;
                }
            }

            if (ventasPasajeRegional > ventasPasajeExtraRegional)
            {
                this.dgvServicioMasSolicitado.Rows.Add("Regional", ventasPasajeRegional);
                this.dgvServicioMasSolicitado.Rows.Add("Extra-Regional", ventasPasajeExtraRegional);
            }
            else
            {
                this.dgvServicioMasSolicitado.Rows.Add("Extra-Regional", ventasPasajeExtraRegional);
                this.dgvServicioMasSolicitado.Rows.Add("Regional", ventasPasajeRegional);
            }
        }

        private void CargarCrucerosConMasHorasViaje()
        {

        }

        private void CargarDestinosMasVendidos()
        {

        }

        public int Comparacion(KeyValuePair<int, double> kV1, KeyValuePair<int, double> kV2)
        {
            int ret = 1;

            if ((double)kV1.Value == (double)kV2.Value)
            {
                ret = 0;
            }
            else if ((double)kV1.Value > (double)kV2.Value)
            {
                ret = -1;
            }

            return ret;
        }

        public int Comparacion(KeyValuePair<string, int> kV1, KeyValuePair<string, int> kV2)
        {
            int ret = 1;

            if ((double)kV1.Value == (double)kV2.Value)
            {
                ret = 0;
            }
            else if ((double)kV1.Value > (double)kV2.Value)
            {
                ret = -1;
            }

            return ret;
        }
    }
}
