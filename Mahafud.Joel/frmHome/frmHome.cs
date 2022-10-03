
namespace frmHome
{
    partial class frmHome
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
            this.lstViajes = new System.Windows.Forms.ListBox();
            this.btnViajes = new System.Windows.Forms.Button();
            this.btnPasajeros = new System.Windows.Forms.Button();
            this.btnCruceros = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstViajes
            // 
            this.lstViajes.FormattingEnabled = true;
            this.lstViajes.ItemHeight = 15;
            this.lstViajes.Location = new System.Drawing.Point(12, 40);
            this.lstViajes.Name = "lstViajes";
            this.lstViajes.Size = new System.Drawing.Size(847, 214);
            this.lstViajes.TabIndex = 0;
            // 
            // btnViajes
            // 
            this.btnViajes.Location = new System.Drawing.Point(12, 563);
            this.btnViajes.Name = "btnViajes";
            this.btnViajes.Size = new System.Drawing.Size(75, 23);
            this.btnViajes.TabIndex = 1;
            this.btnViajes.Text = "Viajes";
            this.btnViajes.UseVisualStyleBackColor = true;
            // 
            // btnPasajeros
            // 
            this.btnPasajeros.Location = new System.Drawing.Point(93, 563);
            this.btnPasajeros.Name = "btnPasajeros";
            this.btnPasajeros.Size = new System.Drawing.Size(75, 23);
            this.btnPasajeros.TabIndex = 2;
            this.btnPasajeros.Text = "Pasajeros";
            this.btnPasajeros.UseVisualStyleBackColor = true;
            // 
            // btnCruceros
            // 
            this.btnCruceros.Location = new System.Drawing.Point(174, 563);
            this.btnCruceros.Name = "btnCruceros";
            this.btnCruceros.Size = new System.Drawing.Size(75, 23);
            this.btnCruceros.TabIndex = 3;
            this.btnCruceros.Text = "Cruceros";
            this.btnCruceros.UseVisualStyleBackColor = true;
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Location = new System.Drawing.Point(784, 563);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(75, 23);
            this.btnEstadisticas.TabIndex = 4;
            this.btnEstadisticas.Text = "Estadísticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Location = new System.Drawing.Point(518, 13);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(124, 15);
            this.lblBienvenido.TabIndex = 5;
            this.lblBienvenido.Text = "Bienvenido username!";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(648, 9);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(84, 23);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(738, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cambiar de usuario";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 598);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnCruceros);
            this.Controls.Add(this.btnPasajeros);
            this.Controls.Add(this.btnViajes);
            this.Controls.Add(this.lstViajes);
            this.Name = "frmHome";
            this.Text = "Cruceros Relaxo S.A.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstViajes;
        private System.Windows.Forms.Button btnViajes;
        private System.Windows.Forms.Button btnPasajeros;
        private System.Windows.Forms.Button btnCruceros;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEstadisticas;
    }
}

