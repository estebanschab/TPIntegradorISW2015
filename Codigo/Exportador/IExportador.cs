using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace Exportacion
{
    /// <summary>
    /// Clase abstracta que sirve para establecer lo minimo a implementar 
    /// por todos los algoritmos de exportacion.
    /// </summary>
    public interface IExportador
    {
        /// <summary>
        /// Metodo utilizado para exportar un correo al sistema de archivos.
        /// </summary>
        /// <param name="pCorreo">correo a exportar.</param>
        /// <param name="pRuta">ruta donde se exportará el correo.</param>
        /// <param name="pNombre">nombre con el que se quiere guardar el correo</param>
        void Exportar(CorreoDTO pCorreo, string pRuta, string pNombre);
    }
}
