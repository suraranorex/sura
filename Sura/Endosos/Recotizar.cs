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
    ///The Recotizar recording.
    /// </summary>
    [TestModule("d0d94ad1-cc59-4a25-9a53-cf5315aaa9d7", ModuleType.Recording, 1)]
    public partial class Recotizar : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static Recotizar instance = new Recotizar();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recotizar()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recotizar Instance
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Cotizar' at 13;1.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_CotizarInfo, new RecordItemIndex(1));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Cotizar.Click("13;1");
            Delay.Milliseconds(0);
            
            AprobacionBloqueo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to exist. Associated repository item: 'SURA.PC.Endosos.Txt_Validacion.txt_Cotizacion'", repo.SURA.PC.Endosos.Txt_Validacion.txt_CotizacionInfo, new ActionTimeout(45000), new RecordItemIndex(3));
            repo.SURA.PC.Endosos.Txt_Validacion.txt_CotizacionInfo.WaitForExists(45000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
