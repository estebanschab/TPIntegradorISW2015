using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using DataTransferObject;

namespace Controladores
{
    /// <summary>
    /// Clase controladora de fachada. Interactúa con las Cuentas de correo 
    /// entre la persistencia y la interfaz.
    /// </summary>
    public class FachadaABMCuenta
    {
        /// <summary>
        /// Atributo que almacena la instancia de la fachada.
        /// </summary>
        private static FachadaABMCuenta cInstancia = null;

        /// <summary>
        /// Atributo DAOFactory para interactuar con la Base de Datos.
        /// </summary>
        private DAOFactory factory;

        /// <summary>
        /// Metodo para dar de alta una cuenta de correo.
        /// </summary>
        /// <param name="pCuenta">Clase DTO con los datos de la cuenta a dar de alta.</param>
        public void CrearCuenta(CuentaDTO pCuenta)
        {
            try
            {
                factory = DAOFactory.Instancia;
                factory.IniciarConexion();
                factory.ComenzarTransaccion();
                factory.CuentaDAO.AgregarCuenta(pCuenta);
                factory.Commit();
            }
            catch (Exception exception)
            {
                factory.RollBack();

                //Se relanza la excepción porque en este punto no se puede tratar
                throw exception;
            }
            finally
            {
                // Haya o no un error, se cierra la transacción.
                factory.FinalizarConexion();
            }
        }

        /// <summary>
        /// Metodo para completar la información de una cuenta de la Base de Datos.
        /// </summary>
        /// <param name="pNombre">Nombre de la cuenta a ser completada.</param>
        /// <returns></returns>
        public CuentaDTO ObtenerCuenta(string pNombre)
        {
            try
            {
                factory = DAOFactory.Instancia;
                factory.IniciarConexion();

                CuentaDTO cuenta = new CuentaDTO();
                cuenta.Nombre = pNombre;
                return factory.CuentaDAO.ObtenerCuenta(cuenta);
            }
            catch (Exception exception)
            {
                factory.RollBack();

                //Se relanza la excepción porque en este punto no se puede tratar
                throw exception;
            }
            finally
            {
                //Haya o no un error, se cierra la transacción.
                factory.FinalizarConexion();
            }
        }

        /// <summary>
        /// Metodo para completar la información de una cuenta de la Base de Datos.
        /// </summary>
        /// <param name="pId">Id de la cuenta a ser completada.</param>
        /// <returns></returns>
        public CuentaDTO ObtenerCuenta(int pId)
        {
            try
            {
                factory = DAOFactory.Instancia;
                factory.IniciarConexion();

                CuentaDTO cuenta = new CuentaDTO();
                cuenta.Id = pId;
                return factory.CuentaDAO.ObtenerCuenta(cuenta);
            }
            catch (Exception exception)
            {
                factory.RollBack();

                //Se relanza la excepción porque en este punto no se puede tratar
                throw exception;
            }
            finally
            {
                //Haya o no un error, se cierra la transacción.
                factory.FinalizarConexion();
            }
        }

        /// <summary>
        /// Método para listar todas las cuentas de correo de la Base de Datos.
        /// </summary>
        /// <returns>Una lista con todos las cuentas de la base de datos.</returns>
        public IList<CuentaDTO> ListarCuentas()
        {
            try
            {
                factory = DAOFactory.Instancia;
                factory.IniciarConexion();

                //Se devuelven las cuentas
                return factory.CuentaDAO.ObtenerCuentas();
            }
            catch (Exception exception)
            {
                factory.RollBack();

                //Se relanza la excepción porque en este punto no se puede tratar
                throw exception;
            }
            finally
            {
                //Haya o no un error, se cierra la transacción.
                factory.FinalizarConexion();
            }
        }

        /// <summary>
        /// Método para modificar los datos de una cuenta de correo.
        /// </summary>
        /// <param name="pCuenta">Clase DTO con los datos de la cuenta a modificar.</param>
        public void ModificarCuenta(CuentaDTO pCuenta)
        {
            try
            {
                factory = DAOFactory.Instancia;
                factory.IniciarConexion();
                factory.ComenzarTransaccion();
                factory.CuentaDAO.ModificarCuenta(pCuenta);
                factory.Commit();
            }
            catch (Exception e)
            {
                factory.RollBack();

                //Se relanza la excepción porque en este punto no se puede tratar
                throw e;
            }
            finally
            {
                // Haya o no un error, se cierra la transacción.
                factory.FinalizarConexion();
            }
        }

        /// <summary>
        /// Método para eliminar una Cuenta de correo.
        /// </summary>
        /// <param name="pCuenta">Clase DTO con los datos de la cuenta de correo a eliminar.</param>
        public void EliminarCuenta(CuentaDTO pCuenta)
        {
            try
            {
                factory = DAOFactory.Instancia;
                factory.IniciarConexion();
                factory.ComenzarTransaccion();
                factory.CuentaDAO.EliminarCuenta(pCuenta);
                factory.Commit();
            }
            catch (Exception e)
            {
                factory.RollBack();

                //Se relanza la excepción porque en este punto no se puede tratar
                throw e;
            }
            finally
            {
                // Haya o no un error, se cierra la transacción.
                factory.FinalizarConexion();
            }
        }

        /// <summary>
        /// Propiedad utilizada para lograr mantener una única instancia de la clase.
        /// </summary>
        public static FachadaABMCuenta Instancia
        {
            get
            {
                if (cInstancia == null)
                {
                    cInstancia = new FachadaABMCuenta();
                }
                return cInstancia;
            }
        }
    }
}
