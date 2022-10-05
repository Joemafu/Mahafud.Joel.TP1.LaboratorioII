
namespace RelaxoSA
{
    partial class FrmAltaViaje
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
            this.lblElegirDestino = new System.Windows.Forms.Label();
            this.lblElegirCrucero = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbxCrucero = new System.Windows.Forms.ComboBox();
            this.cmbxDestino = new System.Windows.Forms.ComboBox();
            this.lblAltaDeViaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAceptar.Location = new System.Drawing.Point(81, 172);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(215, 172);
            // 
            // chkAyuda
            // 
            this.chkAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAyuda.Location = new System.Drawing.Point(12, 219);
            this.chkAyuda.CheckedChanged += new System.EventHandler(this.chkAyuda_CheckedChanged);
            // 
            // lblElegirDestino
            // 
            this.lblElegirDestino.AutoSize = true;
            this.lblElegirDestino.Location = new System.Drawing.Point(21, 61);
            this.lblElegirDestino.Name = "lblElegirDestino";
            this.lblElegirDestino.Size = new System.Drawing.Size(81, 15);
            this.lblElegirDestino.TabIndex = 2;
            this.lblElegirDestino.Text = "Elegir destino:";
            // 
            // lblElegirCrucero
            // 
            this.lblElegirCrucero.AutoSize = true;
            this.lblElegirCrucero.Location = new System.Drawing.Point(21, 90);
            this.lblElegirCrucero.Name = "lblElegirCrucero";
            this.lblElegirCrucero.Size = new System.Drawing.Size(82, 15);
            this.lblElegirCrucero.TabIndex = 3;
            this.lblElegirCrucero.Text = "Elegir crucero:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de partida:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(151, 116);
            this.dtpFecha.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(2022, 10, 5, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 23);
            this.dtpFecha.TabIndex = 5;
            // 
            // cmbxCrucero
            // 
            this.cmbxCrucero.DisplayMember = "The Luxury Placeholder";
            this.cmbxCrucero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCrucero.FormattingEnabled = true;
            this.cmbxCrucero.Location = new System.Drawing.Point(151, 87);
            this.cmbxCrucero.Name = "cmbxCrucero";
            this.cmbxCrucero.Size = new System.Drawing.Size(200, 23);
            this.cmbxCrucero.TabIndex = 6;
            // 
            // cmbxDestino
            // 
            this.cmbxDestino.DisplayMember = "Montevideo";
            this.cmbxDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxDestino.FormattingEnabled = true;
            this.cmbxDestino.Location = new System.Drawing.Point(151, 58);
            this.cmbxDestino.Name = "cmbxDestino";
            this.cmbxDestino.Size = new System.Drawing.Size(200, 23);
            this.cmbxDestino.TabIndex = 7;
            // 
            // lblAltaDeViaje
            // 
            this.lblAltaDeViaje.AutoSize = true;
            this.lblAltaDeViaje.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblAltaDeViaje.Location = new System.Drawing.Point(21, 9);
            this.lblAltaDeViaje.Name = "lblAltaDeViaje";
            this.lblAltaDeViaje.Size = new System.Drawing.Size(129, 28);
            this.lblAltaDeViaje.TabIndex = 31;
            this.lblAltaDeViaje.Text = "Alta de viaje";
            // 
            // FrmAltaViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 250);
            this.Controls.Add(this.lblAltaDeViaje);
            this.Controls.Add(this.cmbxDestino);
            this.Controls.Add(this.cmbxCrucero);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblElegirCrucero);
            this.Controls.Add(this.lblElegirDestino);
            this.MaximumSize = new System.Drawing.Size(387, 289);
            this.MinimumSize = new System.Drawing.Size(387, 289);
            this.Name = "FrmAltaViaje";
            this.Text = "Alta de Viaje";
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.chkAyuda, 0);
            this.Controls.SetChildIndex(this.lblElegirDestino, 0);
            this.Controls.SetChildIndex(this.lblElegirCrucero, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.dtpFecha, 0);
            this.Controls.SetChildIndex(this.cmbxCrucero, 0);
            this.Controls.SetChildIndex(this.cmbxDestino, 0);
            this.Controls.SetChildIndex(this.lblAltaDeViaje, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblElegirDestino;
        private System.Windows.Forms.Label lblElegirCrucero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbxCrucero;
        private System.Windows.Forms.ComboBox cmbxDestino;
        private System.Windows.Forms.Label lblAltaDeViaje;
    }
}