using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace Persistencia
{
    /// <summary>
    /// Interfaz que declara los metodos basicos para persistir un correo en la Base de Datos.
    /// </summary>
    public interface ICorreoDAO
    {
        /// <summary>
        /// Metodo para insertar un correo en la Base de Datos.
        /// </summary>
        /// <param name="pCorreo">Dato de tipo Correo a ser agregado en la Base de Datos.</param>
        void AgregarCorreo(CorreoDTO pCorreo);

        /// <summary>
        /// Metodo para marcar como eliminado un correo en la Base de Datos.
        /// </summary>
        /// <param name="pCorreo">Dato de tipo Correo a ser marcado como eliminado en la Base de Datos.</param>
        void EliminarCorreo(CorreoDTO pCorreo);

        /// <summary>
        /// Metodo para eliminar un correo de la Base de Datos.
        /// </summary>
        /// <param name="pCorreo">Dato de tipo Correo a ser eliminado de la Base de Datos.</param>
        void EliminarCorreoBD(CorreoDTO pCorreo);

        /// <summary>
        /// Metodo para modificar un correo en la Base de Datos.
        /// </summary>
        /// <param name="pCorreo">Dato de tipo Correo a ser modificado en la Base de Datos.</param>
        void ModificarCorreo(CorreoDTO pCorreo);

        /// <summary>
        /// Metodo para obtener los correos de la Base de Datos.
        /// </summary>
        /// <returns>Retorna una lista de correos con todos los corros de la base de datos.</returns>
        IList<CorreoDTO> ObtenerCorreos();

        /// <summary>
        /// Metodo para obtener los correos de la cuenta <paramref name="pCuenta"/>.
        /// </summary>
        /// <returns>Retorna una lista de correos con los correos de la cuenta <paramref name="pCuenta"/>.</returns>
        IList<CorreoDTO> ObtenerCorreos(string pCuenta);

        /// <summary>
        /// Metodo para determinar si un correo ya existe en la base de datos.
        /// </summary>
        /// <param name="pCorreo">Correo a buscar en la base de datos.</param>
        /// <returns>False si el correo no existe en la base, true de lo contrario.</returns>
        bool Existe(CorreoDTO pCorreo);
        
    }
}
