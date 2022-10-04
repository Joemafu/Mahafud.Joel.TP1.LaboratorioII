
namespace RelaxoSA
{
    partial class FrmPasajerosBase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPasajeros = new System.Windows.Forms.DataGridView();
            this.cIdViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCamaroteAsignado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFechaDeNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumeroPasaporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFechaExpedicionPasaporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFechaVencimientoPasaporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEquipajeDeMano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEquipajeDespachado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // chkAyuda
            // 
            this.chkAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAyuda.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chkAyuda.Location = new System.Drawing.Point(12, 419);
            this.chkAyuda.CheckedChanged += new System.EventHandler(this.chkAyuda_CheckedChanged);
            // 
            // dgvPasajeros
            // 
            this.dgvPasajeros.AllowUserToAddRows = false;
            this.dgvPasajeros.AllowUserToDeleteRows = false;
            this.dgvPasajeros.AllowUserToOrderColumns = true;
            this.dgvPasajeros.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.NullValue = "--";
            this.dgvPasajeros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPasajeros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPasajeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPasajeros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIdViaje,
            this.cCamaroteAsignado,
            this.cNombre,
            this.cApellido,
            this.cDni,
            this.cEdad,
            this.cFechaDeNacimiento,
            this.cNumeroPasaporte,
            this.cFechaExpedicionPasaporte,
            this.cFechaVencimientoPasaporte,
            this.cClase,
            this.cEquipajeDeMano,
            this.cEquipajeDespachado});
            this.dgvPasajeros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPasajeros.Location = new System.Drawing.Point(12, 12);
            this.dgvPasajeros.MultiSelect = false;
            this.dgvPasajeros.Name = "dgvPasajeros";
            this.dgvPasajeros.ReadOnly = true;
            this.dgvPasajeros.RowHeadersVisible = false;
            this.dgvPasajeros.RowTemplate.Height = 25;
            this.dgvPasajeros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPasajeros.ShowEditingIcon = false;
            this.dgvPasajeros.Size = new System.Drawing.Size(1029, 298);
            this.dgvPasajeros.TabIndex = 0;
            // 
            // cIdViaje
            // 
            this.cIdViaje.HeaderText = "ID de viaje";
            this.cIdViaje.Name = "cIdViaje";
            this.cIdViaje.ReadOnly = true;
            this.cIdViaje.Width = 79;
            // 
            // cCamaroteAsignado
            // 
            this.cCamaroteAsignado.HeaderText = "Numero de Camarote";
            this.cCamaroteAsignado.Name = "cCamaroteAsignado";
            this.cCamaroteAsignado.ReadOnly = true;
            this.cCamaroteAsignado.Width = 134;
            // 
            // cNombre
            // 
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            this.cNombre.Width = 76;
            // 
            // cApellido
            // 
            this.cApellido.HeaderText = "Apellido";
            this.cApellido.Name = "cApellido";
            this.cApellido.ReadOnly = true;
            this.cApellido.Width = 76;
            // 
            // cDni
            // 
            this.cDni.HeaderText = "DNI";
            this.cDni.Name = "cDni";
            this.cDni.ReadOnly = true;
            this.cDni.Width = 52;
            // 
            // cEdad
            // 
            this.cEdad.HeaderText = "Edad";
            this.cEdad.Name = "cEdad";
            this.cEdad.ReadOnly = true;
            this.cEdad.Width = 58;
            // 
            // cFechaDeNacimiento
            // 
            this.cFechaDeNacimiento.HeaderText = "Fecha de nacimiento";
            this.cFechaDeNacimiento.Name = "cFechaDeNacimiento";
            this.cFechaDeNacimiento.ReadOnly = true;
            this.cFechaDeNacimiento.Width = 130;
            // 
            // cNumeroPasaporte
            // 
            this.cNumeroPasaporte.HeaderText = "Numero de pasaporte";
            this.cNumeroPasaporte.Name = "cNumeroPasaporte";
            this.cNumeroPasaporte.ReadOnly = true;
            this.cNumeroPasaporte.Width = 134;
            // 
            // cFechaExpedicionPasaporte
            // 
            this.cFechaExpedicionPasaporte.HeaderText = "Fecha expedición pasaporte";
            this.cFechaExpedicionPasaporte.Name = "cFechaExpedicionPasaporte";
            this.cFechaExpedicionPasaporte.ReadOnly = true;
            this.cFechaExpedicionPasaporte.Width = 163;
            // 
            // cFechaVencimientoPasaporte
            // 
            this.cFechaVencimientoPasaporte.HeaderText = "Fecha vencimiento pasaporte";
            this.cFechaVencimientoPasaporte.Name = "cFechaVencimientoPasaporte";
            this.cFechaVencimientoPasaporte.ReadOnly = true;
            this.cFechaVencimientoPasaporte.Width = 170;
            // 
            // cClase
            // 
            this.cClase.HeaderText = "Clase";
            this.cClase.Name = "cClase";
            this.cClase.ReadOnly = true;
            this.cClase.Width = 60;
            // 
            // cEquipajeDeMano
            // 
            this.cEquipajeDeMano.HeaderText = "Equipaje de mano";
            this.cEquipajeDeMano.Name = "cEquipajeDeMano";
            this.cEquipajeDeMano.ReadOnly = true;
            this.cEquipajeDeMano.Width = 88;
            // 
            // cEquipajeDespachado
            // 
            this.cEquipajeDespachado.HeaderText = "Equipajes despachados";
            this.cEquipajeDespachado.Name = "cEquipajeDespachado";
            this.cEquipajeDespachado.ReadOnly = true;
            this.cEquipajeDespachado.Width = 141;
            // 
            // FrmPasajerosBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 450);
            this.Controls.Add(this.dgvPasajeros);
            this.MinimumSize = new System.Drawing.Size(908, 451);
            this.Name = "FrmPasajerosBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pasajeros";
            this.Load += new System.EventHandler(this.FrmPasajeros_Load);
            this.Controls.SetChildIndex(this.dgvPasajeros, 0);
            this.Controls.SetChildIndex(this.chkAyuda, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvPasajeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCamaroteAsignado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFechaDeNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumeroPasaporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFechaExpedicionPasaporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFechaVencimientoPasaporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn cClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEquipajeDeMano;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEquipajeDespachado;
    }
}