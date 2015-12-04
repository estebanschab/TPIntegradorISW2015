using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using System.Net.Mail;
using OpenPop.Pop3;
using Excepciones;

namespace CorreoServicio
{
    /// <summary>
    /// Clase utilizada para relacionar el programa con el servicio de correo correspondiente a Gmail.
    /// </summary>
    public class Gmail : ServicioCorreo
    {
        /// <summary>
        /// Constructor de la clase. Llama al constructor de la superclase pasandole como parametro
        /// el nombre del Servicio de Correo.
        /// </summary>
        public Gmail() : base("Gmail") {}

        /// <summary>
        /// Metodo utilizado para enviar un correo.
        /// </summary>
        /// <param name="pCorreo">Correo a ser enviado.</param>
        /// <param name="pCuenta">Cuenta con la que se envia el correo</param>
        public override void EnviarCorreo(CorreoDTO pCorreo, CuentaDTO pCuenta)
        {
            try
            {
                MailMessage correo = new MailMessage();
                correo.From = new MailAddress(pCuenta.Direccion);
                correo.To.Add(pCorreo.CuentaDestino);
                correo.Subject = pCorreo.Asunto;
                correo.Body = pCorreo.Texto;
                if (pCorreo.Adjuntos != null)
                {
                    foreach (string archivo in pCorreo.Adjuntos)
                    {
                        Attachment attach = new Attachment(@archivo);
                        correo.Attachments.Add(attach);
                    }
                }
                SmtpClient cliente = new SmtpClient("smtp.gmail.com");
                cliente.EnableSsl = true;
                cliente.Port = 587;
                cliente.Credentials = new System.Net.NetworkCredential(pCuenta.Direccion, pCuenta.Contraseña);
                cliente.Send(correo);
            }
            catch (FormatException exeption) //Cuando no esta bien el formato del destino
            {
                throw new ServicioCorreoException("No se pudo enviar su correo. Revise el formato del destinatario y vuelva a intentarlo.", exeption);
            }
            catch (SmtpException exeption)    // Cuando no hay conexion o estan mal los datos de la cuenta.
            {
                throw new ServicioCorreoException("No se pudo enviar su correo. Revise la conexion a Internet y sus datos de conexión y vuelva a intentarlo.", exeption);
            }
            catch (Exception exeption) // Otras
            {
                throw new ServicioCorreoException("No se pudo enviar su correo.", exeption);
            }
        }

        /// <summary>
        /// Metodo que descarga los correos del Servicio de correo que pertenecen a la cuenta <paramref name="pCuenta"/>.
        /// </summary>
        /// <param name="pCuenta">Cuenta de la cual se descargan los correos.</param>
        /// <returns>Retorna una lista de correos.</returns>
        public override IList<CorreoDTO> DescargarCorreos(CuentaDTO pCuenta)
        {
            List<CorreoDTO> mCorreos = new List<CorreoDTO>();
            Pop3Client pop = new Pop3Client();
            OpenPop.Mime.Message mensaje;
            try
            {
                pop.Connect("pop.gmail.com", 995, true);
                pop.Authenticate(pCuenta.Direccion, pCuenta.Contraseña);
                int cantidadMensajes = pop.GetMessageCount();
                for (int i = cantidadMensajes; i > 0; i--)
                {
                    mensaje = pop.GetMessage(i);

                    // obtengo el texto del cuerpo del correo.
                    string cuerpo = "";
                    OpenPop.Mime.MessagePart texto = mensaje.FindFirstPlainTextVersion();
                    if (texto != null) // El correo posee texto plano
                    {
                        cuerpo = texto.GetBodyAsText();
                    }
                    else
                    {
                        OpenPop.Mime.MessagePart html = mensaje.FindFirstHtmlVersion();
                        if (html != null)// El correo tiene texto en html
                        {
                            cuerpo = html.GetBodyAsText();
                        }
                    }
                    string pTipoCorreo;
                    // Determina si el correo es enviado o recibido comparando la direccion de la cuenta con la direccion
                    // que aparece como direccion remitente.
                    if (mensaje.Headers.From.Address == pCuenta.Direccion)
                    {
                        pTipoCorreo = "Enviado";
                    }
                    else
                    {
                        pTipoCorreo = "Recibido";
                    }

                    // Armar el string de cuenta destino con las cuentas destinatarias.
                    string pDestino = "";
                    foreach (OpenPop.Mime.Header.RfcMailAddress mailAdres in mensaje.Headers.To)
                    {
                        pDestino = pDestino + mailAdres.Address + "; ";
                    }

                    mCorreos.Add(new CorreoDTO()
                    {
                        Fecha = mensaje.Headers.DateSent,
                        TipoCorreo = pTipoCorreo,
                        Texto = cuerpo,
                        CuentaOrigen = mensaje.Headers.From.Address,
                        CuentaDestino = pDestino,    
                        Asunto = mensaje.Headers.Subject,
                        Leido = false,
                        ServicioId = mensaje.Headers.MessageId
                    });
                }
            }
            catch (OpenPop.Pop3.Exceptions.InvalidLoginException exeption) // Excepcion que se lanza cuando hay un  problema con los datos del usuario y no se puede realizar el login
            {
                throw new ServicioCorreoException("No se pudo actualizar la cuenta " + pCuenta.Direccion + ". Hubo un problema en el acceso a la cuenta. Revise sus datos y vuelva a intentarlo.", exeption);
            }
            catch (OpenPop.Pop3.Exceptions.PopServerNotFoundException exeption) // Excepcion que se lanza al no poder conectarse con el servidor
            {
                throw new ServicioCorreoException("No se pudo actualizar la cuenta " + pCuenta.Direccion + ". Hubo un error de acceso al servidor. Revise su conexion o intentelo más tarde.", exeption);
            }
            catch (Exception exeption)
            {
                throw new ServicioCorreoException("No se pudo actualizar la cuenta " + pCuenta.Direccion + ". ", exeption);
            }
            return mCorreos;
        }    
    }
}
