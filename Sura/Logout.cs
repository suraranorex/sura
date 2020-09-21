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

namespace Sura
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Logout recording.
    /// </summary>
    [TestModule("68c8632a-235c-4edc-9f8a-e1402221543e", ModuleType.Recording, 1)]
    public partial class Logout : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SuraRepository repository.
        /// </summary>
        public static SuraRepository repo = SuraRepository.Instance;

        static Logout instance = new Logout();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Logout()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Logout Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Logout.bttn_Configuracion' at Center.", repo.SURA.Logout.bttn_ConfiguracionInfo, new RecordItemIndex(0));
            repo.SURA.Logout.bttn_Configuracion.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Logout.bttn_CerrarSesion' at Center.", repo.SURA.Logout.bttn_CerrarSesionInfo, new RecordItemIndex(1));
            repo.SURA.Logout.bttn_CerrarSesion.Click();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'SURA_ContinueOnFail.Copy_of_bttn_Aceptar' at Center.", repo.SURA_ContinueOnFail.Copy_of_bttn_AceptarInfo, new RecordItemIndex(2));
                repo.SURA_ContinueOnFail.Copy_of_bttn_Aceptar.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SURA.Login.bttn_IniciarSesion'.", repo.SURA.Login.bttn_IniciarSesionInfo, new RecordItemIndex(3));
            Validate.Exists(repo.SURA.Login.bttn_IniciarSesionInfo);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
