using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    /// <summary>
    /// Excepción que representa un error en la capa de Exportacion.
    /// </summary>
    public class ExportadorException : GeneralException
    {
        /// <summary>
        /// Constructor de la clase ExportadorException.
        /// </summary>
        /// <param name="pDescripcion">Descripcion de la excepción.</param>
        /// <param name="pExcepcion">Excepción relacionada a la excepción a crear.</param>
        public ExportadorException(string pDescripcion, Exception pExcepcion) : base(pDescripcion, pExcepcion) { }

        /// <summary>
        /// Constructor de la clase ExportadorException.
        /// </summary>
        /// <param name="pDescripcion">Descripcion de la excepción.</param>
        public ExportadorException(string pDescripcion) : base(pDescripcion) { }
    }
}
