using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace Persistencia
{
    /// <summary>
    /// Interfaz que declara los metodos basicos para persistir una cuenta de correo en la Base de Datos.
    /// </summary>
    public interface ICuentaDAO
    {
        /// <summary>
        /// Metodo para insertar una cuenta de correo en la Base de Datos.
        /// </summary>
        /// <param name="pCorreo">Dato de tipo CuentaCorreo a ser agregado en la Base de Datos.</param>
        void AgregarCuenta(CuentaDTO pCuentaCorreo);

        /// <summary>
        /// Metodo para actualizar una cuenta de correo de la Base de Datos.
        /// </summary>
        /// <param name="pCorreo">Dato de tipo CuentaCorreo a ser actualizado de la Base de Datos.</param>
        void ModificarCuenta(CuentaDTO pCuentaCorreo);

        /// <summary>
        /// Metodo para eliminar una cuenta de correo de la Base de Datos.
        /// </summary>
        /// <param name="pCorreo">Dato de tipo CuentaCorreo a ser eliminado de la Base de Datos.</param>
        void EliminarCuenta(CuentaDTO pCuentaCorreo);

        /// <summary>
        /// Metodo para obtener mas informacion sobre una cuenta de la Base de Datos.
        /// </summary>
        /// <param name="pCuentaCorreo">Cuenta a ser buscada y completada en la Base de Datos.</param>
        /// <returns></returns>
        CuentaDTO ObtenerCuenta(CuentaDTO pCuentaCorreo);

        /// <summary>
        /// Metodo para obtener las Cuentas de Correo de la Base de Datos.
        /// </summary>
        /// <returns>Retorna una lista de cuentas de correo de la clase CuentaCorreo.</returns>
        IList<CuentaDTO> ObtenerCuentas();
    }
}
