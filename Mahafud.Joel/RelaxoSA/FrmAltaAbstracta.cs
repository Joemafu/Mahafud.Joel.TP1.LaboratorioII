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
    internal partial class FrmAltaAbstracta : FrmBase
    {
        internal FrmAltaAbstracta()
        {
            InitializeComponent();
        }

        public override void SetearMensajeAyuda()
        {
            this.chkAyuda.Text = "";
        }
    }    
}
