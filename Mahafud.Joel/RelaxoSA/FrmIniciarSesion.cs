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
    internal partial class FrmIniciarSesion : FrmBase
    {
        internal FrmIniciarSesion()
        {
            InitializeComponent();
            Hardcodeo hC = new Hardcodeo();

        }

        private void LimpiarCampos(bool soloPass)
        {
            if (!soloPass)
            {
                this.txtUser.Text = "";
            }
            this.txtPassword.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos(false);   
        }

        private void btniniciarSesion_Click(object sender, EventArgs e)
        {
            bool logInExitoso = false;



            List<Operario> listaOperarios = Hardcodeo.ListaOperarios;


            if (!String.IsNullOrWhiteSpace(this.txtUser.Text) && !String.IsNullOrWhiteSpace(this.txtPassword.Text))
            {
                Operario aux = new Operario("","","",this.txtUser.Text,this.txtPassword.Text);
                foreach (Operario item in listaOperarios)
                {
                    if (item == aux)
                    {
                        this.Hide();
                        FrmHome formHome = new FrmHome(this);

                        formHome.SetearBienvenida(item.Nombre);
                        formHome.Show();
                        LimpiarCampos(false);

                        logInExitoso = true;
                        this.DialogResult = DialogResult.OK;
                        break;
                    }
                }
            }
            if (logInExitoso==false)
            {
                MessageBox.Show("Datos incorrectos!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                LimpiarCampos(true);
            }
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

        public override void SetearMensajeAyuda()
        {
            this.chkAyuda.Text = "" +
                "Inicie Sesión.";
        }
    }
}
