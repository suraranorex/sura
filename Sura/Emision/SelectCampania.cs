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
    ///The SelectCampania recording.
    /// </summary>
    [TestModule("525189de-f3b0-44ac-831e-d0536bd85db5", ModuleType.Recording, 1)]
    public partial class SelectCampania : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static SelectCampania instance = new SelectCampania();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SelectCampania()
        {
            Campania = "prueba campaña";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SelectCampania Instance
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
        /// Gets or sets the value of variable Campania.
        /// </summary>
        [TestVariable("e3bd0892-4510-4dc9-b76b-dc96b336e15d")]
        public string Campania
        {
            get { return repo.Campania; }
            set { repo.Campania = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_Campania' at Center.", repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_CampaniaInfo, new RecordItemIndex(0));
            repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_Campania.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SURA.PC.Emision.PolizaMotor.InformacionDePoliza.Select_Campania' at Center.", repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.Select_CampaniaInfo, new RecordItemIndex(1));
            repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.Select_Campania.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.InformacionDePoliza.Select_Campania' at Center.", repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.Select_CampaniaInfo, new RecordItemIndex(2));
            repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.Select_Campania.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.InformacionDePoliza.Copy_of_list_Campania'", repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.Copy_of_list_CampaniaInfo, new ActionTimeout(30000), new RecordItemIndex(3));
            repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.Copy_of_list_CampaniaInfo.WaitForNotExists(30000);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_Campania' at Center.", repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_CampaniaInfo, new RecordItemIndex(4));
            //repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_Campania.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.InformacionDePoliza.lbl_Campana' at Center.", repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.lbl_CampanaInfo, new RecordItemIndex(5));
            repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.lbl_Campana.Click();
            Delay.Milliseconds(0);
            
            // Capturas de Pantalla
            Report.Log(ReportLevel.Info, "Section", "Capturas de Pantalla", new RecordItemIndex(6));
            
            //Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(7));
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(8));
            //Delay.Duration(1000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_SiguienteInfo, new RecordItemIndex(9));
            //repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente.MoveTo();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_SiguienteInfo, new RecordItemIndex(10));
            //repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SURA.PC.Txt_Validacion.txt_ConductoresPropietarios'", repo.SURA.PC.Txt_Validacion.txt_ConductoresPropietariosInfo, new ActionTimeout(30000), new RecordItemIndex(11));
            //repo.SURA.PC.Txt_Validacion.txt_ConductoresPropietariosInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
