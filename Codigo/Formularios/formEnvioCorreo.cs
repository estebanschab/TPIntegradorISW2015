using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;
using DataTransferObject;

namespace Formularios
{
    public partial class formEnvioCorreo : Form
    {
        /// <summary>
        /// Atributo para guardar los adjuntos de un correo.
        /// </summary>
        private List<string> archivos = new List<string>();

        /// <summary>
        /// Atributo Correo de tipo CorreoDTO.
        /// </summary>
        private CorreoDTO iCorreo;

        /// <summary>
        /// Constructor de una instancia del form de envio de correos .
        /// </summary>
        public formEnvioCorreo() 
        {           
            InitializeComponent();
            iCorreo = null;
        }

        /// <summary>
        /// Constructor de una instancia del form de envio de correos .
        /// </summary>
        public formEnvioCorreo(CorreoDTO pCorreo)
        {
            iCorreo = pCorreo;
            InitializeComponent();
        }

        /// <summary>
        /// Metodo que se dispara al hacer click en el boton ENVIAR para enviar un correo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEnviar_Click(object sender, EventArgs e)
        {
            //Muestra el mensaje de información al usuario.
            mensajeEnviando.Visible = true;
            mensajeEnviando.Update();

            CorreoDTO pCorreo = new CorreoDTO();
            pCorreo.Leido = false;
            pCorreo.CuentaOrigen = Convert.ToString(listaCuentas.SelectedItem);
            pCorreo.CuentaDestino = correo_Destino.Text;
            pCorreo.Asunto = correo_Asunto.Text;
            pCorreo.Fecha = DateTime.Today;
            pCorreo.Texto = correo_Texto.Text;
            pCorreo.TipoCorreo = "Enviado";
            pCorreo.Adjuntos = archivos;
            pCorreo.Eliminado = false;

            try
            {
                //Obtenemos la cuenta con la que se envía el correo
                CuentaDTO pCuenta = FachadaABMCuenta.Instancia.ObtenerCuenta(pCorreo.CuentaOrigen);
                if (pCuenta.Contraseña == "" || pCuenta.Contraseña == null)
                {
                    FormContraseña f2 = new FormContraseña(pCuenta);
                    DialogResult res = f2.ShowDialog(); //abrimos el formulario contraseña como cuadro de dialogo modal

                    if (res == DialogResult.OK)
                    {
                        // Recuperando la variable publica del formulario contraseña
                        // asignamos al texbox el dato de la variable
                        pCuenta.Contraseña = f2.varf2;
                    }
                }
            
                //Enviamos el correo.
                FachadaCorreo.Instancia.EnviarCorreo(pCorreo,pCuenta);

                //Guardamos el correo en la base de datos.

                // Actualiza el valor del campo CuentaOrigen, ya que tiene el nombre de la cuenta pero se debe guardar con la direccion.
                pCorreo.CuentaOrigen = FachadaABMCuenta.Instancia.ObtenerCuenta(pCorreo.CuentaOrigen).Direccion;
                //Setea el valor del campo servicioid
                pCorreo.ServicioId = "Correo enviado por el Cliente de Correo";
                FachadaCorreo.Instancia.CrearCorreo(pCorreo);
                MessageBox.Show("Enviado con exito.", "Envio de mail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "PostApp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Oculta el mensaje de información al usuario
            mensajeEnviando.Visible = false;
            this.Close();
        }

        /// <summary>
        /// Metodo que se dispara al hacer click en el boton Agregar Archivo Adjunto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAdjunto_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Seleccione Archivo";
            file.InitialDirectory = @"C:\";
            file.Filter = "All files(*.*)|*.*";
            file.FilterIndex = 1;
            file.RestoreDirectory = true;
            file.ShowDialog();
            archivos.Add(file.FileName);
            correo_Adjuntos.Text = correo_Adjuntos.Text + file.SafeFileName + "\r" + "\n";
        }

        /// <summary>
        /// Metodo para cargar la informacion de las cuentas.
        /// </summary>
        private void MostrarCuentas()
        {
            try
            {
                foreach (CuentaDTO aCuenta in FachadaABMCuenta.Instancia.ListarCuentas())
                {
                    listaCuentas.Items.Add(aCuenta.Nombre);
                }
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "PostApp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                // Coloca la opción de Seleccionar Cuenta
                listaCuentas.Items.Add("Seleccionar Cuenta");
                // Marca como seleccionada a la opción Seleccionar Cuenta.
                listaCuentas.SelectedIndex = listaCuentas.Items.Count - 1;
            }
        }

        /// <summary>
        /// Metodo que se dispara cuando carga el formulario para mostrar las cuentas en el 
        /// menú desplegable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formEnvioCorreo_Load(object sender, EventArgs e)
        {
            MostrarCuentas();
            try
            {
                if (iCorreo != null)
                {
                    correo_Destino.Text = iCorreo.CuentaDestino;
                    correo_Asunto.Text = iCorreo.Asunto;
                    correo_Texto.Text = iCorreo.Texto;
                    // Recorre la lista para encontrar el elemento que debe dejar seleccionado
                    for (int i = 0; i < listaCuentas.Items.Count; i++)
                    {
                        if (FachadaABMCuenta.Instancia.ObtenerCuenta(Convert.ToString(listaCuentas.Items[i])).Direccion == iCorreo.CuentaOrigen)
                        {
                            listaCuentas.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "PostApp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }        
        }
    }
}
