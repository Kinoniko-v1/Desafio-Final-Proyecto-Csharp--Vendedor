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
        public static String CrearTablaHistorial()
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
        public static String LeerHistorial()
        {
            String lista = "";
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
                    lista += "Id: " + registro["identificacion"].ToString() + " - ";
                    lista += "Fecha y hora: " + registro["fechaHora"].ToString() + " - ";
                    lista += "Código del Vendedor: " + registro["codVendedor"].ToString() + " - ";
                    lista += "Prenda: " + registro["prenda"].ToString() + " - ";
                    lista += "Cantidad Cotizada: " + registro["cantCotizada"].ToString() + " - ";
                    lista += "Resultado de la Cotización: $ " + precio + ".|";
                }
            }
            catch (Exception e)
            {
                lista = e.Message;
            }
            finally
            {
                conexion.Close();
            }
            return lista;
        }  
        public static void CrearStock() { }
    }
}
