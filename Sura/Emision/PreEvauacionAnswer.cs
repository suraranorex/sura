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
    ///The PreEvauacionAnswer recording.
    /// </summary>
    [TestModule("071dc85d-3814-495b-9f8f-11116b647853", ModuleType.Recording, 1)]
    public partial class PreEvauacionAnswer : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static PreEvauacionAnswer instance = new PreEvauacionAnswer();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PreEvauacionAnswer()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PreEvauacionAnswer Instance
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente2' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente2Info, new RecordItemIndex(1));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente2.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente' at 26;4.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_SiguienteInfo, new RecordItemIndex(2));
            //repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente.Click("26;4");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 20s to exist. Associated repository item: 'SURA.PC.Txt_Validacion.txt_InformacionDePoliza'", repo.SURA.PC.Txt_Validacion.txt_InformacionDePolizaInfo, new ActionTimeout(20000), new RecordItemIndex(3));
            repo.SURA.PC.Txt_Validacion.txt_InformacionDePolizaInfo.WaitForExists(20000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
