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
    ///The InformacionPolizaEndosoABM recording.
    /// </summary>
    [TestModule("2f71d7ed-c4f2-4748-adef-bf2c5378698b", ModuleType.Recording, 1)]
    public partial class InformacionPolizaEndosoABM : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static InformacionPolizaEndosoABM instance = new InformacionPolizaEndosoABM();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InformacionPolizaEndosoABM()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InformacionPolizaEndosoABM Instance
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

            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(1));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente2' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente2Info, new RecordItemIndex(2));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente2.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente2' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente2Info, new RecordItemIndex(3));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 50s to not exist. Associated repository item: 'SURA.PC.Emision.Generales.InformacionDePoliza.Botones.Copy_of_bttn_Siguiente2'", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.Copy_of_bttn_Siguiente2Info, new ActionTimeout(50000), new RecordItemIndex(4));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.Copy_of_bttn_Siguiente2Info.WaitForNotExists(50000);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 40s to exist. Associated repository item: 'SURA.PC.Txt_Validacion.txt_ConductoresPropietarios'", repo.SURA.PC.Txt_Validacion.txt_ConductoresPropietariosInfo, new ActionTimeout(40000), new RecordItemIndex(5));
            repo.SURA.PC.Txt_Validacion.txt_ConductoresPropietariosInfo.WaitForExists(40000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
