namespace TP_PAV_v1.Formularios
{
    partial class ReporteListadoMarcas
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
            this.btnBuscarModelo = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rb_rango_id = new System.Windows.Forms.RadioButton();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.txtModeloReporte = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBuscarModelo
            // 
            this.btnBuscarModelo.Location = new System.Drawing.Point(559, 39);
            this.btnBuscarModelo.Name = "btnBuscarModelo";
            this.btnBuscarModelo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarModelo.TabIndex = 50;
            this.btnBuscarModelo.Text = "Buscar";
            this.btnBuscarModelo.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_PAV_v1.ListadoDeMarcas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 83);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(701, 281);
            this.reportViewer1.TabIndex = 45;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // rb_rango_id
            // 
            this.rb_rango_id.AutoSize = true;
            this.rb_rango_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_rango_id.Location = new System.Drawing.Point(172, 40);
            this.rb_rango_id.Name = "rb_rango_id";
            this.rb_rango_id.Size = new System.Drawing.Size(199, 21);
            this.rb_rango_id.TabIndex = 52;
            this.rb_rango_id.TabStop = true;
            this.rb_rango_id.Text = "Restringido por rango de id\r\n";
            this.rb_rango_id.UseVisualStyleBackColor = true;
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_todos.Location = new System.Drawing.Point(11, 40);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(146, 21);
            this.rb_todos.TabIndex = 53;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todos los usuarios";
            this.rb_todos.UseVisualStyleBackColor = true;
            // 
            // txtModeloReporte
            // 
            this.txtModeloReporte.Location = new System.Drawing.Point(397, 42);
            this.txtModeloReporte.Name = "txtModeloReporte";
            this.txtModeloReporte.Size = new System.Drawing.Size(121, 20);
            this.txtModeloReporte.TabIndex = 49;
            // 
            // ReporteListadoMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 383);
            this.Controls.Add(this.rb_rango_id);
            this.Controls.Add(this.rb_todos);
            this.Controls.Add(this.btnBuscarModelo);
            this.Controls.Add(this.txtModeloReporte);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteListadoMarcas";
            this.Text = "ReporteListadoMarcas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscarModelo;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.RadioButton rb_rango_id;
        private System.Windows.Forms.RadioButton rb_todos;
        private System.Windows.Forms.TextBox txtModeloReporte;
    }
}