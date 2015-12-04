using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.SQLServer;

namespace Persistencia
{
    /// <summary>
    /// Clase que determina el comportamiento básico para comunicarse con una Base de Datos.
    /// </summary>
    public abstract class DAOFactory
    {
        /// <summary>
        /// Propiedad de solo lectura que devuelve una instancia de la clase CorreoDAO.
        /// </summary>
        public abstract ICorreoDAO CorreoDAO { get; }

        /// <summary>
        /// Propiedad de solo lectura que devuelve una instancia de la clase CuentaCorreoDAO.
        /// </summary>
        public abstract ICuentaDAO CuentaDAO { get; }

        /// <summary>
        /// Método que inicia una conexion con la Base de Datos.
        /// </summary>
        public abstract void IniciarConexion();

        /// <summary>
        /// Método que finaliza la conexion con la Base de Datos.
        /// </summary>
        public abstract void FinalizarConexion();

        /// <summary>
        /// Método que inicia una transaccion en la Base de Datos.
        /// </summary>
        public abstract void ComenzarTransaccion();

        /// <summary>
        /// Método que confirma los cambios en la Base de Datos.
        /// </summary>
        public abstract void Commit();

        /// <summary>
        /// Método que deshace los cambios en la Base de Datos.
        /// </summary>
        public abstract void RollBack();

        /// <summary>
        /// Propiedad que devuelve una instancia de la clase DAOFactory.
        /// </summary>
        public static DAOFactory Instancia
        {
            get
            {
                return new SQLServerDAOFactory();
            }
        }
    }
}
