using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataTransferObject;
using System.Data;
using Excepciones;

namespace Persistencia.SQLServer
{
    /// <summary>
    /// Clase para interactuar con la informacion de la Base de Datos.
    /// </summary>
    public class SQLServerCuentaDAO : ICuentaDAO
    {
        /// <summary>
        /// Instancia de la clase SqlConnection.
        /// </summary>
        private SqlConnection iConexion;

        /// <summary>
        /// Instancia de la clase SqlTransaction.
        /// </summary>
        private SqlTransaction iTransaccion;

        /// <summary>
        /// Constructor de la clase SQLServerCuentaCorreoDAO.
        /// </summary>
        /// <param name="pConexion">Conexión a utilizar.</param>
        /// <param name="pTransaccion">Transacción a utilizar.</param>
        public SQLServerCuentaDAO(SqlConnection pConexion, SqlTransaction pTransaccion)
        {
            this.iConexion = pConexion;
            this.iTransaccion = pTransaccion;
        }

        /// <summary>
        /// Metodo para obtener una cuenta de correo de la Base de Datos.
        /// </summary>
        /// <param name="pCuentaCorreo"></param>
        /// <returns></returns>
        public CuentaDTO ObtenerCuenta(CuentaDTO pCuentaCorreo)
        {
            try
            {
                SqlCommand comando = this.iConexion.CreateCommand();
                comando.CommandText = @"select * from Cuenta where cuentaId = @ID or nombre = @Nombre";
                comando.Parameters.AddWithValue("@ID", pCuentaCorreo.Id);
                comando.Parameters.AddWithValue("@Nombre", pCuentaCorreo.Nombre);
                DataTable tabla = new DataTable();
                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                {
                    adaptador.Fill(tabla);
                    foreach (DataRow fila in tabla.Rows)
                    {
                       pCuentaCorreo.Nombre = Convert.ToString(fila["nombre"]);
                       pCuentaCorreo.Direccion = Convert.ToString(fila["direccion"]);
                       pCuentaCorreo.Contraseña = Convert.ToString(fila["contraseña"]);
                       pCuentaCorreo.Id = Convert.ToInt32(fila["cuentaId"]);
                       pCuentaCorreo.Servicio = Convert.ToString(fila["servicio"]);
                    }
                }
                return pCuentaCorreo;
            }
            catch (SqlException pSqlException)
            {
                throw new DAOException("Error en la obtención de una cuenta de correo", pSqlException);
            }
        }

        /// <summary>
        /// Metodo para obtener la lista de cuentas de correo de la Base de Datos.
        /// </summary>
        /// <returns></returns>
        public IList<CuentaDTO> ObtenerCuentas()
        {
            List<CuentaDTO> mCuentasCorreo = new List<CuentaDTO>();
            try
            {
                SqlCommand comando = this.iConexion.CreateCommand();
                comando.CommandText = "select * from Cuenta";
                DataTable tabla = new DataTable();
                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                {
                    adaptador.Fill(tabla);
                    foreach (DataRow fila in tabla.Rows)
                    {
                        mCuentasCorreo.Add(new CuentaDTO
                        {
                            Nombre = Convert.ToString(fila["nombre"]),
                            Direccion = Convert.ToString(fila["direccion"]),
                            Contraseña = Convert.ToString(fila["contraseña"]),
                            Id = Convert.ToInt32(fila["cuentaId"]),
                            Servicio = Convert.ToString(fila["servicio"])
                        });
                    }
                }
                return mCuentasCorreo;
            }
            catch (SqlException pSqlException)
            {
                throw new DAOException("Error en la obtención de datos de cuenta de correo. Revise la configuración de su servidor de Base de Datos y el nombre de su base de datos. Para más información consulte el manual de PostApp.", pSqlException);
            }
        }
        
