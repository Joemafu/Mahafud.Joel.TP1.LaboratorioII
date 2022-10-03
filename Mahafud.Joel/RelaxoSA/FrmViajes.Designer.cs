
namespace RelaxoSA
{
    partial class FrmViajes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnVentaPremium = new System.Windows.Forms.Button();
            this.btnVentaTurista = new System.Windows.Forms.Button();
            this.lblSalones = new System.Windows.Forms.Label();
            this.dgvViajes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVentaPremium
            // 
            this.btnVentaPremium.Location = new System.Drawing.Point(12, 538);
            this.btnVentaPremium.Name = "btnVentaPremium";
            this.btnVentaPremium.Size = new System.Drawing.Size(156, 23);
            this.btnVentaPremium.TabIndex = 10;
            this.btnVentaPremium.Text = "Vender Pasaje Premium";
            this.btnVentaPremium.UseVisualStyleBackColor = true;
            this.btnVentaPremium.Click += new System.EventHandler(this.btnVentaPremium_Click);
            // 
            // btnVentaTurista
            // 
            this.btnVentaTurista.Location = new System.Drawing.Point(174, 538);
            this.btnVentaTurista.Name = "btnVentaTurista";
            this.btnVentaTurista.Size = new System.Drawing.Size(156, 23);
            this.btnVentaTurista.TabIndex = 11;
            this.btnVentaTurista.Text = "Vender Pasaje Turista";
            this.btnVentaTurista.UseVisualStyleBackColor = true;
            this.btnVentaTurista.Click += new System.EventHandler(this.btnVentaTurista_Click);
            // 
            // lblSalones
            // 
            this.lblSalones.AutoSize = true;
            this.lblSalones.Location = new System.Drawing.Point(12, 265);
            this.lblSalones.Name = "lblSalones";
            this.lblSalones.Size = new System.Drawing.Size(0, 15);
            this.lblSalones.TabIndex = 12;
            // 
            // dgvViajes
            // 
            this.dgvViajes.AllowUserToAddRows = false;
            this.dgvViajes.AllowUserToDeleteRows = false;
            this.dgvViajes.AllowUserToOrderColumns = true;
            this.dgvViajes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.NullValue = "--";
            this.dgvViajes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvViajes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvViajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvViajes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.dgvViajes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvViajes.Location = new System.Drawing.Point(12, 12);
            this.dgvViajes.MultiSelect = false;
            this.dgvViajes.Name = "dgvViajes";
            this.dgvViajes.RowTemplate.Height = 25;
            this.dgvViajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViajes.ShowEditingIcon = false;
            this.dgvViajes.Size = new System.Drawing.Size(1814, 240);
            this.dgvViajes.TabIndex = 13;
            this.dgvViajes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViajes_CellClick);
            this.dgvViajes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvViajes_KeyUp);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Disponibilidad Premium";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 146;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Disponibilidad Turista";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 133;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Destino";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 72;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Origen";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 68;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn6.HeaderText = "Tarifa premium";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 103;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn7.HeaderText = "Tarifa Turista";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 90;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Duracion (Hs.)";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 99;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewCellStyle4.Format = "g";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn9.HeaderText = "Fecha de partida";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 109;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewCellStyle5.Format = "g";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn10.HeaderText = "Fecha de regreso";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 111;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Embarcación";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 101;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Camarotes Premium disponibles";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 186;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Camarotes turista disponibles";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 171;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Boletos vendidos";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 112;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Kgs restantes en bodega";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 110;
            // 
            // FrmViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1850, 573);
            this.Controls.Add(this.dgvViajes);
            this.Controls.Add(this.lblSalones);
            this.Controls.Add(this.btnVentaTurista);
            this.Controls.Add(this.btnVentaPremium);
            this.Name = "FrmViajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viajes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVentaPremium;
        private System.Windows.Forms.Button btnVentaTurista;
        private System.Windows.Forms.Label lblSalones;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDisponibilidadPremium;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDisponibilidadTurista;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecioPremium;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrecioTurista;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDuracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFechaPartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFechaRegreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmbarcacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCamarotesPremiumDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCamarotesTuristaDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPasajeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn cKgsRestantesEnBodega;
        public System.Windows.Forms.DataGridView dgvViajes;
        protected internal System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        protected internal System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        protected internal System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        protected internal System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        protected internal System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        protected internal System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        protected internal System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        protected internal System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        protected internal System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        protected internal System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        protected internal System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        protected internal System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        protected internal System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        protected internal System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        protected internal System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    }
}