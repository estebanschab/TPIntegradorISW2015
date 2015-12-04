using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    /// <summary>
    /// Excepcion que representa una excepcion general del programa.
    /// </summary>
    public class GeneralException : Exception
    {
        /// <summary>
        /// Constructor de la clase GeneralException.
        /// </summary>
        /// <param name="pDescripcion">Descripcion de la excepcion.</param>
        /// <param name="pExcepcion">Excepcion a ser tratada.</param>
        public GeneralException(string pDescripcion, Exception pExcepcion) 
                : base(pDescripcion, pExcepcion) { }

        /// <summary>
        /// Constructor de la clase GeneralException.
        /// </summary>
        /// <param name="pDescripcion">Descripcion de la excepcion.</param>
        public GeneralException(string pDescripcion) : base(pDescripcion) { }
    }
}
