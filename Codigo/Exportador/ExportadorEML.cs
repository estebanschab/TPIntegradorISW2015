using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using System.Net.Mail;
using Excepciones;

namespace Exportacion
{
    /// <summary>
    /// Clase utilizada para exportar un correo al sistema de archivos en formato EML.
    /// </summary>
    public class ExportadorEML : Exportador
    {
        
        /// <summary>
        /// Constructor de la clase. Llama al constructor de la superclase pasandole como parametro
        /// el nombre del metodo de exportacion.
        /// </summary>
        public ExportadorEML() : base("EML") {}

        /// <summary>
        /// Metodo para exportar un correo al Sistema de Archivos.
        /// </summary>
        /// <param name="pCorreo">correo a ser exportado.</param>
        /// <param name="pRuta">ruta donde se ubicará el correo exportado.</param>
        /// <param name="pNombre">nombre con el que se quiere guardar el correo</param>
        public override void Exportar(CorreoDTO pCorreo, string pRuta, string pNombre)
        {
            try
            {
                MailMessage correo = new MailMessage();
                correo.From = new MailAddress(pCorreo.CuentaOrigen);
                correo.To.Add(pCorreo.CuentaDestino);
                correo.Subject = pCorreo.Asunto;
                correo.Body = pCorreo.Texto;
                SmtpClient client = new SmtpClient("mysmtphost");
                client.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
                client.PickupDirectoryLocation = pRuta;
                client.Send(correo); 
            }
            catch (FormatException exception) // Cuando hay un error en el formarto.
            {
                throw new ExportadorException("No se pudo exportar su correo. Hubo un problema con el formato del correo a exportar o con la carpeta elegida. Elija otra carpeta o revise el correo y vuelva a intentarlo.", exception); 
            }
            catch (System.IO.PathTooLongException exception) // Cuando la ruta elegida es demasiado larga.
            {
                throw new ExportadorException("No se pudo exportar su correo. La ruta en la que lo desea guardar es demasiado larga. Revise la ruta y vuelva a intentarlo.", exception); 
            }
            catch (System.IO.IOException exception) // Cuando hay un error en la E/S 
            {
                throw new ExportadorException("No se pudo exportar su correo. Hubo un problema al guardar el archivo. Elija otra carpeta y vuelva a intentarlo.", exception); 
            }
            catch (SmtpException exeption)    // Cuando no hay un error con el smtpClient en la exportacion.
            {
                throw new ExportadorException("No se pudo exportar su correo. Reinicie PostApp y vuelva a intentarlo.", exeption);
            }
            catch (Exception exception)  // Demás problemas.
            {
                throw new ExportadorException("No se pudo exportar su correo.", exception);
            }
        }
    }
}
