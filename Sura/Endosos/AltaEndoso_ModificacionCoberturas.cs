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
    ///The AltaEndoso_ModificacionCoberturas recording.
    /// </summary>
    [TestModule("a4f3b798-b949-4c95-901f-93f008eee94b", ModuleType.Recording, 1)]
    public partial class AltaEndoso_ModificacionCoberturas : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static AltaEndoso_ModificacionCoberturas instance = new AltaEndoso_ModificacionCoberturas();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AltaEndoso_ModificacionCoberturas()
        {
            TipoEndoso = "Modificación de Coberturas";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AltaEndoso_ModificacionCoberturas Instance
        {
            get { return instance; }
        }

#region Variables

        string _TipoEndoso;

        /// <summary>
        /// Gets or sets the value of variable TipoEndoso.
        /// </summary>
        [TestVariable("25161770-feca-4e80-9f3b-e3e17c87c7c1")]
        public string TipoEndoso
        {
            get { return _TipoEndoso; }
            set { _TipoEndoso = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Endosos.Generales.txtbox_TipoEndoso' at Center.", repo.SURA.PC.Endosos.Generales.txtbox_TipoEndosoInfo, new RecordItemIndex(0));
            repo.SURA.PC.Endosos.Generales.txtbox_TipoEndoso.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$TipoEndoso' with focus on 'SURA.PC.Endosos.Generales.txtbox_TipoEndoso'.", repo.SURA.PC.Endosos.Generales.txtbox_TipoEndosoInfo, new RecordItemIndex(1));
            repo.SURA.PC.Endosos.Generales.txtbox_TipoEndoso.PressKeys(TipoEndoso);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SURA.PC.Endosos.Generales.txtbox_TipoEndoso'.", repo.SURA.PC.Endosos.Generales.txtbox_TipoEndosoInfo, new RecordItemIndex(2));
            repo.SURA.PC.Endosos.Generales.txtbox_TipoEndoso.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Endosos.Generales.Copy_of_txtbox_TipoEndoso'", repo.SURA.PC.Endosos.Generales.Copy_of_txtbox_TipoEndosoInfo, new ActionTimeout(45000), new RecordItemIndex(3));
            repo.SURA.PC.Endosos.Generales.Copy_of_txtbox_TipoEndosoInfo.WaitForNotExists(45000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Endosos.Generales.bttn_Siguiente' at Center.", repo.SURA.PC.Endosos.Generales.bttn_SiguienteInfo, new RecordItemIndex(4));
            repo.SURA.PC.Endosos.Generales.bttn_Siguiente.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to exist. Associated repository item: 'SURA.PC.Txt_Validacion.title_InformacionDePoliza'", repo.SURA.PC.Txt_Validacion.title_InformacionDePolizaInfo, new ActionTimeout(45000), new RecordItemIndex(5));
            repo.SURA.PC.Txt_Validacion.title_InformacionDePolizaInfo.WaitForExists(45000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
