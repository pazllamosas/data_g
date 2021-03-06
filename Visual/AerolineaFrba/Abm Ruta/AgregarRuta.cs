﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace AerolineaFrba.Abm_Ruta
{
    public partial class AgregarRuta : Form
    {
        public AgregarRuta()
        {
            InitializeComponent();
        }
        private static bool editando = false;

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!editando)
            {
                bool resultado = funciones.permiteNumeros(txtPrecioEncomienda.Text);
                if (!resultado)
                {
                    MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                btnGuardar.Enabled = validacion();
            }
        }
        public void EditarRuta(string codigo, string precioEncomienda, string precioPasaje, string servicio, string ciudadOrigen, string ciudadDestino) //mandar todos los parametros para completar los texbox 
        {
            
            AgregarRuta.ActiveForm.Text = "Editar Ruta";
            editando = true;
            txtCodigo.Text = codigo;
            txtPrecioEncomienda.Text = precioEncomienda;
            txtPrecioPasaje.Text = precioPasaje;
            cmbTipoServicio.Text = servicio;
            cmbCiudadOrigen.Text = ciudadOrigen;
            cmbCiudadDestino.Text = ciudadDestino;

            string query = "SELECT DATA_G.GET_ID_RUTA('" + codigo + "', '" + ciudadOrigen + "', '" + ciudadDestino + "', '" + servicio + "' ) AS id";

            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            string idRuta = (reader["id"].ToString());
            reader.Close();
            txtid.Text = idRuta;

            btnGuardar.Enabled = true;

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
                Int32 codigo = Convert.ToInt32(txtCodigo.Text);

                string precio_kg = txtPrecioEncomienda.Text;

                string precio_pasaje = txtPrecioPasaje.Text;

                Int32 descripcionServicio = Convert.ToInt32(cmbTipoServicio.SelectedValue);

                Int32 origen = Convert.ToInt32(cmbCiudadOrigen.SelectedValue);

                Int32 destino = Convert.ToInt32(cmbCiudadDestino.SelectedValue);

                
            if (this.validacionDatos( precio_kg, precio_pasaje, origen, destino))
             {
                 if (this.validacion())
                 {
                     if (!editando)
                     {
                         if (codigoValido(codigo))
                         {

                             bool resultado = Conexion.executeProcedure("DATA_G.CREAR_RUTA", Conexion.generarArgumentos("@Codigo", "@PRECIO_KG", "@PRECIO_PASAJE",
                              "@IDSERV", "@ORIGEN", "@DESTINO"), codigo, precio_kg, precio_pasaje, descripcionServicio, origen, destino);

                             if (resultado)
                             {
                                 MessageBox.Show("Ruta creada exitosamente");

                                 this.txtCodigo.Clear();
                                 this.txtPrecioEncomienda.Clear();
                                 this.txtPrecioPasaje.Clear();
                                 this.cmbTipoServicio.SelectedIndex = -1;
                                 this.cmbCiudadOrigen.SelectedIndex = -1;
                                 this.cmbCiudadDestino.SelectedIndex = -1;
                             }
                         }
                         else
                         {
                             MessageBox.Show("El codigo ya existe");
                             this.txtCodigo.Clear();
                         }
                     }

                     else
                     {
                         if (editando)
                         {
                             string idRuta = txtid.Text;

                             bool resultado = Conexion.executeProcedure("DATA_G.MODIFICAR_RUTA", Conexion.generarArgumentos("@IDRUTA", "@Codigo", "@PRECIO_KG", "@PRECIO_PASAJE",
                             "@IDSERV", "@ORIGEN", "@DESTINO"), idRuta, codigo, precio_kg, precio_pasaje, descripcionServicio, origen, destino);
                             if (resultado)
                             {
                                 MessageBox.Show("Ruta modificada exitosamente");

                                 this.txtCodigo.Clear();
                                 this.txtPrecioEncomienda.Clear();
                                 this.txtPrecioPasaje.Clear();
                                 this.cmbTipoServicio.SelectedIndex = -1;
                                 this.cmbCiudadOrigen.SelectedIndex = -1;
                                 this.cmbCiudadDestino.SelectedIndex = -1;
                                 this.Hide();
                                 FormProvider.VerRutas.Show();
                             }

                         }
                     }
                 }
                 else
                 {
                     MessageBox.Show("Completar todos los campos");
                 }
            }
            

            FormProvider.VerRutas.CargarRutas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.VerRutas.Show();
        }

        private void cmbCiudadOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cmbCiudadDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AgregarRuta_Load(object sender, EventArgs e)
        {

            cmbTipoServicio.ValueMember = "IdServicio";
            cmbTipoServicio.DisplayMember = "Descripcion";
            cmbTipoServicio.DataSource = Conexion.cargarTablaConsulta("DATA_G.GET_SERVICIO");

            cmbCiudadOrigen.ValueMember = "CodigoCiudad";
            cmbCiudadOrigen.DisplayMember = "Nombre";
            cmbCiudadOrigen.DataSource = Conexion.cargarTablaConsulta("DATA_G.GET_CIUDADES");

            cmbCiudadDestino.ValueMember = "CodigoCiudad";
            cmbCiudadDestino.DisplayMember = "Nombre";
            cmbCiudadDestino.DataSource = Conexion.cargarTablaConsulta("DATA_G.GET_CIUDADES");

            this.txtCodigo.Clear();
            this.txtPrecioEncomienda.Clear();
            this.txtPrecioPasaje.Clear();
            this.cmbTipoServicio.SelectedIndex = -1;
            this.cmbCiudadOrigen.SelectedIndex = -1;
            this.cmbCiudadDestino.SelectedIndex = -1;
               
            
            }

      

        private bool validacion()
        {
            if (this.txtCodigo.Text.Trim() == "")
                return false;
            if (this.txtPrecioEncomienda.Text.Trim() == "")
                return false;
            if (this.txtPrecioPasaje.Text.Trim() == "")
                return false;
            if (this.cmbTipoServicio.SelectedIndex == -1)
                return false;
            if (this.cmbCiudadOrigen.SelectedIndex == -1)
                return false;
            if (this.cmbCiudadDestino.SelectedIndex == -1)
                return false;
            return true;
        }

        private bool validacionDatos( string precio_kg, string precio_pasaje, int origen, int destino)
        {
            if (origen == destino)
            {
                MessageBox.Show("La ruta no puede tener una misma ciudad como origen y destino");
                this.cmbCiudadDestino.SelectedIndex = -1;
                return false;
            }
            if (precio_kg == "0") 
            {
                MessageBox.Show("El precio de los kg no puede ser 0");
                this.txtPrecioEncomienda.Clear();
                return false;
            }
            if (precio_pasaje == "0")
            {
                MessageBox.Show("El precio del pasaje no puede ser 0");
                this.txtPrecioPasaje.Clear();
                return false;
            }
            return true;
        }

        public Boolean codigoValido(Int32 codigo)
        {
            string query = "SELECT DATA_G.EXISTE_CODIGO_RUTA ('" + codigo + "' ) AS id";

            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            int respuesta = int.Parse(reader["id"].ToString());
            reader.Close();

            if (respuesta == 0)
            {

                return true;
            }
            else
            {
               return false;
            }
        }

        private void txtPrecioPasaje_TextChanged(object sender, EventArgs e)
        {
            if (!editando)
            {

                bool resultado = funciones.permiteNumeros(txtPrecioPasaje.Text);
                if (!resultado)
                {
                    MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                btnGuardar.Enabled = validacion();
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (!editando)
            {

                bool resultado = funciones.permiteNumeros(txtCodigo.Text);
                if (!resultado)
                {
                    MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                btnGuardar.Enabled = validacion();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

    }

}
