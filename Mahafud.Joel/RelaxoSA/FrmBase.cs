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
    public /*abstract*/ partial class FrmBase : Form //Intenté definirla abstracta pero luego los forms que heredan no dibujan el design.
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
    }
}
