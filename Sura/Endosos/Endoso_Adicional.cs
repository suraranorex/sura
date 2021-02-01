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
    ///The Endoso_Adicional recording.
    /// </summary>
    [TestModule("b4ea2874-0be6-4be0-b1e7-a4f7d629c87d", ModuleType.Recording, 1)]
    public partial class Endoso_Adicional : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static Endoso_Adicional instance = new Endoso_Adicional();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Endoso_Adicional()
        {
            Ambiente = "preproducciongestion.segurossura.com.ar";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Endoso_Adicional Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.txt_ComisionesDescuentos' at Center.", repo.SURA.txt_ComisionesDescuentosInfo, new RecordItemIndex(0));
            repo.SURA.txt_ComisionesDescuentos.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 40s to exist. Associated repository item: 'SURA.PC.Endosos.lbl_Descuento'", repo.SURA.PC.Endosos.lbl_DescuentoInfo, new ActionTimeout(40000), new RecordItemIndex(1));
            repo.SURA.PC.Endosos.lbl_DescuentoInfo.WaitForExists(40000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Endosos.txt_recargo_dev_tecnico' at Center.", repo.SURA.PC.Endosos.txt_recargo_dev_tecnicoInfo, new RecordItemIndex(2));
            repo.SURA.PC.Endosos.txt_recargo_dev_tecnico.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '100' with focus on 'SURA.PC.Endosos.txt_recargo_dev_tecnico'.", repo.SURA.PC.Endosos.txt_recargo_dev_tecnicoInfo, new RecordItemIndex(3));
            repo.SURA.PC.Endosos.txt_recargo_dev_tecnico.PressKeys("100");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Endosos.lbl_Descuento' at Center.", repo.SURA.PC.Endosos.lbl_DescuentoInfo, new RecordItemIndex(4));
            repo.SURA.PC.Endosos.lbl_Descuento.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SURA.bttn_ReCotizar_ModifRiesgo' at Center.", repo.SURA.bttn_ReCotizar_ModifRiesgoInfo, new RecordItemIndex(5));
            repo.SURA.bttn_ReCotizar_ModifRiesgo.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.bttn_ReCotizar_ModifRiesgo' at 28;5.", repo.SURA.bttn_ReCotizar_ModifRiesgoInfo, new RecordItemIndex(6));
            repo.SURA.bttn_ReCotizar_ModifRiesgo.Click("28;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SURA.txt_Cotizacion'", repo.SURA.txt_CotizacionInfo, new ActionTimeout(30000), new RecordItemIndex(7));
            repo.SURA.txt_CotizacionInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
