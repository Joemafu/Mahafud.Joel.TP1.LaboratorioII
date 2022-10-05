
namespace RelaxoSA
{
    partial class FrmEstadisticasAmpliadas
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
            this.tabEstadisticas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvDestinoYFacturacion = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvPasajerosFrecuentes = new System.Windows.Forms.DataGridView();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCantidadDeViajesConLaEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvServicioMasSolicitado = new System.Windows.Forms.DataGridView();
            this.cServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFacturacionTotalServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.cEmbarcacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHorasEnViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.cDestino2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCantidadDePasajesVendidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFacturacionTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabEstadisticas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinoYFacturacion)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajerosFrecuentes)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicioMasSolicitado)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // chkAyuda
            // 
            this.chkAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAyuda.Location = new System.Drawing.Point(12, 451);
            this.chkAyuda.CheckedChanged += new System.EventHandler(this.chkAyuda_CheckedChanged);
            // 
            // tabEstadisticas
            // 
            this.tabEstadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabEstadisticas.Controls.Add(this.tabPage1);
            this.tabEstadisticas.Controls.Add(this.tabPage2);
            this.tabEstadisticas.Controls.Add(this.tabPage3);
            this.tabEstadisticas.Controls.Add(this.tabPage4);
            this.tabEstadisticas.Controls.Add(this.tabPage5);
            this.tabEstadisticas.Location = new System.Drawing.Point(12, 12);
            this.tabEstadisticas.Name = "tabEstadisticas";
            this.tabEstadisticas.SelectedIndex = 0;
            this.tabEstadisticas.Size = new System.Drawing.Size(826, 421);
            this.tabEstadisticas.TabIndex = 2;
            this.tabEstadisticas.TabIndexChanged += new System.EventHandler(this.tabEstadisticas_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvDestinoYFacturacion);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(818, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvDestinoYFacturacion
            // 
            this.dgvDestinoYFacturacion.AllowUserToAddRows = false;
            this.dgvDestinoYFacturacion.AllowUserToDeleteRows = false;
            this.dgvDestinoYFacturacion.AllowUserToOrderColumns = true;
            this.dgvDestinoYFacturacion.AllowUserToResizeRows = false;
            this.dgvDestinoYFacturacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDestinoYFacturacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDestinoYFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDestinoYFacturacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cDestino,
            this.cFacturacionTotal});
            this.dgvDestinoYFacturacion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDestinoYFacturacion.Location = new System.Drawing.Point(7, 7);
            this.dgvDestinoYFacturacion.MultiSelect = false;
            this.dgvDestinoYFacturacion.Name = "dgvDestinoYFacturacion";
            this.dgvDestinoYFacturacion.RowHeadersVisible = false;
            this.dgvDestinoYFacturacion.RowTemplate.Height = 25;
            this.dgvDestinoYFacturacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDestinoYFacturacion.ShowEditingIcon = false;
            this.dgvDestinoYFacturacion.Size = new System.Drawing.Size(805, 380);
            this.dgvDestinoYFacturacion.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvPasajerosFrecuentes);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(818, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dgvPasajerosFrecuentes.AllowUserToAddRows = false;
            this.dgvPasajerosFrecuentes.AllowUserToDeleteRows = false;
            this.dgvPasajerosFrecuentes.AllowUserToOrderColumns = true;
            this.dgvPasajerosFrecuentes.AllowUserToResizeRows = false;
            this.dgvPasajerosFrecuentes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPasajerosFrecuentes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPasajerosFrecuentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPasajerosFrecuentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNombre,
            this.cApellido,
            this.cDni,
            this.cCantidadDeViajesConLaEmpresa});
            this.dgvPasajerosFrecuentes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPasajerosFrecuentes.Location = new System.Drawing.Point(7, 6);
            this.dgvPasajerosFrecuentes.MultiSelect = false;
            this.dgvPasajerosFrecuentes.Name = "dataGridView2";
            this.dgvPasajerosFrecuentes.RowHeadersVisible = false;
            this.dgvPasajerosFrecuentes.RowTemplate.Height = 25;
            this.dgvPasajerosFrecuentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPasajerosFrecuentes.ShowEditingIcon = false;
            this.dgvPasajerosFrecuentes.Size = new System.Drawing.Size(805, 380);
            this.dgvPasajerosFrecuentes.TabIndex = 1;
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
            // cCantidadDeViajesConLaEmpresa
            // 
            this.cCantidadDeViajesConLaEmpresa.HeaderText = "Cantidad de viajes realizados";
            this.cCantidadDeViajesConLaEmpresa.Name = "cCantidadDeViajesConLaEmpresa";
            this.cCantidadDeViajesConLaEmpresa.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvServicioMasSolicitado);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(818, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dgvServicioMasSolicitado.AllowUserToAddRows = false;
            this.dgvServicioMasSolicitado.AllowUserToDeleteRows = false;
            this.dgvServicioMasSolicitado.AllowUserToOrderColumns = true;
            this.dgvServicioMasSolicitado.AllowUserToResizeRows = false;
            this.dgvServicioMasSolicitado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServicioMasSolicitado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvServicioMasSolicitado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvServicioMasSolicitado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cServicio,
            this.cFacturacionTotalServicio});
            this.dgvServicioMasSolicitado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvServicioMasSolicitado.Location = new System.Drawing.Point(7, 6);
            this.dgvServicioMasSolicitado.MultiSelect = false;
            this.dgvServicioMasSolicitado.Name = "dataGridView3";
            this.dgvServicioMasSolicitado.RowHeadersVisible = false;
            this.dgvServicioMasSolicitado.RowTemplate.Height = 25;
            this.dgvServicioMasSolicitado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicioMasSolicitado.ShowEditingIcon = false;
            this.dgvServicioMasSolicitado.Size = new System.Drawing.Size(805, 380);
            this.dgvServicioMasSolicitado.TabIndex = 1;
            // 
            // cServicio
            // 
            this.cServicio.HeaderText = "Servicio";
            this.cServicio.Name = "cServicio";
            this.cServicio.ReadOnly = true;
            // 
            // cFacturacionTotalServicio
            // 
            this.cFacturacionTotalServicio.HeaderText = "Facturacion total";
            this.cFacturacionTotalServicio.Name = "cFacturacionTotalServicio";
            this.cFacturacionTotalServicio.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(818, 393);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AllowUserToOrderColumns = true;
            this.dataGridView4.AllowUserToResizeRows = false;
            this.dataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cEmbarcacion,
            this.cHorasEnViaje});
            this.dataGridView4.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView4.Location = new System.Drawing.Point(7, 6);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowTemplate.Height = 25;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.ShowEditingIcon = false;
            this.dataGridView4.Size = new System.Drawing.Size(805, 380);
            this.dataGridView4.TabIndex = 1;
            // 
            // cEmbarcacion
            // 
            this.cEmbarcacion.HeaderText = "Embarcación";
            this.cEmbarcacion.Name = "cEmbarcacion";
            this.cEmbarcacion.ReadOnly = true;
            // 
            // cHorasEnViaje
            // 
            this.cHorasEnViaje.HeaderText = "Horas en viaje";
            this.cHorasEnViaje.Name = "cHorasEnViaje";
            this.cHorasEnViaje.ReadOnly = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(818, 393);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AllowUserToOrderColumns = true;
            this.dataGridView5.AllowUserToResizeRows = false;
            this.dataGridView5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView5.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cDestino2,
            this.cCantidadDePasajesVendidos});
            this.dataGridView5.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView5.Location = new System.Drawing.Point(7, 6);
            this.dataGridView5.MultiSelect = false;
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersVisible = false;
            this.dataGridView5.RowTemplate.Height = 25;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.ShowEditingIcon = false;
            this.dataGridView5.Size = new System.Drawing.Size(805, 380);
            this.dataGridView5.TabIndex = 1;
            // 
            // cDestino2
            // 
            this.cDestino2.HeaderText = "Destino";
            this.cDestino2.Name = "cDestino2";
            this.cDestino2.ReadOnly = true;
            // 
            // cCantidadDePasajesVendidos
            // 
            this.cCantidadDePasajesVendidos.HeaderText = "Cantidad de pasajes vendidos";
            this.cCantidadDePasajesVendidos.Name = "cCantidadDePasajesVendidos";
            this.cCantidadDePasajesVendidos.ReadOnly = true;
            // 
            // cDestino
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.cDestino.DefaultCellStyle = dataGridViewCellStyle1;
            this.cDestino.HeaderText = "Destino";
            this.cDestino.Name = "cDestino";
            this.cDestino.ReadOnly = true;
            this.cDestino.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cFacturacionTotal
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.cFacturacionTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.cFacturacionTotal.HeaderText = "Facturacion total";
            this.cFacturacionTotal.Name = "cFacturacionTotal";
            this.cFacturacionTotal.ReadOnly = true;
            this.cFacturacionTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // FrmEstadisticasAmpliadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 482);
            this.Controls.Add(this.tabEstadisticas);
            this.MinimumSize = new System.Drawing.Size(463, 521);
            this.Name = "FrmEstadisticasAmpliadas";
            this.Text = "Estadísticas Ampliadas";
            this.Load += new System.EventHandler(this.FrmEstadisticasAmpliadas_Load);
            this.Controls.SetChildIndex(this.chkAyuda, 0);
            this.Controls.SetChildIndex(this.tabEstadisticas, 0);
            this.tabEstadisticas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinoYFacturacion)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasajerosFrecuentes)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicioMasSolicitado)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabEstadisticas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvDestinoYFacturacion;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgvPasajerosFrecuentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCantidadDeViajesConLaEmpresa;
        private System.Windows.Forms.DataGridView dgvServicioMasSolicitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFacturacionTotalServicio;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmbarcacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cHorasEnViaje;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDestino2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCantidadDePasajesVendidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFacturacionTotal;
    }
}