using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CorreoServicio;
using DataTransferObject;
using System.Collections.Generic;

namespace Tests
{
    /// <summary>
    /// Pruebas sobre el servicio de correo
    /// </summary>
    [TestClass]
    public class CorreoServicioTest
    {
        private CorreoDTO iMailDTO;
        private CuentaDTO iAccountDTO;
        private IList<CorreoDTO> iListMails1;
        private IList<CorreoDTO> iListMails2;

        [TestInitialize]
        public void Initialize()
        {
            //se instancian las listas de correos
            iListMails1 = new List<CorreoDTO>();
            iListMails2 = new List<CorreoDTO>();

            //Se crea una cuenta de correo de prueba
            iAccountDTO = new CuentaDTO()
            {
                Id = 1,
                Direccion = "pedroperez@gmail.com",
                Contraseña = "1234abc",
                Nombre = "Pedro",
                Servicio = "gmail"
            };
            //Se crea un correo de prueba
            iMailDTO = new CorreoDTO()
            {
                Asunto = "Prueba de Mocking",
                CuentaDestino = "jose@gmail.com",
                CuentaOrigen = "pedroperez@gmail.com",
                Texto = "Esto es una prueba mocking"
            };
            //Se genera la primer lista de correos
            iListMails1.Add(new CorreoDTO
            {
                Id = 1,
                Asunto = "Primer Correo",
                CuentaDestino = "anamaria@gmail.com",
                CuentaOrigen = "carmendolores@gmail.com",
                Texto = "Nuevo correo"
            });
            iListMails1.Add(new CorreoDTO
            {
                Id = 2,
                Asunto = "Segundo Correo",
                CuentaDestino = "jose@gmail.com",
                CuentaOrigen = "pedrogarcia@gmail.com",
                Texto = "Nuevo correo"
            });

            //Se genera la segunda lista de correos
            iListMails2.Add(new CorreoDTO
            {
                Id = 4,
                Asunto = "Correo 1 Lista 2",
                CuentaDestino = "carmen@gmail.com",
                CuentaOrigen = "pedro@gmail.com",
                Texto = "Nuevo correo"
            });
            iListMails2.Add(new CorreoDTO
            {
                Id = 5,
                Asunto = "Correo 2 Lista 2",
                CuentaDestino = "jose@gmail.com",
                CuentaOrigen = "alejandro@gmail.com",
                Texto = "Nuevo correo"
            });
        }

        /// <summary>
        /// Cuando se invoca al metodo "EnviarCorreo" se lanza una excepcion genérica
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ExpectedExceptionWhenEnviarCorreoInvoked()
        {
            
            Mock<IServicioCorreo> mMockMailSvc = new Mock<IServicioCorreo>();
            //Se prepara el mock
            mMockMailSvc.Setup(x => x.EnviarCorreo(this.iMailDTO,this.iAccountDTO)).Throws<Exception>();
            
            IServicioCorreo mMailSvc = mMockMailSvc.Object;
            mMailSvc.EnviarCorreo(this.iMailDTO, this.iAccountDTO);                        
        }

        /// <summary>
        /// Cuando se envia un correo con un destinatario especifico se lanza una excepcion genérica
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ExpectedExceptionWhenToIsSpecificMail()
        {

            Mock<IServicioCorreo> mMockMailSvc = new Mock<IServicioCorreo>();
            //Se prepara el mock
            mMockMailSvc.When(() => this.iMailDTO.CuentaDestino.Equals("jose@gmail.com")).Setup(x => x.EnviarCorreo(this.iMailDTO, this.iAccountDTO)).Throws<Exception>();
            
            IServicioCorreo mMailSvc = mMockMailSvc.Object;
            mMailSvc.EnviarCorreo(this.iMailDTO, this.iAccountDTO);
        }

        /// <summary>
        /// Verifica que se invocó al metodo EnviarCorreo
        /// </summary>
        [TestMethod]
        public void InvokeMethod()
        {
            bool mIsCallMethod = false;
            Mock<IServicioCorreo> mMockMailSvc = new Mock<IServicioCorreo>();
            //Se prepara el mock
            mMockMailSvc.Setup(x => x.EnviarCorreo(this.iMailDTO, this.iAccountDTO)).Callback(() =>
            {
                mIsCallMethod = true;
            });
            IServicioCorreo mMailSvc = mMockMailSvc.Object;
            mMailSvc.EnviarCorreo(this.iMailDTO, this.iAccountDTO);

            Assert.IsTrue(mIsCallMethod);
        }

        /// <summary>
        /// Retorna una lista de correos cuando se invoca el método "DescargarCorreo"
        /// </summary>
        [TestMethod]
        public void ReturnListWhenDescargarCorreoInvoked()
        {
            //Se instancia el Mock
            Mock<IServicioCorreo> mMockMailSvc = new Mock<IServicioCorreo>();
            //Se prepara el Mock para que devuelva una lista.
            mMockMailSvc.Setup(x => x.DescargarCorreos(this.iAccountDTO)).Returns(this.iListMails1);
            //Se le pasa la instancia Mock.Object a una variabe IServicioCorreo 
            IServicioCorreo mMailSvc = mMockMailSvc.Object;
            //Se valida la prueba
            Assert.AreEqual(2, mMailSvc.DescargarCorreos(this.iAccountDTO).Count);
        }

        /// <summary>
        /// Retorna dos listas distintas por cada invocación al método "DescargarCorreos"
        /// </summary>
        [TestMethod]
        public void ReturnTwoListsWhenDescargarCorreoInvoked()
        {
            //Se crea un contador de invocaciones
            var mCountInvocation = 0;
            //Se instancia el Mock
            Mock<IServicioCorreo> mMockMailSvc = new Mock<IServicioCorreo>();
            //Se prepara el Mock para que devuelva una lista.
            mMockMailSvc.Setup(x => x.DescargarCorreos(this.iAccountDTO)).Returns(() =>
            {
                mCountInvocation++;

                if (mCountInvocation == 1)
                {
                    return this.iListMails1;
                }
                else
                {
                    return this.iListMails2;
                }
            });
            //Se le pasa la instancia Mock.Object a una variabe IServicioCorreo 
            IServicioCorreo mMailSvc = mMockMailSvc.Object;
            //Se valida la prueba

            Assert.AreNotEqual(mMailSvc.DescargarCorreos(this.iAccountDTO), mMailSvc.DescargarCorreos(this.iAccountDTO));
        }
    }
}
