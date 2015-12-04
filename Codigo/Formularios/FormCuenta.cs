using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using DataTransferObject;
using OpenPop.Pop3;
using Controladores;
using System.Data.SqlClient;

namespace Formularios
{
    public partial class FormCuenta : Form
    {
        /// <summary>
        /// Constructor del FormCuenta.
        /// </summary>
        public FormCuenta()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método que se dispara al hacer click en el botón Nuevo del Menú
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object[] row = { "", "", "", "" };
            listaCuentas.Rows.Add(row); 
            listaCuentas.Rows[listaCuentas.Rows.Count-1].Selected = true;

            // Marca como seleccionada a la opción Seleccione un servicio.
            listaServicios.SelectedIndex = 0;

            cuenta_contraseña.Text = "";
            cuenta_contraseña2.Text = "";
            cuenta_nombre.Text = "";
            cuenta_usuario.Text = "";
            cuenta_id.Text = "";
        }

        /// <summary>
        /// Método que se dispara al hacer click en el botón Guardar del Menú
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cuenta_contraseña.Text == cuenta_contraseña2.Text) 
            {
                if (Convert.ToString(listaServicios.SelectedItem) != "Seleccione un servicio")
                {
                    CuentaDTO pCuenta = new CuentaDTO();
                    pCuenta.Direccion = cuenta_usuario.Text;
                    pCuenta.Contraseña = cuenta_contraseña.Text;
                    pCuenta.Nombre = cuenta_nombre.Text;
                    pCuenta.Servicio = Convert.ToString(listaServicios.SelectedItem);
                    try
                    {
                        if (cuenta_id.Text == "")
                        {
                            FachadaABMCuenta.Instancia.CrearCuenta(pCuenta);
                            MessageBox.Show("Cuenta guardada con éxito", "PostApp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            pCuenta.Id = Convert.ToInt32(cuenta_id.Text);
                            FachadaABMCuenta.Instancia.ModificarCuenta(pCuenta);
                            MessageBox.Show("Cuenta guardada con éxito", "PostApp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception exeption)
                    {
                        MessageBox.Show(exeption.Message, "PostApp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Servicio", "PostApp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Verifique las contraseñas", "PostApp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Actualiza la lista de cuentas
            MostrarCuentas();
        }

        /// <summary>
        /// Método que se dispara al hacer click en el botón Borrar del Menú
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea eliminar esta cuenta?", "PostApp", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { 
                if (cuenta_id.Text == "")
                {
                    listaCuentas.Rows.Remove(listaCuentas.SelectedRows[0]);
                    // Marca como seleccionada la ultima fila
                    listaCuentas.Rows[listaCuentas.Rows.Count - 1].Selected = true;
                }
                else
                {
                    CuentaDTO pCuenta = new CuentaDTO();
                    pCuenta.Id = Convert.ToInt32(cuenta_id.Text);
                    pCuenta.Direccion = Convert.ToString(cuenta_usuario);
                    try
                    {
                        FachadaABMCuenta.Instancia.EliminarCuenta(pCuenta);
                    }
                    catch (Exception exeption)
                    {
                        MessageBox.Show(exeption.Message, "PostApp", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Actualiza la lista de cuentas
                    MostrarCuentas();
                }
            }
        }

        /// <summary>
        /// Metodo para cargar la informacion de las cuentas.
        /// </summary>
        private void MostrarCuentas()
        {
            listaCuentas.Rows.Clear();
            try
            {
                foreach (CuentaDTO aCuenta in FachadaABMCuenta.Instancia.ListarCuentas())
                {
                    object[] row = { aCuenta.Id, aCuenta.Nombre, aCuenta.Direccion, aCuenta.Contraseña, aCuenta.Servicio };
                    listaCuentas.Rows.Add(row);
                }
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message, "PostApp", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Metodo para cargar la informacion de los servicios.
        /// </summary>
        private void CargarServicios()
        {
            // Coloca las opciones de servicios
            listaServicios.Items.Add("Seleccione un servicio");
            listaServicios.Items.Add("Gmail");
            listaServicios.Items.Add("Yahoo");
            listaServicios.Items.Add("Mailtrap");
            // Marca como seleccionada a la opción Seleccione un servicio.
            listaServicios.SelectedIndex = 0;
        }

        /// <summary>
        /// Metodo que se dispara al cargar el formCuenta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCuenta_Load(object sender, EventArgs e)
        {
            CargarServicios();
            MostrarCuentas();
            // Si la lista esta vacía inserta una fila
            if (listaCuentas.RowCount == 0)
            {
                object[] row = { "", "", "", "" };
                listaCuentas.Rows.Add(row);
            }
        }

        /// <summary>
        /// Metodo que se dispara al seleccionar una cuenta de listaCuentas, y que muestra
        /// la informacion de esa cuenta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listaCuentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexSelected = e.RowIndex;

            //Selecciona toda la fila
            listaCuentas.Rows[indexSelected].Selected = true;

            cuenta_id.Text = Convert.ToString(listaCuentas.Rows[indexSelected].Cells["cuentaId"].Value);
            cuenta_nombre.Text = Convert.ToString(listaCuentas.Rows[indexSelected].Cells["nombre"].Value);
            cuenta_usuario.Text = Convert.ToString(listaCuentas.Rows[indexSelected].Cells["usuario"].Value);
            cuenta_contraseña.Text = Convert.ToString(listaCuentas.Rows[indexSelected].Cells["contraseña"].Value);
            cuenta_contraseña2.Text = Convert.ToString(listaCuentas.Rows[indexSelected].Cells["contraseña"].Value);
            
            for (int i = 0;  i < listaServicios.Items.Count; i++)
            {
                if (Convert.ToString(listaServicios.Items[i]) == Convert.ToString(listaCuentas.Rows[indexSelected].Cells["servicio"].Value))
                {
                    listaServicios.SelectedIndex = i;
                    break;
                }
            }
        }

        /// <summary>
        /// Método que se ejecuta cuando cambia el valor del TextBox cuenta_nombre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cuenta_nombre_TextChanged(object sender, EventArgs e)
        {
            listaCuentas.SelectedRows[0].Cells["nombre"].Value = cuenta_nombre.Text;              
        }

        /// <summary>
        /// Método que se ejecuta cuando cambia el valor del TextBox cuenta_usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cuenta_usuario_TextChanged(object sender, EventArgs e)
        {
            listaCuentas.SelectedRows[0].Cells["usuario"].Value = cuenta_usuario.Text;
        }

        /// <summary>
        /// Método que se ejecuta cuando cambia el valor del TextBox cuenta_contraseña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cuenta_contraseña_TextChanged(object sender, EventArgs e)
        {
            listaCuentas.SelectedRows[0].Cells["contraseña"].Value = cuenta_contraseña.Text;
        }

        /// <summary>
        /// Método que se ejecuta cuando cambia el valor del ComboBox listaServicios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listaServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cambia el valor en la fila seleccionada de listaCuntas solo si hay una fila seleccionada
            if (listaCuentas.SelectedRows.Count==1)
            {
                listaCuentas.SelectedRows[0].Cells["servicio"].Value = Convert.ToString(listaServicios.SelectedItem);
            }
        }

        /// <summary>
        /// Método que se ejecuta cuando se entra a una fila (Haciendo uso de las flechas)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listaCuentas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int indexSelected = e.RowIndex;
            //Selecciona toda la fila
            listaCuentas.Rows[indexSelected].Selected = true;

            cuenta_id.Text = Convert.ToString(listaCuentas.Rows[indexSelected].Cells["cuentaId"].Value);
            cuenta_nombre.Text = Convert.ToString(listaCuentas.Rows[indexSelected].Cells["nombre"].Value);
            cuenta_usuario.Text = Convert.ToString(listaCuentas.Rows[indexSelected].Cells["usuario"].Value);
            cuenta_contraseña.Text = Convert.ToString(listaCuentas.Rows[indexSelected].Cells["contraseña"].Value);
            cuenta_contraseña2.Text = Convert.ToString(listaCuentas.Rows[indexSelected].Cells["contraseña"].Value);

            for (int i = 0; i < listaServicios.Items.Count; i++)
            {
                if (Convert.ToString(listaServicios.Items[i]) == Convert.ToString(listaCuentas.Rows[indexSelected].Cells["servicio"].Value))
                {
                    listaServicios.SelectedIndex = i;
                    break;
                }
            }
        }

        /// <summary>
        /// Método que se ejecuta al hacer doble click sobre una celda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listaCuentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //marca la fila como seleccionada, para no perder la fila seleccionada actual.
            listaCuentas.Rows[e.RowIndex].Selected = true;
        }

        /// <summary>
        /// Metodo que se dispara cuando cambia el valor del CheckBox "mostrar".
        /// Utilizado para mostrar y ocultar la contraseña de la cuenta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (mostrar.Checked == true) // mostramos las claves
            {
                cuenta_contraseña.UseSystemPasswordChar = false;
                cuenta_contraseña2.UseSystemPasswordChar = false;
            }
            else  // ocultamos las claves
            {
                cuenta_contraseña.UseSystemPasswordChar = true;
                cuenta_contraseña2.UseSystemPasswordChar = true;
            }
        }

    }
}
