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

namespace AerolineaFrba.Abm_Rol
{
    public partial class AgregarRol : Form
    {
        public AgregarRol()
        {
            InitializeComponent();
            dgvElegirFuncionalidad.Rows.Clear();

            string query = "SELECT * FROM DATA_G.FUNCIONALIDADES order by IdFuncionalidad";
            SqlDataReader reader = Conexion.ejecutarQuery(query);

            while (reader.Read())
            {
                dgvElegirFuncionalidad.Rows.Add(reader["IdFuncionalidad"], reader["DescripcionFunc"]);
            }
            reader.Close();
              }

        //public void CargarFunci()
        //{
        //    dgvElegirFuncionalidad.Rows.Clear();

        //    string query = "SELECT * FROM DATA_G.FUNCIONALIDADES order by IdFuncionalidad";
        //    SqlDataReader reader = Conexion.ejecutarQuery(query);

        //    while (reader.Read())
        //    {
        //        dgvElegirFuncionalidad.Rows.Add(reader["IdFuncionalidad"], reader["DescripcionFunc"]);
        //    }
        //    reader.Close();
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtidRol.Text.Trim() == "")
            {
                string nombre = txtNombre.Text;
                //string idRol = txtidRol.Text;

                bool resultado = Conexion.executeProcedure("DATA_G.CREAR_ROL", Conexion.generarArgumentos("@NOMBRE"), nombre);
                if (resultado)
                {

                    string query = "SELECT DATA_G.GET_ID_ROL ('" + nombre + "' ) AS id";

                    SqlDataReader reader = Conexion.ejecutarQuery(query);
                    reader.Read();
                    string respuesta = (reader["id"].ToString());
                    reader.Close();
                    txtidRol.Text = respuesta;


                    MessageBox.Show("Rol creado");

                    dgvElegirFuncionalidad.Enabled = true;
                    labelUsuario.Enabled = true;
                    cmbUsuario.Enabled = true;
                    btnAsignar.Enabled = true;
                    button1.Enabled = true;
                    button3.Enabled = true;
                    btnVolver.Enabled = true;

                }
            }
            else
            {
                if (txtidRol.Text.Trim() != "")
                {
                    string nombre = txtNombre.Text;
                    string idRol = txtidRol.Text;

                    bool resultado = Conexion.executeProcedure("DATA_G.MODIFICAR_NOMBRE_ROL", Conexion.generarArgumentos("@NOMBRE", "@ROL "), nombre, idRol);
                    if (resultado)
                    {
                        MessageBox.Show("Rol modificado");
                    }
                }

            }
                     
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            Conexion.executeProcedure("DATA_G.ELIMINAR_ROL", Conexion.generarArgumentos("@ROL"), nombre);
            this.txtNombre.Clear();
            this.txtidRol.Clear();
            this.cmbUsuario.SelectedIndex = -1;
            this.Hide();
            FormProvider.VerRoles.Show();
        }

        private void AgregarRol_Load(object sender, EventArgs e)
        {
            //string query = "SELECT * FROM DATA_G.FUNCIONALIDADES";
            //SqlDataReader reader = Conexion.ejecutarQuery(query);

            //while (reader.Read())
            //{
            //    dgvElegirFuncionalidad.Rows.Add(reader["DescripcionFunc"]);
            //}
            //reader.Close();

            cmbUsuario.ValueMember = "IdUsuario";
            cmbUsuario.DisplayMember = "Username";
            cmbUsuario.DataSource = Conexion.cargarTablaConsulta("DATA_G.GET_USUARIOS");

            this.txtNombre.Clear();
            this.txtidRol.Clear();
            this.cmbUsuario.SelectedIndex = -1;
            editando = false;


        }

        private void dgvElegirFuncionalidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
       }

        private void button1_Click_1(object sender, EventArgs e)
        {
             Int32 selectedRowCount = dgvElegirFuncionalidad.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0 && selectedRowCount < 2)
            {
                DataGridViewRow d = dgvElegirFuncionalidad.SelectedRows[0];
                Int32 func =  Convert.ToInt32(d.Cells[0].Value);
                string funcDesc = d.Cells[1].Value.ToString();
                Int32 idRol = Convert.ToInt32(txtidRol.Text);

                if(existeFuncionalidad(func, idRol))
            {
                bool resultado = Conexion.executeProcedure("DATA_G.ASIGNAR_FUNCIONALIDAD", Conexion.generarArgumentos("@FUNC", "@ROL"), func, idRol); 
               if (resultado)
                {
                    MessageBox.Show("Funcionalidad Asignada");
                }
                }

                 else
                 {
                    MessageBox.Show("Esa funcionalidad ya esta asignada al rol", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 }       
          }
            else
            {
                MessageBox.Show("Elegir una y solo una funcionalidad para agregar");
            }
        }

            

       


        public void EditarRol(string rol, string rolDesc) 
        {
            txtidRol.Text = rol;
            txtNombre.Text = rolDesc;
            button2.Visible = true;
            txtNombre.ReadOnly = true;
            editando = true;
            btnVolver.Enabled = true;
            dgvElegirFuncionalidad.Enabled = true;
            labelUsuario.Enabled = true;
            cmbUsuario.Enabled = true;
            btnAsignar.Enabled = true;
            button1.Enabled = true;
            button3.Enabled = true;
            AgregarRol.ActiveForm.Text = "Editar Rol";

            
        }
        private static bool editando = false;

        private void button2_Click(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = false;
            txtNombre.Clear();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = false;
            txtNombre.Clear();

        }

        public Boolean existeRol(string nombre)
        {
            string query = "SELECT DATA_G.EXISTE_ROL ('" + nombre + "' ) AS id";

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

        private void txtNombre_TextChanged_1(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;

        }

        private bool validacion()
        {
            if (this.txtNombre.Text.Trim() == "")
                return false;
           if (this.cmbUsuario.SelectedIndex == -1)
                return false;
            return true;
        }

        public Boolean existeFuncionalidad(Int32 funcionalidad, Int32 rol)
        {
            string query = "SELECT DATA_G.EXISTE_FUNCIONALIDAD_ROL ('" + funcionalidad + "', '" + rol + "' ) AS id";

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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (!editando)
            {
                if (!(this.cmbUsuario.SelectedIndex == -1))
                {
                    this.txtNombre.Clear();
                    this.txtidRol.Clear();
                    this.cmbUsuario.SelectedIndex = -1;
                    this.Hide();
                    FormProvider.VerRoles.CargarRoles();
                    FormProvider.VerRoles.Show();
                }
                else
                {
                    MessageBox.Show("Asignar un usuario");
                }
            }
            else
            {
                this.txtNombre.Clear();
                this.txtidRol.Clear();
                this.cmbUsuario.SelectedIndex = -1;
                this.Hide();
                FormProvider.VerRoles.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Int32 selectedRowCount = dgvElegirFuncionalidad.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0 && selectedRowCount < 2)
            {
                DataGridViewRow d = dgvElegirFuncionalidad.SelectedRows[0];
                Int32 func = Convert.ToInt32(d.Cells[0].Value);
                string funcDesc = d.Cells[1].Value.ToString();
                Int32 idRol = Convert.ToInt32(txtidRol.Text);

                if (!existeFuncionalidad(func, idRol))
                {
                    bool resultado = Conexion.executeProcedure("DATA_G.ELIMINAR_FUNCIONALIDAD", Conexion.generarArgumentos("@FUNC", "@ROL"), func, idRol);
                    if (resultado)
                    {
                        MessageBox.Show("Funcionalidad Eliminada");
                    }
                }

                else
                {
                    MessageBox.Show("Esa funcionalidad no esta asignada al rol", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Elegir una y solo una funcionalidad para eliminar");
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            Int32 idRol = Convert.ToInt32(txtidRol.Text);
            Int32 usuario = Convert.ToInt32(cmbUsuario.SelectedValue);

            if (!(this.cmbUsuario.SelectedIndex == -1))
            {
                if (existeUsrenRol(usuario, idRol))
                {
                    string query = "SELECT DATA_G.GET_ID_USUARIO ('" + cmbUsuario.Text + "') AS id";

                    SqlDataReader reader = Conexion.ejecutarQuery(query);
                    reader.Read();
                    string idUsuario = reader["id"].ToString();
                    reader.Close();

                    bool resultado = Conexion.executeProcedure("DATA_G.ASIGNAR_ROL", Conexion.generarArgumentos("@USUARIO", "@ROL"), idUsuario, idRol);
                    if (resultado)
                    {
                        MessageBox.Show("Rol asignado");
                    }
                }
                else {
                    MessageBox.Show("El usuario ya esta asignado al rol", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Seleccionar un usuario");
            }
         }

        public Boolean existeUsrenRol(Int32 usuario, Int32 rol)
        {
            string query = "SELECT DATA_G.EXISTE_USUARIO_ROL ('" + usuario + "', '" + rol + "' ) AS id";

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

    }
}
