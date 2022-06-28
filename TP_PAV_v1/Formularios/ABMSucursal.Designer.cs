namespace TP_PAV_v1.Formularios
{
    partial class ABMSucursal
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
            this.btnBorrarSucursal = new System.Windows.Forms.Button();
            this.btnGuardarSucursal = new System.Windows.Forms.Button();
            this.btnActualizarSucursal = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gdrSucursales = new System.Windows.Forms.DataGridView();
            this.NroSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNroSucursal = new System.Windows.Forms.MaskedTextBox();
            this.cmbIdProvincia = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdrSucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrarSucursal
            // 
            this.btnBorrarSucursal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBorrarSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarSucursal.Location = new System.Drawing.Point(267, 210);
            this.btnBorrarSucursal.Name = "btnBorrarSucursal";
            this.btnBorrarSucursal.Size = new System.Drawing.Size(89, 39);
            this.btnBorrarSucursal.TabIndex = 25;
            this.btnBorrarSucursal.Text = "Borrar Sucursal";
            this.btnBorrarSucursal.UseVisualStyleBackColor = false;
            this.btnBorrarSucursal.Click += new System.EventHandler(this.btnBorrarSucursal_Click);
            // 
            // btnGuardarSucursal
            // 
            this.btnGuardarSucursal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardarSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarSucursal.Location = new System.Drawing.Point(362, 165);
            this.btnGuardarSucursal.Name = "btnGuardarSucursal";
            this.btnGuardarSucursal.Size = new System.Drawing.Size(89, 39);
            this.btnGuardarSucursal.TabIndex = 24;
            this.btnGuardarSucursal.Text = "Guardar Sucursal";
            this.btnGuardarSucursal.UseVisualStyleBackColor = false;
            this.btnGuardarSucursal.Click += new System.EventHandler(this.btnGuardarSucursal_Click);
            // 
            // btnActualizarSucursal
            // 
            this.btnActualizarSucursal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnActualizarSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarSucursal.Location = new System.Drawing.Point(267, 165);
            this.btnActualizarSucursal.Name = "btnActualizarSucursal";
            this.btnActualizarSucursal.Size = new System.Drawing.Size(89, 39);
            this.btnActualizarSucursal.TabIndex = 23;
            this.btnActualizarSucursal.Text = "Actualizar Sucursal";
            this.btnActualizarSucursal.UseVisualStyleBackColor = false;
            this.btnActualizarSucursal.Click += new System.EventHandler(this.btnActualizarSucursal_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(172, 165);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(89, 39);
            this.btnLimpiarCampos.TabIndex = 22;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(187, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Alta de Nueva Sucursal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(206, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Provincia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(193, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id Sucursal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TP_PAV_v1.Properties.Resources.FONDO_OFICIAL;
            this.pictureBox1.Image = global::TP_PAV_v1.Properties.Resources.YPF_GIRO;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // gdrSucursales
            // 
            this.gdrSucursales.AllowUserToAddRows = false;
            this.gdrSucursales.AllowUserToDeleteRows = false;
            this.gdrSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrSucursales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroSucursal,
            this.idProv});
            this.gdrSucursales.Location = new System.Drawing.Point(473, 12);
            this.gdrSucursales.Name = "gdrSucursales";
            this.gdrSucursales.ReadOnly = true;
            this.gdrSucursales.Size = new System.Drawing.Size(234, 244);
            this.gdrSucursales.TabIndex = 26;
            this.gdrSucursales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrSucursales_CellClick);
            // 
            // NroSucursal
            // 
            this.NroSucursal.DataPropertyName = "Nro_Sucursal";
            this.NroSucursal.HeaderText = "N° sucursal";
            this.NroSucursal.Name = "NroSucursal";
            this.NroSucursal.ReadOnly = true;
            // 
            // idProv
            // 
            this.idProv.DataPropertyName = "Id_Provincia";
            this.idProv.HeaderText = "Provincia";
            this.idProv.Name = "idProv";
            this.idProv.ReadOnly = true;
            // 
            // txtNroSucursal
            // 
            this.txtNroSucursal.Location = new System.Drawing.Point(294, 50);
            this.txtNroSucursal.Mask = "99";
            this.txtNroSucursal.Name = "txtNroSucursal";
            this.txtNroSucursal.Size = new System.Drawing.Size(121, 20);
            this.txtNroSucursal.TabIndex = 27;
            this.txtNroSucursal.ValidatingType = typeof(int);
            // 
            // cmbIdProvincia
            // 
            this.cmbIdProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdProvincia.FormattingEnabled = true;
            this.cmbIdProvincia.Location = new System.Drawing.Point(294, 87);
            this.cmbIdProvincia.Name = "cmbIdProvincia";
            this.cmbIdProvincia.Size = new System.Drawing.Size(121, 21);
            this.cmbIdProvincia.TabIndex = 28;
            // 
            // ABMSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(3)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(719, 268);
            this.Controls.Add(this.cmbIdProvincia);
            this.Controls.Add(this.txtNroSucursal);
            this.Controls.Add(this.gdrSucursales);
            this.Controls.Add(this.btnBorrarSucursal);
            this.Controls.Add(this.btnGuardarSucursal);
            this.Controls.Add(this.btnActualizarSucursal);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ABMSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABMSucursal";
            this.Load += new System.EventHandler(this.ABMSucursal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdrSucursales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrarSucursal;
        private System.Windows.Forms.Button btnGuardarSucursal;
        private System.Windows.Forms.Button btnActualizarSucursal;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView gdrSucursales;
        private System.Windows.Forms.MaskedTextBox txtNroSucursal;
        private System.Windows.Forms.ComboBox cmbIdProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProv;
    }
}