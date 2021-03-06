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
    ///The Persona_Answer recording.
    /// </summary>
    [TestModule("aacc5739-621d-48e0-a134-56103a97a9b5", ModuleType.Recording, 1)]
    public partial class Persona_Answer : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static Persona_Answer instance = new Persona_Answer();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Persona_Answer()
        {
            NumeroDocumento = "38191893";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Persona_Answer Instance
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
        /// Gets or sets the value of variable NroPoliza.
        /// </summary>
        [TestVariable("7f21a146-b56c-4b8b-84a6-3fad8d4c0caa")]
        public string NroPoliza
        {
            get { return repo.NroPoliza; }
            set { repo.NroPoliza = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable NumeroDocumento.
        /// </summary>
        [TestVariable("0ca98dd1-5c0c-4f0d-a9e8-083eecbb5db8")]
        public string NumeroDocumento
        {
            get { return repo.NumeroDocumento; }
            set { repo.NumeroDocumento = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.bttn_Siguiente' at Center.", repo.SURA.bttn_SiguienteInfo, new RecordItemIndex(0));
            repo.SURA.bttn_Siguiente.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaAP.Personas.bttn_InformacionAsegurado' at Center.", repo.SURA.PC.Emision.PolizaAP.Personas.bttn_InformacionAseguradoInfo, new RecordItemIndex(1));
            repo.SURA.PC.Emision.PolizaAP.Personas.bttn_InformacionAsegurado.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SURA.PC.Emision.PolizaAP.Personas.txtbox_NumeroDeDocumento'.", repo.SURA.PC.Emision.PolizaAP.Personas.txtbox_NumeroDeDocumentoInfo, new RecordItemIndex(2));
            repo.SURA.PC.Emision.PolizaAP.Personas.txtbox_NumeroDeDocumento.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NumeroDocumento' with focus on 'SURA.PC.Emision.PolizaAP.Personas.txtbox_NumeroDeDocumento'.", repo.SURA.PC.Emision.PolizaAP.Personas.txtbox_NumeroDeDocumentoInfo, new RecordItemIndex(3));
            repo.SURA.PC.Emision.PolizaAP.Personas.txtbox_NumeroDeDocumento.PressKeys(NumeroDocumento);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.txt_Refacturacion' at Center.", repo.SURA.PC.txt_RefacturacionInfo, new RecordItemIndex(4));
            repo.SURA.PC.txt_Refacturacion.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaAP.Personas.Copy_of_txtbox_NumeroDeDocumento'", repo.SURA.PC.Emision.PolizaAP.Personas.Copy_of_txtbox_NumeroDeDocumentoInfo, new ActionTimeout(30000), new RecordItemIndex(5));
            repo.SURA.PC.Emision.PolizaAP.Personas.Copy_of_txtbox_NumeroDeDocumentoInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SURA.bttn_Siguiente' at Center.", repo.SURA.bttn_SiguienteInfo, new RecordItemIndex(6));
            repo.SURA.bttn_Siguiente.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.bttn_Siguiente' at Center.", repo.SURA.bttn_SiguienteInfo, new RecordItemIndex(7));
            repo.SURA.bttn_Siguiente.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'SURA.txt_Personas'", repo.SURA.txt_PersonasInfo, new ActionTimeout(5000), new RecordItemIndex(8));
            repo.SURA.txt_PersonasInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.bttn_Siguiente' at Center.", repo.SURA.bttn_SiguienteInfo, new RecordItemIndex(9));
            repo.SURA.bttn_Siguiente.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
