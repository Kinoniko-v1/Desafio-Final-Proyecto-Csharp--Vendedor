using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Dominio
{
    public static class ConexionBD
    {
        public static SqlConnection ConectarBD()
        {
            string serverName = "localhost";
            try
            {
                SqlConnection conexion = new SqlConnection($"server={serverName} ; database=base1 ; integrated security = true");

                return conexion;
            }
            catch
            {
                return null;
            }

        }
        public static string CrearTablaHistorial()
        {
            string msj;
            SqlConnection conexion = ConectarBD();
            conexion.Open();
            string cadenaTabla =
                "create table tablaCotizaciones(identificacion int primary key identity, fechaHora varchar(50)," +
                "codVendedor int, prenda varchar(50), cantCotizada int, resultado money)";
            SqlCommand comando = new SqlCommand(cadenaTabla, conexion);
            try
            {
                comando.ExecuteNonQuery();
                msj = "tabla creada";
            }
            catch (Exception e)
            {
                msj = e.Message;
            }
            finally
            {
                conexion.Close();
            }
            return msj;
        }
        public static void Almacenar(Cotizacion cotizacion)
        {
            string fechaHora = "@fechaHora", codVendedor = "@codVendedor",
                prenda = "@prenda", cantCotizada = "@cantCotizada", resultado = "@resultado";
            string cadena = $"insert into tablaCotizaciones(fechaHora,codVendedor,prenda,cantCotizada,resultado) values ({fechaHora},{codVendedor},{prenda},{cantCotizada},{resultado})";

            SqlConnection conexion = ConectarBD();
            conexion.Open();

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.Add(fechaHora, SqlDbType.VarChar);
            comando.Parameters.Add(codVendedor, SqlDbType.Int);
            comando.Parameters.Add(prenda, SqlDbType.VarChar);
            comando.Parameters.Add(cantCotizada, SqlDbType.Int);
            comando.Parameters.Add(resultado, SqlDbType.Money);

            comando.Parameters[fechaHora].Value = cotizacion.FechaHora.ToString();
            comando.Parameters[codVendedor].Value = cotizacion.CodigoVendedor;
            comando.Parameters[prenda].Value = cotizacion.Prenda;  // HAY QUE NORMALIZAR
            comando.Parameters[cantCotizada].Value = cotizacion.CantUnidades;
            comando.Parameters[resultado].Value = cotizacion.Resultado;

            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            finally
            {
                conexion.Close();
            }
        }
        public static string LeerHistorial()
        {
            String tabla = "";
            string cadena = "select * from tablaCotizaciones";

            SqlConnection conexion = ConectarBD();
            conexion.Open();
            SqlCommand comando = new SqlCommand(cadena, conexion);
            try
            {
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    double precio = Convert.ToDouble(registro["resultado"]);
                    tabla += "Id: " + registro["identificacion"].ToString() + " - ";
                    tabla += "Fecha y hora: " + registro["fechaHora"].ToString() + " - ";
                    tabla += "Código del Vendedor: " + registro["codVendedor"].ToString() + " - ";
                    tabla += "Prenda: " + registro["prenda"].ToString() + " - ";
                    tabla += "Cantidad Cotizada: " + registro["cantCotizada"].ToString() + " - ";
                    tabla += "Resultado de la Cotización: $ " + precio + ".|";
                }
            }
            catch (Exception e)
            {
                tabla = e.Message;
            }
            finally
            {
                conexion.Close();
            }
            return tabla;
        }  

        // Métodos a modo prueba. Funcionan sólo para emular una base de datos real.
        public static void CrearTablaStock()
        {
            SqlConnection conexion = ConectarBD();
            conexion.Open();
            string cadena = "create table tablaStock(identificacion int primary key identity, prenda varchar(50), stock int)";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            finally
            {
                conexion.Close();
            }
        }
        public static void GuardarStock()
        {
            SqlConnection conexion = ConectarBD();
            conexion.Open();
            string cadena = "insert into tablaStock(prenda, stock) values ('PSCh',750),('PSCm',250),('PPCh',750),('PPCm',250),('CSCC',150),('CSCM',100),('CSLC',175),('CSLM',75),('CPCC',150),('CPCM',100),('CPLC',175),('CPLM',75)";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            try
            {
                int xd = comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally
            {
                conexion.Close();
            }
        }
        public static Dictionary<string,int> LeerStock()
        {
            Dictionary<string, int> lista = new Dictionary<string, int>();
            SqlConnection conexion = ConectarBD();
            conexion.Open();
            string cadena = "select * from tablaStock";
            SqlCommand comando = new SqlCommand(cadena, conexion);

            try
            {
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    lista.Add(registro["prenda"].ToString(), Convert.ToInt32(registro["stock"]));
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                conexion.Close();
            }
            return lista;
        }
    }
}
