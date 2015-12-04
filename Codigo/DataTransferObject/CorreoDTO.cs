using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    /// <summary>
    /// Clase utilizada para representar un correo electronico.
    /// </summary>
    public class CorreoDTO
    {
        /// <summary>
        /// Atributo ID.
        /// </summary>
        private int iId;

        /// <summary>
        /// Atributo ID del correo en el servicio.
        /// </summary>
        private string iServicioId;

        /// <summary>
        /// Atributo fecha.
        /// </summary>
        private DateTime iFecha;

        /// <summary>
        /// Atributo tipoCorreo.
        /// </summary>
        private string iTipoCorreo;

        /// <summary>
        /// Atributo texto.
        /// </summary>
        private string iTexto;

        /// <summary>
        /// Atributo origen.
        /// </summary>
        private string iCuentaOrigen;      

        /// <summary>
        /// Atributo destino.
        /// </summary>
        private string iCuentaDestino;

        /// <summary>
        /// Atributo asunto.
        /// </summary>
        private string iAsunto;

        /// <summary>
        /// Atributo leido.
        /// </summary>
        private bool iLeido;

        /// <summary>
        /// Atributo eliminado.
        /// </summary>
        private bool iEliminado;

        /// <summary>
        /// Atributo para archivos adjuntos.
        /// </summary>
        private List<string> iAdjuntos;

        /// <summary>
        /// Constructor de una instancia de la clase Correo .
        /// </summary>
        public CorreoDTO() {}

        /// <summary>
        /// Propiedad de lectura y escritura del ID.
        /// </summary>
        public int Id
        {
            get { return this.iId; }
            set { this.iId = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del ID del correo en el servicio.
        /// </summary>
        public string ServicioId
        {
            get { return this.iServicioId; }
            set { this.iServicioId = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura de la Fecha.
        /// </summary>
        public DateTime Fecha
        {
            get { return this.iFecha; }
            set { this.iFecha = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del tipo de correo.
        /// </summary>
        public string TipoCorreo
        {
            get { return this.iTipoCorreo; }
            set { this.iTipoCorreo = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del Texto.
        /// </summary>
        public string Texto
        {
            get { return this.iTexto; }
            set { this.iTexto = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del Origen.
        /// </summary>
        public string CuentaOrigen
        {
            get { return this.iCuentaOrigen; }
            set { this.iCuentaOrigen = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del Destino.
        /// </summary>
        public string CuentaDestino
        {
            get { return this.iCuentaDestino; }
            set { this.iCuentaDestino = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del Asunto.
        /// </summary>
        public string Asunto
        {
            get { return this.iAsunto; }
            set { this.iAsunto = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo leído.
        /// </summary>
        public bool Leido
        {
            get { return this.iLeido; }
            set { this.iLeido = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo eliminado.
        /// </summary>
        public bool Eliminado
        {
            get { return this.iEliminado; }
            set { this.iEliminado = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo que representa los archivos adjuntos.
        /// </summary>
        public List<string> Adjuntos
        {
            get { return this.iAdjuntos; }
            set { this.iAdjuntos = value; }
        }
    }
}
