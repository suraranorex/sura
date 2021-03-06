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

namespace Sura.Validaciones
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SinValidacion_SumaAsegurada recording.
    /// </summary>
    [TestModule("76d95362-e9d5-4090-8094-205e7a5d3c35", ModuleType.Recording, 1)]
    public partial class SinValidacion_SumaAsegurada : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static SinValidacion_SumaAsegurada instance = new SinValidacion_SumaAsegurada();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SinValidacion_SumaAsegurada()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SinValidacion_SumaAsegurada Instance
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

            // Cotizar
            Report.Log(ReportLevel.Info, "Section", "Cotizar", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Cotizar' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_CotizarInfo, new RecordItemIndex(1));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Cotizar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Validaciones.txt_VehiculosPantalla'", repo.SURA.PC.Emision.PolizaMotor.Validaciones.txt_VehiculosPantallaInfo, new ActionTimeout(30000), new RecordItemIndex(2));
            repo.SURA.PC.Emision.PolizaMotor.Validaciones.txt_VehiculosPantallaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'SURA.PC.Emision.PolizaMotor.Validaciones.txt_ValidacionCotizacion_SumaAsegurada'.", repo.SURA.PC.Emision.PolizaMotor.Validaciones.txt_ValidacionCotizacion_SumaAseguradaInfo, new RecordItemIndex(3));
            Validate.NotExists(repo.SURA.PC.Emision.PolizaMotor.Validaciones.txt_ValidacionCotizacion_SumaAseguradaInfo);
            Delay.Milliseconds(0);
            
            // Emitir
            Report.Log(ReportLevel.Info, "Section", "Emitir", new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_EmitirPoliza' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_EmitirPolizaInfo, new RecordItemIndex(5));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_EmitirPoliza.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Aceptar' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_AceptarInfo, new RecordItemIndex(6));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Aceptar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Validaciones.txt_CotizacionPantalla'", repo.SURA.PC.Emision.PolizaMotor.Validaciones.txt_CotizacionPantallaInfo, new ActionTimeout(30000), new RecordItemIndex(7));
            repo.SURA.PC.Emision.PolizaMotor.Validaciones.txt_CotizacionPantallaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'SURA.PC.Emision.PolizaMotor.Validaciones.txt_ValidacionEmision_SumaAsegurada'.", repo.SURA.PC.Emision.PolizaMotor.Validaciones.txt_ValidacionEmision_SumaAseguradaInfo, new RecordItemIndex(8));
            Validate.NotExists(repo.SURA.PC.Emision.PolizaMotor.Validaciones.txt_ValidacionEmision_SumaAseguradaInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
