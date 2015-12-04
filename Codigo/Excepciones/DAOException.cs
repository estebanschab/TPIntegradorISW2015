using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    /// <summary>
    /// Excepción que representa un error en la capa DAO
    /// </summary>
    public class DAOException : GeneralException
    {
        /// <summary>
        /// Constructor de la clase DAOException.
        /// </summary>
        /// <param name="pDescripcion">Descripcion de la excepción.</param>
        /// <param name="pExcepcion">Excepción relacionada a la excepción a crear.</param>
        public DAOException(string pDescripcion, Exception pExcepcion) : base(pDescripcion, pExcepcion) { }

        /// <summary>
        /// Constructor de la clase DAOException.
        /// </summary>
        /// <param name="pDescripcion">Descripcion de la excepción.</param>
        public DAOException(string pDescripcion) : base(pDescripcion) { }
    }
}
