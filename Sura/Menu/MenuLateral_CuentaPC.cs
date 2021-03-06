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

namespace Sura.Menu
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The MenuLateral_CuentaPC recording.
    /// </summary>
    [TestModule("5bb086e1-d816-4abc-b088-2dff0422adbb", ModuleType.Recording, 1)]
    public partial class MenuLateral_CuentaPC : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static MenuLateral_CuentaPC instance = new MenuLateral_CuentaPC();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MenuLateral_CuentaPC()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MenuLateral_CuentaPC Instance
        {
            get { return instance; }
        }

#region Variables

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

            // --------------------------------Nueva Poliza
            Report.Log(ReportLevel.Info, "Section", "--------------------------------Nueva Poliza", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Menu.Lateral_Cuenta.bttn_Nuevo' at Center.", repo.SURA.PC.Menu.Lateral_Cuenta.bttn_NuevoInfo, new RecordItemIndex(1));
            repo.SURA.PC.Menu.Lateral_Cuenta.bttn_Nuevo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Menu.Lateral_Cuenta.bttn_NuevaSolicitud' at Center.", repo.SURA.PC.Menu.Lateral_Cuenta.bttn_NuevaSolicitudInfo, new RecordItemIndex(2));
            repo.SURA.PC.Menu.Lateral_Cuenta.bttn_NuevaSolicitud.Click();
            Delay.Milliseconds(0);
            
            // --------------------------------Cuando tiene saldo deudor
            Report.Log(ReportLevel.Info, "Section", "--------------------------------Cuando tiene saldo deudor", new RecordItemIndex(3));
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'SURA_ContinueOnFail.bttn_AceptarCOF' at 11;11.", repo.SURA_ContinueOnFail.bttn_AceptarCOFInfo, new RecordItemIndex(4));
                repo.SURA_ContinueOnFail.bttn_AceptarCOF.Click("11;11");
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.SolicitudDePolizaNueva.lbl_SolicitudesDePolizaNuevas'", repo.SURA.PC.Emision.PolizaMotor.SolicitudDePolizaNueva.lbl_SolicitudesDePolizaNuevasInfo, new ActionTimeout(15000), new RecordItemIndex(5));
            repo.SURA.PC.Emision.PolizaMotor.SolicitudDePolizaNueva.lbl_SolicitudesDePolizaNuevasInfo.WaitForExists(15000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
