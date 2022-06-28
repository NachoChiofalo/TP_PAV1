namespace TP_PAV_v1.Formularios
{
    partial class ABMTipoDocumento
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
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtNombreTipoDoc = new System.Windows.Forms.TextBox();
            this.txtIdTipoDoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgrTipoDocumento = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idTipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomTipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrTipoDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBorrar.Font = new System.Drawing.Font("HelvLight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(269, 193);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(89, 39);
            this.btnBorrar.TabIndex = 25;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.Font = new System.Drawing.Font("HelvLight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(364, 148);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 39);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnActualizar.Font = new System.Drawing.Font("HelvLight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(269, 148);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(89, 39);
            this.btnActualizar.TabIndex = 23;
            this.btnActualizar.Text = "Actualizar ";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimpiar.Font = new System.Drawing.Font("HelvLight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(174, 148);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(89, 39);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // txtNombreTipoDoc
            // 
            this.txtNombreTipoDoc.Location = new System.Drawing.Point(332, 71);
            this.txtNombreTipoDoc.Name = "txtNombreTipoDoc";
            this.txtNombreTipoDoc.Size = new System.Drawing.Size(121, 20);
            this.txtNombreTipoDoc.TabIndex = 20;
            // 
            // txtIdTipoDoc
            // 
            this.txtIdTipoDoc.Location = new System.Drawing.Point(332, 46);
            this.txtIdTipoDoc.Name = "txtIdTipoDoc";
            this.txtIdTipoDoc.Size = new System.Drawing.Size(121, 20);
            this.txtIdTipoDoc.TabIndex = 19;
            this.txtIdTipoDoc.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HelvLight", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(164, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Alta de Tipo de Documento";
            // 
            // dgrTipoDocumento
            // 
            this.dgrTipoDocumento.AllowUserToAddRows = false;
            this.dgrTipoDocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrTipoDocumento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipoDoc,
            this.nomTipoDoc});
            this.dgrTipoDocumento.Location = new System.Drawing.Point(470, 12);
            this.dgrTipoDocumento.Name = "dgrTipoDocumento";
            this.dgrTipoDocumento.ReadOnly = true;
            this.dgrTipoDocumento.Size = new System.Drawing.Size(244, 236);
            this.dgrTipoDocumento.TabIndex = 17;
            this.dgrTipoDocumento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrTipoDocumento_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HelvLight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(153, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre Tipo Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HelvLight", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(191, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id Tipo Documento";
            this.label1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TP_PAV_v1.Properties.Resources.FONDO_OFICIAL;
            this.pictureBox1.Image = global::TP_PAV_v1.Properties.Resources.YPF_GIRO;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // idTipoDoc
            // 
            this.idTipoDoc.DataPropertyName = "Id_Tipo_Documento";
            this.idTipoDoc.HeaderText = "ID";
            this.idTipoDoc.Name = "idTipoDoc";
            this.idTipoDoc.ReadOnly = true;
            // 
            // nomTipoDoc
            // 
            this.nomTipoDoc.DataPropertyName = "nombre";
            this.nomTipoDoc.HeaderText = "Nombre";
            this.nomTipoDoc.Name = "nomTipoDoc";
            this.nomTipoDoc.ReadOnly = true;
            // 
            // ABMTipoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(3)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(723, 261);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtNombreTipoDoc);
            this.Controls.Add(this.txtIdTipoDoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgrTipoDocumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ABMTipoDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABMTipoDocumento";
            this.Load += new System.EventHandler(this.ABMTipoDocumento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrTipoDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtNombreTipoDoc;
        private System.Windows.Forms.TextBox txtIdTipoDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgrTipoDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomTipoDoc;
    }
}