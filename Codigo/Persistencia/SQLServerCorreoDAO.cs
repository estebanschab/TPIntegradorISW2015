using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataTransferObject;
using Excepciones;

namespace Persistencia.SQLServer
{
    /// <summary>
    /// Clase para interactuar con la informacion de la Base de Datos.
    /// </summary>
    public class SQLServerCorreoDAO : ICorreoDAO
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
        /// Constructor de la clase SQLServerCorreoDAO.
        /// </summary>
        /// <param name="pConexion">Conexión a utilizar.</param>
        /// <param name="pTransaccion">Transacción a utilizar.</param>
        public SQLServerCorreoDAO(SqlConnection pConexion, SqlTransaction pTransaccion)
        {
            this.iConexion = pConexion;
            this.iTransaccion = pTransaccion;
        }

        /// <summary>
        /// Metodo para determinar si un correo ya existe en la base de datos.
        /// </summary>
        /// <param name="pCorreo">Correo a buscar en la base de datos.</param>
        /// <returns>False si el correo no existe en la base, true de lo contrario.</returns>
        public bool Existe(CorreoDTO pCorreo)
        {
            bool encontrado = false;         
            try
            {
                SqlCommand comando = this.iConexion.CreateCommand();
                comando.CommandText = @"select * from Correo where (correoId = @ID or correoServicioId = @ServicioId)";
                comando.Parameters.AddWithValue("@ID", pCorreo.Id);
                comando.Parameters.AddWithValue("@ServicioId", pCorreo.ServicioId);
                comando.Transaction = iTransaccion;
                DataTable tabla = new DataTable();
                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                {
                    adaptador.Fill(tabla);
                    if (tabla.Rows.Count> 0)
                    {
                        //Si encuentra un correo con el mismo id o idServicio  en la base marca encontrado como verdadero 
                        encontrado = true;
                    }
                }
                return encontrado;
            }
            catch (SqlException pSqlException)
            {
                throw new DAOException("Error en la busqueda de un correo. Revise la configuración de su servidor de Base de Datos y el nombre de su base de datos. Para más información consulte el manual de PostApp.", pSqlException);
            }
        }

        /// <summary>
        /// Metodo para obtener la lista de correos de la Base de Datos.
        /// </summary>
        /// <returns></returns>
        public IList<CorreoDTO> ObtenerCorreos()
        {
            List<CorreoDTO> mCorreos = new List<CorreoDTO>();
            try
            {
                SqlCommand comando = this.iConexion.CreateCommand();
                comando.CommandText = "select * from Correo where eliminado = 0";
                DataTable tabla = new DataTable();
                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                {
                    adaptador.Fill(tabla);
                    foreach (DataRow fila in tabla.Rows)
                    {
                        mCorreos.Add(new CorreoDTO()
                        {
                            Id = Convert.ToInt32(fila["correoId"]),
                            Fecha = Convert.ToDateTime(fila["fecha"]),
                            TipoCorreo = Convert.ToString(fila["tipocorreo"]),
                            Texto = Convert.ToString(fila["texto"]),
                            CuentaOrigen = Convert.ToString(fila["cuentaOrigen"]),
                            CuentaDestino = Convert.ToString(fila["cuentaDestino"]),
                            Asunto = Convert.ToString(fila["Asunto"]),
                            Leido = Convert.ToBoolean(fila["leido"]),
                            ServicioId = Convert.ToString(fila["correoServicioId"]),
                            Eliminado = Convert.ToBoolean(fila["eliminado"]) 
                        });
                    }
                }
                return mCorreos;
            }
            catch (SqlException pSqlException)
            {
                throw new DAOException("Error en la obtención de datos de correo. Revise la configuración de su servidor de Base de Datos y el nombre de su base de datos. Para más información consulte el manual de PostApp.", pSqlException);
            }
        }

