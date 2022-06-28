namespace TP_PAV_v1
{
    partial class ABMBarrio
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
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBorrarBarrio = new System.Windows.Forms.Button();
            this.btnGuardarBarrio = new System.Windows.Forms.Button();
            this.btnActualizarBarrio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gdrBarrios = new System.Windows.Forms.DataGridView();
            this.IdBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIdBarrio = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbIdLocalidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdrBarrios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(148, 163);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(89, 39);
            this.btnLimpiarCampos.TabIndex = 10;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(169, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Alta de Nuevo Barrio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(164, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Localidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(178, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(171, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id Barrio";
            // 
            // btnBorrarBarrio
            // 
            this.btnBorrarBarrio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBorrarBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarBarrio.Location = new System.Drawing.Point(243, 208);
            this.btnBorrarBarrio.Name = "btnBorrarBarrio";
            this.btnBorrarBarrio.Size = new System.Drawing.Size(89, 39);
            this.btnBorrarBarrio.TabIndex = 20;
            this.btnBorrarBarrio.Text = "Borrar Barrio";
            this.btnBorrarBarrio.UseVisualStyleBackColor = false;
            this.btnBorrarBarrio.Click += new System.EventHandler(this.btnBorrarBarrio_Click);
            // 
            // btnGuardarBarrio
            // 
            this.btnGuardarBarrio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardarBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarBarrio.Location = new System.Drawing.Point(338, 163);
            this.btnGuardarBarrio.Name = "btnGuardarBarrio";
            this.btnGuardarBarrio.Size = new System.Drawing.Size(89, 39);
            this.btnGuardarBarrio.TabIndex = 19;
            this.btnGuardarBarrio.Text = "Guardar Barrio";
            this.btnGuardarBarrio.UseVisualStyleBackColor = false;
            this.btnGuardarBarrio.Click += new System.EventHandler(this.btnGuardarBarrio_Click);
            // 
            // btnActualizarBarrio
            // 
            this.btnActualizarBarrio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnActualizarBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarBarrio.Location = new System.Drawing.Point(243, 163);
            this.btnActualizarBarrio.Name = "btnActualizarBarrio";
            this.btnActualizarBarrio.Size = new System.Drawing.Size(89, 39);
            this.btnActualizarBarrio.TabIndex = 18;
            this.btnActualizarBarrio.Text = "Actualizar Barrio";
            this.btnActualizarBarrio.UseVisualStyleBackColor = false;
            this.btnActualizarBarrio.Click += new System.EventHandler(this.btnActualizarBarrio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TP_PAV_v1.Properties.Resources.FONDO_OFICIAL;
            this.pictureBox1.Image = global::TP_PAV_v1.Properties.Resources.YPF_GIRO;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gdrBarrios
            // 
            this.gdrBarrios.AllowUserToAddRows = false;
            this.gdrBarrios.AllowUserToDeleteRows = false;
            this.gdrBarrios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrBarrios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBarrio,
            this.Nombre,
            this.IdLocalidad});
            this.gdrBarrios.Location = new System.Drawing.Point(448, 12);
            this.gdrBarrios.Name = "gdrBarrios";
            this.gdrBarrios.ReadOnly = true;
            this.gdrBarrios.Size = new System.Drawing.Size(340, 248);
            this.gdrBarrios.TabIndex = 64;
            this.gdrBarrios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrBarrios_CellClick);
            // 
            // IdBarrio
            // 
            this.IdBarrio.DataPropertyName = "Id_Barrio";
            this.IdBarrio.HeaderText = "ID Barrio";
            this.IdBarrio.Name = "IdBarrio";
            this.IdBarrio.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // IdLocalidad
            // 
            this.IdLocalidad.DataPropertyName = "Id_Localidad";
            this.IdLocalidad.HeaderText = "Localidad";
            this.IdLocalidad.Name = "IdLocalidad";
            this.IdLocalidad.ReadOnly = true;
            // 
            // txtIdBarrio
            // 
            this.txtIdBarrio.Location = new System.Drawing.Point(265, 54);
            this.txtIdBarrio.Mask = "99";
            this.txtIdBarrio.Name = "txtIdBarrio";
            this.txtIdBarrio.Size = new System.Drawing.Size(121, 20);
            this.txtIdBarrio.TabIndex = 65;
            this.txtIdBarrio.ValidatingType = typeof(int);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(265, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 66;
            // 
            // cmbIdLocalidad
            // 
            this.cmbIdLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdLocalidad.FormattingEnabled = true;
            this.cmbIdLocalidad.Location = new System.Drawing.Point(265, 112);
            this.cmbIdLocalidad.Name = "cmbIdLocalidad";
            this.cmbIdLocalidad.Size = new System.Drawing.Size(121, 21);
            this.cmbIdLocalidad.TabIndex = 67;
            // 
            // ABMBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(3)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(800, 269);
            this.Controls.Add(this.cmbIdLocalidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdBarrio);
            this.Controls.Add(this.gdrBarrios);
            this.Controls.Add(this.btnBorrarBarrio);
            this.Controls.Add(this.btnGuardarBarrio);
            this.Controls.Add(this.btnActualizarBarrio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ABMBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABMBarrio";
            this.Load += new System.EventHandler(this.ABMBarrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdrBarrios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBorrarBarrio;
        private System.Windows.Forms.Button btnGuardarBarrio;
        private System.Windows.Forms.Button btnActualizarBarrio;
        private System.Windows.Forms.DataGridView gdrBarrios;
        private System.Windows.Forms.MaskedTextBox txtIdBarrio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbIdLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLocalidad;
    }
}