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
    ///The InformacionDePoliza_Hogar_Inclusion_de_Riesgo recording.
    /// </summary>
    [TestModule("95804cb6-0d59-4537-bb8a-8bedeee1cf26", ModuleType.Recording, 1)]
    public partial class InformacionDePoliza_Hogar_Inclusion_de_Riesgo : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static InformacionDePoliza_Hogar_Inclusion_de_Riesgo instance = new InformacionDePoliza_Hogar_Inclusion_de_Riesgo();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InformacionDePoliza_Hogar_Inclusion_de_Riesgo()
        {
            Provincia = "CAPITAL";
            Localidad = "CIUDAD AUTONOMA BUENOS AIRES";
            NvoPais = "Argentina";
            NvaPcia = "Capital";
            NvaCiudad = "CIUDAD";
            NvaCalle = "rivadavia";
            NvoNro = "500";
            UbicacionRiesgo = "1: ";
            TipoVivienda = "Permanente";
            Producto = "Incendio";
            PlanPlanta = "Casa en PB o Depto hasta 1er piso";
            TipoConstruccion = "Construccion de Material y Techos Sólidos";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InformacionDePoliza_Hogar_Inclusion_de_Riesgo Instance
        {
            get { return instance; }
        }

#region Variables

        string _NvoPais;

        /// <summary>
        /// Gets or sets the value of variable NvoPais.
        /// </summary>
        [TestVariable("4544a872-8101-442d-a631-11d5e6a42973")]
        public string NvoPais
        {
            get { return _NvoPais; }
            set { _NvoPais = value; }
        }

        string _NvaPcia;

        /// <summary>
        /// Gets or sets the value of variable NvaPcia.
        /// </summary>
        [TestVariable("8d2f4d76-4c96-41bd-ba9a-6a01fbf4cfaa")]
        public string NvaPcia
        {
            get { return _NvaPcia; }
            set { _NvaPcia = value; }
        }

        string _NvaCiudad;

        /// <summary>
        /// Gets or sets the value of variable NvaCiudad.
        /// </summary>
        [TestVariable("3093f538-e5ce-4db0-bdfc-666e29aea370")]
        public string NvaCiudad
        {
            get { return _NvaCiudad; }
            set { _NvaCiudad = value; }
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
        /// Gets or sets the value of variable Provincia.
        /// </summary>
        [TestVariable("4a87bf1c-f3a3-44e3-b899-bbf6abdc3306")]
        public string Provincia
        {
            get { return repo.PROVINCIA; }
            set { repo.PROVINCIA = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Localidad.
        /// </summary>
        [TestVariable("bf758f54-fb9c-4721-a05d-d540ad6f3461")]
        public string Localidad
        {
            get { return repo.LOCALIDAD; }
            set { repo.LOCALIDAD = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TipoVivienda.
        /// </summary>
        [TestVariable("e5e4befd-0763-40d2-8d53-4a23ac35d43b")]
        public string TipoVivienda
        {
            get { return repo.TipoVivienda; }
            set { repo.TipoVivienda = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Producto.
        /// </summary>
        [TestVariable("f837ff95-c7a7-4a45-84ef-28160c72aa3c")]
        public string Producto
        {
            get { return repo.Producto; }
            set { repo.Producto = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable PlanPlanta.
        /// </summary>
        [TestVariable("01106f27-6f26-41ba-8a14-db68ab6376e3")]
        public string PlanPlanta
        {
            get { return repo.PlanPlanta; }
            set { repo.PlanPlanta = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TipoConstruccion.
        /// </summary>
        [TestVariable("4633a055-c3c0-491f-bc76-d1d848c7bcfb")]
        public string TipoConstruccion
        {
            get { return repo.TipoConstruccion; }
            set { repo.TipoConstruccion = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable NvaCalle.
        /// </summary>
        [TestVariable("dcbbe521-0976-4221-a609-c8fa2728dc66")]
        public string NvaCalle
        {
            get { return repo.NvaCalle; }
            set { repo.NvaCalle = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable NvoNro.
        /// </summary>
        [TestVariable("8846bc96-c31a-4c94-9a94-5a6a90cbc1b1")]
        public string NvoNro
        {
            get { return repo.NvoNro; }
            set { repo.NvoNro = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable UbicacionRiesgo.
        /// </summary>
        [TestVariable("9b6e4fbc-4396-4057-a98e-ed646c147c28")]
        public string UbicacionRiesgo
        {
            get { return repo.UbicacionRiesgo; }
            set { repo.UbicacionRiesgo = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Siguiente' at Center.", repo.SURA.SiguienteInfo, new RecordItemIndex(0));
            repo.SURA.Siguiente.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SURA.title_Vivienda'", repo.SURA.title_ViviendaInfo, new ActionTimeout(30000), new RecordItemIndex(1));
            repo.SURA.title_ViviendaInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.CrerVivienda' at 50;10.", repo.SURA.CrerViviendaInfo, new RecordItemIndex(2));
            repo.SURA.CrerVivienda.Click("50;10");
            Delay.Milliseconds(0);
            
            // --------------------------------Cargo Provincia
            Report.Log(ReportLevel.Info, "Section", "--------------------------------Cargo Provincia", new RecordItemIndex(3));
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to not exist. Associated repository item: 'SURA.Copy_of_cbo_Provincia'", repo.SURA.Copy_of_cbo_ProvinciaInfo, new ActionTimeout(15000), new RecordItemIndex(4));
            //repo.SURA.Copy_of_cbo_ProvinciaInfo.WaitForNotExists(15000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Provincia' at Center.", repo.SURA.ProvinciaInfo, new RecordItemIndex(5));
            repo.SURA.Provincia.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.Provincia'.", repo.SURA.ProvinciaInfo, new RecordItemIndex(6));
            Keyboard.PrepareFocus(repo.SURA.Provincia);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'SURA.Provincia'.", repo.SURA.ProvinciaInfo, new RecordItemIndex(7));
            repo.SURA.Provincia.EnsureVisible();
            Keyboard.Press("{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Provincia' with focus on 'SURA.Provincia'.", repo.SURA.ProvinciaInfo, new RecordItemIndex(8));
            repo.SURA.Provincia.EnsureVisible();
            Keyboard.Press(Provincia);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(9));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.cbo_Provincia' at Center.", repo.SURA.cbo_ProvinciaInfo, new RecordItemIndex(10));
            repo.SURA.cbo_Provincia.Click();
            Delay.Milliseconds(0);
            
            // --------------------------------Cargo Localidad
            Report.Log(ReportLevel.Info, "Section", "--------------------------------Cargo Localidad", new RecordItemIndex(11));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1.5s.", new RecordItemIndex(12));
            Delay.Duration(1500, false);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to exist. Associated repository item: 'SURA.Copy_of_cbo_Localidad2'", repo.SURA.Copy_of_cbo_Localidad2Info, new ActionTimeout(15000), new RecordItemIndex(13));
            //repo.SURA.Copy_of_cbo_Localidad2Info.WaitForExists(15000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Localidad' at Center.", repo.SURA.LocalidadInfo, new RecordItemIndex(14));
            repo.SURA.Localidad.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.Localidad'.", repo.SURA.LocalidadInfo, new RecordItemIndex(15));
            Keyboard.PrepareFocus(repo.SURA.Localidad);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'SURA.Localidad'.", repo.SURA.LocalidadInfo, new RecordItemIndex(16));
            repo.SURA.Localidad.EnsureVisible();
            Keyboard.Press("{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Localidad' with focus on 'SURA.Localidad'.", repo.SURA.LocalidadInfo, new RecordItemIndex(17));
            repo.SURA.Localidad.EnsureVisible();
            Keyboard.Press(Localidad);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.cbo_Localidad' at Center.", repo.SURA.cbo_LocalidadInfo, new RecordItemIndex(18));
            repo.SURA.cbo_Localidad.Click();
            Delay.Milliseconds(0);
            
            // --------------------------------Agrego Ubicacion Nueva
            Report.Log(ReportLevel.Info, "Section", "--------------------------------Agrego Ubicacion Nueva", new RecordItemIndex(19));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4.5s.", new RecordItemIndex(20));
            Delay.Duration(4500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.cbo_UbicacionNueva' at Center.", repo.SURA.cbo_UbicacionNuevaInfo, new RecordItemIndex(21));
            repo.SURA.cbo_UbicacionNueva.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(22));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SURA.EditarUbicacion'", repo.SURA.EditarUbicacionInfo, new ActionTimeout(30000), new RecordItemIndex(23));
            repo.SURA.EditarUbicacionInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Copy_of_EditarUbicacion' at Center.", repo.SURA.Copy_of_EditarUbicacionInfo, new RecordItemIndex(24));
            repo.SURA.Copy_of_EditarUbicacion.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 20s to exist. Associated repository item: 'SURA.PC.Emision.PolizaHogar.Enlatado.txt_InformacionDeUbicacion'", repo.SURA.PC.Emision.PolizaHogar.Enlatado.txt_InformacionDeUbicacionInfo, new ActionTimeout(20000), new RecordItemIndex(25));
            repo.SURA.PC.Emision.PolizaHogar.Enlatado.txt_InformacionDeUbicacionInfo.WaitForExists(20000);
            
            // --------------------------------Cargo Datos Nueva Ubicacion
            Report.Log(ReportLevel.Info, "Section", "--------------------------------Cargo Datos Nueva Ubicacion", new RecordItemIndex(26));
            
            // --------------------------------Nuevo pais
            Report.Log(ReportLevel.Info, "Section", "--------------------------------Nuevo pais", new RecordItemIndex(27));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.cbo_Pais' at Center.", repo.SURA.cbo_PaisInfo, new RecordItemIndex(28));
            repo.SURA.cbo_Pais.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.imp_Pais'.", repo.SURA.imp_PaisInfo, new RecordItemIndex(29));
            Keyboard.PrepareFocus(repo.SURA.imp_Pais);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NvoPais' with focus on 'SURA.imp_Pais'.", repo.SURA.imp_PaisInfo, new RecordItemIndex(30));
            repo.SURA.imp_Pais.EnsureVisible();
            Keyboard.Press(NvoPais);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.imp_Pais' at Center.", repo.SURA.imp_PaisInfo, new RecordItemIndex(31));
            repo.SURA.imp_Pais.Click();
            Delay.Milliseconds(0);
            
            // --------------------------------Nueva Pcia
            Report.Log(ReportLevel.Info, "Section", "--------------------------------Nueva Pcia", new RecordItemIndex(32));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(33));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.cbo_NvaProvincia' at Center.", repo.SURA.cbo_NvaProvinciaInfo, new RecordItemIndex(34));
            repo.SURA.cbo_NvaProvincia.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(35));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.imp_NvaProvincia'.", repo.SURA.imp_NvaProvinciaInfo, new RecordItemIndex(36));
            Keyboard.PrepareFocus(repo.SURA.imp_NvaProvincia);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NvaPcia' with focus on 'SURA.imp_NvaProvincia'.", repo.SURA.imp_NvaProvinciaInfo, new RecordItemIndex(37));
            repo.SURA.imp_NvaProvincia.EnsureVisible();
            Keyboard.Press(NvaPcia);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.imp_NvaProvincia' at Center.", repo.SURA.imp_NvaProvinciaInfo, new RecordItemIndex(38));
            repo.SURA.imp_NvaProvincia.Click();
            Delay.Milliseconds(0);
            
            // --------------------------------nueva localidad
            Report.Log(ReportLevel.Info, "Section", "--------------------------------nueva localidad", new RecordItemIndex(39));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(40));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.cbo_NvaLocalidad' at Center.", repo.SURA.cbo_NvaLocalidadInfo, new RecordItemIndex(41));
            repo.SURA.cbo_NvaLocalidad.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1.5s.", new RecordItemIndex(42));
            Delay.Duration(1500, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.Imp_NvaLocalidad'.", repo.SURA.Imp_NvaLocalidadInfo, new RecordItemIndex(43));
            Keyboard.PrepareFocus(repo.SURA.Imp_NvaLocalidad);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NvaCiudad' with focus on 'SURA.Imp_NvaLocalidad'.", repo.SURA.Imp_NvaLocalidadInfo, new RecordItemIndex(44));
            repo.SURA.Imp_NvaLocalidad.EnsureVisible();
            Keyboard.Press(NvaCiudad);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Imp_NvaLocalidad' at Center.", repo.SURA.Imp_NvaLocalidadInfo, new RecordItemIndex(45));
            repo.SURA.Imp_NvaLocalidad.Click();
            Delay.Milliseconds(0);
            
            // --------------------------------nueva calle
            Report.Log(ReportLevel.Info, "Section", "--------------------------------nueva calle", new RecordItemIndex(46));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(47));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.imp_NvaCalle_IncluRiesgo' at Center.", repo.SURA.imp_NvaCalle_IncluRiesgoInfo, new RecordItemIndex(48));
            repo.SURA.imp_NvaCalle_IncluRiesgo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(49));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.imp_NvaCalle_IncluRiesgo'.", repo.SURA.imp_NvaCalle_IncluRiesgoInfo, new RecordItemIndex(50));
            Keyboard.PrepareFocus(repo.SURA.imp_NvaCalle_IncluRiesgo);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(51));
            //Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NvaCalle' with focus on 'SURA.imp_NvaCalle_IncluRiesgo'.", repo.SURA.imp_NvaCalle_IncluRiesgoInfo, new RecordItemIndex(52));
            repo.SURA.imp_NvaCalle_IncluRiesgo.PressKeys(NvaCalle);
            Delay.Milliseconds(0);
            
            // --------------------------------nuevo numero
            Report.Log(ReportLevel.Info, "Section", "--------------------------------nuevo numero", new RecordItemIndex(53));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(54));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.imp_NvoNro_IncluRiesgo' at Center.", repo.SURA.imp_NvoNro_IncluRiesgoInfo, new RecordItemIndex(55));
            repo.SURA.imp_NvoNro_IncluRiesgo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(56));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.imp_NvoNro_IncluRiesgo'.", repo.SURA.imp_NvoNro_IncluRiesgoInfo, new RecordItemIndex(57));
            Keyboard.PrepareFocus(repo.SURA.imp_NvoNro_IncluRiesgo);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NvoNro' with focus on 'SURA.imp_NvoNro_IncluRiesgo'.", repo.SURA.imp_NvoNro_IncluRiesgoInfo, new RecordItemIndex(58));
            repo.SURA.imp_NvoNro_IncluRiesgo.EnsureVisible();
            Keyboard.Press(NvoNro);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(59));
            Delay.Duration(3000, false);
            
            // --------------------------------Validación Dirección
            Report.Log(ReportLevel.Info, "Section", "--------------------------------Validación Dirección", new RecordItemIndex(60));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.btn_ValidarDireccion' at Center.", repo.SURA.btn_ValidarDireccionInfo, new RecordItemIndex(61));
            repo.SURA.btn_ValidarDireccion.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(62));
            //Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2.5s.", new RecordItemIndex(63));
            Delay.Duration(2500, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to exist. Associated repository item: 'SURA.Copy_of_bttn_Aceptar2'", repo.SURA.Copy_of_bttn_Aceptar2Info, new ActionTimeout(15000), new RecordItemIndex(64));
            repo.SURA.Copy_of_bttn_Aceptar2Info.WaitForExists(15000);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(65));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.bttn_Aceptar2' at Center.", repo.SURA.bttn_Aceptar2Info, new RecordItemIndex(66));
            repo.SURA.bttn_Aceptar2.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.bttn_Aceptar' at Center.", repo.SURA.bttn_AceptarInfo, new RecordItemIndex(67));
            //repo.SURA.bttn_Aceptar.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to exist. Associated repository item: 'SURA.title_Vivienda'", repo.SURA.title_ViviendaInfo, new ActionTimeout(45000), new RecordItemIndex(68));
            repo.SURA.title_ViviendaInfo.WaitForExists(45000);
            
            // --------------------------------Fin Datos Nueva Ubicacion
            Report.Log(ReportLevel.Info, "Section", "--------------------------------Fin Datos Nueva Ubicacion", new RecordItemIndex(69));
            
            // --------------------------------Cargo Tipo de Vivienda
            Report.Log(ReportLevel.Info, "Section", "--------------------------------Cargo Tipo de Vivienda", new RecordItemIndex(70));
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'SURA.Copy_of_cbo_TipoDeVivienda'", repo.SURA.Copy_of_cbo_TipoDeViviendaInfo, new ActionTimeout(10000), new RecordItemIndex(71));
            //repo.SURA.Copy_of_cbo_TipoDeViviendaInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.TipoDeVivienda' at Center.", repo.SURA.TipoDeViviendaInfo, new RecordItemIndex(72));
            repo.SURA.TipoDeVivienda.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.TipoDeVivienda'.", repo.SURA.TipoDeViviendaInfo, new RecordItemIndex(73));
            Keyboard.PrepareFocus(repo.SURA.TipoDeVivienda);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$TipoVivienda' with focus on 'SURA.TipoDeVivienda'.", repo.SURA.TipoDeViviendaInfo, new RecordItemIndex(74));
            repo.SURA.TipoDeVivienda.EnsureVisible();
            Keyboard.Press(TipoVivienda);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(75));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.cbo_TipoDeVivienda' at Center.", repo.SURA.cbo_TipoDeViviendaInfo, new RecordItemIndex(76));
            repo.SURA.cbo_TipoDeVivienda.Click();
            Delay.Milliseconds(0);
            
            // --------------------------------Cargo Producto
            Report.Log(ReportLevel.Info, "Section", "--------------------------------Cargo Producto", new RecordItemIndex(77));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(78));
            Delay.Duration(2000, false);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'SURA.Copy_of_cbo_Producto'", repo.SURA.Copy_of_cbo_ProductoInfo, new ActionTimeout(10000), new RecordItemIndex(79));
            //repo.SURA.Copy_of_cbo_ProductoInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Producto' at Center.", repo.SURA.ProductoInfo, new RecordItemIndex(80));
            repo.SURA.Producto.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(81));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.Producto'.", repo.SURA.ProductoInfo, new RecordItemIndex(82));
            Keyboard.PrepareFocus(repo.SURA.Producto);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Producto' with focus on 'SURA.Producto'.", repo.SURA.ProductoInfo, new RecordItemIndex(83));
            repo.SURA.Producto.EnsureVisible();
            Keyboard.Press(Producto);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.cbo_Producto' at Center.", repo.SURA.cbo_ProductoInfo, new RecordItemIndex(84));
            repo.SURA.cbo_Producto.Click();
            Delay.Milliseconds(0);
            
            // --------------------------------Cargo Plan Planta
            Report.Log(ReportLevel.Info, "Section", "--------------------------------Cargo Plan Planta", new RecordItemIndex(85));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2.5s.", new RecordItemIndex(86));
            Delay.Duration(2500, false);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 20s to exist. Associated repository item: 'SURA.PC.Emision.Flota_Nomina.Flota.item_TipoDocumento'", repo.SURA.PC.Emision.Flota_Nomina.Flota.item_TipoDocumentoInfo, new ActionTimeout(20000), new RecordItemIndex(87));
            //repo.SURA.PC.Emision.Flota_Nomina.Flota.item_TipoDocumentoInfo.WaitForExists(20000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Plan_Planta' at Center.", repo.SURA.Plan_PlantaInfo, new RecordItemIndex(88));
            repo.SURA.Plan_Planta.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(89));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.Plan_Planta'.", repo.SURA.Plan_PlantaInfo, new RecordItemIndex(90));
            Keyboard.PrepareFocus(repo.SURA.Plan_Planta);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$PlanPlanta' with focus on 'SURA.Plan_Planta'.", repo.SURA.Plan_PlantaInfo, new RecordItemIndex(91));
            repo.SURA.Plan_Planta.EnsureVisible();
            Keyboard.Press(PlanPlanta);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(92));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.cbo_Plan_Planta' at Center.", repo.SURA.cbo_Plan_PlantaInfo, new RecordItemIndex(93));
            repo.SURA.cbo_Plan_Planta.Click();
            Delay.Milliseconds(0);
            
            // --------------------------------Cargo Tipo de Construccion
            Report.Log(ReportLevel.Info, "Section", "--------------------------------Cargo Tipo de Construccion", new RecordItemIndex(94));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(95));
            Delay.Duration(1000, false);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to not exist. Associated repository item: 'SURA.Copy_of_cbo_TipoDeConstruccion'", repo.SURA.Copy_of_cbo_TipoDeConstruccionInfo, new ActionTimeout(15000), new RecordItemIndex(96));
            //repo.SURA.Copy_of_cbo_TipoDeConstruccionInfo.WaitForNotExists(15000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.TipoDeConstruccion' at Center.", repo.SURA.TipoDeConstruccionInfo, new RecordItemIndex(97));
            repo.SURA.TipoDeConstruccion.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(98));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.TipoDeConstruccion'.", repo.SURA.TipoDeConstruccionInfo, new RecordItemIndex(99));
            Keyboard.PrepareFocus(repo.SURA.TipoDeConstruccion);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$TipoConstruccion' with focus on 'SURA.TipoDeConstruccion'.", repo.SURA.TipoDeConstruccionInfo, new RecordItemIndex(100));
            repo.SURA.TipoDeConstruccion.EnsureVisible();
            Keyboard.Press(TipoConstruccion);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.cbo_TipoDeConstruccion' at Center.", repo.SURA.cbo_TipoDeConstruccionInfo, new RecordItemIndex(101));
            repo.SURA.cbo_TipoDeConstruccion.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(102));
            Delay.Duration(1000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.bttn_Siguiente' at Center.", repo.SURA.bttn_SiguienteInfo, new RecordItemIndex(103));
            //repo.SURA.bttn_Siguiente.Click();
            //Delay.Milliseconds(0);
            
            // --------------------------------Siguiente
            Report.Log(ReportLevel.Info, "Section", "--------------------------------Siguiente", new RecordItemIndex(104));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Siguiente' at Center.", repo.SURA.SiguienteInfo, new RecordItemIndex(105));
            repo.SURA.Siguiente.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SURA.txt_Coberturas'", repo.SURA.txt_CoberturasInfo, new ActionTimeout(30000), new RecordItemIndex(106));
            repo.SURA.txt_CoberturasInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
