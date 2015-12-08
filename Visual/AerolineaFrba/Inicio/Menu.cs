using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AerolineaFrba.Inicio
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public void habilitarFuncionalidadesPorRol(string usuario,string loginmode) {

            btnConsultarMillas.Visible = false;
            btnCanjearMillas.Visible = false;
            btnRegistroLlegada.Visible = false;
            btnDevolucion.Visible = false;
            btnGenerarViaje.Visible = false;
            btnTop5.Visible = false;
            
            
            string idrol;
            if (loginmode != "invitado") {

                string query = "SELECT R.IdRol FROM DATA_G.USUARIO U, DATA_G.USUARIOPORROL UR, DATA_G.ROL R WHERE USERNAME = '" + usuario + "' AND U.IdUsuario  = UR.IdUsuario AND R.IdRol = UR.IdRol AND R.ESTADO = 1 AND U.ESTADO = 1";
                SqlDataReader Roles = Conexion.ejecutarQuery(query);
                idrol = Roles[0].ToString();
                while (Roles.Read())
                {
                    funcionalidadesParaElRol(idrol);
                }
                Roles.Close();
            }
            else {
                idrol = "2";
                funcionalidadesParaElRol(idrol);
            }

        }

        private void funcionalidadesParaElRol(string idrol)
        {
            SqlDataReader Funcionalidades = Conexion.ejecutarQuery("SELECT F.IdFuncionalidad, DescripcionFunc AS Funcionalidad FROM DATA_G.ROL_POR_FUNCIONALIDADES RF, DATA_G.FUNCIONALIDADES F WHERE IdRol = " + idrol + " AND F.IdFuncionalidad = RF.IdFuncionalidad");

            if (Funcionalidades.HasRows)
            {
                while (Funcionalidades.Read())
                {
                    switch (Funcionalidades.GetString(1))
                    {
                        case "Consulta de millas de pasajero frecuente":
                            btnConsultarMillas.Visible = true;
                            break;
                        case "Canje de millas de pasajero frecuente":
                            btnCanjearMillas.Visible = true;
                            break;
                        case "Registro de llegada destino":
                            btnRegistroLlegada.Visible = true;
                            break;
                        case "Cancelacion/Devolucion de pasaje y/o encomienda":
                            btnDevolucion.Visible = true;
                            break;
                        case "Crear origen y destino viaje":
                            btnGenerarViaje.Visible = true;
                            break;
                        case "Consulta TOP 5":
                            btnTop5.Visible = true;
                            break;
                    }
                }
            }
            Funcionalidades.Close();
        }

        private void deslogearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.IngresarDatosCompra.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.ConsultaMillas.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.CanjeMillas.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.RegistroLlegadaDestino.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.Devolucion.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.ListadoEstadistico.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.GenerarViaje.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.VerRutas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.VerAeronaves.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.VerRoles.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.VerCiudades.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //getUserRole

            // Conexion.executeProcedure("DATA_G.GET_ROL", Conexion.generarArgumentos("@usuario"), usuario);
           
           
            }

        }
    }

