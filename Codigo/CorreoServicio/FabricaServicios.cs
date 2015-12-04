using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorreoServicio
{
    /// <summary>
    /// Clase singleton utilizada para crear y mantener una instancia de cada implementación de Iservicio.
    /// </summary>
    public class FabricaServicios 
    {
        /// <summary>
        /// Atributo utilizado para lograr mantener una única instancia de la clase.
        /// </summary>
        private static FabricaServicios cInstancia = null;

        /// <summary>
        /// Atributo de tipo diccionario responsable de relacionar los nombres de los servicios
        /// con los mismos.
        /// </summary>
        private IDictionary<string, IServicioCorreo> iServicios;

        /// <summary>
        /// Constructor de la clase FabricaServicios responsable de colocar en el diccionario
        /// los servicios con sus respectivos nombres.
        /// </summary>
        private FabricaServicios()
            {
                this.iServicios = new Dictionary<string, IServicioCorreo>();

                Gmail servicioGmail = new Gmail();
                Yahoo servicioYahoo = new Yahoo(); 
                Mailtrap servicioMailtrap = new Mailtrap();

                this.iServicios.Add("Gmail", servicioGmail);
                this.iServicios.Add("Yahoo", servicioYahoo);
                this.iServicios.Add("Mailtrap", servicioMailtrap);
            }

        /// <summary>
        /// Propiedad utilizada para lograr mantener una únca instancia de la clase FabricaServicios.
        /// </summary>
        public static FabricaServicios Instancia
        {
            get
            {
                if (cInstancia == null)
                {
                    cInstancia = new FabricaServicios();
                }
                return cInstancia;
            }
        }

        /// <summary>
        /// Metodo responsable de buscar y devolver un servicio dependiendo del nombre como parametro.
        /// </summary>
        /// <param name="nombre">nombre de tipo string que hace referencia al servicio a buscar.</param>
        /// <returns>Devuelve un servicio de tipo IServicio buscado.</returns>
        public IServicioCorreo GetServicio(string nombre)
        {
            //Le pedimos al diccionario con el nombre como clave que nos devuelva el servicio asociado.
            IServicioCorreo servicio = this.iServicios[nombre];

            return servicio;
        }
    }
}
