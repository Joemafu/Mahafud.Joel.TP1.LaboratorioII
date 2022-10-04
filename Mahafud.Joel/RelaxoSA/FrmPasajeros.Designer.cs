
namespace RelaxoSA
{
    partial class FrmPasajeros
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
            this.dgvPasajeros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPasajeros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvPasajeros.Size = new System.Drawing.Size(1189, 263);
            this.dgvPasajeros.TabIndex = 0;
            // 
            // cCamaroteAsignado
            // 
            this.cCamaroteAsignado.HeaderText = "Numero de Camarote";
            this.cCamaroteAsignado.Name = "cCamaroteAsignado";
            this.cCamaroteAsignado.ReadOnly = true;
            // 
            // cNombre
            // 
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            // 
            // cApellido
            // 
            this.cApellido.HeaderText = "Apellido";
            this.cApellido.Name = "cApellido";
            this.cApellido.ReadOnly = true;
            // 
            // cDni
            // 
            this.cDni.HeaderText = "DNI";
            this.cDni.Name = "cDni";
            this.cDni.ReadOnly = true;
            // 
            // cEdad
            // 
            this.cEdad.HeaderText = "Edad";
            this.cEdad.Name = "cEdad";
            this.cEdad.ReadOnly = true;
            // 
            // cFechaDeNacimiento
            // 
            this.cFechaDeNacimiento.HeaderText = "Fecha de nacimiento";
            this.cFechaDeNacimiento.Name = "cFechaDeNacimiento";
            this.cFechaDeNacimiento.ReadOnly = true;
            // 
            // cNumeroPasaporte
            // 
            this.cNumeroPasaporte.HeaderText = "Numero de pasaporte";
            this.cNumeroPasaporte.Name = "cNumeroPasaporte";
            this.cNumeroPasaporte.ReadOnly = true;
            // 
            // cFechaExpedicionPasaporte
            // 
            this.cFechaExpedicionPasaporte.HeaderText = "Fecha expedición pasaporte";
            this.cFechaExpedicionPasaporte.Name = "cFechaExpedicionPasaporte";
            this.cFechaExpedicionPasaporte.ReadOnly = true;
            // 
            // cFechaVencimientoPasaporte
            // 
            this.cFechaVencimientoPasaporte.HeaderText = "Fecha vencimiento pasaporte";
            this.cFechaVencimientoPasaporte.Name = "cFechaVencimientoPasaporte";
            this.cFechaVencimientoPasaporte.ReadOnly = true;
            // 
            // cClase
            // 
            this.cClase.HeaderText = "Clase";
            this.cClase.Name = "cClase";
            this.cClase.ReadOnly = true;
            // 
            // cEquipajeDeMano
            // 
            this.cEquipajeDeMano.HeaderText = "Equipaje de mano";
            this.cEquipajeDeMano.Name = "cEquipajeDeMano";
            this.cEquipajeDeMano.ReadOnly = true;
            // 
            // cEquipajeDespachado
            // 
            this.cEquipajeDespachado.HeaderText = "Equipajes despachados";
            this.cEquipajeDespachado.Name = "cEquipajeDespachado";
            this.cEquipajeDespachado.ReadOnly = true;
            // 
            // FrmPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 557);
            this.Controls.Add(this.dgvPasajeros);
            this.Name = "FrmPasajeros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pasajeros";
            this.Load += new System.EventHandler(this.FrmPasajeros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPasajeros;
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