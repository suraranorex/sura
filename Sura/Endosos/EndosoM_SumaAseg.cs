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

namespace Sura.Endosos
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EndosoM_SumaAseg recording.
    /// </summary>
    [TestModule("784aa57b-4ed0-413a-b2a6-43210f76ff7e", ModuleType.Recording, 1)]
    public partial class EndosoM_SumaAseg : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static EndosoM_SumaAseg instance = new EndosoM_SumaAseg();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EndosoM_SumaAseg()
        {
            NuevaSumaAsegurada = "430000";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EndosoM_SumaAseg Instance
        {
            get { return instance; }
        }

#region Variables

        string _NuevaSumaAsegurada;

        /// <summary>
        /// Gets or sets the value of variable NuevaSumaAsegurada.
        /// </summary>
        [TestVariable("74765a03-ffb9-4b7c-8783-a056ed1a011d")]
        public string NuevaSumaAsegurada
        {
            get { return _NuevaSumaAsegurada; }
            set { _NuevaSumaAsegurada = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Menu.optionMenu_Vehiculos' at 38;6.", repo.SURA.PC.Menu.optionMenu_VehiculosInfo, new RecordItemIndex(0));
            repo.SURA.PC.Menu.optionMenu_Vehiculos.Click("38;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SURA.PC.Txt_Validacion.txt_Vehiculos'", repo.SURA.PC.Txt_Validacion.txt_VehiculosInfo, new ActionTimeout(30000), new RecordItemIndex(1));
            repo.SURA.PC.Txt_Validacion.txt_VehiculosInfo.WaitForExists(30000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAseguradaInfo, new RecordItemIndex(3));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAseguradaInfo, new RecordItemIndex(4));
            Keyboard.PrepareFocus(repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NuevaSumaAsegurada' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAseguradaInfo, new RecordItemIndex(5));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada.PressKeys(NuevaSumaAsegurada);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Txt_Validacion.txt_Vehiculos' at Center.", repo.SURA.PC.Txt_Validacion.txt_VehiculosInfo, new RecordItemIndex(6));
            repo.SURA.PC.Txt_Validacion.txt_Vehiculos.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_SumaAsegurada'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_SumaAseguradaInfo, new ActionTimeout(30000), new RecordItemIndex(7));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_SumaAseguradaInfo.WaitForNotExists(30000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(8));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
