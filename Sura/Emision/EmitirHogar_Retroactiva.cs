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
    ///The EmitirHogar_Retroactiva recording.
    /// </summary>
    [TestModule("9abaff35-b8f0-4c43-9f16-50f60f0aabf5", ModuleType.Recording, 1)]
    public partial class EmitirHogar_Retroactiva : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static EmitirHogar_Retroactiva instance = new EmitirHogar_Retroactiva();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EmitirHogar_Retroactiva()
        {
            NumPolizaEmitida = "";
            ValidateNroCuenta = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EmitirHogar_Retroactiva Instance
        {
            get { return instance; }
        }

#region Variables

        string _NumPolizaEmitida;

        /// <summary>
        /// Gets or sets the value of variable NumPolizaEmitida.
        /// </summary>
        [TestVariable("7f593bf8-c021-4a2e-97c2-a590844406a6")]
        public string NumPolizaEmitida
        {
            get { return _NumPolizaEmitida; }
            set { _NumPolizaEmitida = value; }
        }

        string _ValidateNroCuenta;

        /// <summary>
        /// Gets or sets the value of variable ValidateNroCuenta.
        /// </summary>
        [TestVariable("8f46347d-0f5d-4622-b418-ed8ead2941d5")]
        public string ValidateNroCuenta
        {
            get { return _ValidateNroCuenta; }
            set { _ValidateNroCuenta = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaHogar.Hogar_NoEnlatado.EmitirPoliza' at Center.", repo.SURA.PC.Emision.PolizaHogar.Hogar_NoEnlatado.EmitirPolizaInfo, new RecordItemIndex(0));
            repo.SURA.PC.Emision.PolizaHogar.Hogar_NoEnlatado.EmitirPoliza.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaHogar.Hogar_NoEnlatado.bttn_Aceptar' at Center.", repo.SURA.PC.Emision.PolizaHogar.Hogar_NoEnlatado.bttn_AceptarInfo, new RecordItemIndex(2));
            repo.SURA.PC.Emision.PolizaHogar.Hogar_NoEnlatado.bttn_Aceptar.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 20s to exist. Associated repository item: 'SURA.PC.Emision.PolizaHogar.Hogar_NoEnlatado.PolizaContratada'", repo.SURA.PC.Emision.PolizaHogar.Hogar_NoEnlatado.PolizaContratadaInfo, new ActionTimeout(20000), new RecordItemIndex(3));
            //repo.SURA.PC.Emision.PolizaHogar.Hogar_NoEnlatado.PolizaContratadaInfo.WaitForExists(20000);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(4));
            //Delay.Duration(3000, false);
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'SURA_ContinueOnFail.btn_Detalles' at Center.", repo.SURA_ContinueOnFail.btn_DetallesInfo, new RecordItemIndex(5));
                repo.SURA_ContinueOnFail.btn_Detalles.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA_ContinueOnFail.btn_AprobacionEspecial' at Center.", repo.SURA_ContinueOnFail.btn_AprobacionEspecialInfo, new RecordItemIndex(6));
            repo.SURA_ContinueOnFail.btn_AprobacionEspecial.Click();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'SURA_ContinueOnFail.bttn_AceptarCOF' at Center.", repo.SURA_ContinueOnFail.bttn_AceptarCOFInfo, new RecordItemIndex(7));
                repo.SURA_ContinueOnFail.bttn_AceptarCOF.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA_ContinueOnFail.bttn_Aceptar4' at Center.", repo.SURA_ContinueOnFail.bttn_Aceptar4Info, new RecordItemIndex(8));
            repo.SURA_ContinueOnFail.bttn_Aceptar4.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaHogar.Hogar_NoEnlatado.EmitirPoliza' at Center.", repo.SURA.PC.Emision.PolizaHogar.Hogar_NoEnlatado.EmitirPolizaInfo, new RecordItemIndex(9));
            repo.SURA.PC.Emision.PolizaHogar.Hogar_NoEnlatado.EmitirPoliza.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(10));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaHogar.Hogar_NoEnlatado.bttn_Aceptar' at Center.", repo.SURA.PC.Emision.PolizaHogar.Hogar_NoEnlatado.bttn_AceptarInfo, new RecordItemIndex(11));
            repo.SURA.PC.Emision.PolizaHogar.Hogar_NoEnlatado.bttn_Aceptar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 20s to exist. Associated repository item: 'SURA.PC.Emision.PolizaHogar.Hogar_NoEnlatado.PolizaContratada'", repo.SURA.PC.Emision.PolizaHogar.Hogar_NoEnlatado.PolizaContratadaInfo, new ActionTimeout(20000), new RecordItemIndex(12));
            repo.SURA.PC.Emision.PolizaHogar.Hogar_NoEnlatado.PolizaContratadaInfo.WaitForExists(20000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(13));
            
            // La poliza emitida es:
            Report.Log(ReportLevel.Info, "Section", "La poliza emitida es:", new RecordItemIndex(14));
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(15));
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'SURA.PC.Emision.Generales.InformacionDePoliza.Botones.NumeroDePolizaEmitida' and assigning the part of its value captured by '[0-9]+' to variable 'NumPolizaEmitida'.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.NumeroDePolizaEmitidaInfo, new RecordItemIndex(16));
            NumPolizaEmitida = repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.NumeroDePolizaEmitida.Element.GetAttributeValueText("InnerText", new Regex("[0-9]+"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'SURA.validate_NroCuenta' and assigning its value to variable 'ValidateNroCuenta'.", repo.SURA.validate_NroCuentaInfo, new RecordItemIndex(17));
            ValidateNroCuenta = repo.SURA.validate_NroCuenta.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", "El número de poliza emitida es:", new RecordItemIndex(18));
            
            Report.Log(ReportLevel.Info, "User", NumPolizaEmitida, new RecordItemIndex(19));
            
            Report.Log(ReportLevel.Info, "User", "Para la cuenta:", new RecordItemIndex(20));
            
            Report.Log(ReportLevel.Info, "User", ValidateNroCuenta, new RecordItemIndex(21));
            
            guardarNumPoliza();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
