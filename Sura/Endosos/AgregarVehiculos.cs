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
    ///The AgregarVehiculos recording.
    /// </summary>
    [TestModule("42bc5570-af75-42cb-b755-a9bddba5f70e", ModuleType.Recording, 1)]
    public partial class AgregarVehiculos : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static AgregarVehiculos instance = new AgregarVehiculos();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AgregarVehiculos()
        {
            Anio = "";
            Marca = "";
            Modelo = "";
            Actividad = "Sin Actividad";
            SumaAsegurada = "400000";
            Patente = "ZZZ999";
            Motor = "ABH134H8812";
            Chasis = "CA52MN31912";
            Producto = "A - Responsabilidad Civil Unicamente";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AgregarVehiculos Instance
        {
            get { return instance; }
        }

#region Variables

        string _Actividad;

        /// <summary>
        /// Gets or sets the value of variable Actividad.
        /// </summary>
        [TestVariable("a27d5302-9402-43d2-9f70-dde1b9ea87ba")]
        public string Actividad
        {
            get { return _Actividad; }
            set { _Actividad = value; }
        }

        string _Patente;

        /// <summary>
        /// Gets or sets the value of variable Patente.
        /// </summary>
        [TestVariable("b554cd55-4dfd-4c20-be09-7833b4c8f08b")]
        public string Patente
        {
            get { return _Patente; }
            set { _Patente = value; }
        }

        string _Motor;

        /// <summary>
        /// Gets or sets the value of variable Motor.
        /// </summary>
        [TestVariable("7536376c-4d6b-497a-a76c-69dd8b9b2063")]
        public string Motor
        {
            get { return _Motor; }
            set { _Motor = value; }
        }

        string _Chasis;

        /// <summary>
        /// Gets or sets the value of variable Chasis.
        /// </summary>
        [TestVariable("739a3126-5a5e-43df-9301-88cf56909507")]
        public string Chasis
        {
            get { return _Chasis; }
            set { _Chasis = value; }
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
        /// Gets or sets the value of variable Anio.
        /// </summary>
        [TestVariable("3a41f651-1fbc-470c-935e-fe43e5962202")]
        public string Anio
        {
            get { return repo.Anio; }
            set { repo.Anio = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Marca.
        /// </summary>
        [TestVariable("4a0cda88-3b9e-4304-b923-ed240ee6bdd4")]
        public string Marca
        {
            get { return repo.Marca; }
            set { repo.Marca = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Modelo.
        /// </summary>
        [TestVariable("94486440-25de-41ab-b401-b4e8a537d8e0")]
        public string Modelo
        {
            get { return repo.Modelo; }
            set { repo.Modelo = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable SumaAsegurada.
        /// </summary>
        [TestVariable("193e46b6-419f-4a0d-91ff-2563420ce412")]
        public string SumaAsegurada
        {
            get { return repo.SumaAsegurada; }
            set { repo.SumaAsegurada = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Producto.
        /// </summary>
        [TestVariable("80b1a37c-b9c1-448b-bb8f-b2a559663532")]
        public string Producto
        {
            get { return repo.Producto; }
            set { repo.Producto = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.bttn_Agregar' at Center.", repo.SURA.bttn_AgregarInfo, new RecordItemIndex(0));
            repo.SURA.bttn_Agregar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Anio'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_AnioInfo, new ActionTimeout(45000), new RecordItemIndex(1));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_AnioInfo.WaitForNotExists(45000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Anio' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Anio'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_AnioInfo, new RecordItemIndex(2));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Anio.PressKeys(Anio);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(3));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Anio'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_AnioInfo, new ActionTimeout(45000), new RecordItemIndex(4));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_AnioInfo.WaitForNotExists(45000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Flota.rdo_0Km' at Center.", repo.SURA.PC.Emision.PolizaMotor.Flota.rdo_0KmInfo, new RecordItemIndex(5));
            repo.SURA.PC.Emision.PolizaMotor.Flota.rdo_0Km.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(6));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Anio'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_AnioInfo, new ActionTimeout(45000), new RecordItemIndex(7));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_AnioInfo.WaitForNotExists(45000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Marca' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Marca'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_MarcaInfo, new RecordItemIndex(8));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Marca.PressKeys(Marca, 10);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(9));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Marca'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_MarcaInfo, new RecordItemIndex(10));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Marca.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(11));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(12));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(13));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Marca'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_MarcaInfo, new ActionTimeout(45000), new RecordItemIndex(14));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_MarcaInfo.WaitForNotExists(45000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Modelo' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Modelo'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ModeloInfo, new RecordItemIndex(15));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Modelo.PressKeys(Modelo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(16));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Modelo'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ModeloInfo, new RecordItemIndex(17));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Modelo.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(18));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(19));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(20));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Modelo'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ModeloInfo, new ActionTimeout(45000), new RecordItemIndex(21));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ModeloInfo.WaitForNotExists(45000);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ActividadInfo, new RecordItemIndex(22));
            //Keyboard.PrepareFocus(repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad);
            //Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ActividadInfo, new RecordItemIndex(23));
            //repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad.PressKeys("{Back}");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Actividad' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ActividadInfo, new RecordItemIndex(24));
            //repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad.PressKeys(Actividad);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(25));
            //repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Actividad'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ActividadInfo, new ActionTimeout(45000), new RecordItemIndex(26));
            //repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ActividadInfo.WaitForNotExists(45000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAseguradaInfo, new RecordItemIndex(27));
            Keyboard.PrepareFocus(repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$SumaAsegurada' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAseguradaInfo, new RecordItemIndex(28));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada.PressKeys(SumaAsegurada);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(29));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(30));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_SumaAsegurada'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_SumaAseguradaInfo, new ActionTimeout(45000), new RecordItemIndex(31));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_SumaAseguradaInfo.WaitForNotExists(45000);
            
            // --------------------------------Campos Opcionales
            Report.Log(ReportLevel.Info, "Section", "--------------------------------Campos Opcionales", new RecordItemIndex(32));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Patente' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Patente'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_PatenteInfo, new RecordItemIndex(33));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Patente.PressKeys(Patente);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(34));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Patente'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_PatenteInfo, new ActionTimeout(45000), new RecordItemIndex(35));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_PatenteInfo.WaitForNotExists(45000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Motor'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_MotorInfo, new RecordItemIndex(36));
            Keyboard.PrepareFocus(repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Motor);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Motor'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_MotorInfo, new RecordItemIndex(37));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Motor.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Motor' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Motor'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_MotorInfo, new RecordItemIndex(38));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Motor.PressKeys(Motor);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(39));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Motor'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_MotorInfo, new ActionTimeout(45000), new RecordItemIndex(40));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_MotorInfo.WaitForNotExists(45000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Chasis'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ChasisInfo, new RecordItemIndex(41));
            Keyboard.PrepareFocus(repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Chasis);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Chasis'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ChasisInfo, new RecordItemIndex(42));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Chasis.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Chasis' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Chasis'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ChasisInfo, new RecordItemIndex(43));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Chasis.PressKeys(Chasis);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(44));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Chasis'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ChasisInfo, new ActionTimeout(45000), new RecordItemIndex(45));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ChasisInfo.WaitForNotExists(45000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(46));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Producto' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Producto'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ProductoInfo, new RecordItemIndex(47));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Producto.PressKeys(Producto);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(48));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Producto'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ProductoInfo, new ActionTimeout(45000), new RecordItemIndex(49));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ProductoInfo.WaitForNotExists(45000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(50));
            
            // --------------------------------Cambio a Siguiente Pantalla
            Report.Log(ReportLevel.Info, "Section", "--------------------------------Cambio a Siguiente Pantalla", new RecordItemIndex(51));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_SiguienteInfo, new RecordItemIndex(52));
            //repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to exist. Associated repository item: 'SURA.PC.Txt_Validacion.txt_ComisionesDescuentos'", repo.SURA.PC.Txt_Validacion.txt_ComisionesDescuentosInfo, new ActionTimeout(45000), new RecordItemIndex(53));
            //repo.SURA.PC.Txt_Validacion.txt_ComisionesDescuentosInfo.WaitForExists(45000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
