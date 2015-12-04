using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    /// <summary>
    /// Excepción que representa un error en la capa de CorreoServicio.
    /// </summary>
    public class ServicioCorreoException : GeneralException
    {
        /// <summary>
        /// Constructor de la clase ServicioCorreoException.
        /// </summary>
        /// <param name="pDescripcion">Descripcion de la excepción.</param>
        /// <param name="pExcepcion">Excepción relacionada a la excepción a crear.</param>
        public ServicioCorreoException(string pDescripcion, Exception pExcepcion) : base(pDescripcion, pExcepcion) { }

        /// <summary>
        /// Constructor de la clase ServicioCorreoException.
        /// </summary>
        /// <param name="pDescripcion">Descripcion de la excepción.</param>
        public ServicioCorreoException(string pDescripcion) : base(pDescripcion) { }
    }
}
