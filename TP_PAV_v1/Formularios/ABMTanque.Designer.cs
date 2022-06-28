namespace TP_PAV_v1.Formularios
{
    partial class ABMTanque
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
            this.btnBorrarTanque = new System.Windows.Forms.Button();
            this.btnGuardadTanque = new System.Windows.Forms.Button();
            this.btnActualizarTanque = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.cmbCodTipoCombustible = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gdrTanques = new System.Windows.Forms.DataGridView();
            this.lblVolMax = new System.Windows.Forms.Label();
            this.lblCUITTanque = new System.Windows.Forms.Label();
            this.lblNroTanque = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVolMin = new System.Windows.Forms.Label();
            this.lblCodTipoCombustible = new System.Windows.Forms.Label();
            this.txtNroTanque = new System.Windows.Forms.MaskedTextBox();
            this.txtCUITTanque = new System.Windows.Forms.MaskedTextBox();
            this.txtVolMax = new System.Windows.Forms.MaskedTextBox();
            this.txtVolMin = new System.Windows.Forms.MaskedTextBox();
            this.NroTanque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodTipoCombustible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdrTanques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrarTanque
            // 
            this.btnBorrarTanque.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBorrarTanque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarTanque.Location = new System.Drawing.Point(263, 295);
            this.btnBorrarTanque.Name = "btnBorrarTanque";
            this.btnBorrarTanque.Size = new System.Drawing.Size(89, 39);
            this.btnBorrarTanque.TabIndex = 25;
            this.btnBorrarTanque.Text = "Borrar Tanque";
            this.btnBorrarTanque.UseVisualStyleBackColor = false;
            this.btnBorrarTanque.Click += new System.EventHandler(this.btnBorrarTanque_Click);
            // 
            // btnGuardadTanque
            // 
            this.btnGuardadTanque.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardadTanque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardadTanque.Location = new System.Drawing.Point(358, 250);
            this.btnGuardadTanque.Name = "btnGuardadTanque";
            this.btnGuardadTanque.Size = new System.Drawing.Size(89, 39);
            this.btnGuardadTanque.TabIndex = 24;
            this.btnGuardadTanque.Text = "Guardar Tanque";
            this.btnGuardadTanque.UseVisualStyleBackColor = false;
            this.btnGuardadTanque.Click += new System.EventHandler(this.btnGuardadTanque_Click);
            // 
            // btnActualizarTanque
            // 
            this.btnActualizarTanque.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnActualizarTanque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTanque.Location = new System.Drawing.Point(263, 250);
            this.btnActualizarTanque.Name = "btnActualizarTanque";
            this.btnActualizarTanque.Size = new System.Drawing.Size(89, 39);
            this.btnActualizarTanque.TabIndex = 23;
            this.btnActualizarTanque.Text = "Actualizar Tanque";
            this.btnActualizarTanque.UseVisualStyleBackColor = false;
            this.btnActualizarTanque.Click += new System.EventHandler(this.btnActualizarTanque_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(168, 250);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(89, 39);
            this.btnLimpiarCampos.TabIndex = 22;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // cmbCodTipoCombustible
            // 
            this.cmbCodTipoCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodTipoCombustible.FormattingEnabled = true;
            this.cmbCodTipoCombustible.Location = new System.Drawing.Point(358, 172);
            this.cmbCodTipoCombustible.Name = "cmbCodTipoCombustible";
            this.cmbCodTipoCombustible.Size = new System.Drawing.Size(121, 21);
            this.cmbCodTipoCombustible.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(259, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Alta de Tanque";
            // 
            // gdrTanques
            // 
            this.gdrTanques.AllowUserToAddRows = false;
            this.gdrTanques.AllowUserToDeleteRows = false;
            this.gdrTanques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrTanques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroTanque,
            this.CUIT,
            this.VolMax,
            this.VolMin,
            this.CodTipoCombustible});
            this.gdrTanques.Location = new System.Drawing.Point(488, 12);
            this.gdrTanques.Name = "gdrTanques";
            this.gdrTanques.ReadOnly = true;
            this.gdrTanques.Size = new System.Drawing.Size(348, 322);
            this.gdrTanques.TabIndex = 17;
            this.gdrTanques.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrTanques_CellClick);
            // 
            // lblVolMax
            // 
            this.lblVolMax.AutoSize = true;
            this.lblVolMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolMax.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVolMax.Location = new System.Drawing.Point(231, 115);
            this.lblVolMax.Name = "lblVolMax";
            this.lblVolMax.Size = new System.Drawing.Size(124, 16);
            this.lblVolMax.TabIndex = 16;
            this.lblVolMax.Text = "Volumen maximo";
            // 
            // lblCUITTanque
            // 
            this.lblCUITTanque.AutoSize = true;
            this.lblCUITTanque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUITTanque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCUITTanque.Location = new System.Drawing.Point(312, 82);
            this.lblCUITTanque.Name = "lblCUITTanque";
            this.lblCUITTanque.Size = new System.Drawing.Size(42, 16);
            this.lblCUITTanque.TabIndex = 15;
            this.lblCUITTanque.Text = "CUIT";
            // 
            // lblNroTanque
            // 
            this.lblNroTanque.AutoSize = true;
            this.lblNroTanque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroTanque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNroTanque.Location = new System.Drawing.Point(276, 52);
            this.lblNroTanque.Name = "lblNroTanque";
            this.lblNroTanque.Size = new System.Drawing.Size(81, 16);
            this.lblNroTanque.TabIndex = 14;
            this.lblNroTanque.Text = "Nº Tanque";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TP_PAV_v1.Properties.Resources.FONDO_OFICIAL;
            this.pictureBox1.Image = global::TP_PAV_v1.Properties.Resources.YPF_GIRO;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 356);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblVolMin
            // 
            this.lblVolMin.AutoSize = true;
            this.lblVolMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolMin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVolMin.Location = new System.Drawing.Point(235, 147);
            this.lblVolMin.Name = "lblVolMin";
            this.lblVolMin.Size = new System.Drawing.Size(120, 16);
            this.lblVolMin.TabIndex = 26;
            this.lblVolMin.Text = "Volumen minimo";
            // 
            // lblCodTipoCombustible
            // 
            this.lblCodTipoCombustible.AutoSize = true;
            this.lblCodTipoCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodTipoCombustible.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCodTipoCombustible.Location = new System.Drawing.Point(151, 177);
            this.lblCodTipoCombustible.Name = "lblCodTipoCombustible";
            this.lblCodTipoCombustible.Size = new System.Drawing.Size(205, 16);
            this.lblCodTipoCombustible.TabIndex = 27;
            this.lblCodTipoCombustible.Text = "Codigo Tipo de Combustible";
            // 
            // txtNroTanque
            // 
            this.txtNroTanque.Location = new System.Drawing.Point(358, 48);
            this.txtNroTanque.Mask = "999";
            this.txtNroTanque.Name = "txtNroTanque";
            this.txtNroTanque.Size = new System.Drawing.Size(121, 20);
            this.txtNroTanque.TabIndex = 30;
            this.txtNroTanque.ValidatingType = typeof(int);
            // 
            // txtCUITTanque
            // 
            this.txtCUITTanque.Location = new System.Drawing.Point(358, 81);
            this.txtCUITTanque.Mask = "9999999";
            this.txtCUITTanque.Name = "txtCUITTanque";
            this.txtCUITTanque.Size = new System.Drawing.Size(121, 20);
            this.txtCUITTanque.TabIndex = 31;
            this.txtCUITTanque.ValidatingType = typeof(int);
            // 
            // txtVolMax
            // 
            this.txtVolMax.Location = new System.Drawing.Point(358, 111);
            this.txtVolMax.Mask = "9999";
            this.txtVolMax.Name = "txtVolMax";
            this.txtVolMax.Size = new System.Drawing.Size(121, 20);
            this.txtVolMax.TabIndex = 32;
            this.txtVolMax.ValidatingType = typeof(int);
            // 
            // txtVolMin
            // 
            this.txtVolMin.Location = new System.Drawing.Point(358, 143);
            this.txtVolMin.Mask = "9999";
            this.txtVolMin.Name = "txtVolMin";
            this.txtVolMin.Size = new System.Drawing.Size(121, 20);
            this.txtVolMin.TabIndex = 33;
            this.txtVolMin.ValidatingType = typeof(int);
            // 
            // NroTanque
            // 
            this.NroTanque.DataPropertyName = "Nro_Tanque";
            this.NroTanque.HeaderText = "NroTanque";
            this.NroTanque.Name = "NroTanque";
            this.NroTanque.ReadOnly = true;
            // 
            // CUIT
            // 
            this.CUIT.DataPropertyName = "CUIT";
            this.CUIT.HeaderText = "CUIT";
            this.CUIT.Name = "CUIT";
            this.CUIT.ReadOnly = true;
            // 
            // VolMax
            // 
            this.VolMax.DataPropertyName = "Vol_Maximo";
            this.VolMax.HeaderText = "VolMax";
            this.VolMax.Name = "VolMax";
            this.VolMax.ReadOnly = true;
            // 
            // VolMin
            // 
            this.VolMin.DataPropertyName = "Vol_Minimo";
            this.VolMin.HeaderText = "VolMin";
            this.VolMin.Name = "VolMin";
            this.VolMin.ReadOnly = true;
            // 
            // CodTipoCombustible
            // 
            this.CodTipoCombustible.DataPropertyName = "Cod_Tipo_Combustible";
            this.CodTipoCombustible.HeaderText = "CodTipoCombustible";
            this.CodTipoCombustible.Name = "CodTipoCombustible";
            this.CodTipoCombustible.ReadOnly = true;
            // 
            // ABMTanque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(3)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(848, 349);
            this.Controls.Add(this.txtVolMin);
            this.Controls.Add(this.txtVolMax);
            this.Controls.Add(this.txtCUITTanque);
            this.Controls.Add(this.txtNroTanque);
            this.Controls.Add(this.lblCodTipoCombustible);
            this.Controls.Add(this.lblVolMin);
            this.Controls.Add(this.btnBorrarTanque);
            this.Controls.Add(this.btnGuardadTanque);
            this.Controls.Add(this.btnActualizarTanque);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.cmbCodTipoCombustible);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gdrTanques);
            this.Controls.Add(this.lblVolMax);
            this.Controls.Add(this.lblCUITTanque);
            this.Controls.Add(this.lblNroTanque);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ABMTanque";
            this.Text = "ABMTanque";
            this.Load += new System.EventHandler(this.ABMTanque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrTanques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrarTanque;
        private System.Windows.Forms.Button btnGuardadTanque;
        private System.Windows.Forms.Button btnActualizarTanque;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.ComboBox cmbCodTipoCombustible;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gdrTanques;
        private System.Windows.Forms.Label lblVolMax;
        private System.Windows.Forms.Label lblCUITTanque;
        private System.Windows.Forms.Label lblNroTanque;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVolMin;
        private System.Windows.Forms.Label lblCodTipoCombustible;
        private System.Windows.Forms.MaskedTextBox txtNroTanque;
        private System.Windows.Forms.MaskedTextBox txtCUITTanque;
        private System.Windows.Forms.MaskedTextBox txtVolMax;
        private System.Windows.Forms.MaskedTextBox txtVolMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroTanque;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodTipoCombustible;
    }
}