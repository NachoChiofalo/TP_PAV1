namespace TP_PAV_v1.Formularios
{
    partial class ReporteListadoCamiones
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblMarcaReporte = new System.Windows.Forms.Label();
            this.txtMarcaReporte = new System.Windows.Forms.TextBox();
            this.btnBuscarMarca = new System.Windows.Forms.Button();
            this.txtModeloReporte = new System.Windows.Forms.TextBox();
            this.btnBuscarModelo = new System.Windows.Forms.Button();
            this.lblModelo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_PAV_v1.ListadoDeCamiones.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 70);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(637, 389);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // lblMarcaReporte
            // 
            this.lblMarcaReporte.AutoSize = true;
            this.lblMarcaReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaReporte.Location = new System.Drawing.Point(355, 20);
            this.lblMarcaReporte.Name = "lblMarcaReporte";
            this.lblMarcaReporte.Size = new System.Drawing.Size(67, 24);
            this.lblMarcaReporte.TabIndex = 1;
            this.lblMarcaReporte.Text = "Marca";
            // 
            // txtMarcaReporte
            // 
            this.txtMarcaReporte.Location = new System.Drawing.Point(428, 23);
            this.txtMarcaReporte.Name = "txtMarcaReporte";
            this.txtMarcaReporte.Size = new System.Drawing.Size(121, 20);
            this.txtMarcaReporte.TabIndex = 40;
            // 
            // btnBuscarMarca
            // 
            this.btnBuscarMarca.Location = new System.Drawing.Point(574, 21);
            this.btnBuscarMarca.Name = "btnBuscarMarca";
            this.btnBuscarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarMarca.TabIndex = 41;
            this.btnBuscarMarca.Text = "Buscar";
            this.btnBuscarMarca.UseVisualStyleBackColor = true;
            this.btnBuscarMarca.Click += new System.EventHandler(this.btnBuscarMarca_Click);
            // 
            // txtModeloReporte
            // 
            this.txtModeloReporte.Location = new System.Drawing.Point(97, 24);
            this.txtModeloReporte.Name = "txtModeloReporte";
            this.txtModeloReporte.Size = new System.Drawing.Size(121, 20);
            this.txtModeloReporte.TabIndex = 42;
            // 
            // btnBuscarModelo
            // 
            this.btnBuscarModelo.Location = new System.Drawing.Point(236, 22);
            this.btnBuscarModelo.Name = "btnBuscarModelo";
            this.btnBuscarModelo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarModelo.TabIndex = 43;
            this.btnBuscarModelo.Text = "Buscar";
            this.btnBuscarModelo.UseVisualStyleBackColor = true;
            this.btnBuscarModelo.Click += new System.EventHandler(this.btnBuscarModelo_Click);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(11, 22);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(80, 24);
            this.lblModelo.TabIndex = 44;
            this.lblModelo.Text = "Modelo";
            // 
            // ReporteListadoCamiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 471);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.btnBuscarModelo);
            this.Controls.Add(this.txtModeloReporte);
            this.Controls.Add(this.btnBuscarMarca);
            this.Controls.Add(this.txtMarcaReporte);
            this.Controls.Add(this.lblMarcaReporte);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteListadoCamiones";
            this.Text = "ReporteListadoCamiones";
            this.Load += new System.EventHandler(this.ReporteListadoCamiones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label lblMarcaReporte;
        private System.Windows.Forms.TextBox txtMarcaReporte;
        private System.Windows.Forms.Button btnBuscarMarca;
        private System.Windows.Forms.TextBox txtModeloReporte;
        private System.Windows.Forms.Button btnBuscarModelo;
        private System.Windows.Forms.Label lblModelo;
    }
}