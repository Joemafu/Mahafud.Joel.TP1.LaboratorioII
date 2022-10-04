using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelaxoSA
{
    public /*abstract*/ partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
        }

        public virtual /*abstract*/ void SetearMensajeAyuda()
        {
            this.chkAyuda.Text = "";
        }

        public void SetearMensajeAyudaADefault()
        {
            this.chkAyuda.Text = "Ayuda!";
        }

        private void chkAyuda_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.chkAyuda.Checked)
            {
                this.SetearMensajeAyuda();
            }
        }
    }
}
