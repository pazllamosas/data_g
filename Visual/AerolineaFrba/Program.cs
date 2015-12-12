using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inicio.Login());
        }
    }

    public class FormProvider
    {
        public static Inicio.Menu MainMenu
        {
            get
            {
                if (_mainMenu == null)
                {
                    _mainMenu = new Inicio.Menu();
                }
                return _mainMenu;
            }
        }
        private static Inicio.Menu _mainMenu;


        public static Inicio.Login Login
        {
            get
            {
                if (_Login == null)
                {
                    _Login = new Inicio.Login();
                }
                return _Login;
            }
        }
        private static Inicio.Login _Login;


        public static Abm_Aeronave.VerAeronaves VerAeronaves
        {
            get
            {
                if (_VerAeronaves == null)
                {
                    _VerAeronaves = new Abm_Aeronave.VerAeronaves();
                }
                return _VerAeronaves;
            }
        }
        private static Abm_Aeronave.VerAeronaves _VerAeronaves;

        public static Abm_Aeronave.AgregarAeronave AgregarAeronave
        {
            get
            {
                if (_AgregarAeronave == null)
                {
                    _AgregarAeronave = new Abm_Aeronave.AgregarAeronave();
                }
                return _AgregarAeronave;
            }
        }
        private static Abm_Aeronave.AgregarAeronave _AgregarAeronave;


        public static Abm_Aeronave.BajaAeronave BajaAeronave
        {
            get
            {
                if (_BajaAeronave == null)
                {
                    _BajaAeronave = new Abm_Aeronave.BajaAeronave();
                }
                return _BajaAeronave;
            }
        }
        private static Abm_Aeronave.ReemplazarAeronave _BajaAeronave;

        public static Abm_Aeronave.BajaAeronave BajaAeronave
        {
            get
            {
                if (_ReemplazarAeronave == null)
                {
                    _ReemplazarAeronave = new Abm_Aeronave.ReemplazarAeronave();
                }
                return _ReemplazarAeronave;
            }
        }
        private static Abm_Aeronave.ReemplazarAeronave _BajaAeronave;

        public static Abm_Ciudad.VerCiudades VerCiudades
        {
            get
            {
                if (_VerCiudades == null)
                {
                    _VerCiudades = new Abm_Ciudad.VerCiudades();
                }
                return _VerCiudades;
            }
        }
        private static Abm_Ciudad.VerCiudades _VerCiudades;

        public static Abm_Ciudad.AgregarCiudad AgregarCiudad
        {
            get
            {
                if (_AgregarCiudad == null)
                {
                    _AgregarCiudad = new Abm_Ciudad.AgregarCiudad();
                }
                return _AgregarCiudad;
            }
        }
        private static Abm_Ciudad.AgregarCiudad _AgregarCiudad;

        public static Abm_Rol.VerRoles VerRoles
        {
            get
            {
                if (_VerRoles == null)
                {
                    _VerRoles = new Abm_Rol.VerRoles();
                }
                return _VerRoles;
            }
        }
        private static Abm_Rol.VerRoles _VerRoles;

        public static Abm_Rol.AgregarRol AgregarRol
        {
            get
            {
                if (_AgregarRol == null)
                {
                    _AgregarRol = new Abm_Rol.AgregarRol();
                }
                return _AgregarRol;
            }
        }
        private static Abm_Rol.AgregarRol _AgregarRol;

        public static Abm_Ruta.VerRutas VerRutas
        {
            get
            {
                if (_VerRutas == null)
                {
                    _VerRutas = new Abm_Ruta.VerRutas();
                }
                return _VerRutas;
            }
        }
        private static Abm_Ruta.VerRutas _VerRutas;

        public static Abm_Ruta.AgregarRuta AgregarRuta
        {
            get
            {
                if (_AgregarRuta == null)
                {
                    _AgregarRuta = new Abm_Ruta.AgregarRuta();
                }
                return _AgregarRuta;
            }
        }
        private static Abm_Ruta.AgregarRuta _AgregarRuta;


        public static Canje_Millas.CanjeMillas CanjeMillas
        {
            get
            {
                if (_CanjeMillas == null)
                {
                    _CanjeMillas = new Canje_Millas.CanjeMillas();
                }
                return _CanjeMillas;
            }
        }
        private static Canje_Millas.CanjeMillas _CanjeMillas;


        public static Compra.IngresarDatosCompra IngresarDatosCompra
        {
            get
            {
                if (_IngresarDatosCompra == null)
                {
                    _IngresarDatosCompra = new Compra.IngresarDatosCompra();
                }
                return _IngresarDatosCompra;
            }
        }
        private static Compra.IngresarDatosCompra _IngresarDatosCompra;


        public static Compra.ElegirButaca ElegirButaca
        {
            get
            {
                if (_ElegirButaca == null)
                {
                    _ElegirButaca = new Compra.ElegirButaca();
                }
                return _ElegirButaca;
            }

        }
        private static Compra.ElegirButaca _ElegirButaca;

        public static Compra.FormaDeCompra FormaDeCompra
        {
            get
            {
                if (_FormaDeCompra == null)
                {
                    _FormaDeCompra = new Compra.FormaDeCompra();
                }
                
                return _FormaDeCompra;
            }
        }
        private static Compra.FormaDeCompra _FormaDeCompra;

        public static Consulta_Millas.ConsultaMillas ConsultaMillas
        {
            get
            {
                if (_ConsultaMillas == null)
                {
                    _ConsultaMillas = new Consulta_Millas.ConsultaMillas();
                }
                return _ConsultaMillas;
            }
        }
        private static Consulta_Millas.ConsultaMillas _ConsultaMillas;

        public static Devolucion.Devolucion Devolucion
        {
            get
            {
                if (_Devolucion == null)
                {
                    _Devolucion = new Devolucion.Devolucion();
                }
                return _Devolucion;
            }
        }
        private static Devolucion.Devolucion _Devolucion;


        public static Generacion_Viaje.GenerarViaje GenerarViaje
        {
            get
            {
                if (_GenerarViaje == null)
                {
                    _GenerarViaje = new Generacion_Viaje.GenerarViaje();
                }
                return _GenerarViaje;
            }
        }
        private static Generacion_Viaje.GenerarViaje _GenerarViaje;



        public static Listado_Estadistico.ListadoEstadistico ListadoEstadistico
        {
            get
            {
                if (_ListadoEstadistico == null)
                {
                    _ListadoEstadistico = new Listado_Estadistico.ListadoEstadistico();
                }
                return _ListadoEstadistico;
            }
        }
        private static Listado_Estadistico.ListadoEstadistico _ListadoEstadistico;

        public static Listado_Estadistico.AeronavesConMayorCantidadDeDiasFueraDeServicio AeronavesConMayorCantidadDeDiasFueraDeServicio
        {
            get
            {
                if (_AeronavesConMayorCantidadDeDiasFueraDeServicio == null)
                {
                    _AeronavesConMayorCantidadDeDiasFueraDeServicio = new Listado_Estadistico.AeronavesConMayorCantidadDeDiasFueraDeServicio();
                }
                return _AeronavesConMayorCantidadDeDiasFueraDeServicio;
            }
        }
        private static Listado_Estadistico.AeronavesConMayorCantidadDeDiasFueraDeServicio _AeronavesConMayorCantidadDeDiasFueraDeServicio;


        public static Listado_Estadistico.ClientesConMasPuntosAcumuladosALaFecha ClientesConMasPuntosAcumuladosALaFecha
        {
            get
            {
                if (_ClientesConMasPuntosAcumuladosALaFecha == null)
                {
                    _ClientesConMasPuntosAcumuladosALaFecha = new Listado_Estadistico.ClientesConMasPuntosAcumuladosALaFecha();
                }
                return _ClientesConMasPuntosAcumuladosALaFecha;
            }
        }
        private static Listado_Estadistico.ClientesConMasPuntosAcumuladosALaFecha _ClientesConMasPuntosAcumuladosALaFecha;


        public static Listado_Estadistico.DestinosConAeronavesMasVacias DestinosConAeronavesMasVacias
        {
            get
            {
                if (_DestinosConAeronavesMasVacias == null)
                {
                    _DestinosConAeronavesMasVacias = new Listado_Estadistico.DestinosConAeronavesMasVacias();
                }
                return _DestinosConAeronavesMasVacias;
            }
        }
        private static Listado_Estadistico.DestinosConAeronavesMasVacias _DestinosConAeronavesMasVacias;


        public static Listado_Estadistico.DestinosConMasPasajesComprados DestinosConMasPasajesComprados
        {
            get
            {
                if (_DestinosConMasPasajesComprados == null)
                {
                    _DestinosConMasPasajesComprados = new Listado_Estadistico.DestinosConMasPasajesComprados();
                }
                return _DestinosConMasPasajesComprados;
            }
        }
        private static Listado_Estadistico.DestinosConMasPasajesComprados _DestinosConMasPasajesComprados;


        public static Listado_Estadistico.DestinosConPasajesCancelados DestinosConPasajesCancelados
        {
            get
            {
                if (_DestinosConPasajesCancelados == null)
                {
                    _DestinosConPasajesCancelados = new Listado_Estadistico.DestinosConPasajesCancelados();
                }
                return _DestinosConPasajesCancelados;
            }
        }
        private static Listado_Estadistico.DestinosConPasajesCancelados _DestinosConPasajesCancelados;

        public static Registro_Llegada_Destino.RegistroLlegadaDestino RegistroLlegadaDestino
        {
            get
            {
                if (_RegistroLlegadaDestino == null)
                {
                    _RegistroLlegadaDestino = new Registro_Llegada_Destino.RegistroLlegadaDestino();
                }
                return _RegistroLlegadaDestino;
            }
        }
        private static Registro_Llegada_Destino.RegistroLlegadaDestino _RegistroLlegadaDestino;



    }
}
