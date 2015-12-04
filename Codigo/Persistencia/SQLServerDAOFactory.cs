using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Excepciones;

namespace Persistencia.SQLServer
{
    /// <summary>
    /// Clase que mantiene los datos e implementa los metodos basicos para la conexion con 
    /// la base de datos SQLServer.
    /// </summary>
    public class SQLServerDAOFactory : DAOFactory
    {
        /// <summary>
        /// Atributo de la clase SQLConnection.
        /// </summary>
        private SqlConnection iConexion;

        /// <summary>
        /// Atributo de la clase SQLTransaction instanciado en null.
        /// </summary>
        private SqlTransaction iTransaccion = null;

        /// <summary>
        /// Atributo que mantiene la cadena de conexion con la Base de Datos SQLServer.
        /// </summary>
        private string STRING_CONEXION = @"Data Source= (local); Initial Catalog = PostAppBD;Integrated Security=True;Pooling=False";

        /// <summary>
        /// Propiedad de solo lectura que devuelve una instancia de la clase CorreoDAO.
        /// </summary>
        public override ICorreoDAO CorreoDAO
        {
            get { return new SQLServerCorreoDAO(iConexion, iTransaccion); }
        }

        /// <summary>
        /// Propiedad de solo lectura que devuelve una instancia de la clase CuentaCorreoDAO.
        /// </summary>
        public override ICuentaDAO CuentaDAO
        {
            get { return new SQLServerCuentaDAO(iConexion, iTransaccion); }
        }

        /// <summary>
        /// Método que inicia una conexion con la Base de Datos.
        /// </summary>
        public override void IniciarConexion()
        {
            try
            {
                this.iConexion = new SqlConnection(STRING_CONEXION);
                iConexion.Open();       
            }
            catch (SqlException exception)   
            {
                throw new DAOException("Hubo un problema al conectarse con la Base de Datos. Revise la configuración de su servidor y el nombre de su base de datos. Para más información consulte el manual de PostApp.",exception);
            }
            
        }

        /// <summary>
        /// Método que inicia una transaccion en la Base de Datos.
        /// </summary>
        public override void ComenzarTransaccion()
        {
            if (this.iConexion == null)
            {
                throw new DAOException("No se puede iniciar una transacción sin una conexión abierta.");
            }
            try
            {
                this.iTransaccion = this.iConexion.BeginTransaction();
            }
            catch (SqlException exception)  // Esta excepción es solo para el tiempo de diseño. No llega al usuario.
            {
                throw new DAOException("Hubo un problema al iniciar una transacción en la Base de Datos.", exception);
            }        
        }

        /// <summary>
        /// Método que finaliza la conexion con la Base de Datos.
        /// </summary>
        public override void FinalizarConexion()
        {
            if (this.iConexion != null)
            {
                try
                {
                    this.iConexion.Close();
                }
                catch (SqlException exception)  // Esta excepción es solo para el tiempo de diseño. No llega al usuario.
                {
                    throw new DAOException("Hubo un problema al cerrar una conexión con la Base de Datos.", exception);
                }   
            }
        }

        /// <summary>
        /// Método que confirma los cambios en la Base de Datos.
        /// </summary>
        public override void Commit()
        {
            if (this.iTransaccion != null)
            {
                try
                {
                    this.iTransaccion.Commit();
                }
                catch (SqlException exception)  // Esta excepción es solo para el tiempo de diseño. No llega al usuario.
                {
                    throw new DAOException("Hubo un problema al hacer un commit en la Base de Datos.", exception);
                }   
            }
        }

        /// <summary>
        /// Método que deshace los cambios en la Base de Datos.
        /// </summary>
        public override void RollBack()
        {
            if (this.iTransaccion != null)
            {
                try
                {
                    this.iTransaccion.Rollback();
                }
                catch (SqlException exception)  // Esta excepción es solo para el tiempo de diseño. No llega al usuario.
                {
                    throw new DAOException("Hubo un problema al hacer un Rollback en la Base de Datos.", exception);
                }                
            }
        }
    }
}
