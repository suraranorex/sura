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
    ///The EndosoAP_Persona recording.
    /// </summary>
    [TestModule("6bd2a6a4-bee2-41d2-866b-ff0811e3e4a3", ModuleType.Recording, 1)]
    public partial class EndosoAP_Persona : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static EndosoAP_Persona instance = new EndosoAP_Persona();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EndosoAP_Persona()
        {
            SumaAseguradaIncapacidad = "100500";
            NUEVA_COBERTURA = "Uso de Motocicletas In Itinere";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EndosoAP_Persona Instance
        {
            get { return instance; }
        }

#region Variables

        string _SumaAseguradaIncapacidad;

        /// <summary>
        /// Gets or sets the value of variable SumaAseguradaIncapacidad.
        /// </summary>
        [TestVariable("197b4df5-b892-482e-9df6-9dac54982f23")]
        public string SumaAseguradaIncapacidad
        {
            get { return _SumaAseguradaIncapacidad; }
            set { _SumaAseguradaIncapacidad = value; }
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
        /// Gets or sets the value of variable NUEVA_COBERTURA.
        /// </summary>
        [TestVariable("86a1bb50-75f8-44fd-9628-77cc5cfdf714")]
        public string NUEVA_COBERTURA
        {
            get { return repo.NUEVA_COBERTURA; }
            set { repo.NUEVA_COBERTURA = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Endosos.AP.Coberturas.bttn_Personas' at Center.", repo.SURA.PC.Endosos.AP.Coberturas.bttn_PersonasInfo, new RecordItemIndex(0));
            repo.SURA.PC.Endosos.AP.Coberturas.bttn_Personas.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SURA.PC.Endosos.AP.Coberturas.txt_Personas'", repo.SURA.PC.Endosos.AP.Coberturas.txt_PersonasInfo, new ActionTimeout(30000), new RecordItemIndex(1));
            repo.SURA.PC.Endosos.AP.Coberturas.txt_PersonasInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(2));
            Delay.Duration(2000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Información original", repo.SURA.Self, false, new RecordItemIndex(3));
            
            // Selecciono una cobertura extra. Tener en cuenta que varian según la extensión de la cobertura.
            Report.Log(ReportLevel.Info, "Section", "Selecciono una cobertura extra. Tener en cuenta que varian según la extensión de la cobertura.", new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Focus() on item 'SURA.PC.Endosos.AP.Coberturas.check_Cobertura'.", repo.SURA.PC.Endosos.AP.Coberturas.check_CoberturaInfo, new RecordItemIndex(5));
            repo.SURA.PC.Endosos.AP.Coberturas.check_Cobertura.Focus();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Endosos.AP.Coberturas.check_Cobertura' at Center.", repo.SURA.PC.Endosos.AP.Coberturas.check_CoberturaInfo, new RecordItemIndex(6));
            repo.SURA.PC.Endosos.AP.Coberturas.check_Cobertura.Click();
            Delay.Milliseconds(0);
            
            // Cuando hay cambio de oferta, tengo que completar este campo
            Report.Log(ReportLevel.Info, "Section", "Cuando hay cambio de oferta, tengo que completar este campo", new RecordItemIndex(7));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$SumaAseguradaIncapacidad' with focus on 'SURA.PC.Endosos.AP.Coberturas.txtbox_IncapacadidadSumaAsegurada'.", repo.SURA.PC.Endosos.AP.Coberturas.txtbox_IncapacadidadSumaAseguradaInfo, new RecordItemIndex(8));
            repo.SURA.PC.Endosos.AP.Coberturas.txtbox_IncapacadidadSumaAsegurada.PressKeys(SumaAseguradaIncapacidad);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Endosos.AP.Coberturas.txt_Personas' at Center.", repo.SURA.PC.Endosos.AP.Coberturas.txt_PersonasInfo, new RecordItemIndex(9));
            repo.SURA.PC.Endosos.AP.Coberturas.txt_Personas.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Endosos.AP.Coberturas.Copy_of_txtbox_IncapacadidadSumaAsegurada'", repo.SURA.PC.Endosos.AP.Coberturas.Copy_of_txtbox_IncapacadidadSumaAseguradaInfo, new ActionTimeout(30000), new RecordItemIndex(10));
            repo.SURA.PC.Endosos.AP.Coberturas.Copy_of_txtbox_IncapacadidadSumaAseguradaInfo.WaitForNotExists(30000);
            
            Report.Screenshot(ReportLevel.Info, "User", "Modificación producida por el endoso", repo.SURA.Self, false, new RecordItemIndex(11));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
