﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Sura.Emision
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CotizarPolizaMotor recording.
    /// </summary>
    [TestModule("8c4a1cbd-6b09-440e-8acd-56d6c63d0a30", ModuleType.Recording, 1)]
    public partial class CotizarPolizaMotor : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static CotizarPolizaMotor instance = new CotizarPolizaMotor();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CotizarPolizaMotor()
        {
            Anio = "2009";
            Marca = "CHEVROLET";
            Modelo = "ASTRA";
            Actividad = "Sin Actividad";
            SumaAsegurada = "400000";
            Patente = "ZZZ999";
            Motor = "ABH134H8812";
            Chasis = "CA52MN31912";
            Producto = "A - Responsabilidad Civil Unicamente";
            NumSolicitud = "";
            ValidateNroCuenta = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CotizarPolizaMotor Instance
        {
            get { return instance; }
        }

#region Variables

        string _Actividad;

        /// <summary>
        /// Gets or sets the value of variable Actividad.
        /// </summary>
        [TestVariable("0f99b695-4057-4ca9-82f4-744864db57ef")]
        public string Actividad
        {
            get { return _Actividad; }
            set { _Actividad = value; }
        }

        string _Patente;

        /// <summary>
        /// Gets or sets the value of variable Patente.
        /// </summary>
        [TestVariable("f31e65be-c04b-49b8-a654-0a409ee27bd3")]
        public string Patente
        {
            get { return _Patente; }
            set { _Patente = value; }
        }

        string _Motor;

        /// <summary>
        /// Gets or sets the value of variable Motor.
        /// </summary>
        [TestVariable("c24923f5-80af-43be-bf56-dd993b391800")]
        public string Motor
        {
            get { return _Motor; }
            set { _Motor = value; }
        }

        string _Chasis;

        /// <summary>
        /// Gets or sets the value of variable Chasis.
        /// </summary>
        [TestVariable("add0581d-0f6a-4732-a7b4-e5d6311a345d")]
        public string Chasis
        {
            get { return _Chasis; }
            set { _Chasis = value; }
        }

        string _NumSolicitud;

        /// <summary>
        /// Gets or sets the value of variable NumSolicitud.
        /// </summary>
        [TestVariable("9d2e9547-4dfe-4277-8f22-7b60c80c7a87")]
        public string NumSolicitud
        {
            get { return _NumSolicitud; }
            set { _NumSolicitud = value; }
        }

        string _ValidateNroCuenta;

        /// <summary>
        /// Gets or sets the value of variable ValidateNroCuenta.
        /// </summary>
        [TestVariable("7cadb737-c89c-4145-ba82-5abb1f541228")]
        public string ValidateNroCuenta
        {
            get { return _ValidateNroCuenta; }
            set { _ValidateNroCuenta = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Ambiente.
        /// </summary>
        [TestVariable("e249a1a2-b157-42ff-9826-60bc615aa12c")]
        public string Ambiente
        {
            get { return repo.Ambiente; }
            set { repo.Ambiente = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Anio.
        /// </summary>
        [TestVariable("30942861-4073-4c2c-b3a7-b31ab71ded39")]
        public string Anio
        {
            get { return repo.Anio; }
            set { repo.Anio = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Marca.
        /// </summary>
        [TestVariable("21fb6e6d-0e44-42c5-9ab0-0b4f12b9845d")]
        public string Marca
        {
            get { return repo.Marca; }
            set { repo.Marca = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Modelo.
        /// </summary>
        [TestVariable("672a390d-431c-41d0-83f8-7c1ddb37b053")]
        public string Modelo
        {
            get { return repo.Modelo; }
            set { repo.Modelo = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable SumaAsegurada.
        /// </summary>
        [TestVariable("d502f83a-600a-49ba-bb72-046085ba76e7")]
        public string SumaAsegurada
        {
            get { return repo.SumaAsegurada; }
            set { repo.SumaAsegurada = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Producto.
        /// </summary>
        [TestVariable("e895e24a-b7f5-4105-b590-b73395336522")]
        public string Producto
        {
            get { return repo.Producto; }
            set { repo.Producto = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'SURA.txt_SolicitudPoliza' and assigning the part of its value captured by '[0-9]+' to variable 'NumSolicitud'.", repo.SURA.txt_SolicitudPolizaInfo, new RecordItemIndex(0));
            NumSolicitud = repo.SURA.txt_SolicitudPoliza.Element.GetAttributeValueText("InnerText", new Regex("[0-9]+"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'SURA.validate_NroCuenta' and assigning its value to variable 'ValidateNroCuenta'.", repo.SURA.validate_NroCuentaInfo, new RecordItemIndex(1));
            ValidateNroCuenta = repo.SURA.validate_NroCuenta.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", "El número de solicitud es:", new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "User", NumSolicitud, new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "User", "Para la cuenta:", new RecordItemIndex(4));
            
            // Para la cuenta:
            Report.Log(ReportLevel.Info, "User", ValidateNroCuenta, new RecordItemIndex(5));
            
            guardarNumSolicitud();
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(7));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}