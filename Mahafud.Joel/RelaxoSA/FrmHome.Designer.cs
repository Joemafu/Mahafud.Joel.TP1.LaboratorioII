
namespace RelaxoSA
{
    partial class FrmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnViajes = new System.Windows.Forms.Button();
            this.btnPasajeros = new System.Windows.Forms.Button();
            this.btnCruceros = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnAgregarViaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkAyuda
            // 
            this.chkAyuda.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkAyuda.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkAyuda.Location = new System.Drawing.Point(12, 65);
            this.chkAyuda.CheckedChanged += new System.EventHandler(this.chkAyuda_CheckedChanged);
            // 
            // btnViajes
            // 
            this.btnViajes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnViajes.Location = new System.Drawing.Point(12, 270);
            this.btnViajes.Name = "btnViajes";
            this.btnViajes.Size = new System.Drawing.Size(188, 53);
            this.btnViajes.TabIndex = 1;
            this.btnViajes.Text = "Vender Pasajes";
            this.btnViajes.UseVisualStyleBackColor = true;
            this.btnViajes.Click += new System.EventHandler(this.btnViajes_Click);
            // 
            // btnPasajeros
            // 
            this.btnPasajeros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPasajeros.Location = new System.Drawing.Point(400, 270);
            this.btnPasajeros.Name = "btnPasajeros";
            this.btnPasajeros.Size = new System.Drawing.Size(188, 53);
            this.btnPasajeros.TabIndex = 2;
            this.btnPasajeros.Text = "Buscar Pasajeros";
            this.btnPasajeros.UseVisualStyleBackColor = true;
            this.btnPasajeros.Click += new System.EventHandler(this.btnPasajeros_Click);
            // 
            // btnCruceros
            // 
            this.btnCruceros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCruceros.Location = new System.Drawing.Point(594, 270);
            this.btnCruceros.Name = "btnCruceros";
            this.btnCruceros.Size = new System.Drawing.Size(188, 53);
            this.btnCruceros.TabIndex = 3;
            this.btnCruceros.Text = "Ver Flota";
            this.btnCruceros.UseVisualStyleBackColor = true;
            this.btnCruceros.Click += new System.EventHandler(this.btnCruceros_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEstadisticas.Location = new System.Drawing.Point(788, 270);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(188, 53);
            this.btnEstadisticas.TabIndex = 4;
            this.btnEstadisticas.Text = "Consultar Estadísticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(788, 12);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(188, 53);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblBienvenido.Location = new System.Drawing.Point(12, 21);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(521, 28);
            this.lblBienvenido.TabIndex = 31;
            this.lblBienvenido.Text = "Bienvenido Nombre del Usuario! Hoy es XX/XX/XXXX";
            // 
            // btnAgregarViaje
            // 
            this.btnAgregarViaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarViaje.Location = new System.Drawing.Point(206, 270);
            this.btnAgregarViaje.Name = "btnAgregarViaje";
            this.btnAgregarViaje.Size = new System.Drawing.Size(188, 53);
            this.btnAgregarViaje.TabIndex = 32;
            this.btnAgregarViaje.Text = "Agregar Viaje";
            this.btnAgregarViaje.UseVisualStyleBackColor = true;
            this.btnAgregarViaje.Click += new System.EventHandler(this.btnAgregarViaje_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(988, 335);
            this.Controls.Add(this.btnAgregarViaje);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnCruceros);
            this.Controls.Add(this.btnPasajeros);
            this.Controls.Add(this.btnViajes);
            this.MinimumSize = new System.Drawing.Size(1004, 374);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cruceros Relaxo S.A.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHome_FormClosing);
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.Controls.SetChildIndex(this.btnViajes, 0);
            this.Controls.SetChildIndex(this.btnPasajeros, 0);
            this.Controls.SetChildIndex(this.btnCruceros, 0);
            this.Controls.SetChildIndex(this.btnEstadisticas, 0);
            this.Controls.SetChildIndex(this.btnCerrarSesion, 0);
            this.Controls.SetChildIndex(this.lblBienvenido, 0);
            this.Controls.SetChildIndex(this.chkAyuda, 0);
            this.Controls.SetChildIndex(this.btnAgregarViaje, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnViajes;
        private System.Windows.Forms.Button btnPasajeros;
        private System.Windows.Forms.Button btnCruceros;
        private System.Windows.Forms.Button btnCerrarSesion;
        internal System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnAgregarViaje;
    }
}

