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
    ///The InformacionDePolizaEnlatadosAP recording.
    /// </summary>
    [TestModule("b4793a0c-73e2-4915-a451-f14c29eba9eb", ModuleType.Recording, 1)]
    public partial class InformacionDePolizaEnlatadosAP : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static InformacionDePolizaEnlatadosAP instance = new InformacionDePolizaEnlatadosAP();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InformacionDePolizaEnlatadosAP()
        {
            Plan = "PLAN A ver. 1";
            MetodoDePago = "Cupón";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InformacionDePolizaEnlatadosAP Instance
        {
            get { return instance; }
        }

#region Variables

        string _Plan;

        /// <summary>
        /// Gets or sets the value of variable Plan.
        /// </summary>
        [TestVariable("df7b1e60-77d5-470f-80ab-8b783ab4ab5c")]
        public string Plan
        {
            get { return _Plan; }
            set { _Plan = value; }
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

        /// <summary>
        /// Gets or sets the value of variable OPCION_PAGOCUOTAS.
        /// </summary>
        [TestVariable("b047dcae-a43e-4341-b82d-66d844bb7960")]
        public string OPCION_PAGOCUOTAS
        {
            get { return repo.OPCION_PAGOCUOTAS; }
            set { repo.OPCION_PAGOCUOTAS = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable MetodoDePago.
        /// </summary>
        [TestVariable("f774390e-cc74-4508-8c0f-778935e7c0b0")]
        public string MetodoDePago
        {
            get { return repo.MetodoDePago; }
            set { repo.MetodoDePago = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.txtxbox_Plan' at Center.", repo.SURA.txtxbox_PlanInfo, new RecordItemIndex(0));
            repo.SURA.txtxbox_Plan.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Plan' with focus on 'SURA.txtxbox_Plan'.", repo.SURA.txtxbox_PlanInfo, new RecordItemIndex(1));
            repo.SURA.txtxbox_Plan.PressKeys(Plan);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.txt_InformacionDePoliza' at Center.", repo.SURA.txt_InformacionDePolizaInfo, new RecordItemIndex(2));
            repo.SURA.txt_InformacionDePoliza.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.Copy_of_txtxbox_Plan'", repo.SURA.Copy_of_txtxbox_PlanInfo, new ActionTimeout(30000), new RecordItemIndex(3));
            repo.SURA.Copy_of_txtxbox_PlanInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$MetodoDePago' with focus on 'SURA.PC.Emision.Generales.InformacionDePoliza.list_MetodoDePago'.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.list_MetodoDePagoInfo, new RecordItemIndex(4));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.list_MetodoDePago.PressKeys(MetodoDePago);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Txt_Validacion.txt_InformacionDePoliza' at Center.", repo.SURA.PC.Txt_Validacion.txt_InformacionDePolizaInfo, new RecordItemIndex(5));
            repo.SURA.PC.Txt_Validacion.txt_InformacionDePoliza.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to not exist. Associated repository item: 'SURA.PC.Emision.Generales.InformacionDePoliza.Copy_of_list_MetodoDePago'", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Copy_of_list_MetodoDePagoInfo, new ActionTimeout(10000), new RecordItemIndex(6));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.Copy_of_list_MetodoDePagoInfo.WaitForNotExists(10000);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.rb_PagoCuotas' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.rb_PagoCuotasInfo, new RecordItemIndex(7));
            //repo.SURA.PC.Emision.Generales.InformacionDePoliza.rb_PagoCuotas.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'SURA.PC.Emision.Generales.InformacionDePoliza.option_Pago'", repo.SURA.PC.Emision.Generales.InformacionDePoliza.option_PagoInfo, new ActionTimeout(10000), new RecordItemIndex(8));
            //repo.SURA.PC.Emision.Generales.InformacionDePoliza.option_PagoInfo.WaitForExists(10000);
            
            //Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(9));
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(10));
            //Delay.Duration(2000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente2' at 48;4.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente2Info, new RecordItemIndex(11));
            //repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente2.Click("48;4");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente' at 48;4.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_SiguienteInfo, new RecordItemIndex(12));
            //repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente.Click("48;4");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 20s to exist. Associated repository item: 'SURA.PC.Txt_Validacion.txt_Enlatada_Personas_Vivenda'", repo.SURA.PC.Txt_Validacion.txt_Enlatada_Personas_VivendaInfo, new ActionTimeout(20000), new RecordItemIndex(13));
            //repo.SURA.PC.Txt_Validacion.txt_Enlatada_Personas_VivendaInfo.WaitForExists(20000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
