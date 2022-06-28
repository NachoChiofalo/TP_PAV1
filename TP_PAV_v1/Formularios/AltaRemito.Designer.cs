namespace TP_PAV_v1.Formularios
{
    partial class AltaRemito
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtNroRemito = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarEstacion = new System.Windows.Forms.Button();
            this.txtNombreEstacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.btnBuscarCamion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdSucursal = new System.Windows.Forms.TextBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombreTipoCombu = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.grillaDetalle = new System.Windows.Forms.DataGridView();
            this.CodTipoCombustible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LtsCombustibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.btnGuardarRemito = new System.Windows.Forms.Button();
            this.txtCuit = new System.Windows.Forms.MaskedTextBox();
            this.txtCodTipoCombu = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnBuscarTipoCombustible = new System.Windows.Forms.Button();
            this.txtPrecioXLitro = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.btnCalcularSubtotal = new System.Windows.Forms.Button();
            this.txtCantLitros = new System.Windows.Forms.MaskedTextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtIdProvincia = new System.Windows.Forms.TextBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TP_PAV_v1.Properties.Resources.FONDO_OFICIAL;
            this.pictureBox1.Image = global::TP_PAV_v1.Properties.Resources.YPF_GIRO;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 654);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(478, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Alta de Remito";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFecha.Location = new System.Drawing.Point(876, 29);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 16);
            this.lblFecha.TabIndex = 41;
            this.lblFecha.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(933, 28);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(121, 20);
            this.txtFecha.TabIndex = 42;
            // 
            // txtNroRemito
            // 
            this.txtNroRemito.Enabled = false;
            this.txtNroRemito.Location = new System.Drawing.Point(345, 88);
            this.txtNroRemito.Name = "txtNroRemito";
            this.txtNroRemito.Size = new System.Drawing.Size(58, 20);
            this.txtNroRemito.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(254, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Nro Remito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(297, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "CUIT";
            // 
            // btnBuscarEstacion
            // 
            this.btnBuscarEstacion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscarEstacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEstacion.Location = new System.Drawing.Point(472, 119);
            this.btnBuscarEstacion.Name = "btnBuscarEstacion";
            this.btnBuscarEstacion.Size = new System.Drawing.Size(88, 26);
            this.btnBuscarEstacion.TabIndex = 47;
            this.btnBuscarEstacion.Text = "Buscar";
            this.btnBuscarEstacion.UseVisualStyleBackColor = false;
            this.btnBuscarEstacion.Click += new System.EventHandler(this.btnBuscarEstacion_Click);
            // 
            // txtNombreEstacion
            // 
            this.txtNombreEstacion.Enabled = false;
            this.txtNombreEstacion.Location = new System.Drawing.Point(809, 119);
            this.txtNombreEstacion.Name = "txtNombreEstacion";
            this.txtNombreEstacion.Size = new System.Drawing.Size(184, 20);
            this.txtNombreEstacion.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(279, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Patente";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(345, 206);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(109, 20);
            this.txtPatente.TabIndex = 50;
            // 
            // btnBuscarCamion
            // 
            this.btnBuscarCamion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscarCamion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCamion.Location = new System.Drawing.Point(472, 200);
            this.btnBuscarCamion.Name = "btnBuscarCamion";
            this.btnBuscarCamion.Size = new System.Drawing.Size(88, 26);
            this.btnBuscarCamion.TabIndex = 51;
            this.btnBuscarCamion.Text = "Buscar";
            this.btnBuscarCamion.UseVisualStyleBackColor = false;
            this.btnBuscarCamion.Click += new System.EventHandler(this.btnBuscarCamion_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(602, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Modelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(828, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "Marca";
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Location = new System.Drawing.Point(667, 207);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(109, 20);
            this.txtModelo.TabIndex = 55;
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(884, 207);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(109, 20);
            this.txtMarca.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(284, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 57;
            this.label7.Text = "Legajo";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(345, 248);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(109, 20);
            this.txtLegajo.TabIndex = 58;
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(472, 242);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(88, 26);
            this.btnBuscarEmpleado.TabIndex = 59;
            this.btnBuscarEmpleado.Text = "Buscar";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = false;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.Enabled = false;
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(884, 252);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(109, 20);
            this.txtApellidoEmpleado.TabIndex = 63;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Enabled = false;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(667, 252);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(109, 20);
            this.txtNombreEmpleado.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(813, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 61;
            this.label8.Text = "Apellido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(599, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 60;
            this.label9.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(255, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 64;
            this.label10.Text = "Id Sucursal";
            // 
            // txtIdSucursal
            // 
            this.txtIdSucursal.Enabled = false;
            this.txtIdSucursal.Location = new System.Drawing.Point(345, 162);
            this.txtIdSucursal.Name = "txtIdSucursal";
            this.txtIdSucursal.Size = new System.Drawing.Size(58, 20);
            this.txtIdSucursal.TabIndex = 65;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Enabled = false;
            this.txtProvincia.Location = new System.Drawing.Point(667, 162);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(109, 20);
            this.txtProvincia.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(589, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 68;
            this.label11.Text = "Provincia";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(629, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 16);
            this.label12.TabIndex = 69;
            this.label12.Text = "Nombre de estación";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(174, 302);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 16);
            this.label13.TabIndex = 70;
            this.label13.Text = "Cod. Tipo Combustible";
            // 
            // txtNombreTipoCombu
            // 
            this.txtNombreTipoCombu.Enabled = false;
            this.txtNombreTipoCombu.Location = new System.Drawing.Point(667, 300);
            this.txtNombreTipoCombu.Name = "txtNombreTipoCombu";
            this.txtNombreTipoCombu.Size = new System.Drawing.Size(109, 20);
            this.txtNombreTipoCombu.TabIndex = 75;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(599, 303);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 16);
            this.label14.TabIndex = 73;
            this.label14.Text = "Nombre";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(260, 346);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 16);
            this.label15.TabIndex = 72;
            this.label15.Text = "Cant litros";
            // 
            // grillaDetalle
            // 
            this.grillaDetalle.AllowUserToAddRows = false;
            this.grillaDetalle.AllowUserToDeleteRows = false;
            this.grillaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodTipoCombustible,
            this.LtsCombustibles,
            this.Precio});
            this.grillaDetalle.Location = new System.Drawing.Point(433, 390);
            this.grillaDetalle.Name = "grillaDetalle";
            this.grillaDetalle.ReadOnly = true;
            this.grillaDetalle.Size = new System.Drawing.Size(343, 227);
            this.grillaDetalle.TabIndex = 76;
            // 
            // CodTipoCombustible
            // 
            this.CodTipoCombustible.HeaderText = "Cod Tipo Combustible";
            this.CodTipoCombustible.Name = "CodTipoCombustible";
            this.CodTipoCombustible.ReadOnly = true;
            // 
            // LtsCombustibles
            // 
            this.LtsCombustibles.HeaderText = "Litros Combustible";
            this.LtsCombustibles.Name = "LtsCombustibles";
            this.LtsCombustibles.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDetalle.Location = new System.Drawing.Point(851, 506);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(169, 30);
            this.btnAgregarDetalle.TabIndex = 77;
            this.btnAgregarDetalle.Text = "Agregar detalle remito";
            this.btnAgregarDetalle.UseVisualStyleBackColor = false;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // btnGuardarRemito
            // 
            this.btnGuardarRemito.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardarRemito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarRemito.Location = new System.Drawing.Point(851, 564);
            this.btnGuardarRemito.Name = "btnGuardarRemito";
            this.btnGuardarRemito.Size = new System.Drawing.Size(167, 39);
            this.btnGuardarRemito.TabIndex = 78;
            this.btnGuardarRemito.Text = "GUARDAR REMITO";
            this.btnGuardarRemito.UseVisualStyleBackColor = false;
            this.btnGuardarRemito.Click += new System.EventHandler(this.btnGuardarRemito_Click);
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(345, 124);
            this.txtCuit.Mask = "9999999";
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(109, 20);
            this.txtCuit.TabIndex = 79;
            // 
            // txtCodTipoCombu
            // 
            this.txtCodTipoCombu.Location = new System.Drawing.Point(345, 297);
            this.txtCodTipoCombu.Mask = "99999";
            this.txtCodTipoCombu.Name = "txtCodTipoCombu";
            this.txtCodTipoCombu.Size = new System.Drawing.Size(58, 20);
            this.txtCodTipoCombu.TabIndex = 80;
            this.txtCodTipoCombu.ValidatingType = typeof(int);
            this.txtCodTipoCombu.TextChanged += new System.EventHandler(this.txtCodTipoCombu_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(787, 302);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 16);
            this.label16.TabIndex = 81;
            this.label16.Text = "PrecioXLitro";
            // 
            // btnBuscarTipoCombustible
            // 
            this.btnBuscarTipoCombustible.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscarTipoCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTipoCombustible.Location = new System.Drawing.Point(472, 291);
            this.btnBuscarTipoCombustible.Name = "btnBuscarTipoCombustible";
            this.btnBuscarTipoCombustible.Size = new System.Drawing.Size(88, 27);
            this.btnBuscarTipoCombustible.TabIndex = 83;
            this.btnBuscarTipoCombustible.Text = "Buscar";
            this.btnBuscarTipoCombustible.UseVisualStyleBackColor = false;
            this.btnBuscarTipoCombustible.Click += new System.EventHandler(this.btnBuscarTipoCombustible_Click);
            // 
            // txtPrecioXLitro
            // 
            this.txtPrecioXLitro.Location = new System.Drawing.Point(884, 298);
            this.txtPrecioXLitro.Mask = "99999999999999";
            this.txtPrecioXLitro.Name = "txtPrecioXLitro";
            this.txtPrecioXLitro.Size = new System.Drawing.Size(109, 20);
            this.txtPrecioXLitro.TabIndex = 84;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(759, 352);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 16);
            this.label17.TabIndex = 85;
            this.label17.Text = "Precio SubTotal";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(884, 348);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(109, 20);
            this.txtSubTotal.TabIndex = 86;
            // 
            // btnCalcularSubtotal
            // 
            this.btnCalcularSubtotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcularSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularSubtotal.Location = new System.Drawing.Point(472, 339);
            this.btnCalcularSubtotal.Name = "btnCalcularSubtotal";
            this.btnCalcularSubtotal.Size = new System.Drawing.Size(137, 29);
            this.btnCalcularSubtotal.TabIndex = 87;
            this.btnCalcularSubtotal.Text = "Calcular Subtotal";
            this.btnCalcularSubtotal.UseVisualStyleBackColor = false;
            this.btnCalcularSubtotal.Click += new System.EventHandler(this.btnCalcularSubtotal_Click);
            // 
            // txtCantLitros
            // 
            this.txtCantLitros.Location = new System.Drawing.Point(345, 345);
            this.txtCantLitros.Mask = "99999999999999";
            this.txtCantLitros.Name = "txtCantLitros";
            this.txtCantLitros.Size = new System.Drawing.Size(109, 20);
            this.txtCantLitros.TabIndex = 88;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(884, 439);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(109, 20);
            this.txtTotal.TabIndex = 90;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(786, 443);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 16);
            this.label18.TabIndex = 89;
            this.label18.Text = "Precio Total";
            // 
            // txtIdProvincia
            // 
            this.txtIdProvincia.Enabled = false;
            this.txtIdProvincia.Location = new System.Drawing.Point(809, 161);
            this.txtIdProvincia.Name = "txtIdProvincia";
            this.txtIdProvincia.Size = new System.Drawing.Size(39, 20);
            this.txtIdProvincia.TabIndex = 91;
            this.txtIdProvincia.Visible = false;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(214, 564);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(167, 39);
            this.btnLimpiarCampos.TabIndex = 92;
            this.btnLimpiarCampos.Text = "LIMPIAR CAMPOS";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // AltaRemito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(3)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1083, 640);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.txtIdProvincia);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtCantLitros);
            this.Controls.Add(this.btnCalcularSubtotal);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtPrecioXLitro);
            this.Controls.Add(this.btnBuscarTipoCombustible);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtCodTipoCombu);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.btnGuardarRemito);
            this.Controls.Add(this.btnAgregarDetalle);
            this.Controls.Add(this.grillaDetalle);
            this.Controls.Add(this.txtNombreTipoCombu);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtProvincia);
            this.Controls.Add(this.txtIdSucursal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtApellidoEmpleado);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBuscarEmpleado);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBuscarCamion);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreEstacion);
            this.Controls.Add(this.btnBuscarEstacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNroRemito);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AltaRemito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABMRemito";
            this.Load += new System.EventHandler(this.AltaRemito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtNroRemito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarEstacion;
        private System.Windows.Forms.TextBox txtNombreEstacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Button btnBuscarCamion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private System.Windows.Forms.TextBox txtApellidoEmpleado;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdSucursal;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNombreTipoCombu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView grillaDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodTipoCombustible;
        private System.Windows.Forms.DataGridViewTextBoxColumn LtsCombustibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.Button btnGuardarRemito;
        private System.Windows.Forms.MaskedTextBox txtCuit;
        private System.Windows.Forms.MaskedTextBox txtCodTipoCombu;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnBuscarTipoCombustible;
        private System.Windows.Forms.MaskedTextBox txtPrecioXLitro;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Button btnCalcularSubtotal;
        private System.Windows.Forms.MaskedTextBox txtCantLitros;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtIdProvincia;
        private System.Windows.Forms.Button btnLimpiarCampos;
    }
}