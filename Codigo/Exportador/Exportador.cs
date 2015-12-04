using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace Exportacion
{
    /// <summary>
    /// Clase abstracta que sirve de base para los distintos exportadores que se deseen implementar.
    /// </summary>
    public abstract class Exportador : IExportador
    {
        /// <summary>
        /// Atributo nombre del exportador que se construye.
        /// </summary>
        private string iNombre;

        /// <summary>
        /// Constructor de la clase Exportador tomando como parametro el nombre
        /// del exportador que se instancia.
        /// </summary>
        /// <param name="pNombre"></param>
        public Exportador(string pNombre)
        {
            this.iNombre = pNombre;
        }

        /// <summary>
        /// Propiedad de solo lectura que devuelve el atributo nombre de la instancia.
        /// </summary>
        public string Nombre
        {
            get { return this.iNombre; }
        }

        /// <summary>
        /// Metodo abstracto que exporta un correo al sistema de archivos.
        /// </summary>
        /// <param name="pCorreo">correo a exportar.</param>
        /// <param name="pRuta">ruta donde exportar el correo.</param>
        /// <param name="pNombre">nombre con el que se quiere guardar el correo</param>
        public abstract void Exportar(CorreoDTO pCorreo, string pRuta, string pNombre);
    }
}
