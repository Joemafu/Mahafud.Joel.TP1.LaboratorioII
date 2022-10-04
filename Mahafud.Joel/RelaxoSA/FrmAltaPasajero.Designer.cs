
namespace RelaxoSA
{
    partial class FrmAltaPasajero
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblFechaDeNacimiento = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblPasaporte = new System.Windows.Forms.Label();
            this.lblFechaExoedicionPasaporte = new System.Windows.Forms.Label();
            this.lblFechaVencimientoPasaporte = new System.Windows.Forms.Label();
            this.lblEquipajeDeMano = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNumeroPasaporte = new System.Windows.Forms.TextBox();
            this.chkbxEquipajeDeMano = new System.Windows.Forms.CheckBox();
            this.rbtnCeroDespachos = new System.Windows.Forms.RadioButton();
            this.rbtnUnDespacho = new System.Windows.Forms.RadioButton();
            this.rbtnDosDespachos = new System.Windows.Forms.RadioButton();
            this.gbxEquipajeDespachable = new System.Windows.Forms.GroupBox();
            this.datepFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.datepExpedicionPasaporte = new System.Windows.Forms.DateTimePicker();
            this.datepVencimientoPasaporte = new System.Windows.Forms.DateTimePicker();
            this.lblDestino = new System.Windows.Forms.Label();
            this.cmbxNacionalidad = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalPrecio = new System.Windows.Forms.Label();
            this.lblClase = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblPrecioPasaje = new System.Windows.Forms.Label();
            this.lblTasasAdicionales = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblPrecioBase = new System.Windows.Forms.Label();
            this.lblIvaPrecio = new System.Windows.Forms.Label();
            this.lblTasasAdicionalesPrecio = new System.Windows.Forms.Label();
            this.gbxEquipajeDespachable.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAceptar.Location = new System.Drawing.Point(75, 512);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(219, 512);
            // 
            // chkAyuda
            // 
            this.chkAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAyuda.Location = new System.Drawing.Point(3, 538);
            this.chkAyuda.CheckedChanged += new System.EventHandler(this.chkAyuda_CheckedChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 105);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 15);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(12, 134);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(30, 15);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "DNI:";
            // 
            // lblFechaDeNacimiento
            // 
            this.lblFechaDeNacimiento.AutoSize = true;
            this.lblFechaDeNacimiento.Location = new System.Drawing.Point(12, 163);
            this.lblFechaDeNacimiento.Name = "lblFechaDeNacimiento";
            this.lblFechaDeNacimiento.Size = new System.Drawing.Size(122, 15);
            this.lblFechaDeNacimiento.TabIndex = 5;
            this.lblFechaDeNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(12, 192);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(77, 15);
            this.lblNacionalidad.TabIndex = 6;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // lblPasaporte
            // 
            this.lblPasaporte.AutoSize = true;
            this.lblPasaporte.Location = new System.Drawing.Point(12, 221);
            this.lblPasaporte.Name = "lblPasaporte";
            this.lblPasaporte.Size = new System.Drawing.Size(101, 15);
            this.lblPasaporte.TabIndex = 7;
            this.lblPasaporte.Text = "Nro de Pasaporte:";
            // 
            // lblFechaExoedicionPasaporte
            // 
            this.lblFechaExoedicionPasaporte.AutoSize = true;
            this.lblFechaExoedicionPasaporte.Location = new System.Drawing.Point(12, 250);
            this.lblFechaExoedicionPasaporte.Name = "lblFechaExoedicionPasaporte";
            this.lblFechaExoedicionPasaporte.Size = new System.Drawing.Size(118, 15);
            this.lblFechaExoedicionPasaporte.TabIndex = 8;
            this.lblFechaExoedicionPasaporte.Text = "Fecha de Expedición:";
            // 
            // lblFechaVencimientoPasaporte
            // 
            this.lblFechaVencimientoPasaporte.AutoSize = true;
            this.lblFechaVencimientoPasaporte.Location = new System.Drawing.Point(12, 279);
            this.lblFechaVencimientoPasaporte.Name = "lblFechaVencimientoPasaporte";
            this.lblFechaVencimientoPasaporte.Size = new System.Drawing.Size(126, 15);
            this.lblFechaVencimientoPasaporte.TabIndex = 9;
            this.lblFechaVencimientoPasaporte.Text = "Fecha de Vencimiento:";
            // 
            // lblEquipajeDeMano
            // 
            this.lblEquipajeDeMano.AutoSize = true;
            this.lblEquipajeDeMano.Location = new System.Drawing.Point(12, 311);
            this.lblEquipajeDeMano.Name = "lblEquipajeDeMano";
            this.lblEquipajeDeMano.Size = new System.Drawing.Size(105, 15);
            this.lblEquipajeDeMano.TabIndex = 10;
            this.lblEquipajeDeMano.Text = "Equipaje de Mano:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(196, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(163, 23);
            this.txtNombre.TabIndex = 12;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(196, 102);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(163, 23);
            this.txtApellido.TabIndex = 13;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(196, 131);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(163, 23);
            this.txtDni.TabIndex = 14;
            // 
            // txtNumeroPasaporte
            // 
            this.txtNumeroPasaporte.Location = new System.Drawing.Point(196, 218);
            this.txtNumeroPasaporte.Name = "txtNumeroPasaporte";
            this.txtNumeroPasaporte.Size = new System.Drawing.Size(163, 23);
            this.txtNumeroPasaporte.TabIndex = 17;
            // 
            // chkbxEquipajeDeMano
            // 
            this.chkbxEquipajeDeMano.AutoSize = true;
            this.chkbxEquipajeDeMano.Location = new System.Drawing.Point(196, 312);
            this.chkbxEquipajeDeMano.Name = "chkbxEquipajeDeMano";
            this.chkbxEquipajeDeMano.Size = new System.Drawing.Size(15, 14);
            this.chkbxEquipajeDeMano.TabIndex = 20;
            this.chkbxEquipajeDeMano.UseVisualStyleBackColor = true;
            // 
            // rbtnCeroDespachos
            // 
            this.rbtnCeroDespachos.AutoSize = true;
            this.rbtnCeroDespachos.Location = new System.Drawing.Point(184, 22);
            this.rbtnCeroDespachos.Name = "rbtnCeroDespachos";
            this.rbtnCeroDespachos.Size = new System.Drawing.Size(31, 19);
            this.rbtnCeroDespachos.TabIndex = 21;
            this.rbtnCeroDespachos.TabStop = true;
            this.rbtnCeroDespachos.Text = "0";
            this.rbtnCeroDespachos.UseVisualStyleBackColor = true;
            // 
            // rbtnUnDespacho
            // 
            this.rbtnUnDespacho.AutoSize = true;
            this.rbtnUnDespacho.Location = new System.Drawing.Point(245, 22);
            this.rbtnUnDespacho.Name = "rbtnUnDespacho";
            this.rbtnUnDespacho.Size = new System.Drawing.Size(31, 19);
            this.rbtnUnDespacho.TabIndex = 22;
            this.rbtnUnDespacho.TabStop = true;
            this.rbtnUnDespacho.Text = "1";
            this.rbtnUnDespacho.UseVisualStyleBackColor = true;
            // 
            // rbtnDosDespachos
            // 
            this.rbtnDosDespachos.AutoSize = true;
            this.rbtnDosDespachos.Location = new System.Drawing.Point(299, 22);
            this.rbtnDosDespachos.Name = "rbtnDosDespachos";
            this.rbtnDosDespachos.Size = new System.Drawing.Size(31, 19);
            this.rbtnDosDespachos.TabIndex = 23;
            this.rbtnDosDespachos.TabStop = true;
            this.rbtnDosDespachos.Text = "2";
            this.rbtnDosDespachos.UseVisualStyleBackColor = true;
            // 
            // gbxEquipajeDespachable
            // 
            this.gbxEquipajeDespachable.Controls.Add(this.rbtnDosDespachos);
            this.gbxEquipajeDespachable.Controls.Add(this.rbtnUnDespacho);
            this.gbxEquipajeDespachable.Controls.Add(this.rbtnCeroDespachos);
            this.gbxEquipajeDespachable.Location = new System.Drawing.Point(12, 336);
            this.gbxEquipajeDespachable.Name = "gbxEquipajeDespachable";
            this.gbxEquipajeDespachable.Size = new System.Drawing.Size(347, 57);
            this.gbxEquipajeDespachable.TabIndex = 26;
            this.gbxEquipajeDespachable.TabStop = false;
            this.gbxEquipajeDespachable.Text = "Equipajes adicionales";
            // 
            // datepFechaNacimiento
            // 
            this.datepFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepFechaNacimiento.Location = new System.Drawing.Point(196, 157);
            this.datepFechaNacimiento.MaxDate = new System.DateTime(2022, 10, 3, 0, 0, 0, 0);
            this.datepFechaNacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datepFechaNacimiento.Name = "datepFechaNacimiento";
            this.datepFechaNacimiento.Size = new System.Drawing.Size(163, 23);
            this.datepFechaNacimiento.TabIndex = 15;
            this.datepFechaNacimiento.Value = new System.DateTime(1992, 1, 1, 0, 0, 0, 0);
            // 
            // datepExpedicionPasaporte
            // 
            this.datepExpedicionPasaporte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepExpedicionPasaporte.Location = new System.Drawing.Point(196, 244);
            this.datepExpedicionPasaporte.MaxDate = new System.DateTime(2022, 10, 3, 15, 14, 36, 0);
            this.datepExpedicionPasaporte.MinDate = new System.DateTime(2010, 12, 31, 0, 0, 0, 0);
            this.datepExpedicionPasaporte.Name = "datepExpedicionPasaporte";
            this.datepExpedicionPasaporte.Size = new System.Drawing.Size(163, 23);
            this.datepExpedicionPasaporte.TabIndex = 18;
            this.datepExpedicionPasaporte.Value = new System.DateTime(2012, 10, 3, 0, 0, 0, 0);
            // 
            // datepVencimientoPasaporte
            // 
            this.datepVencimientoPasaporte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepVencimientoPasaporte.Location = new System.Drawing.Point(196, 273);
            this.datepVencimientoPasaporte.MinDate = new System.DateTime(2022, 10, 4, 0, 0, 0, 0);
            this.datepVencimientoPasaporte.Name = "datepVencimientoPasaporte";
            this.datepVencimientoPasaporte.Size = new System.Drawing.Size(163, 23);
            this.datepVencimientoPasaporte.TabIndex = 19;
            this.datepVencimientoPasaporte.Value = new System.DateTime(2032, 10, 4, 0, 0, 0, 0);
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDestino.Location = new System.Drawing.Point(12, 7);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(84, 28);
            this.lblDestino.TabIndex = 30;
            this.lblDestino.Text = "Destino";
            // 
            // cmbxNacionalidad
            // 
            this.cmbxNacionalidad.DisplayMember = "Argentina";
            this.cmbxNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxNacionalidad.FormattingEnabled = true;
            this.cmbxNacionalidad.Items.AddRange(new object[] {
            "Afganistán",
            "Albania",
            "Alemania",
            "Andorra",
            "Angola",
            "Antigua y Barbuda",
            "Arabia Saudita",
            "Argelia",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaiyán",
            "Bahamas",
            "Bangladés",
            "Barbados",
            "Baréin",
            "Bélgica",
            "Belice",
            "Benín",
            "Bielorrusia",
            "Birmania",
            "Bolivia",
            "Bosnia y Herzegovina",
            "Botsuana",
            "Brasil",
            "Brunéi",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Bután",
            "Cabo Verde",
            "Camboya",
            "Camerún",
            "Canadá",
            "Catar",
            "Chad",
            "Chile",
            "China",
            "Chipre",
            "Ciudad del Vaticano",
            "Colombia",
            "Comoras",
            "Corea del Norte",
            "Corea del Sur",
            "Costa de Marfil",
            "Costa Rica",
            "Croacia",
            "Cuba",
            "Dinamarca",
            "Dominica",
            "Ecuador",
            "Egipto",
            "El Salvador",
            "Emiratos Árabes Unidos",
            "Eritrea",
            "Eslovaquia",
            "Eslovenia",
            "España",
            "Estados Unidos",
            "Estonia",
            "Etiopía",
            "Filipinas",
            "Finlandia",
            "Fiyi",
            "Francia",
            "Gabón",
            "Gambia",
            "Georgia",
            "Ghana",
            "Granada",
            "Grecia",
            "Guatemala",
            "Guyana",
            "Guinea",
            "Guinea ecuatorial",
            "Guinea-Bisáu",
            "Haití",
            "Honduras",
            "Hungría",
            "India",
            "Indonesia",
            "Irak",
            "Irán",
            "Irlanda",
            "Islandia",
            "Islas Marshall",
            "Islas Salomón",
            "Israel",
            "Italia",
            "Jamaica",
            "Japón",
            "Jordania",
            "Kazajistán",
            "Kenia",
            "Kirguistán",
            "Kiribati",
            "Kuwait",
            "Laos",
            "Lesoto",
            "Letonia",
            "Líbano",
            "Liberia",
            "Libia",
            "Liechtenstein",
            "Lituania",
            "Luxemburgo",
            "Macedonia del Norte",
            "Madagascar",
            "Malasia",
            "Malaui",
            "Maldivas",
            "Malí",
            "Malta",
            "Marruecos",
            "Mauricio",
            "Mauritania",
            "México",
            "Micronesia",
            "Moldavia",
            "Mónaco",
            "Mongolia",
            "Montenegro",
            "Mozambique",
            "Namibia",
            "Nauru",
            "Nepal",
            "Nicaragua",
            "Níger",
            "Nigeria",
            "Noruega",
            "Nueva Zelanda",
            "Omán",
            "Países Bajos",
            "Pakistán",
            "Palaos",
            "Panamá",
            "Papúa Nueva Guinea",
            "Paraguay",
            "Perú",
            "Polonia",
            "Portugal",
            "Reino Unido",
            "República Centroafricana",
            "República Checa",
            "República del Congo",
            "República Democrática del Congo",
            "República Dominicana",
            "Ruanda",
            "Rumanía",
            "Rusia",
            "Samoa",
            "San Cristóbal y Nieves",
            "San Marino",
            "San Vicente y las Granadinas",
            "Santa Lucía",
            "Santo Tomé y Príncipe",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leona",
            "Singapur",
            "Siria",
            "Somalia",
            "Sri Lanka",
            "Suazilandia",
            "Sudáfrica",
            "Sudán",
            "Sudán del Sur",
            "Suecia",
            "Suiza",
            "Surinam",
            "Tailandia",
            "Tanzania",
            "Tayikistán",
            "Timor Oriental",
            "Togo",
            "Tonga",
            "Trinidad y Tobago",
            "Túnez",
            "Turkmenistán",
            "Turquía",
            "Tuvalu",
            "Ucrania",
            "Uganda",
            "Uruguay",
            "Uzbekistán",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Yibuti",
            "Zambia",
            "Zimbabue"});
            this.cmbxNacionalidad.Location = new System.Drawing.Point(196, 189);
            this.cmbxNacionalidad.Name = "cmbxNacionalidad";
            this.cmbxNacionalidad.Size = new System.Drawing.Size(163, 23);
            this.cmbxNacionalidad.TabIndex = 16;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(12, 472);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(68, 28);
            this.lblTotal.TabIndex = 31;
            this.lblTotal.Text = "Total:";
            // 
            // lblTotalPrecio
            // 
            this.lblTotalPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPrecio.AutoSize = true;
            this.lblTotalPrecio.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTotalPrecio.Location = new System.Drawing.Point(219, 472);
            this.lblTotalPrecio.Name = "lblTotalPrecio";
            this.lblTotalPrecio.Size = new System.Drawing.Size(23, 28);
            this.lblTotalPrecio.TabIndex = 32;
            this.lblTotalPrecio.Text = "$";
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblClase.Location = new System.Drawing.Point(18, 35);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(49, 21);
            this.lblClase.TabIndex = 33;
            this.lblClase.Text = "Clase";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblId.Location = new System.Drawing.Point(295, 35);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(64, 21);
            this.lblId.TabIndex = 34;
            this.lblId.Text = "ID ####";
            // 
            // lblPrecioPasaje
            // 
            this.lblPrecioPasaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrecioPasaje.AutoSize = true;
            this.lblPrecioPasaje.Location = new System.Drawing.Point(12, 400);
            this.lblPrecioPasaje.Name = "lblPrecioPasaje";
            this.lblPrecioPasaje.Size = new System.Drawing.Size(76, 15);
            this.lblPrecioPasaje.TabIndex = 35;
            this.lblPrecioPasaje.Text = "Precio pasaje";
            // 
            // lblTasasAdicionales
            // 
            this.lblTasasAdicionales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTasasAdicionales.AutoSize = true;
            this.lblTasasAdicionales.Location = new System.Drawing.Point(12, 449);
            this.lblTasasAdicionales.Name = "lblTasasAdicionales";
            this.lblTasasAdicionales.Size = new System.Drawing.Size(132, 15);
            this.lblTasasAdicionales.TabIndex = 36;
            this.lblTasasAdicionales.Text = "Otros impuestos y tasas";
            // 
            // lblIva
            // 
            this.lblIva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(12, 424);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(34, 15);
            this.lblIva.TabIndex = 37;
            this.lblIva.Text = "I.V.A.";
            // 
            // lblPrecioBase
            // 
            this.lblPrecioBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrecioBase.AutoSize = true;
            this.lblPrecioBase.Location = new System.Drawing.Point(257, 400);
            this.lblPrecioBase.Name = "lblPrecioBase";
            this.lblPrecioBase.Size = new System.Drawing.Size(13, 15);
            this.lblPrecioBase.TabIndex = 35;
            this.lblPrecioBase.Text = "$";
            // 
            // lblIvaPrecio
            // 
            this.lblIvaPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIvaPrecio.AutoSize = true;
            this.lblIvaPrecio.Location = new System.Drawing.Point(257, 424);
            this.lblIvaPrecio.Name = "lblIvaPrecio";
            this.lblIvaPrecio.Size = new System.Drawing.Size(13, 15);
            this.lblIvaPrecio.TabIndex = 36;
            this.lblIvaPrecio.Text = "$";
            // 
            // lblTasasAdicionalesPrecio
            // 
            this.lblTasasAdicionalesPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTasasAdicionalesPrecio.AutoSize = true;
            this.lblTasasAdicionalesPrecio.Location = new System.Drawing.Point(257, 449);
            this.lblTasasAdicionalesPrecio.Name = "lblTasasAdicionalesPrecio";
            this.lblTasasAdicionalesPrecio.Size = new System.Drawing.Size(13, 15);
            this.lblTasasAdicionalesPrecio.TabIndex = 37;
            this.lblTasasAdicionalesPrecio.Text = "$";
            // 
            // FrmAltaPasajero
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(371, 557);
            this.Controls.Add(this.lblTasasAdicionalesPrecio);
            this.Controls.Add(this.lblIvaPrecio);
            this.Controls.Add(this.lblIva);
            this.Controls.Add(this.lblPrecioBase);
            this.Controls.Add(this.lblTasasAdicionales);
            this.Controls.Add(this.lblPrecioPasaje);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.chkbxEquipajeDeMano);
            this.Controls.Add(this.lblClase);
            this.Controls.Add(this.lblTotalPrecio);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cmbxNacionalidad);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.lblEquipajeDeMano);
            this.Controls.Add(this.datepVencimientoPasaporte);
            this.Controls.Add(this.datepExpedicionPasaporte);
            this.Controls.Add(this.datepFechaNacimiento);
            this.Controls.Add(this.txtNumeroPasaporte);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblFechaVencimientoPasaporte);
            this.Controls.Add(this.lblFechaExoedicionPasaporte);
            this.Controls.Add(this.lblPasaporte);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.lblFechaDeNacimiento);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.gbxEquipajeDespachable);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(387, 596);
            this.MinimumSize = new System.Drawing.Size(387, 596);
            this.Name = "FrmAltaPasajero";
            this.Text = "Vender Pasaje";
            this.Load += new System.EventHandler(this.FrmAltaPasajero_Load);
            this.Controls.SetChildIndex(this.chkAyuda, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.gbxEquipajeDespachable, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.lblApellido, 0);
            this.Controls.SetChildIndex(this.lblDni, 0);
            this.Controls.SetChildIndex(this.lblFechaDeNacimiento, 0);
            this.Controls.SetChildIndex(this.lblNacionalidad, 0);
            this.Controls.SetChildIndex(this.lblPasaporte, 0);
            this.Controls.SetChildIndex(this.lblFechaExoedicionPasaporte, 0);
            this.Controls.SetChildIndex(this.lblFechaVencimientoPasaporte, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtApellido, 0);
            this.Controls.SetChildIndex(this.txtDni, 0);
            this.Controls.SetChildIndex(this.txtNumeroPasaporte, 0);
            this.Controls.SetChildIndex(this.datepFechaNacimiento, 0);
            this.Controls.SetChildIndex(this.datepExpedicionPasaporte, 0);
            this.Controls.SetChildIndex(this.datepVencimientoPasaporte, 0);
            this.Controls.SetChildIndex(this.lblEquipajeDeMano, 0);
            this.Controls.SetChildIndex(this.lblDestino, 0);
            this.Controls.SetChildIndex(this.cmbxNacionalidad, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.lblTotalPrecio, 0);
            this.Controls.SetChildIndex(this.lblClase, 0);
            this.Controls.SetChildIndex(this.chkbxEquipajeDeMano, 0);
            this.Controls.SetChildIndex(this.lblId, 0);
            this.Controls.SetChildIndex(this.lblPrecioPasaje, 0);
            this.Controls.SetChildIndex(this.lblTasasAdicionales, 0);
            this.Controls.SetChildIndex(this.lblPrecioBase, 0);
            this.Controls.SetChildIndex(this.lblIva, 0);
            this.Controls.SetChildIndex(this.lblIvaPrecio, 0);
            this.Controls.SetChildIndex(this.lblTasasAdicionalesPrecio, 0);
            this.gbxEquipajeDespachable.ResumeLayout(false);
            this.gbxEquipajeDespachable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblFechaDeNacimiento;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Label lblPasaporte;
        private System.Windows.Forms.Label lblFechaExoedicionPasaporte;
        private System.Windows.Forms.Label lblFechaVencimientoPasaporte;
        private System.Windows.Forms.Label lblEquipajeDeMano;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNumeroPasaporte;
        private System.Windows.Forms.CheckBox chkbxEquipajeDeMano;
        private System.Windows.Forms.RadioButton rbtnCeroDespachos;
        private System.Windows.Forms.RadioButton rbtnUnDespacho;
        private System.Windows.Forms.RadioButton rbtnDosDespachos;
        private System.Windows.Forms.GroupBox gbxEquipajeDespachable;
        private System.Windows.Forms.DateTimePicker datepFechaNacimiento;
        private System.Windows.Forms.DateTimePicker datepExpedicionPasaporte;
        private System.Windows.Forms.DateTimePicker datepVencimientoPasaporte;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.ComboBox cmbxNacionalidad;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalPrecio;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPrecioPasaje;
        private System.Windows.Forms.Label lblTasasAdicionales;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblPrecioBase;
        private System.Windows.Forms.Label lblIvaPrecio;
        private System.Windows.Forms.Label lblTasasAdicionalesPrecio;
    }
}