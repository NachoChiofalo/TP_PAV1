namespace TP_PAV_v1.Entidades
{
    partial class PrincipalForm
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
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMEstacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMTanqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ABMCamion = new System.Windows.Forms.ToolStripMenuItem();
            this.ABMCombustible = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMVariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMVariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMModeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMBarrioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMLocalidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMProvinciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMTipoDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMTipoCombustibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lsitadosConFiltrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBienvenida.Location = new System.Drawing.Point(516, 34);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(225, 42);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido!";
            this.lblBienvenida.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMToolStripMenuItem,
            this.remitoToolStripMenuItem,
            this.listadosSimplesToolStripMenuItem,
            this.lsitadosConFiltrosToolStripMenuItem,
            this.estadisticasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1267, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // aBMToolStripMenuItem
            // 
            this.aBMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMEstacionToolStripMenuItem,
            this.aBMTanqueToolStripMenuItem,
            this.ABMCamion,
            this.ABMCombustible,
            this.aBMEmpleadoToolStripMenuItem,
            this.aBMTurnoToolStripMenuItem,
            this.aBMVariosToolStripMenuItem,
            this.aBMVariosToolStripMenuItem1});
            this.aBMToolStripMenuItem.Name = "aBMToolStripMenuItem";
            this.aBMToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.aBMToolStripMenuItem.Text = "ABM";
            // 
            // aBMEstacionToolStripMenuItem
            // 
            this.aBMEstacionToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.aBMEstacionToolStripMenuItem.Image = global::TP_PAV_v1.Properties.Resources.pngtree_vector_fuel_station_icon_png_image_701271;
            this.aBMEstacionToolStripMenuItem.Name = "aBMEstacionToolStripMenuItem";
            this.aBMEstacionToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.aBMEstacionToolStripMenuItem.Text = "ABM Estacion";
            this.aBMEstacionToolStripMenuItem.Click += new System.EventHandler(this.aBMEstacionToolStripMenuItem_Click);
            // 
            // aBMTanqueToolStripMenuItem
            // 
            this.aBMTanqueToolStripMenuItem.Image = global::TP_PAV_v1.Properties.Resources.Tanques;
            this.aBMTanqueToolStripMenuItem.Name = "aBMTanqueToolStripMenuItem";
            this.aBMTanqueToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.aBMTanqueToolStripMenuItem.Text = "ABM Tanque";
            this.aBMTanqueToolStripMenuItem.Click += new System.EventHandler(this.aBMTanqueToolStripMenuItem_Click);
            // 
            // ABMCamion
            // 
            this.ABMCamion.Image = global::TP_PAV_v1.Properties.Resources.Camion;
            this.ABMCamion.Name = "ABMCamion";
            this.ABMCamion.Size = new System.Drawing.Size(196, 22);
            this.ABMCamion.Text = "ABM Camion";
            this.ABMCamion.Click += new System.EventHandler(this.aBMCamionToolStripMenuItem_Click);
            // 
            // ABMCombustible
            // 
            this.ABMCombustible.Image = global::TP_PAV_v1.Properties.Resources.Combustible;
            this.ABMCombustible.Name = "ABMCombustible";
            this.ABMCombustible.Size = new System.Drawing.Size(196, 22);
            this.ABMCombustible.Text = "ABM Combustible";
            this.ABMCombustible.Click += new System.EventHandler(this.aBMCombustibleToolStripMenuItem_Click);
            // 
            // aBMEmpleadoToolStripMenuItem
            // 
            this.aBMEmpleadoToolStripMenuItem.Image = global::TP_PAV_v1.Properties.Resources._4172317_connect_consumer_follow_person_somebody_icon;
            this.aBMEmpleadoToolStripMenuItem.Name = "aBMEmpleadoToolStripMenuItem";
            this.aBMEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.aBMEmpleadoToolStripMenuItem.Text = "ABM Empleado";
            this.aBMEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.aBMEmpleadoToolStripMenuItem_Click);
            // 
            // aBMTurnoToolStripMenuItem
            // 
            this.aBMTurnoToolStripMenuItem.Image = global::TP_PAV_v1.Properties.Resources.Turno;
            this.aBMTurnoToolStripMenuItem.Name = "aBMTurnoToolStripMenuItem";
            this.aBMTurnoToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.aBMTurnoToolStripMenuItem.Text = "ABM Turno";
            this.aBMTurnoToolStripMenuItem.Click += new System.EventHandler(this.aBMTurnoToolStripMenuItem_Click);
            // 
            // aBMVariosToolStripMenuItem
            // 
            this.aBMVariosToolStripMenuItem.Image = global::TP_PAV_v1.Properties.Resources.estacion_d_servicio;
            this.aBMVariosToolStripMenuItem.Name = "aBMVariosToolStripMenuItem";
            this.aBMVariosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.aBMVariosToolStripMenuItem.Text = "ABM Sucursal";
            this.aBMVariosToolStripMenuItem.Click += new System.EventHandler(this.aBMVariosToolStripMenuItem_Click);
            // 
            // aBMVariosToolStripMenuItem1
            // 
            this.aBMVariosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMMarcaToolStripMenuItem,
            this.aBMModeloToolStripMenuItem,
            this.aBMBarrioToolStripMenuItem,
            this.aBMLocalidadToolStripMenuItem,
            this.aBMProvinciaToolStripMenuItem,
            this.aBMTipoDocumentoToolStripMenuItem,
            this.aBMTipoCombustibleToolStripMenuItem});
            this.aBMVariosToolStripMenuItem1.Image = global::TP_PAV_v1.Properties.Resources.VARIOS;
            this.aBMVariosToolStripMenuItem1.Name = "aBMVariosToolStripMenuItem1";
            this.aBMVariosToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.aBMVariosToolStripMenuItem1.Text = "ABM Varios";
            // 
            // aBMMarcaToolStripMenuItem
            // 
            this.aBMMarcaToolStripMenuItem.Name = "aBMMarcaToolStripMenuItem";
            this.aBMMarcaToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.aBMMarcaToolStripMenuItem.Text = "ABM Marca";
            this.aBMMarcaToolStripMenuItem.Click += new System.EventHandler(this.aBMMarcaToolStripMenuItem_Click);
            // 
            // aBMModeloToolStripMenuItem
            // 
            this.aBMModeloToolStripMenuItem.Name = "aBMModeloToolStripMenuItem";
            this.aBMModeloToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.aBMModeloToolStripMenuItem.Text = "ABM Modelo";
            // 
            // aBMBarrioToolStripMenuItem
            // 
            this.aBMBarrioToolStripMenuItem.Image = global::TP_PAV_v1.Properties.Resources._3994378_location_map_navigation_pin_position_icon;
            this.aBMBarrioToolStripMenuItem.Name = "aBMBarrioToolStripMenuItem";
            this.aBMBarrioToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.aBMBarrioToolStripMenuItem.Text = "ABM Barrio";
            this.aBMBarrioToolStripMenuItem.Click += new System.EventHandler(this.aBMBarrioToolStripMenuItem_Click);
            // 
            // aBMLocalidadToolStripMenuItem
            // 
            this.aBMLocalidadToolStripMenuItem.Image = global::TP_PAV_v1.Properties.Resources._3994384_local_location_map_travel_world_icon;
            this.aBMLocalidadToolStripMenuItem.Name = "aBMLocalidadToolStripMenuItem";
            this.aBMLocalidadToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.aBMLocalidadToolStripMenuItem.Text = "ABM Localidad";
            this.aBMLocalidadToolStripMenuItem.Click += new System.EventHandler(this.aBMLocalidadToolStripMenuItem_Click);
            // 
            // aBMProvinciaToolStripMenuItem
            // 
            this.aBMProvinciaToolStripMenuItem.Image = global::TP_PAV_v1.Properties.Resources.provincias;
            this.aBMProvinciaToolStripMenuItem.Name = "aBMProvinciaToolStripMenuItem";
            this.aBMProvinciaToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.aBMProvinciaToolStripMenuItem.Text = "ABM Provincia";
            this.aBMProvinciaToolStripMenuItem.Click += new System.EventHandler(this.aBMProvinciaToolStripMenuItem_Click);
            // 
            // aBMTipoDocumentoToolStripMenuItem
            // 
            this.aBMTipoDocumentoToolStripMenuItem.Image = global::TP_PAV_v1.Properties.Resources.tipos_dos;
            this.aBMTipoDocumentoToolStripMenuItem.Name = "aBMTipoDocumentoToolStripMenuItem";
            this.aBMTipoDocumentoToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.aBMTipoDocumentoToolStripMenuItem.Text = "ABM Tipo Documento";
            this.aBMTipoDocumentoToolStripMenuItem.Click += new System.EventHandler(this.aBMTipoDocumentoToolStripMenuItem_Click);
            // 
            // aBMTipoCombustibleToolStripMenuItem
            // 
            this.aBMTipoCombustibleToolStripMenuItem.Image = global::TP_PAV_v1.Properties.Resources.TIPOCOMB;
            this.aBMTipoCombustibleToolStripMenuItem.Name = "aBMTipoCombustibleToolStripMenuItem";
            this.aBMTipoCombustibleToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.aBMTipoCombustibleToolStripMenuItem.Text = "ABM Tipo Combustible";
            this.aBMTipoCombustibleToolStripMenuItem.Click += new System.EventHandler(this.aBMTipoCombustibleToolStripMenuItem_Click);
            // 
            // remitoToolStripMenuItem
            // 
            this.remitoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem});
            this.remitoToolStripMenuItem.Name = "remitoToolStripMenuItem";
            this.remitoToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.remitoToolStripMenuItem.Text = "Remito";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.altaToolStripMenuItem.Text = "Alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // listadosSimplesToolStripMenuItem
            // 
            this.listadosSimplesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeToolStripMenuItem,
            this.listadoDeEmpleadosToolStripMenuItem,
            this.listadoDeMarcasToolStripMenuItem});
            this.listadosSimplesToolStripMenuItem.Name = "listadosSimplesToolStripMenuItem";
            this.listadosSimplesToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.listadosSimplesToolStripMenuItem.Text = "Listados Simples";
            // 
            // listadoDeToolStripMenuItem
            // 
            this.listadoDeToolStripMenuItem.Name = "listadoDeToolStripMenuItem";
            this.listadoDeToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.listadoDeToolStripMenuItem.Text = "Listado de camiones";
            this.listadoDeToolStripMenuItem.Click += new System.EventHandler(this.listadoDeToolStripMenuItem_Click);
            // 
            // listadoDeEmpleadosToolStripMenuItem
            // 
            this.listadoDeEmpleadosToolStripMenuItem.Name = "listadoDeEmpleadosToolStripMenuItem";
            this.listadoDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.listadoDeEmpleadosToolStripMenuItem.Text = "Listado de Empleados";
            this.listadoDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeEmpleadosToolStripMenuItem_Click);
            // 
            // lsitadosConFiltrosToolStripMenuItem
            // 
            this.lsitadosConFiltrosToolStripMenuItem.Name = "lsitadosConFiltrosToolStripMenuItem";
            this.lsitadosConFiltrosToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.lsitadosConFiltrosToolStripMenuItem.Text = "Listados con filtros";
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            // 
            // listadoDeMarcasToolStripMenuItem
            // 
            this.listadoDeMarcasToolStripMenuItem.Name = "listadoDeMarcasToolStripMenuItem";
            this.listadoDeMarcasToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.listadoDeMarcasToolStripMenuItem.Text = "Listado de marcas";
            this.listadoDeMarcasToolStripMenuItem.Click += new System.EventHandler(this.listadoDeMarcasToolStripMenuItem_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP_PAV_v1.Properties.Resources.EA4_YPF_renueva_imagen_estaciones_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1267, 749);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YPF - Inicio";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lsitadosConFiltrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMEstacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMTanqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ABMCamion;
        private System.Windows.Forms.ToolStripMenuItem ABMCombustible;
        private System.Windows.Forms.ToolStripMenuItem aBMEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMTurnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMVariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMVariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aBMMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMModeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMBarrioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMLocalidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMProvinciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMTipoDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMTipoCombustibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeMarcasToolStripMenuItem;
    }
}