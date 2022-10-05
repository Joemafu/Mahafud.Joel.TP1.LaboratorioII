
namespace RelaxoSA
{
    partial class FrmViajesAgregar
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
            this.btnAltaviaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkAyuda
            // 
            this.chkAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAyuda.Location = new System.Drawing.Point(12, 455);
            this.chkAyuda.CheckedChanged += new System.EventHandler(this.chkAyuda_CheckedChanged);
            // 
            // btnAltaviaje
            // 
            this.btnAltaviaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAltaviaje.Location = new System.Drawing.Point(804, 437);
            this.btnAltaviaje.Name = "btnAltaviaje";
            this.btnAltaviaje.Size = new System.Drawing.Size(134, 38);
            this.btnAltaviaje.TabIndex = 15;
            this.btnAltaviaje.Text = "Agregar Viaje";
            this.btnAltaviaje.UseVisualStyleBackColor = true;
            this.btnAltaviaje.Click += new System.EventHandler(this.btnAltaviaje_Click);
            // 
            // FrmViajesAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 486);
            this.Controls.Add(this.btnAltaviaje);
            this.Name = "FrmViajesAgregar";
            this.Text = "FrmViajesAltaViaje";
            this.Controls.SetChildIndex(this.chkAyuda, 0);
            this.Controls.SetChildIndex(this.btnAltaviaje, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAltaviaje;
    }
}