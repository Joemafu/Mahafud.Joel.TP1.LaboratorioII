
namespace RelaxoSA
{
    partial class FrmBase
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
            this.chkAyuda = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkAyuda
            // 
            this.chkAyuda.AutoSize = true;
            this.chkAyuda.Location = new System.Drawing.Point(1, 2);
            this.chkAyuda.Name = "chkAyuda";
            this.chkAyuda.Size = new System.Drawing.Size(63, 19);
            this.chkAyuda.TabIndex = 1;
            this.chkAyuda.Text = "Ayuda!";
            this.chkAyuda.UseVisualStyleBackColor = true;
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkAyuda);
            this.Name = "FrmBase";
            this.Text = "FrmBase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox chkAyuda;
    }
}