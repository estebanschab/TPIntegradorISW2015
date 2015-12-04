using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace CorreoServicio
{
    /// <summary>
    /// Clase abstracta que sirve para establecer lo minimo a implementar 
    /// por todos los algoritmos de Servicio de Correo.
    /// </summary>
    public interface IServicioCorreo
    {
        /// <summary>
        /// Metodo para obtener los correos de una cuenta en un Servicio.
        /// </summary>
        /// <param name="pCuenta">Cuenta de la cual se descargan los correos.</param>
        /// <returns>Se devuelve una lista de correos de la cuenta.</returns>
        IList<CorreoDTO> DescargarCorreos(CuentaDTO pCuenta);

        /// <summary>
        /// Metodo para enviar un correo.
        /// </summary>
        /// <param name="pCorreo">Correo a ser enviado.</param>
        /// <param name="pCuenta">Cuenta con la que se envia el correo</param>
        void EnviarCorreo(CorreoDTO pCorreo, CuentaDTO pCuenta);
    }
}
