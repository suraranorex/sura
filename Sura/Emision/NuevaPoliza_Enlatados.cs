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
    ///The NuevaPoliza_Enlatados recording.
    /// </summary>
    [TestModule("af96891c-ec2c-4e86-811f-e8a8a584bc0a", ModuleType.Recording, 1)]
    public partial class NuevaPoliza_Enlatados : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static NuevaPoliza_Enlatados instance = new NuevaPoliza_Enlatados();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public NuevaPoliza_Enlatados()
        {
            CodigoAgente = "2344";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static NuevaPoliza_Enlatados Instance
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

        /// <summary>
        /// Gets or sets the value of variable CodigoAgente.
        /// </summary>
        [TestVariable("adc9525d-0629-4cb8-ba1e-7631963edcb8")]
        public string CodigoAgente
        {
            get { return repo.CodigoAgente; }
            set { repo.CodigoAgente = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Enlatados.txtbox_CodigoAgente' at Center.", repo.SURA.PC.Emision.Enlatados.txtbox_CodigoAgenteInfo, new RecordItemIndex(0));
            repo.SURA.PC.Emision.Enlatados.txtbox_CodigoAgente.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.PC.Emision.Enlatados.txtbox_CodigoAgente'.", repo.SURA.PC.Emision.Enlatados.txtbox_CodigoAgenteInfo, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.SURA.PC.Emision.Enlatados.txtbox_CodigoAgente);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CodigoAgente' with focus on 'SURA.PC.Emision.Enlatados.txtbox_CodigoAgente'.", repo.SURA.PC.Emision.Enlatados.txtbox_CodigoAgenteInfo, new RecordItemIndex(2));
            repo.SURA.PC.Emision.Enlatados.txtbox_CodigoAgente.PressKeys(CodigoAgente);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.SolicitudDePolizaNueva.lbl_SolicitudesDePolizaNuevas' at Center.", repo.SURA.PC.Emision.PolizaMotor.SolicitudDePolizaNueva.lbl_SolicitudesDePolizaNuevasInfo, new RecordItemIndex(3));
            repo.SURA.PC.Emision.PolizaMotor.SolicitudDePolizaNueva.lbl_SolicitudesDePolizaNuevas.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to not exist. Associated repository item: 'SURA.PC.Emision.Enlatados.Copy_of_txtbox_CodigoAgente'", repo.SURA.PC.Emision.Enlatados.Copy_of_txtbox_CodigoAgenteInfo, new ActionTimeout(10000), new RecordItemIndex(4));
            repo.SURA.PC.Emision.Enlatados.Copy_of_txtbox_CodigoAgenteInfo.WaitForNotExists(10000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(5));
            
            // -------------------
            Report.Log(ReportLevel.Info, "Section", "-------------------", new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.SolicitudDePolizaNueva.bttn_Elegir' at 20;3.", repo.SURA.PC.Emision.PolizaMotor.SolicitudDePolizaNueva.bttn_ElegirInfo, new RecordItemIndex(7));
            repo.SURA.PC.Emision.PolizaMotor.SolicitudDePolizaNueva.bttn_Elegir.Click("20;3");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Txt_Validacion.txt_PreEvaluacion' at 64;11.", repo.SURA.PC.Txt_Validacion.txt_PreEvaluacionInfo, new RecordItemIndex(8));
            //repo.SURA.PC.Txt_Validacion.txt_PreEvaluacion.Click("64;11");
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
