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
    ///The PolizasVigentesOtroGrupoComercial recording.
    /// </summary>
    [TestModule("5d8a2599-76d6-425c-8163-6424fe941388", ModuleType.Recording, 1)]
    public partial class PolizasVigentesOtroGrupoComercial : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static PolizasVigentesOtroGrupoComercial instance = new PolizasVigentesOtroGrupoComercial();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PolizasVigentesOtroGrupoComercial()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PolizasVigentesOtroGrupoComercial Instance
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
        /// Gets or sets the value of variable TIPOPOLIZA.
        /// </summary>
        [TestVariable("3c2b5907-735e-42e1-87ab-42197132c013")]
        public string TIPOPOLIZA
        {
            get { return repo.TIPOPOLIZA; }
            set { repo.TIPOPOLIZA = value; }
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(0));
            Delay.Duration(5000, false);
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'SURA.PC.Emision.PolizaMotor.SolicitudDePolizaNueva.bttn_Elegir' at Center.", repo.SURA.PC.Emision.PolizaMotor.SolicitudDePolizaNueva.bttn_ElegirInfo, new RecordItemIndex(1));
                repo.SURA.PC.Emision.PolizaMotor.SolicitudDePolizaNueva.bttn_Elegir.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
