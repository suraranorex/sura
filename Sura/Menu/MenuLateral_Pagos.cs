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
    ///The MenuLateral_Pagos recording.
    /// </summary>
    [TestModule("23aeaf2b-8487-4ae2-b4be-7f03a0883577", ModuleType.Recording, 1)]
    public partial class MenuLateral_Pagos : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static MenuLateral_Pagos instance = new MenuLateral_Pagos();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MenuLateral_Pagos()
        {
            NUMPOLIZA_REVERTIR = "12420005077";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MenuLateral_Pagos Instance
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
        /// Gets or sets the value of variable NUMPOLIZA_REVERTIR.
        /// </summary>
        [TestVariable("a79bcfcb-2886-4ecb-b616-863668223404")]
        public string NUMPOLIZA_REVERTIR
        {
            get { return repo.NUMPOLIZA_REVERTIR; }
            set { repo.NUMPOLIZA_REVERTIR = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.BC.Reversa.bttnLateral_Pagos' at Center.", repo.SURA.BC.Reversa.bttnLateral_PagosInfo, new RecordItemIndex(0));
            repo.SURA.BC.Reversa.bttnLateral_Pagos.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SURA.BC.Reversa.txt_Pagos'", repo.SURA.BC.Reversa.txt_PagosInfo, new ActionTimeout(30000), new RecordItemIndex(1));
            repo.SURA.BC.Reversa.txt_PagosInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.BC.Reversa.bttn_Acciones' at Center.", repo.SURA.BC.Reversa.bttn_AccionesInfo, new RecordItemIndex(2));
            repo.SURA.BC.Reversa.bttn_Acciones.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.BC.Reversa.bttn_Revertir' at Center.", repo.SURA.BC.Reversa.bttn_RevertirInfo, new RecordItemIndex(3));
            //repo.SURA.BC.Reversa.bttn_Revertir.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'r'.", new RecordItemIndex(4));
            Keyboard.Press("r");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(5));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SURA.BC.Reversa.txt_ReversionDePago'", repo.SURA.BC.Reversa.txt_ReversionDePagoInfo, new ActionTimeout(30000), new RecordItemIndex(6));
            repo.SURA.BC.Reversa.txt_ReversionDePagoInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