        /// <summary>
        /// Metodo para obtener los correos de la cuenta <paramref name="pCuenta"/>.
        /// </summary>
        /// <returns>Retorna una lista de correos con los correos de la cuenta <paramref name="pCuenta"/>.</returns>
        public IList<CorreoDTO> ObtenerCorreos(string pCuenta)
        {
            List<CorreoDTO> mCorreos = new List<CorreoDTO>();
            try
            {
                SqlCommand comando = this.iConexion.CreateCommand();
                comando.CommandText = "select * from Correo where ((cuentaOrigen = @Cuenta and tipoCorreo = 'Enviado') or (cuentaDestino = @Cuenta2 and tipoCorreo = 'Recibido')) and (eliminado = 0)";
                comando.Parameters.AddWithValue("@Cuenta", pCuenta);
                // Utilizo el ; porque lasdirecciones de destino se guardan con ;
                comando.Parameters.AddWithValue("@Cuenta2", pCuenta + "; ");
                DataTable tabla = new DataTable();
                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                {
                    adaptador.Fill(tabla);
                    foreach (DataRow fila in tabla.Rows)
                    {
                       mCorreos.Add(new CorreoDTO
                       {
                           Id = Convert.ToInt32(fila["correoId"]),
                           Fecha = Convert.ToDateTime(fila["fecha"]),
                           TipoCorreo = Convert.ToString(fila["tipocorreo"]),
                           Texto = Convert.ToString(fila["texto"]),
                           CuentaOrigen = Convert.ToString(fila["cuentaOrigen"]),
                           CuentaDestino = Convert.ToString(fila["cuentaDestino"]),
                           Asunto = Convert.ToString(fila["Asunto"]),
                           Leido = Convert.ToBoolean(fila["leido"]),
                           ServicioId = Convert.ToString(fila["correoServicioId"]),
                           Eliminado = Convert.ToBoolean(fila["eliminado"])
                        });
                        
                    }
                }
                return mCorreos;
            }
            catch (SqlException pSqlException)
            {
                throw new DAOException("Error en la obtención de datos de correo. Revise la configuración de su servidor de Base de Datos y el nombre de su base de datos. Para más información consulte el manual de PostApp.", pSqlException);
            }
        }

        /// <summary>
        /// Metodo para insertar la informacion de un correo en la Base de Datos.
        /// </summary>
        /// <param name="pCorreo"></param>
        public void AgregarCorreo(CorreoDTO pCorreo)
        {
            try
            {
                SqlCommand comando = this.iConexion.CreateCommand();
                comando.CommandText = @"insert into Correo(fecha,tipocorreo,cuentaOrigen,cuentaDestino,texto,asunto,leido,correoServicioId, eliminado) 
                                        values(@Fecha,@TipoCorreo,@CuentaOrigen,@Destino,@Texto,@Asunto,@Leido,@correoServicioId,@eliminado)";
                comando.Parameters.AddWithValue("@Fecha", pCorreo.Fecha);
                comando.Parameters.AddWithValue("@TipoCorreo", pCorreo.TipoCorreo);
                comando.Parameters.AddWithValue("@CuentaOrigen", pCorreo.CuentaOrigen);
                comando.Parameters.AddWithValue("@Destino", pCorreo.CuentaDestino);
                comando.Parameters.AddWithValue("@Texto", pCorreo.Texto);
                comando.Parameters.AddWithValue("@Asunto", pCorreo.Asunto);
                comando.Parameters.AddWithValue("@Leido", pCorreo.Leido);
                comando.Parameters.AddWithValue("@correoServicioId", pCorreo.ServicioId);
                comando.Parameters.AddWithValue("@eliminado", pCorreo.Eliminado);
                comando.Transaction = iTransaccion;
                comando.ExecuteNonQuery();
            }
            catch (SqlException pSqlException)
            {
                throw new DAOException("Error en la inserción de datos de correo. Revise la configuración de su servidor de Base de Datos y el nombre de su base de datos. Para más información consulte el manual de PostApp.", pSqlException);
            }
        }

