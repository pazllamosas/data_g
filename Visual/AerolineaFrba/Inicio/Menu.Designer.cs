namespace AerolineaFrba.Inicio
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deslogearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTop5 = new System.Windows.Forms.Button();
            this.btnRegistroLlegada = new System.Windows.Forms.Button();
            this.btnGenerarViaje = new System.Windows.Forms.Button();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.btnConsultarMillas = new System.Windows.Forms.Button();
            this.btnComprarPasaje = new System.Windows.Forms.Button();
            this.btnCanjearMillas = new System.Windows.Forms.Button();
            this.btnVerRutas = new System.Windows.Forms.Button();
            this.btnVerRoles = new System.Windows.Forms.Button();
            this.btnVerAeronave = new System.Windows.Forms.Button();
            this.btnVerCiudades = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deslogearToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // deslogearToolStripMenuItem
            // 
            this.deslogearToolStripMenuItem.Name = "deslogearToolStripMenuItem";
            this.deslogearToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.deslogearToolStripMenuItem.Text = "Salir";
            this.deslogearToolStripMenuItem.Click += new System.EventHandler(this.deslogearToolStripMenuItem_Click);
            // 
            // btnTop5
            // 
            this.btnTop5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTop5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTop5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTop5.FlatAppearance.BorderSize = 0;
            this.btnTop5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTop5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnTop5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTop5.Image = global::AerolineaFrba.Properties.Resources.top_large;
            this.btnTop5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTop5.Location = new System.Drawing.Point(167, 246);
            this.btnTop5.Name = "btnTop5";
            this.btnTop5.Size = new System.Drawing.Size(260, 35);
            this.btnTop5.TabIndex = 31;
            this.btnTop5.Text = "Top 5";
            this.btnTop5.UseVisualStyleBackColor = false;
            this.btnTop5.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnRegistroLlegada
            // 
            this.btnRegistroLlegada.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistroLlegada.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRegistroLlegada.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistroLlegada.FlatAppearance.BorderSize = 0;
            this.btnRegistroLlegada.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegistroLlegada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnRegistroLlegada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistroLlegada.Image = global::AerolineaFrba.Properties.Resources.arrival_large;
            this.btnRegistroLlegada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroLlegada.Location = new System.Drawing.Point(12, 164);
            this.btnRegistroLlegada.Name = "btnRegistroLlegada";
            this.btnRegistroLlegada.Size = new System.Drawing.Size(260, 35);
            this.btnRegistroLlegada.TabIndex = 30;
            this.btnRegistroLlegada.Text = "Registro de Llegada a Destino";
            this.btnRegistroLlegada.UseVisualStyleBackColor = false;
            this.btnRegistroLlegada.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnGenerarViaje
            // 
            this.btnGenerarViaje.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGenerarViaje.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGenerarViaje.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGenerarViaje.FlatAppearance.BorderSize = 0;
            this.btnGenerarViaje.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGenerarViaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnGenerarViaje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerarViaje.Image = global::AerolineaFrba.Properties.Resources.travel_large;
            this.btnGenerarViaje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarViaje.Location = new System.Drawing.Point(305, 41);
            this.btnGenerarViaje.Name = "btnGenerarViaje";
            this.btnGenerarViaje.Size = new System.Drawing.Size(260, 35);
            this.btnGenerarViaje.TabIndex = 29;
            this.btnGenerarViaje.Text = "Generar Viaje";
            this.btnGenerarViaje.UseVisualStyleBackColor = false;
            this.btnGenerarViaje.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDevolucion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDevolucion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDevolucion.FlatAppearance.BorderSize = 0;
            this.btnDevolucion.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDevolucion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDevolucion.Image = global::AerolineaFrba.Properties.Resources.return_large;
            this.btnDevolucion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevolucion.Location = new System.Drawing.Point(12, 205);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(260, 35);
            this.btnDevolucion.TabIndex = 28;
            this.btnDevolucion.Text = "Devolución";
            this.btnDevolucion.UseVisualStyleBackColor = false;
            this.btnDevolucion.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnConsultarMillas
            // 
            this.btnConsultarMillas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConsultarMillas.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConsultarMillas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarMillas.FlatAppearance.BorderSize = 0;
            this.btnConsultarMillas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConsultarMillas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnConsultarMillas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarMillas.Image = global::AerolineaFrba.Properties.Resources.xchangemiles_large;
            this.btnConsultarMillas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarMillas.Location = new System.Drawing.Point(12, 82);
            this.btnConsultarMillas.Name = "btnConsultarMillas";
            this.btnConsultarMillas.Size = new System.Drawing.Size(260, 35);
            this.btnConsultarMillas.TabIndex = 27;
            this.btnConsultarMillas.Text = "Consultar Millas";
            this.btnConsultarMillas.UseVisualStyleBackColor = false;
            this.btnConsultarMillas.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnComprarPasaje
            // 
            this.btnComprarPasaje.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnComprarPasaje.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnComprarPasaje.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnComprarPasaje.FlatAppearance.BorderSize = 0;
            this.btnComprarPasaje.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnComprarPasaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnComprarPasaje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComprarPasaje.Image = global::AerolineaFrba.Properties.Resources.ticket_large;
            this.btnComprarPasaje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprarPasaje.Location = new System.Drawing.Point(12, 41);
            this.btnComprarPasaje.Name = "btnComprarPasaje";
            this.btnComprarPasaje.Size = new System.Drawing.Size(260, 35);
            this.btnComprarPasaje.TabIndex = 26;
            this.btnComprarPasaje.Text = "Comprar Pasaje";
            this.btnComprarPasaje.UseVisualStyleBackColor = false;
            this.btnComprarPasaje.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnCanjearMillas
            // 
            this.btnCanjearMillas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCanjearMillas.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCanjearMillas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCanjearMillas.FlatAppearance.BorderSize = 0;
            this.btnCanjearMillas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCanjearMillas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnCanjearMillas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCanjearMillas.Image = global::AerolineaFrba.Properties.Resources.miles_large;
            this.btnCanjearMillas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCanjearMillas.Location = new System.Drawing.Point(12, 123);
            this.btnCanjearMillas.Name = "btnCanjearMillas";
            this.btnCanjearMillas.Size = new System.Drawing.Size(260, 35);
            this.btnCanjearMillas.TabIndex = 25;
            this.btnCanjearMillas.Text = "Canjear Millas";
            this.btnCanjearMillas.UseVisualStyleBackColor = false;
            this.btnCanjearMillas.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnVerRutas
            // 
            this.btnVerRutas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVerRutas.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVerRutas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerRutas.FlatAppearance.BorderSize = 0;
            this.btnVerRutas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVerRutas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnVerRutas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerRutas.Image = global::AerolineaFrba.Properties.Resources.route_large;
            this.btnVerRutas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerRutas.Location = new System.Drawing.Point(305, 82);
            this.btnVerRutas.Name = "btnVerRutas";
            this.btnVerRutas.Size = new System.Drawing.Size(260, 35);
            this.btnVerRutas.TabIndex = 24;
            this.btnVerRutas.Text = "Ver Rutas";
            this.btnVerRutas.UseVisualStyleBackColor = false;
            this.btnVerRutas.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnVerRoles
            // 
            this.btnVerRoles.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVerRoles.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVerRoles.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerRoles.FlatAppearance.BorderSize = 0;
            this.btnVerRoles.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVerRoles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnVerRoles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerRoles.Image = global::AerolineaFrba.Properties.Resources.roles_large;
            this.btnVerRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerRoles.Location = new System.Drawing.Point(305, 164);
            this.btnVerRoles.Name = "btnVerRoles";
            this.btnVerRoles.Size = new System.Drawing.Size(260, 35);
            this.btnVerRoles.TabIndex = 23;
            this.btnVerRoles.Text = "Ver Roles";
            this.btnVerRoles.UseVisualStyleBackColor = false;
            this.btnVerRoles.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVerAeronave
            // 
            this.btnVerAeronave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVerAeronave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVerAeronave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerAeronave.FlatAppearance.BorderSize = 0;
            this.btnVerAeronave.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVerAeronave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnVerAeronave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerAeronave.Image = global::AerolineaFrba.Properties.Resources.airplane_large;
            this.btnVerAeronave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerAeronave.Location = new System.Drawing.Point(305, 123);
            this.btnVerAeronave.Name = "btnVerAeronave";
            this.btnVerAeronave.Size = new System.Drawing.Size(260, 35);
            this.btnVerAeronave.TabIndex = 22;
            this.btnVerAeronave.Text = "Ver Aeronaves";
            this.btnVerAeronave.UseVisualStyleBackColor = false;
            this.btnVerAeronave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVerCiudades
            // 
            this.btnVerCiudades.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnVerCiudades.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVerCiudades.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerCiudades.FlatAppearance.BorderSize = 0;
            this.btnVerCiudades.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVerCiudades.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnVerCiudades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerCiudades.Image = global::AerolineaFrba.Properties.Resources.city_large;
            this.btnVerCiudades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerCiudades.Location = new System.Drawing.Point(306, 205);
            this.btnVerCiudades.Name = "btnVerCiudades";
            this.btnVerCiudades.Size = new System.Drawing.Size(260, 35);
            this.btnVerCiudades.TabIndex = 21;
            this.btnVerCiudades.Text = "Ver Ciudades";
            this.btnVerCiudades.UseVisualStyleBackColor = false;
            this.btnVerCiudades.Click += new System.EventHandler(this.button5_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 297);
            this.Controls.Add(this.btnTop5);
            this.Controls.Add(this.btnRegistroLlegada);
            this.Controls.Add(this.btnGenerarViaje);
            this.Controls.Add(this.btnDevolucion);
            this.Controls.Add(this.btnConsultarMillas);
            this.Controls.Add(this.btnComprarPasaje);
            this.Controls.Add(this.btnCanjearMillas);
            this.Controls.Add(this.btnVerRutas);
            this.Controls.Add(this.btnVerRoles);
            this.Controls.Add(this.btnVerAeronave);
            this.Controls.Add(this.btnVerCiudades);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deslogearToolStripMenuItem;
        private System.Windows.Forms.Button btnVerCiudades;
        private System.Windows.Forms.Button btnVerAeronave;
        private System.Windows.Forms.Button btnVerRoles;
        private System.Windows.Forms.Button btnVerRutas;
        private System.Windows.Forms.Button btnCanjearMillas;
        private System.Windows.Forms.Button btnComprarPasaje;
        private System.Windows.Forms.Button btnConsultarMillas;
        private System.Windows.Forms.Button btnDevolucion;
        private System.Windows.Forms.Button btnGenerarViaje;
        private System.Windows.Forms.Button btnRegistroLlegada;
        private System.Windows.Forms.Button btnTop5;
    }
}