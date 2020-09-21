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
    ///The AgregarPersonas recording.
    /// </summary>
    [TestModule("11d467af-0245-4cc7-9c06-c22a2ed2ead3", ModuleType.Recording, 1)]
    public partial class AgregarPersonas : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static AgregarPersonas instance = new AgregarPersonas();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AgregarPersonas()
        {
            Actividad = "PERSONAL ADMINISTRATIVO";
            CantidadVigente = "1";
            SumaAsegurada = "100000";
            TipoDocumento = "D.N.I.";
            NumeroDocumento = "38191893";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AgregarPersonas Instance
        {
            get { return instance; }
        }

#region Variables

        string _Actividad;

        /// <summary>
        /// Gets or sets the value of variable Actividad.
        /// </summary>
        [TestVariable("a1d9ba5f-05aa-416c-a1d2-beea70819f15")]
        public string Actividad
        {
            get { return _Actividad; }
            set { _Actividad = value; }
        }

        string _CantidadVigente;

        /// <summary>
        /// Gets or sets the value of variable CantidadVigente.
        /// </summary>
        [TestVariable("250055c8-3f38-4448-aeaa-76aa6dcc9e58")]
        public string CantidadVigente
        {
            get { return _CantidadVigente; }
            set { _CantidadVigente = value; }
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
        /// Gets or sets the value of variable SumaAsegurada.
        /// </summary>
        [TestVariable("4e17a6d3-1784-4c04-bc86-2820dd620664")]
        public string SumaAsegurada
        {
            get { return repo.SumaAsegurada; }
            set { repo.SumaAsegurada = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TipoDocumento.
        /// </summary>
        [TestVariable("e08b9c31-d4c9-43d6-97e5-84713fdd857e")]
        public string TipoDocumento
        {
            get { return repo.TipoDocumento; }
            set { repo.TipoDocumento = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable NumeroDocumento.
        /// </summary>
        [TestVariable("9366793c-d740-481c-965a-4ffa54317eab")]
        public string NumeroDocumento
        {
            get { return repo.NumeroDocumento; }
            set { repo.NumeroDocumento = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Actividad' with focus on 'SURA.PC.Emision.PolizaAP.Personas.txtbox_Actividad'.", repo.SURA.PC.Emision.PolizaAP.Personas.txtbox_ActividadInfo, new RecordItemIndex(0));
            repo.SURA.PC.Emision.PolizaAP.Personas.txtbox_Actividad.PressKeys(Actividad);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaAP.Personas.Pantalla' at Center.", repo.SURA.PC.Emision.PolizaAP.Personas.PantallaInfo, new RecordItemIndex(1));
            repo.SURA.PC.Emision.PolizaAP.Personas.Pantalla.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaAP.Personas.Copy_of_txtbox_Actividad'", repo.SURA.PC.Emision.PolizaAP.Personas.Copy_of_txtbox_ActividadInfo, new ActionTimeout(30000), new RecordItemIndex(2));
            repo.SURA.PC.Emision.PolizaAP.Personas.Copy_of_txtbox_ActividadInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CantidadVigente' with focus on 'SURA.PC.Emision.PolizaAP.Personas.txtbox_CantidadVigente'.", repo.SURA.PC.Emision.PolizaAP.Personas.txtbox_CantidadVigenteInfo, new RecordItemIndex(3));
            repo.SURA.PC.Emision.PolizaAP.Personas.txtbox_CantidadVigente.PressKeys(CantidadVigente);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaAP.Personas.Pantalla' at Center.", repo.SURA.PC.Emision.PolizaAP.Personas.PantallaInfo, new RecordItemIndex(4));
            repo.SURA.PC.Emision.PolizaAP.Personas.Pantalla.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaAP.Personas.Copy_of_txtbox_CantidadVigente'", repo.SURA.PC.Emision.PolizaAP.Personas.Copy_of_txtbox_CantidadVigenteInfo, new ActionTimeout(30000), new RecordItemIndex(5));
            repo.SURA.PC.Emision.PolizaAP.Personas.Copy_of_txtbox_CantidadVigenteInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$SumaAsegurada' with focus on 'SURA.PC.Emision.PolizaAP.Personas.txtbox_SumaAsegurada'.", repo.SURA.PC.Emision.PolizaAP.Personas.txtbox_SumaAseguradaInfo, new RecordItemIndex(6));
            repo.SURA.PC.Emision.PolizaAP.Personas.txtbox_SumaAsegurada.PressKeys(SumaAsegurada);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaAP.Personas.Pantalla' at Center.", repo.SURA.PC.Emision.PolizaAP.Personas.PantallaInfo, new RecordItemIndex(7));
            repo.SURA.PC.Emision.PolizaAP.Personas.Pantalla.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaAP.Personas.Copy_of_txtbox_SumaAsegurada'", repo.SURA.PC.Emision.PolizaAP.Personas.Copy_of_txtbox_SumaAseguradaInfo, new ActionTimeout(30000), new RecordItemIndex(8));
            repo.SURA.PC.Emision.PolizaAP.Personas.Copy_of_txtbox_SumaAseguradaInfo.WaitForNotExists(30000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(9));
            
            // -------Información Asegurado
            Report.Log(ReportLevel.Info, "Section", "-------Información Asegurado", new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaAP.Personas.bttn_InformacionAsegurado' at Center.", repo.SURA.PC.Emision.PolizaAP.Personas.bttn_InformacionAseguradoInfo, new RecordItemIndex(11));
            repo.SURA.PC.Emision.PolizaAP.Personas.bttn_InformacionAsegurado.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaAP.Personas.bttn_AgregarPersona' at Center.", repo.SURA.PC.Emision.PolizaAP.Personas.bttn_AgregarPersonaInfo, new RecordItemIndex(12));
            repo.SURA.PC.Emision.PolizaAP.Personas.bttn_AgregarPersona.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$TipoDocumento' with focus on 'SURA.PC.Emision.PolizaAP.Personas.txtbox_TipoDeDocumento'.", repo.SURA.PC.Emision.PolizaAP.Personas.txtbox_TipoDeDocumentoInfo, new RecordItemIndex(13));
            repo.SURA.PC.Emision.PolizaAP.Personas.txtbox_TipoDeDocumento.PressKeys(TipoDocumento);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaAP.Personas.Pantalla' at Center.", repo.SURA.PC.Emision.PolizaAP.Personas.PantallaInfo, new RecordItemIndex(14));
            repo.SURA.PC.Emision.PolizaAP.Personas.Pantalla.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaAP.Personas.Copy_of_txtbox_TipoDeDocumento'", repo.SURA.PC.Emision.PolizaAP.Personas.Copy_of_txtbox_TipoDeDocumentoInfo, new ActionTimeout(30000), new RecordItemIndex(15));
            repo.SURA.PC.Emision.PolizaAP.Personas.Copy_of_txtbox_TipoDeDocumentoInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NumeroDocumento' with focus on 'SURA.PC.Emision.PolizaAP.Personas.txtbox_NumeroDeDocumento'.", repo.SURA.PC.Emision.PolizaAP.Personas.txtbox_NumeroDeDocumentoInfo, new RecordItemIndex(16));
            repo.SURA.PC.Emision.PolizaAP.Personas.txtbox_NumeroDeDocumento.PressKeys(NumeroDocumento);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaAP.Personas.Pantalla' at Center.", repo.SURA.PC.Emision.PolizaAP.Personas.PantallaInfo, new RecordItemIndex(17));
            repo.SURA.PC.Emision.PolizaAP.Personas.Pantalla.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaAP.Personas.Copy_of_txtbox_NumeroDeDocumento'", repo.SURA.PC.Emision.PolizaAP.Personas.Copy_of_txtbox_NumeroDeDocumentoInfo, new ActionTimeout(30000), new RecordItemIndex(18));
            repo.SURA.PC.Emision.PolizaAP.Personas.Copy_of_txtbox_NumeroDeDocumentoInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaAP.Personas.bttn_ValidarDocumento' at Center.", repo.SURA.PC.Emision.PolizaAP.Personas.bttn_ValidarDocumentoInfo, new RecordItemIndex(19));
            repo.SURA.PC.Emision.PolizaAP.Personas.bttn_ValidarDocumento.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaAP.Personas.Copy_of_txtbox_NumeroDeDocumento'", repo.SURA.PC.Emision.PolizaAP.Personas.Copy_of_txtbox_NumeroDeDocumentoInfo, new ActionTimeout(30000), new RecordItemIndex(20));
            repo.SURA.PC.Emision.PolizaAP.Personas.Copy_of_txtbox_NumeroDeDocumentoInfo.WaitForNotExists(30000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(21));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_SiguienteInfo, new RecordItemIndex(22));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SURA.PC.Txt_Validacion.txt_ComisionesDescuentos'", repo.SURA.PC.Txt_Validacion.txt_ComisionesDescuentosInfo, new ActionTimeout(30000), new RecordItemIndex(23));
            repo.SURA.PC.Txt_Validacion.txt_ComisionesDescuentosInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
