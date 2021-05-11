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
    ///The BuscarGrupos recording.
    /// </summary>
    [TestModule("ccb0676d-cbbf-4ccf-866a-4c5daaaf449f", ModuleType.Recording, 1)]
    public partial class BuscarGrupos : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static BuscarGrupos instance = new BuscarGrupos();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BuscarGrupos()
        {
            CodigoAgente = "6965";
            NUM_GRUPO = "Corporativos Directo";
            Ambiente = "i-preproducciongestion.segurossura.com.ar";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BuscarGrupos Instance
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

        /// <summary>
        /// Gets or sets the value of variable NUM_GRUPO.
        /// </summary>
        [TestVariable("83067c29-0671-4e04-b81a-f3a234251e38")]
        public string NUM_GRUPO
        {
            get { return repo.NUM_GRUPO; }
            set { repo.NUM_GRUPO = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CodigoAgente.
        /// </summary>
        [TestVariable("82173b09-8bbf-4e2e-8375-40886c9c86be")]
        public string CodigoAgente
        {
            get { return repo.CodigoAgente; }
            set { repo.CodigoAgente = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Enlatados.txtbox_UnidadDeNegocio' at Center.", repo.SURA.PC.Emision.Enlatados.txtbox_UnidadDeNegocioInfo, new RecordItemIndex(0));
            repo.SURA.PC.Emision.Enlatados.txtbox_UnidadDeNegocio.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.PC.Emision.Enlatados.txtbox_UnidadDeNegocio'.", repo.SURA.PC.Emision.Enlatados.txtbox_UnidadDeNegocioInfo, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.SURA.PC.Emision.Enlatados.txtbox_UnidadDeNegocio);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'SURA.PC.Emision.Enlatados.txtbox_UnidadDeNegocio'.", repo.SURA.PC.Emision.Enlatados.txtbox_UnidadDeNegocioInfo, new RecordItemIndex(2));
            repo.SURA.PC.Emision.Enlatados.txtbox_UnidadDeNegocio.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.PC.Emision.Enlatados.txtbox_CodigoAgente'.", repo.SURA.PC.Emision.Enlatados.txtbox_CodigoAgenteInfo, new RecordItemIndex(3));
            Keyboard.PrepareFocus(repo.SURA.PC.Emision.Enlatados.txtbox_CodigoAgente);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CodigoAgente' with focus on 'SURA.PC.Emision.Enlatados.txtbox_CodigoAgente'.", repo.SURA.PC.Emision.Enlatados.txtbox_CodigoAgenteInfo, new RecordItemIndex(4));
            repo.SURA.PC.Emision.Enlatados.txtbox_CodigoAgente.PressKeys(CodigoAgente);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 20s to not exist. Associated repository item: 'SURA.PC.Emision.Enlatados.Copy_of_txtbox_CodigoAgente'", repo.SURA.PC.Emision.Enlatados.Copy_of_txtbox_CodigoAgenteInfo, new ActionTimeout(20000), new RecordItemIndex(5));
            repo.SURA.PC.Emision.Enlatados.Copy_of_txtbox_CodigoAgenteInfo.WaitForNotExists(20000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Enlatados.bttn_BuscarGrupo2' at Center.", repo.SURA.PC.Emision.Enlatados.bttn_BuscarGrupo2Info, new RecordItemIndex(6));
            repo.SURA.PC.Emision.Enlatados.bttn_BuscarGrupo2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(7));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Enlatados.bttn_Seleccionar' at Center.", repo.SURA.PC.Emision.Enlatados.bttn_SeleccionarInfo, new RecordItemIndex(8));
            repo.SURA.PC.Emision.Enlatados.bttn_Seleccionar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 20s to exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.SolicitudDePolizaNueva.lbl_SolicitudesDePolizaNuevas'", repo.SURA.PC.Emision.PolizaMotor.SolicitudDePolizaNueva.lbl_SolicitudesDePolizaNuevasInfo, new ActionTimeout(20000), new RecordItemIndex(9));
            repo.SURA.PC.Emision.PolizaMotor.SolicitudDePolizaNueva.lbl_SolicitudesDePolizaNuevasInfo.WaitForExists(20000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
