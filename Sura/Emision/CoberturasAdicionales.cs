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
    ///The CoberturasAdicionales recording.
    /// </summary>
    [TestModule("ddf6ef14-5eb8-47b3-9af0-e5089e599508", ModuleType.Recording, 1)]
    public partial class CoberturasAdicionales : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static CoberturasAdicionales instance = new CoberturasAdicionales();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CoberturasAdicionales()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CoberturasAdicionales Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.SolapaCoberturasAdicionales' at Center.", repo.SURA.SolapaCoberturasAdicionalesInfo, new RecordItemIndex(0));
            repo.SURA.SolapaCoberturasAdicionales.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.CoberturasAdicionales.OptionDaniosCerradura' at 7;7.", repo.SURA.PC.Emision.PolizaMotor.CoberturasAdicionales.OptionDaniosCerraduraInfo, new RecordItemIndex(1));
            //repo.SURA.PC.Emision.PolizaMotor.CoberturasAdicionales.OptionDaniosCerradura.Click("7;7");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Txt_Validacion.txt_Vehiculos1' at Center.", repo.SURA.PC.Txt_Validacion.txt_Vehiculos1Info, new RecordItemIndex(2));
            //repo.SURA.PC.Txt_Validacion.txt_Vehiculos1.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.CoberturasAdicionales.Copy_of_OptionDaniosCerradura'", repo.SURA.PC.Emision.PolizaMotor.CoberturasAdicionales.Copy_of_OptionDaniosCerraduraInfo, new ActionTimeout(30000), new RecordItemIndex(3));
            //repo.SURA.PC.Emision.PolizaMotor.CoberturasAdicionales.Copy_of_OptionDaniosCerraduraInfo.WaitForNotExists(30000);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.CoberturasAdicionales.OptionDanioPorGranizo' at 5;7.", repo.SURA.PC.Emision.PolizaMotor.CoberturasAdicionales.OptionDanioPorGranizoInfo, new RecordItemIndex(4));
            //repo.SURA.PC.Emision.PolizaMotor.CoberturasAdicionales.OptionDanioPorGranizo.Click("5;7");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Txt_Validacion.txt_Vehiculos1' at Center.", repo.SURA.PC.Txt_Validacion.txt_Vehiculos1Info, new RecordItemIndex(5));
            //repo.SURA.PC.Txt_Validacion.txt_Vehiculos1.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.CoberturasAdicionales.Copy_of_OptionDanioPorGranizo'", repo.SURA.PC.Emision.PolizaMotor.CoberturasAdicionales.Copy_of_OptionDanioPorGranizoInfo, new ActionTimeout(30000), new RecordItemIndex(6));
            //repo.SURA.PC.Emision.PolizaMotor.CoberturasAdicionales.Copy_of_OptionDanioPorGranizoInfo.WaitForNotExists(30000);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.CoberturasAdicionales.OptionCamposPetroliferos' at 6;7.", repo.SURA.PC.Emision.PolizaMotor.CoberturasAdicionales.OptionCamposPetroliferosInfo, new RecordItemIndex(7));
            //repo.SURA.PC.Emision.PolizaMotor.CoberturasAdicionales.OptionCamposPetroliferos.Click("6;7");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Txt_Validacion.txt_Vehiculos1' at Center.", repo.SURA.PC.Txt_Validacion.txt_Vehiculos1Info, new RecordItemIndex(8));
            //repo.SURA.PC.Txt_Validacion.txt_Vehiculos1.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.CoberturasAdicionales.Copy_of_OptionCamposPetroliferos'", repo.SURA.PC.Emision.PolizaMotor.CoberturasAdicionales.Copy_of_OptionCamposPetroliferosInfo, new ActionTimeout(30000), new RecordItemIndex(9));
            //repo.SURA.PC.Emision.PolizaMotor.CoberturasAdicionales.Copy_of_OptionCamposPetroliferosInfo.WaitForNotExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
