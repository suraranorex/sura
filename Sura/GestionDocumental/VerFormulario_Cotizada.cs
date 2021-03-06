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

namespace Sura.GestionDocumental
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The VerFormulario_Cotizada recording.
    /// </summary>
    [TestModule("03d5cad4-1f32-4da2-bf41-95bfcb2c3067", ModuleType.Recording, 1)]
    public partial class VerFormulario_Cotizada : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static VerFormulario_Cotizada instance = new VerFormulario_Cotizada();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerFormulario_Cotizada()
        {
            NombreArchivo = "";
            NumeroTransaccion = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerFormulario_Cotizada Instance
        {
            get { return instance; }
        }

#region Variables

        string _NombreArchivo;

        /// <summary>
        /// Gets or sets the value of variable NombreArchivo.
        /// </summary>
        [TestVariable("0112f02f-cf20-454d-9b1e-22c2bdc480d2")]
        public string NombreArchivo
        {
            get { return _NombreArchivo; }
            set { _NombreArchivo = value; }
        }

        string _NumeroTransaccion;

        /// <summary>
        /// Gets or sets the value of variable NumeroTransaccion.
        /// </summary>
        [TestVariable("98fe957e-8da3-46e6-9fdf-35b14b56ab4a")]
        public string NumeroTransaccion
        {
            get { return _NumeroTransaccion; }
            set { _NumeroTransaccion = value; }
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
        /// Gets or sets the value of variable Formulario.
        /// </summary>
        [TestVariable("ae0cf604-99d8-4ced-a2eb-344dcca1526a")]
        public string Formulario
        {
            get { return repo.Formulario; }
            set { repo.Formulario = value; }
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

            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.GestionDocumental.bttn_VerFormulario' at Center.", repo.SURA.PC.GestionDocumental.bttn_VerFormularioInfo, new RecordItemIndex(1));
            repo.SURA.PC.GestionDocumental.bttn_VerFormulario.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SURA.PC.GestionDocumental.formularioPDF' at Center.", repo.SURA.PC.GestionDocumental.formularioPDFInfo, new RecordItemIndex(2));
            repo.SURA.PC.GestionDocumental.formularioPDF.Click(System.Windows.Forms.MouseButtons.Right);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Chrome.option_GuardarComo' at Center.", repo.Chrome.option_GuardarComoInfo, new RecordItemIndex(3));
            repo.Chrome.option_GuardarComo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GuardarComo.ButtonGuardar' at Center.", repo.GuardarComo.ButtonGuardarInfo, new RecordItemIndex(4));
            repo.GuardarComo.ButtonGuardar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'Chrome.bttn_FormularioPDF'", repo.Chrome.bttn_FormularioPDFInfo, new ActionTimeout(10000), new RecordItemIndex(5));
            repo.Chrome.bttn_FormularioPDFInfo.WaitForExists(10000);
            
            Generales.UC_Generales.fileCheck();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'Chrome.bttn_FormularioPDF' and assigning its value to variable 'NombreArchivo'.", repo.Chrome.bttn_FormularioPDFInfo, new RecordItemIndex(7));
            NombreArchivo = repo.Chrome.bttn_FormularioPDF.Element.GetAttributeValueText("Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", NombreArchivo, new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'bttn_CerrarPestaniaFormulario' at Center.", repo.bttn_CerrarPestaniaFormularioInfo, new RecordItemIndex(9));
            repo.bttn_CerrarPestaniaFormulario.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'SURA.txt_SolicitudPoliza' and assigning the part of its value captured by '[0-9]+' to variable 'NumeroTransaccion'.", repo.SURA.txt_SolicitudPolizaInfo, new RecordItemIndex(10));
            NumeroTransaccion = repo.SURA.txt_SolicitudPoliza.Element.GetAttributeValueText("InnerText", new Regex("[0-9]+"));
            Delay.Milliseconds(0);
            
            manejarFormulario();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Chrome.Cerrar' at 17;15.", repo.Chrome.CerrarInfo, new RecordItemIndex(12));
            repo.Chrome.Cerrar.Click("17;15");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
