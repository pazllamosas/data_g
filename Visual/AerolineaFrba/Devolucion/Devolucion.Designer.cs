namespace AerolineaFrba.Devolucion
{
    partial class Devolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devolucion));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deslogearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCodItem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.rdbPasaje = new System.Windows.Forms.CheckBox();
            this.rdbEncomienda = new System.Windows.Forms.CheckBox();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(845, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deslogearToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // deslogearToolStripMenuItem
            // 
            this.deslogearToolStripMenuItem.Name = "deslogearToolStripMenuItem";
            this.deslogearToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.deslogearToolStripMenuItem.Text = "Salir";
            // 
            // txtCodItem
            // 
            this.txtCodItem.Location = new System.Drawing.Point(220, 95);
            this.txtCodItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodItem.Name = "txtCodItem";
            this.txtCodItem.Size = new System.Drawing.Size(160, 22);
            this.txtCodItem.TabIndex = 16;
            this.txtCodItem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Código de item o Nro compra:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.Image = global::AerolineaFrba.Properties.Resources.back;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(20, 43);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(76, 28);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // rdbPasaje
            // 
            this.rdbPasaje.AutoSize = true;
            this.rdbPasaje.Location = new System.Drawing.Point(20, 132);
            this.rdbPasaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbPasaje.Name = "rdbPasaje";
            this.rdbPasaje.Size = new System.Drawing.Size(72, 21);
            this.rdbPasaje.TabIndex = 18;
            this.rdbPasaje.TabStop = true;
            this.rdbPasaje.Text = "Pasaje";
            this.rdbPasaje.UseVisualStyleBackColor = true;
            this.rdbPasaje.CheckedChanged += new System.EventHandler(this.rdbPasaje_CheckedChanged);
            // 
            // rdbEncomienda
            // 
            this.rdbEncomienda.AutoSize = true;
            this.rdbEncomienda.Location = new System.Drawing.Point(20, 160);
            this.rdbEncomienda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbEncomienda.Name = "rdbEncomienda";
            this.rdbEncomienda.Size = new System.Drawing.Size(107, 21);
            this.rdbEncomienda.TabIndex = 19;
            this.rdbEncomienda.TabStop = true;
            this.rdbEncomienda.Text = "Encomienda";
            this.rdbEncomienda.UseVisualStyleBackColor = true;
            // 
            // btnDevolver
            // 
            this.btnDevolver.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDevolver.Enabled = false;
            this.btnDevolver.Image = global::AerolineaFrba.Properties.Resources.next;
            this.btnDevolver.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDevolver.Location = new System.Drawing.Point(736, 402);
            this.btnDevolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(93, 28);
            this.btnDevolver.TabIndex = 20;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 189);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 21);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Compra";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVolver;
            this.ClientSize = new System.Drawing.Size(845, 446);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.rdbEncomienda);
            this.Controls.Add(this.rdbPasaje);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtCodItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Devolucion";
            this.Text = "Devoluciones";
            this.Load += new System.EventHandler(this.Devolucion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deslogearToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCodItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.CheckBox rdbPasaje;
        private System.Windows.Forms.CheckBox rdbEncomienda;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.CheckBox radioButton1;
    }
}