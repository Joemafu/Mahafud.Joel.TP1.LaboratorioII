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
    public partial class FrmHome : Form
    {
        private FrmIniciarSesion frmIniciarSesion;
       
        public FrmHome()
        {
            InitializeComponent();
        }

        public FrmHome(FrmIniciarSesion frmIniciarSesion) : this()
        {
            this.frmIniciarSesion = frmIniciarSesion;
        }

        public void setearBienvenida(string nombreDelOperario)
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
            Hardcodeo hC = new Hardcodeo();

            /*FrmHome.ListarViajesEnDGV(Hardcodeo.ListaViajes,this.dgvViajes);
            FrmHome.ListarCrucerosEnDGV(Hardcodeo.ListaCruceros,this.dgvCruceros);*/
        }

        private void FrmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.frmIniciarSesion.Dispose();
        }

        

        

        public static void ListarCrucerosEnDGV(List<Crucero> cruceros, DataGridView dgv)
        {
            foreach (Crucero c in cruceros)
            {
                dgv.Rows.Add(c.Nombre, c.Matricula, c.CantidadCamarotesPremium, c.CantidadCamarotesTurista, c.Salones["piletas"],c.Salones["casinos"],c.Salones["restaurantes"], c.CapacidadBodegaKgs);
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

        public static int LocalizarIndiceFilaSeleccionada(DataGridView dgv)
        {
            int i=0;
            bool encontrado = false;

            for (; i < dgv.RowCount; i++)
            {
                if (dgv.Rows[i].Selected)
                {
                    encontrado = true;
                    break;
                }
            }

            if(!encontrado)
            {
                i = -1;
            }

            return i;
        }
    }
}