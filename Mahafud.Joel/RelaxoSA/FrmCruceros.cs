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
    internal partial class FrmCruceros : Form
    {
        internal FrmCruceros()
        {
            InitializeComponent();
        }

        internal FrmCruceros(List<Crucero> cruceros) : this()
        {
            FrmCruceros.ListarCrucerosEnDGV(cruceros, this.dgvCruceros);
        }

        internal static void ListarCrucerosEnDGV(List<Crucero> cruceros, DataGridView dgv)
        {
            dgv.Rows.Clear();
            foreach (Crucero c in cruceros)
            {
                dgv.Rows.Add(
                    c.Nombre,
                    c.Matricula,
                    c.CantidadCamarotesPremium,
                    c.CantidadCamarotesTurista,
                    c.Salones["piletas"],
                    c.Salones["casinos"],
                    c.Salones["restaurantes"],
                    c.CapacidadBodegaKgs);
            }
        }
    }
}
