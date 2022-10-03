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
    public partial class FrmCruceros : Form
    {
        public FrmCruceros()
        {
            InitializeComponent();
        }

        public FrmCruceros(List<Crucero> cruceros) : this()
        {
            FrmHome.ListarCrucerosEnDGV(cruceros, this.dgvCruceros);
        }

        private void FrmCruceros_Load(object sender, EventArgs e)
        {
            
        }
    }
}
