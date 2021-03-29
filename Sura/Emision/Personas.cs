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
    ///The Personas recording.
    /// </summary>
    [TestModule("0ff82c1b-e283-4084-8ea1-9812309d4cca", ModuleType.Recording, 1)]
    public partial class Personas : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static Personas instance = new Personas();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Personas()
        {
            Actividad = "PERSONAL ADMINISTRATIVO";
            CantidadVigente = "1";
            SumaAsegurada = "100000";
            TipoDocumento = "D.N.I.";
            NumeroDocumento = "38191893";
            Nombre = "Luis";
            Apellido = "Perez";
            FechaNac = "13/12/1980";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Personas Instance
        {
            get { return instance; }
        }

#region Variables

        string _Actividad;

        /// <summary>
        /// Gets or sets the value of variable Actividad.
        /// </summary>
        [TestVariable("c6cfcee9-4572-4b4d-94fb-1ed0500e2b25")]
        public string Actividad
        {
            get { return _Actividad; }
            set { _Actividad = value; }
        }

        string _CantidadVigente;

        /// <summary>
        /// Gets or sets the value of variable CantidadVigente.
        /// </summary>
        [TestVariable("fc2a41ca-f448-4ba0-b0b8-10e1fd9bbd1b")]
        public string CantidadVigente
        {
            get { return _CantidadVigente; }
            set { _CantidadVigente = value; }
        }

        string _Nombre;

        /// <summary>
        /// Gets or sets the value of variable Nombre.
        /// </summary>
        [TestVariable("8e100ceb-0c3c-497d-b233-5cbe8f892d73")]
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        string _Apellido;

        /// <summary>
        /// Gets or sets the value of variable Apellido.
        /// </summary>
        [TestVariable("2075ec13-3ba5-4882-b8de-ef7cdbe58b12")]
        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        string _FechaNac;

        /// <summary>
        /// Gets or sets the value of variable FechaNac.
        /// </summary>
        [TestVariable("452b3928-978f-43cb-9ef0-fcef5c83cbb9")]
        public string FechaNac
        {
            get { return _FechaNac; }
            set { _FechaNac = value; }
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
        [TestVariable("e3bb0bb3-f0a7-4803-93dc-c5582cd29ae4")]
        public string SumaAsegurada
        {
            get { return repo.SumaAsegurada; }
            set { repo.SumaAsegurada = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TipoDocumento.
        /// </summary>
        [TestVariable("e5bbd427-f3d2-461f-93d0-74272e719b80")]
        public string TipoDocumento
        {
            get { return repo.TipoDocumento; }
            set { repo.TipoDocumento = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable NumeroDocumento.
        /// </summary>
        [TestVariable("1edca5f8-2cf7-42eb-9b85-d1e9ec32e944")]
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
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Nombre' with focus on 'SURA.PC.Emision.PolizaAP.Personas.txt_NombrePersona'.", repo.SURA.PC.Emision.PolizaAP.Personas.txt_NombrePersonaInfo, new RecordItemIndex(19));
            repo.SURA.PC.Emision.PolizaAP.Personas.txt_NombrePersona.PressKeys(Nombre);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaAP.Personas.lbl_Detalle' at Center.", repo.SURA.PC.Emision.PolizaAP.Personas.lbl_DetalleInfo, new RecordItemIndex(20));
            repo.SURA.PC.Emision.PolizaAP.Personas.lbl_Detalle.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaAP.Personas.Copy_of_txt_NombrePersona'", repo.SURA.PC.Emision.PolizaAP.Personas.Copy_of_txt_NombrePersonaInfo, new ActionTimeout(30000), new RecordItemIndex(21));
            repo.SURA.PC.Emision.PolizaAP.Personas.Copy_of_txt_NombrePersonaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Apellido' with focus on 'SURA.PC.Emision.PolizaAP.Personas.txt_ApellidoPersona'.", repo.SURA.PC.Emision.PolizaAP.Personas.txt_ApellidoPersonaInfo, new RecordItemIndex(22));
            repo.SURA.PC.Emision.PolizaAP.Personas.txt_ApellidoPersona.PressKeys(Apellido);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaAP.Personas.lbl_Detalle' at Center.", repo.SURA.PC.Emision.PolizaAP.Personas.lbl_DetalleInfo, new RecordItemIndex(23));
            repo.SURA.PC.Emision.PolizaAP.Personas.lbl_Detalle.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaAP.Personas.Copy_of_txt_ApellidoPersona'", repo.SURA.PC.Emision.PolizaAP.Personas.Copy_of_txt_ApellidoPersonaInfo, new ActionTimeout(30000), new RecordItemIndex(24));
            repo.SURA.PC.Emision.PolizaAP.Personas.Copy_of_txt_ApellidoPersonaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$FechaNac' with focus on 'SURA.PC.Emision.PolizaAP.Personas.txt_fecha_nac_persona'.", repo.SURA.PC.Emision.PolizaAP.Personas.txt_fecha_nac_personaInfo, new RecordItemIndex(25));
            repo.SURA.PC.Emision.PolizaAP.Personas.txt_fecha_nac_persona.PressKeys(FechaNac);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaAP.Personas.lbl_Detalle' at Center.", repo.SURA.PC.Emision.PolizaAP.Personas.lbl_DetalleInfo, new RecordItemIndex(26));
            repo.SURA.PC.Emision.PolizaAP.Personas.lbl_Detalle.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaAP.Personas.Copy_of_txt_fecha_nac_persona'", repo.SURA.PC.Emision.PolizaAP.Personas.Copy_of_txt_fecha_nac_personaInfo, new ActionTimeout(30000), new RecordItemIndex(27));
            repo.SURA.PC.Emision.PolizaAP.Personas.Copy_of_txt_fecha_nac_personaInfo.WaitForNotExists(30000);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaAP.Personas.bttn_ValidarDocumento' at Center.", repo.SURA.PC.Emision.PolizaAP.Personas.bttn_ValidarDocumentoInfo, new RecordItemIndex(28));
            //repo.SURA.PC.Emision.PolizaAP.Personas.bttn_ValidarDocumento.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaAP.Personas.Copy_of_txtbox_NumeroDeDocumento'", repo.SURA.PC.Emision.PolizaAP.Personas.Copy_of_txtbox_NumeroDeDocumentoInfo, new ActionTimeout(30000), new RecordItemIndex(29));
            //repo.SURA.PC.Emision.PolizaAP.Personas.Copy_of_txtbox_NumeroDeDocumentoInfo.WaitForNotExists(30000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(30));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_SiguienteInfo, new RecordItemIndex(31));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SURA.PC.Txt_Validacion.txt_ComisionesDescuentos'", repo.SURA.PC.Txt_Validacion.txt_ComisionesDescuentosInfo, new ActionTimeout(30000), new RecordItemIndex(32));
            repo.SURA.PC.Txt_Validacion.txt_ComisionesDescuentosInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
