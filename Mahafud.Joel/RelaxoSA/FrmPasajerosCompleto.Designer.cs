
namespace RelaxoSA
{
    partial class FrmPasajerosCompleto
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCriterioDeBusqueda = new System.Windows.Forms.Label();
            this.cmbCriterioDeBusqueda = new System.Windows.Forms.ComboBox();
            this.txtValorDeBusqueda = new System.Windows.Forms.TextBox();
            this.lblCantidadResultados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBuscar.Location = new System.Drawing.Point(397, 383);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(167, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCriterioDeBusqueda
            // 
            this.lblCriterioDeBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCriterioDeBusqueda.AutoSize = true;
            this.lblCriterioDeBusqueda.Location = new System.Drawing.Point(335, 337);
            this.lblCriterioDeBusqueda.Name = "lblCriterioDeBusqueda";
            this.lblCriterioDeBusqueda.Size = new System.Drawing.Size(66, 15);
            this.lblCriterioDeBusqueda.TabIndex = 2;
            this.lblCriterioDeBusqueda.Text = "Buscar por:";
            // 
            // cmbCriterioDeBusqueda
            // 
            this.cmbCriterioDeBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmbCriterioDeBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriterioDeBusqueda.FormattingEnabled = true;
            this.cmbCriterioDeBusqueda.Items.AddRange(new object[] {
            "Nombre",
            "Apellido",
            "DNI",
            "Edad",
            "Nro de Pasaporte"});
            this.cmbCriterioDeBusqueda.Location = new System.Drawing.Point(420, 334);
            this.cmbCriterioDeBusqueda.Name = "cmbCriterioDeBusqueda";
            this.cmbCriterioDeBusqueda.Size = new System.Drawing.Size(126, 23);
            this.cmbCriterioDeBusqueda.TabIndex = 3;
            this.cmbCriterioDeBusqueda.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtValorDeBusqueda
            // 
            this.txtValorDeBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtValorDeBusqueda.Location = new System.Drawing.Point(571, 334);
            this.txtValorDeBusqueda.Name = "txtValorDeBusqueda";
            this.txtValorDeBusqueda.Size = new System.Drawing.Size(128, 23);
            this.txtValorDeBusqueda.TabIndex = 5;
            // 
            // lblCantidadResultados
            // 
            this.lblCantidadResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCantidadResultados.AutoSize = true;
            this.lblCantidadResultados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadResultados.Location = new System.Drawing.Point(7, 429);
            this.lblCantidadResultados.Name = "lblCantidadResultados";
            this.lblCantidadResultados.Size = new System.Drawing.Size(0, 19);
            this.lblCantidadResultados.TabIndex = 6;
            // 
            // FrmPasajerosCompleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 450);
            this.Controls.Add(this.lblCantidadResultados);
            this.Controls.Add(this.txtValorDeBusqueda);
            this.Controls.Add(this.cmbCriterioDeBusqueda);
            this.Controls.Add(this.lblCriterioDeBusqueda);
            this.Controls.Add(this.btnBuscar);
            this.Name = "FrmPasajerosCompleto";
            this.Text = "FrmPasajerosCompleto";
            this.Load += new System.EventHandler(this.FrmPasajerosCompleto_Load);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.lblCriterioDeBusqueda, 0);
            this.Controls.SetChildIndex(this.cmbCriterioDeBusqueda, 0);
            this.Controls.SetChildIndex(this.txtValorDeBusqueda, 0);
            this.Controls.SetChildIndex(this.lblCantidadResultados, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCriterioDeBusqueda;
        private System.Windows.Forms.ComboBox cmbCriterioDeBusqueda;
        private System.Windows.Forms.TextBox txtValorDeBusqueda;
        private System.Windows.Forms.Label lblCantidadResultados;
    }
}