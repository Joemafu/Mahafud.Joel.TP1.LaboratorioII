
namespace RelaxoSA
{
    partial class FrmCruceros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCruceros = new System.Windows.Forms.DataGridView();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCantCamarotesPremium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCantCamarotesTurista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCantPiletas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCantidadCasinos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCantidadRestaurantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCapacidadBodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCruceros)).BeginInit();
            this.SuspendLayout();
            // 
            // chkAyuda
            // 
            this.chkAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAyuda.Location = new System.Drawing.Point(12, 361);
            this.chkAyuda.CheckedChanged += new System.EventHandler(this.chkAyuda_CheckedChanged);
            // 
            // dgvCruceros
            // 
            this.dgvCruceros.AllowUserToAddRows = false;
            this.dgvCruceros.AllowUserToDeleteRows = false;
            this.dgvCruceros.AllowUserToOrderColumns = true;
            this.dgvCruceros.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.NullValue = "--";
            this.dgvCruceros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCruceros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCruceros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCruceros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCruceros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCruceros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNombre,
            this.cMatricula,
            this.cCantCamarotesPremium,
            this.cCantCamarotesTurista,
            this.cCantPiletas,
            this.cCantidadCasinos,
            this.cCantidadRestaurantes,
            this.cCapacidadBodega});
            this.dgvCruceros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCruceros.Location = new System.Drawing.Point(12, 12);
            this.dgvCruceros.MultiSelect = false;
            this.dgvCruceros.Name = "dgvCruceros";
            this.dgvCruceros.RowHeadersVisible = false;
            this.dgvCruceros.RowTemplate.Height = 25;
            this.dgvCruceros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCruceros.ShowEditingIcon = false;
            this.dgvCruceros.Size = new System.Drawing.Size(878, 342);
            this.dgvCruceros.TabIndex = 8;
            // 
            // cNombre
            // 
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            // 
            // cMatricula
            // 
            this.cMatricula.HeaderText = "Matricula";
            this.cMatricula.Name = "cMatricula";
            this.cMatricula.ReadOnly = true;
            // 
            // cCantCamarotesPremium
            // 
            this.cCantCamarotesPremium.HeaderText = "Cantidad de camarotes premium";
            this.cCantCamarotesPremium.Name = "cCantCamarotesPremium";
            this.cCantCamarotesPremium.ReadOnly = true;
            // 
            // cCantCamarotesTurista
            // 
            this.cCantCamarotesTurista.HeaderText = "Cantidad de camarotes turista";
            this.cCantCamarotesTurista.Name = "cCantCamarotesTurista";
            this.cCantCamarotesTurista.ReadOnly = true;
            // 
            // cCantPiletas
            // 
            this.cCantPiletas.HeaderText = "Cantidad de piletas";
            this.cCantPiletas.Name = "cCantPiletas";
            this.cCantPiletas.ReadOnly = true;
            // 
            // cCantidadCasinos
            // 
            this.cCantidadCasinos.HeaderText = "Cantidad de casinos";
            this.cCantidadCasinos.Name = "cCantidadCasinos";
            this.cCantidadCasinos.ReadOnly = true;
            // 
            // cCantidadRestaurantes
            // 
            this.cCantidadRestaurantes.HeaderText = "Cantidad de restaurantes";
            this.cCantidadRestaurantes.Name = "cCantidadRestaurantes";
            this.cCantidadRestaurantes.ReadOnly = true;
            // 
            // cCapacidadBodega
            // 
            this.cCapacidadBodega.HeaderText = "Capacidad en bodega";
            this.cCapacidadBodega.Name = "cCapacidadBodega";
            this.cCapacidadBodega.ReadOnly = true;
            // 
            // FrmCruceros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 392);
            this.Controls.Add(this.dgvCruceros);
            this.MinimumSize = new System.Drawing.Size(918, 375);
            this.Name = "FrmCruceros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cruceros";
            this.Controls.SetChildIndex(this.dgvCruceros, 0);
            this.Controls.SetChildIndex(this.chkAyuda, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCruceros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCruceros;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCantCamarotesPremium;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCantCamarotesTurista;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCantPiletas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCantidadCasinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCantidadRestaurantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCapacidadBodega;
    }
}