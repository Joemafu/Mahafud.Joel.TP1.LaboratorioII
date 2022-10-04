
namespace RelaxoSA
{
    partial class FrmViajesVenta
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
            this.btnVentaPremium = new System.Windows.Forms.Button();
            this.btnVentaTurista = new System.Windows.Forms.Button();
            this.lblDetalle = new System.Windows.Forms.Label();
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
            base.dgvViajes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViajes_CellClick);
            base.dgvViajes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvViajes_KeyUp);
            this.btnPasajeros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkAyuda
            // 
            this.chkAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAyuda.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chkAyuda.Location = new System.Drawing.Point(336, 498);
            this.chkAyuda.CheckedChanged += new System.EventHandler(this.chkAyuda_CheckedChanged);
            // 
            // btnVentaPremium
            // 
            this.btnVentaPremium.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVentaPremium.Location = new System.Drawing.Point(12, 495);
            this.btnVentaPremium.Name = "btnVentaPremium";
            this.btnVentaPremium.Size = new System.Drawing.Size(156, 23);
            this.btnVentaPremium.TabIndex = 10;
            this.btnVentaPremium.Text = "Vender Pasaje Premium";
            this.btnVentaPremium.UseVisualStyleBackColor = true;
            this.btnVentaPremium.Click += new System.EventHandler(this.btnVentaPremium_Click);
            // 
            // btnVentaTurista
            // 
            this.btnVentaTurista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVentaTurista.Location = new System.Drawing.Point(174, 495);
            this.btnVentaTurista.Name = "btnVentaTurista";
            this.btnVentaTurista.Size = new System.Drawing.Size(156, 23);
            this.btnVentaTurista.TabIndex = 11;
            this.btnVentaTurista.Text = "Vender Pasaje Turista";
            this.btnVentaTurista.UseVisualStyleBackColor = true;
            this.btnVentaTurista.Click += new System.EventHandler(this.btnVentaTurista_Click);
            // 
            // lblDetalle
            // 
            this.lblDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetalle.Location = new System.Drawing.Point(12, 338);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(261, 19);
            this.lblDetalle.TabIndex = 12;
            this.lblDetalle.Text = "Seleccione un viaje para más información.";
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
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn6.HeaderText = "Tarifa premium";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 103;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn9.HeaderText = "Fecha de partida";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 109;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewCellStyle4.Format = "g";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle4;
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
            // btnPasajeros
            // 
            this.btnPasajeros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPasajeros.Location = new System.Drawing.Point(1166, 495);
            this.btnPasajeros.Name = "btnPasajeros";
            this.btnPasajeros.Size = new System.Drawing.Size(156, 23);
            this.btnPasajeros.TabIndex = 14;
            this.btnPasajeros.Text = "Ver Pasajeros";
            this.btnPasajeros.UseVisualStyleBackColor = true;
            this.btnPasajeros.Click += new System.EventHandler(this.btnPasajeros_Click);
            // 
            // FrmViajesVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 524);
            this.Controls.Add(this.btnPasajeros);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.btnVentaTurista);
            this.Controls.Add(this.btnVentaPremium);
            this.Name = "FrmViajesVenta";
            this.Text = "Viajes";
            this.Controls.SetChildIndex(this.chkAyuda, 0);
            this.Controls.SetChildIndex(this.btnVentaPremium, 0);
            this.Controls.SetChildIndex(this.btnVentaTurista, 0);
            this.Controls.SetChildIndex(this.lblDetalle, 0);
            this.Controls.SetChildIndex(this.btnPasajeros, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVentaPremium;
        private System.Windows.Forms.Button btnVentaTurista;
        private System.Windows.Forms.Label lblDetalle;
        /*private System.Windows.Forms.DataGridViewTextBoxColumn cId;
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
        protected internal System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;*/
        private System.Windows.Forms.Button btnPasajeros;
    }
}