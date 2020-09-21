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
    ///The Cant_Cuotas recording.
    /// </summary>
    [TestModule("b72675f6-1250-4843-966e-038436ac00a4", ModuleType.Recording, 1)]
    public partial class Cant_Cuotas : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static Cant_Cuotas instance = new Cant_Cuotas();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Cant_Cuotas()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Cant_Cuotas Instance
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
        /// Gets or sets the value of variable OPCION_PAGOCUOTAS.
        /// </summary>
        [TestVariable("b047dcae-a43e-4341-b82d-66d844bb7960")]
        public string OPCION_PAGOCUOTAS
        {
            get { return repo.OPCION_PAGOCUOTAS; }
            set { repo.OPCION_PAGOCUOTAS = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.rb_PagoCuotas' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.rb_PagoCuotasInfo, new RecordItemIndex(0));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.rb_PagoCuotas.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Lbl_DetallesDeLaPoliza' at Center.", repo.SURA.Lbl_DetallesDeLaPolizaInfo, new RecordItemIndex(1));
            repo.SURA.Lbl_DetallesDeLaPoliza.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 50s to exist. Associated repository item: 'SURA.PC.Emision.Generales.InformacionDePoliza.option_Pago'", repo.SURA.PC.Emision.Generales.InformacionDePoliza.option_PagoInfo, new ActionTimeout(50000), new RecordItemIndex(2));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.option_PagoInfo.WaitForExists(50000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Lbl_DetallesDeLaPoliza' at UpperRight.", repo.SURA.Lbl_DetallesDeLaPolizaInfo, new RecordItemIndex(3));
            repo.SURA.Lbl_DetallesDeLaPoliza.Click(Location.UpperRight);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