        /// <summary>
        /// Metodo para insertar la informacion de una cuenta de correo en la Base de Datos.
        /// </summary>
        /// <param name="pCuentaCorreo"></param>
        public void AgregarCuenta(CuentaDTO pCuentaCorreo)
        {
            try
            {
                SqlCommand comando = this.iConexion.CreateCommand();
                comando.CommandText = @"insert into Cuenta(Nombre,Direccion,Contraseña,Servicio)
                                                   values(@Nombre,@Direccion,@Contraseña,@Servicio)";
                comando.Parameters.AddWithValue("@Nombre", pCuentaCorreo.Nombre);
                comando.Parameters.AddWithValue("@Direccion", pCuentaCorreo.Direccion);
                comando.Parameters.AddWithValue("@Contraseña", pCuentaCorreo.Contraseña);
                comando.Parameters.AddWithValue("@Servicio", pCuentaCorreo.Servicio);
                comando.Transaction = iTransaccion;
                comando.ExecuteNonQuery();
            }
            catch (SqlException pSqlException)
            {
                if (pSqlException.Errors[0].Number == 2627)
                {
                    throw new DAOException("Error de datos duplicados. No puede crear 2 cuentas con el mismo nombre. Modifique el nombre y vuelva a intentarlo.", pSqlException);
                }
                throw new DAOException("Error en la inserción de datos de Cuenta de correo. Revise la configuración de su servidor de Base de Datos y el nombre de su base de datos. Para más información consulte el manual de PostApp.", pSqlException);
            }
        }

        /// <summary>
        /// Metodo para actualizar la informacion de una cuenta de correo de la Base de Datos.
        /// </summary>
        /// <param name="pCuentaCorreo"></param>
        public void ModificarCuenta(CuentaDTO pCuentaCorreo)
        {
            try
            {
                SqlCommand comando = this.iConexion.CreateCommand();
                comando.CommandText = @"update Cuenta set direccion= @Direccion, contraseña= @Contraseña,
                                                                 nombre = @Nombre, servicio = @Servicio                        
                                                                where cuentaId = @ID";
                comando.Parameters.AddWithValue("@Nombre", pCuentaCorreo.Nombre);
                comando.Parameters.AddWithValue("@Direccion", pCuentaCorreo.Direccion);
                comando.Parameters.AddWithValue("@Contraseña", pCuentaCorreo.Contraseña);
                comando.Parameters.AddWithValue("@ID", pCuentaCorreo.Id);
                comando.Parameters.AddWithValue("@Servicio", pCuentaCorreo.Servicio);
                comando.Transaction = iTransaccion;
                comando.ExecuteNonQuery();
            }
            catch (SqlException pSqlException)
            {
                if (pSqlException.Errors[0].Number == 2627)
                {
                    throw new DAOException("Error de datos duplicados. Modifique el nombre y vuelva a intentarlo.", pSqlException);
                }
                throw new DAOException("Error en la actualizacion de datos de cuenta de correo. Revise la configuración de su servidor de Base de Datos y el nombre de su base de datos. Para más información consulte el manual de PostApp.", pSqlException);
            }
        }

        /// <summary>
        /// Metodo para eliminar los datos de una Cuenta de Correo en la Base de Datos.
        /// </summary>
        /// <param name="pCuentaCorreo"></param>
        public void EliminarCuenta(CuentaDTO pCuentaCorreo)
        {
            try
            {
                SqlCommand comando = this.iConexion.CreateCommand();
                comando.CommandText = @"delete from Cuenta where cuentaId = @ID; 
                                        delete from Correo where (cuentaOrigen = @Cuenta and tipocorreo = 'Enviado') 
                                                            or (cuentaDestino = @Cuenta2 and tipocorreo = 'Recibido');";
                comando.Parameters.AddWithValue("@ID", pCuentaCorreo.Id);
                comando.Parameters.AddWithValue("@Cuenta", pCuentaCorreo.Direccion);
                // agrega ; a la direccion porque las direcciones de cuentasDestino se guardan con ;
                comando.Parameters.AddWithValue("@Cuenta2", pCuentaCorreo.Direccion + "; ");
                comando.Transaction = iTransaccion;
                comando.ExecuteNonQuery();
            }
            catch (SqlException pSqlException)
            {
                throw new DAOException("Error en la eliminacion de una cuenta de correo. Revise la configuración de su servidor de Base de Datos y el nombre de su base de datos. Para más información consulte el manual de PostApp.", pSqlException);
            }
        }
    }
}
