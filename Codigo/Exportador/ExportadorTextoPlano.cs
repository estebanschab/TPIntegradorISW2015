using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using System.IO;
using Excepciones;

namespace Exportacion
{
    /// <summary>
    /// Clase utilizada para exportar un correo al sistema de archivos en Texto Plano.
    /// </summary>
    public class ExportadorTextoPlano : Exportador
    {

        /// <summary>
        /// Constructor de la clase. Llama al constructor de la superclase pasandole como parametro
        /// el nombre del metodo de exportacion.
        /// </summary>
        public ExportadorTextoPlano() : base("Texto Plano") { }

        /// <summary>
        /// Metodo para exportar un correo al sistema de archivos.
        /// </summary>
        /// <param name="pCorreo">correo a ser exportado.</param>
        /// <param name="pRuta">ruta en donde se exportará el correo.</param>
        /// <param name="pNombre">nombre con el que se quiere guardar el correo</param>
        public override void Exportar(CorreoDTO pCorreo,string pRuta,string pNombre)
        {
            //Formamos un array de string para luego escribir en el archivo.
            string[] lines = {"De: <" + pCorreo.CuentaOrigen + ">", "Para: <" + pCorreo.CuentaDestino + ">", 
                                 "Asunto: " + pCorreo.Asunto, "Fecha: " + pCorreo.Fecha.ToString("dddd, dd ") +
                                 "de " + pCorreo.Fecha.ToString("MMMM") + " de " + pCorreo.Fecha.ToString("yyyy")
                                 + pCorreo.Fecha.ToString(" HH:mm"), 
                                 " ", pCorreo.Texto};
            try
            {
                //Creamos y escribimos el archivo en la ruta especificada por el usuario.
                System.IO.File.WriteAllLines(pRuta + "\\" + pNombre + ".txt", lines);
            }
            catch (FormatException exception) // Cuando hay un error en el formarto.
            {
                throw new ExportadorException("No se pudo exportar su correo. Hubo un problema con la carpeta elegida. Elija otra carpeta y vuelva a intentarlo.", exception);
            }
            catch (System.IO.PathTooLongException exception)  // Cuando la ruta elegida es demasiado larga.
            {
                throw new ExportadorException("No se pudo exportar su correo. La ruta en la que lo desea guardar o el asunto del correo son demasiado largos. Revise la ruta y vuelva a intentarlo.", exception); 
            }
            catch (System.IO.IOException exception) // Cuando hay un error en la E/S 
            {
                throw new ExportadorException("No se pudo exportar su correo. Hubo un problema al guardar el archivo. Elija otra carpeta y vuelva a intentarlo.", exception); 
            }
            catch (Exception exception) // Demás problemas.
            {
                throw new ExportadorException("No se pudo exportar su correo.", exception);
            }
          
        }

    }
}
