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
    ///The MenuSuperior_SolicitudPoliza recording.
    /// </summary>
    [TestModule("522c1674-af8e-481b-94f3-1af91492e908", ModuleType.Recording, 1)]
    public partial class MenuSuperior_SolicitudPoliza : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static MenuSuperior_SolicitudPoliza instance = new MenuSuperior_SolicitudPoliza();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MenuSuperior_SolicitudPoliza()
        {
            NumSolicitudPoliza = "0010490216";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MenuSuperior_SolicitudPoliza Instance
        {
            get { return instance; }
        }

#region Variables

        string _NumSolicitudPoliza;

        /// <summary>
        /// Gets or sets the value of variable NumSolicitudPoliza.
        /// </summary>
        [TestVariable("96c83125-ae54-4949-bedd-c74964a99cc1")]
        public string NumSolicitudPoliza
        {
            get { return _NumSolicitudPoliza; }
            set { _NumSolicitudPoliza = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.bttn_Poliza' at CenterRight.", repo.SURA.bttn_PolizaInfo, new RecordItemIndex(0));
            repo.SURA.bttn_Poliza.Click(Location.CenterRight);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NumSolicitudPoliza' with focus on 'SURA.txtbox_NumSolicitudPoliza'.", repo.SURA.txtbox_NumSolicitudPolizaInfo, new RecordItemIndex(1));
            repo.SURA.txtbox_NumSolicitudPoliza.PressKeys(NumSolicitudPoliza);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SURA.txtbox_NumSolicitudPoliza'.", repo.SURA.txtbox_NumSolicitudPolizaInfo, new RecordItemIndex(2));
            repo.SURA.txtbox_NumSolicitudPoliza.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SURA.txt_InformacionDePoliza'", repo.SURA.txt_InformacionDePolizaInfo, new ActionTimeout(30000), new RecordItemIndex(3));
            repo.SURA.txt_InformacionDePolizaInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
