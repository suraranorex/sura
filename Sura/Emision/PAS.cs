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
    ///The PAS recording.
    /// </summary>
    [TestModule("bb1d5663-fb97-46eb-8363-c889c495c006", ModuleType.Recording, 1)]
    public partial class PAS : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static PAS instance = new PAS();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PAS()
        {
            CodPASCuenta = "2344";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PAS Instance
        {
            get { return instance; }
        }

#region Variables

        string _CodPASCuenta;

        /// <summary>
        /// Gets or sets the value of variable CodPASCuenta.
        /// </summary>
        [TestVariable("4583d533-055e-4288-ae6a-a66d6c9e3e0b")]
        public string CodPASCuenta
        {
            get { return _CodPASCuenta; }
            set { _CodPASCuenta = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.SolicitudDePolizaNueva.CodPASCuenta' at Center.", repo.SURA.PC.Emision.PolizaMotor.SolicitudDePolizaNueva.CodPASCuentaInfo, new RecordItemIndex(0));
            repo.SURA.PC.Emision.PolizaMotor.SolicitudDePolizaNueva.CodPASCuenta.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'SURA.PC.Emision.PolizaMotor.SolicitudDePolizaNueva.CodPASCuenta' and assigning its value to variable 'CodPASCuenta'.", repo.SURA.PC.Emision.PolizaMotor.SolicitudDePolizaNueva.CodPASCuentaInfo, new RecordItemIndex(1));
            CodPASCuenta = repo.SURA.PC.Emision.PolizaMotor.SolicitudDePolizaNueva.CodPASCuenta.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", CodPASCuenta, new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(3));
            Delay.Duration(300, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
