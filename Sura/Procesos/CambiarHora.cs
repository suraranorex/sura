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

namespace Sura.Procesos
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CambiarHora recording.
    /// </summary>
    [TestModule("0a6079d9-b6a2-40f3-a85a-91c2daf275a1", ModuleType.Recording, 1)]
    public partial class CambiarHora : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static CambiarHora instance = new CambiarHora();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CambiarHora()
        {
            Fecha = "18/02/2021 19:40";
            FechaVieja = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CambiarHora Instance
        {
            get { return instance; }
        }

#region Variables

        string _Fecha;

        /// <summary>
        /// Gets or sets the value of variable Fecha.
        /// </summary>
        [TestVariable("6e772ede-eea8-4c7f-83c8-a685acfdb633")]
        public string Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }

        string _FechaVieja;

        /// <summary>
        /// Gets or sets the value of variable FechaVieja.
        /// </summary>
        [TestVariable("be547bbd-eff6-4b88-a283-df5bd29bbce2")]
        public string FechaVieja
        {
            get { return _FechaVieja; }
            set { _FechaVieja = value; }
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

            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'SURA.Procesos.txt_FechaActual' and assigning its value to variable 'FechaVieja'.", repo.SURA.Procesos.txt_FechaActualInfo, new RecordItemIndex(0));
            FechaVieja = repo.SURA.Procesos.txt_FechaActual.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Fecha' with focus on 'SURA.Procesos.input_Fecha'.", repo.SURA.Procesos.input_FechaInfo, new RecordItemIndex(1));
            repo.SURA.Procesos.input_Fecha.PressKeys(Fecha);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SURA.Procesos.input_Fecha'.", repo.SURA.Procesos.input_FechaInfo, new RecordItemIndex(2));
            repo.SURA.Procesos.input_Fecha.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Procesos.bttn_CambiarFecha' at Center.", repo.SURA.Procesos.bttn_CambiarFechaInfo, new RecordItemIndex(3));
            repo.SURA.Procesos.bttn_CambiarFecha.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to not contain the specified value $FechaVieja. Associated repository item: 'SURA.Procesos.txt_FechaActual'", repo.SURA.Procesos.txt_FechaActualInfo, new RecordItemIndex(4));
            repo.SURA.Procesos.txt_FechaActualInfo.WaitForAttributeNotContains(5000, "InnerText", FechaVieja);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(5));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
