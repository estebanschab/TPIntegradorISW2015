using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exportacion
{
    /// <summary>
    /// Clase singleton utilizada para crear y mantener una instancia de cada implementación de IExportador.
    /// </summary>
    public class FabricaExportadores
    {
        /// <summary>
        /// Atributo utilizado para lograr mantener una única instancia de la clase.
        /// </summary>
        private static FabricaExportadores cInstancia = null;

        /// <summary>
        /// Atributo de tipo diccionario responsable de relacionar los nombres de los exportadores
        /// con los mismos.
        /// </summary>
        private IDictionary<string,IExportador> iExportadores;

        /// <summary>
        /// Constructor de la clase FabricaExportadores responsable de colocar en el diccionario
        /// los exportadores con sus respectivos nombres.
        /// </summary>
        private FabricaExportadores()
        {
            this.iExportadores = new Dictionary<string, IExportador>();

            ExportadorEML exportadorEML = new ExportadorEML();
            ExportadorTextoPlano exportadorTextoPlano = new ExportadorTextoPlano();

            this.iExportadores.Add("EML", exportadorEML);
            this.iExportadores.Add("Texto Plano", exportadorTextoPlano);
        }
        
        /// <summary>
        /// Metodo responsable de buscar y devolverte un exportador dependiendo del nombre como parametro.
        /// </summary>
        /// <param name="nombre">nombre de tipo string que hace referencia al exportador a buscar.</param>
        /// <returns>Devuelve un exportador de tipo IExportador buscado.</returns>
        public IExportador GetExportador(string nombre)
        {
            //Le pedimos al diccionario con el nombre como clave que nos devuelva el exportador asociado.
            IExportador exportador = this.iExportadores[nombre];
            return exportador;
        }

        /// <summary>
        /// Propiedad utilizada para lograr mantener una únca instancia de la clase FabricaExportadores.
        /// </summary>
        public static FabricaExportadores Instancia
        {
            get
            {
                if (cInstancia == null)
                {
                    cInstancia = new FabricaExportadores();
                }
                return cInstancia;
            }
        }
    }
}