        /// <summary>
        /// Metodo para eliminar los datos de un Correo en la Base de Datos.
        /// </summary>
        /// <param name="pCorreo">Dato de tipo Correo a ser eliminado de la Base de Datos.</param>
        public void EliminarCorreoBD(CorreoDTO pCorreo)
        {
            try
            {
                SqlCommand comando = this.iConexion.CreateCommand();
                comando.CommandText = @"delete from adjunto where correoId = @Id;
                                            delete from Correo where correoId = @Id;";
                comando.Parameters.AddWithValue("@ID", pCorreo.Id);                
                comando.Transaction = iTransaccion;
                comando.ExecuteNonQuery();
            }
            catch (SqlException pSqlException)
            {
                throw new DAOException("Error en la eliminacion de un correo. Revise la configuración de su servidor de Base de Datos y el nombre de su base de datos. Para más información consulte el manual de PostApp.", pSqlException);
            }
        }

        /// <summary>
        /// Metodo para marcar como eliminado un correo en la Base de Datos.
        /// </summary>
        /// <param name="pCorreo">Dato de tipo Correo a ser marcado como eliminado en la Base de Datos.</param>
        public void EliminarCorreo(CorreoDTO pCorreo)
        {
            try
            {
                SqlCommand comando = this.iConexion.CreateCommand();
                comando.CommandText = @"update Correo set eliminado = 1 where correoId = @Id;";
                comando.Parameters.AddWithValue("@ID", pCorreo.Id);
                comando.Transaction = iTransaccion;
                comando.ExecuteNonQuery();
            }
            catch (SqlException pSqlException)
            {
                throw new DAOException("Error en la eliminacion de un correo. Revise la configuración de su servidor de Base de Datos y el nombre de su base de datos. Para más información consulte el manual de PostApp.", pSqlException);
            }
        }

        /// <summary>
        /// Metodo para modificar un correo en la Base de Datos.
        /// </summary>
        /// <param name="pCorreo">Dato de tipo Correo a ser modificado en la Base de Datos.</param>
        public void ModificarCorreo(CorreoDTO pCorreo)
        {
            try
            {
                SqlCommand comando = this.iConexion.CreateCommand();
                comando.CommandText = @"update Correo set fecha=@Fecha,tipocorreo=@TipoCorreo,cuentaOrigen=@CuentaOrigen,
                                        cuentaDestino=@Destino,texto=@Texto,asunto=@Asunto,leido=@Leido, 
                                        correoServicioId = @correoServicioId, eliminado = @eliminado
                                         where correoId = @Id or correoServicioId = @correoServicioId";
                comando.Parameters.AddWithValue("@Id", pCorreo.Id);
                comando.Parameters.AddWithValue("@Fecha", pCorreo.Fecha);
                comando.Parameters.AddWithValue("@TipoCorreo", pCorreo.TipoCorreo);
                comando.Parameters.AddWithValue("@CuentaOrigen", pCorreo.CuentaOrigen);
                comando.Parameters.AddWithValue("@Destino", pCorreo.CuentaDestino);
                comando.Parameters.AddWithValue("@Texto", pCorreo.Texto);
                comando.Parameters.AddWithValue("@Asunto", pCorreo.Asunto);
                comando.Parameters.AddWithValue("@Leido", pCorreo.Leido);
                comando.Parameters.AddWithValue("@correoServicioId", pCorreo.ServicioId);
                comando.Parameters.AddWithValue("@eliminado", pCorreo.Eliminado);
                comando.Transaction = iTransaccion;
                comando.ExecuteNonQuery();
            }
            catch (SqlException pSqlException)
            {
                throw new DAOException("Error en la actualización de datos de un correo. Revise la configuración de su servidor de Base de Datos y el nombre de su base de datos. Para más información consulte el manual de PostApp.", pSqlException);
            }
        }
    }
}
