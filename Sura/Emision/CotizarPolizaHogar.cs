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
    ///The CotizarPolizaHogar recording.
    /// </summary>
    [TestModule("0fad853c-2a01-4af8-aa83-14b926bb6e16", ModuleType.Recording, 1)]
    public partial class CotizarPolizaHogar : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static CotizarPolizaHogar instance = new CotizarPolizaHogar();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CotizarPolizaHogar()
        {
            NumSolicitud = "";
            ValidateNroCuenta = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CotizarPolizaHogar Instance
        {
            get { return instance; }
        }

#region Variables

        string _NumSolicitud;

        /// <summary>
        /// Gets or sets the value of variable NumSolicitud.
        /// </summary>
        [TestVariable("10dd4774-7aa0-4cd3-977a-6812225059ef")]
        public string NumSolicitud
        {
            get { return _NumSolicitud; }
            set { _NumSolicitud = value; }
        }

        string _ValidateNroCuenta;

        /// <summary>
        /// Gets or sets the value of variable ValidateNroCuenta.
        /// </summary>
        [TestVariable("4cadc0bf-9ee9-4f53-b574-65dbace2fd3b")]
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