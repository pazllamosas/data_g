using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.Compra
{
    public partial class AgregarCliente : Form
    {

        public AgregarCliente()
        {
            InitializeComponent();
        }
        private static bool editando = false;

        public void EditarCliente(string dni, string apellido, string nombre, DateTime fNac, string telefono, string mail, string direccion)  
        {
            txtDNI.Text = dni; 
            txtApellido.Text = apellido;
            txtNombre.Text = nombre;
            dtmFNac.Value = fNac;
            txtTelefono.Text = telefono;
            txtMail.Text = mail;
            txtDireccion.Text = direccion;
            AgregarCliente.ActiveForm.Text = "Editar Cliente";
            editando = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //FormProvider.VerCliente.Show();
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {
            this.txtApellido.Clear();
            this.txtDNI.Clear();
            this.txtTelefono.Clear();
            this.txtNombre.Clear();
            this.txtDireccion.Clear();
            editando = false;
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           if (this.validacion())
           {
            Int32 dni = Convert.ToInt32(txtDNI.Text);
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            string fecha = dtmFNac.Value.ToString("yyyy-MM-dd");
            string telefono = txtTelefono.Text;
            string mail = txtMail.Text;
            string direccion = txtDireccion.Text;

            if (this.validacionDatos(dni, fecha))
            {
                if (!editando)
                {
                    bool resultado = Conexion.executeProcedure("DATA_G.ALTA_CLIENTE", Conexion.generarArgumentos
                          ("@nombre", "@apellido", "@dni", "@direccion", "@telefono", "@mail", "@fechaNac"),
                          nombre, apellido, dni, direccion, telefono, mail, fecha);

                    if (resultado)
                    {
                        MessageBox.Show("Cliente creado exitosamente");
                        this.txtDNI.Clear();
                        this.txtApellido.Clear();
                        this.txtNombre.Clear();
                        this.txtTelefono.Clear();
                        this.txtMail.Clear();
                        this.txtDireccion.Clear();
                    }
                }
                else
                {
                    if (editando)
                    {
                        bool resultado = Conexion.executeProcedure("DATA_G.MODIFICACION_CLIENTE", Conexion.generarArgumentos
                             ("@nombre", "@apellido", "@dni", "@direccion", "@telefono", "@mail", "@fechaNac"),
                             nombre, apellido, dni, direccion, telefono, mail, fecha);

                        if (resultado)
                        {
                            MessageBox.Show("Cliente modificado exitosamente");
                            this.txtDNI.Clear();
                            this.txtApellido.Clear();
                            this.txtNombre.Clear();
                            this.txtTelefono.Clear();
                            this.txtMail.Clear();
                            this.txtDireccion.Clear();
                        }
                    }
                
                }
            }
        }
           else
            {
                MessageBox.Show("Completar todos los campos");
            }

         //  FormProvider.; CARGAR DATOS DEL ANTERIOR?
          }
        
        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            bool resultado = funciones.permiteNumeros(txtDNI.Text);
            if (!resultado)
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            btnGuardar.Enabled = validacion(); 
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            bool resultado = funciones.permiteNumeros(txtDNI.Text);
            if (!resultado)
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            btnGuardar.Enabled = validacion(); 
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = validacion();
        }

        private bool validacion()
        {
            if (this.txtDireccion.Text.Trim() == "")
                return false;
            if (this.txtTelefono.Text.Trim() == "")
                return false;
            if (this.txtApellido.Text.Trim() == "")
                return false;
            if (this.txtNombre.Text.Trim() == "")
                return false;
            if (this.txtDNI.Text.Trim() == "")
                return false;
            if (this.txtMail.Text.Trim() == "")
                return false;
            return true;
             }

        private bool validacionDatos(Int32 dni, string fNac)
        {
            if ((dni - 999999) < 0)
            {
                MessageBox.Show("Complete correctamente el Dni");
                this.txtDNI.Clear();
                return false;
            }
            if (DateTime.Parse(fNac) > DateTime.Parse(funciones.getFechaSistema()))
            {
                MessageBox.Show("La fecha de nacimiento no puede ser mayor a la fecha de hoy");
                return false;
            }
            return true;
        }

       private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            bool resultado = funciones.permiteLetras(txtApellido.Text);
            if (!resultado)
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            btnGuardar.Enabled = validacion();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            bool resultado = funciones.permiteLetras(txtApellido.Text);
            if (!resultado)
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            btnGuardar.Enabled = validacion();
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtmFNac_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
