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
    ///The VehiculosFlota_Parte1 recording.
    /// </summary>
    [TestModule("b65fb9d0-25b4-4350-af38-a4b56929282a", ModuleType.Recording, 1)]
    public partial class VehiculosFlota_Parte1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static VehiculosFlota_Parte1 instance = new VehiculosFlota_Parte1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VehiculosFlota_Parte1()
        {
            Anio = "2009";
            Marca = "CHEVROLET";
            Modelo = "ASTRA";
            Actividad = "Sin Actividad";
            SumaAsegurada = "400000";
            Producto = "A - Responsabilidad Civil Unicamente";
            Patente = "ZZZ999";
            Motor = "ABH134H8812";
            Chasis = "CA52MN31912";
            NombreArchivo = "";
            NroTransaccion = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VehiculosFlota_Parte1 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Marca;

        /// <summary>
        /// Gets or sets the value of variable Marca.
        /// </summary>
        [TestVariable("cd5fbe31-698f-43f6-b13e-d72dae3c575d")]
        public string Marca
        {
            get { return _Marca; }
            set { _Marca = value; }
        }

        string _Modelo;

        /// <summary>
        /// Gets or sets the value of variable Modelo.
        /// </summary>
        [TestVariable("d00cad0a-f599-40f5-86b0-b27b9c1c4574")]
        public string Modelo
        {
            get { return _Modelo; }
            set { _Modelo = value; }
        }

        string _Actividad;

        /// <summary>
        /// Gets or sets the value of variable Actividad.
        /// </summary>
        [TestVariable("d8620377-8490-44c6-8598-1559b8a9dd66")]
        public string Actividad
        {
            get { return _Actividad; }
            set { _Actividad = value; }
        }

        string _Patente;

        /// <summary>
        /// Gets or sets the value of variable Patente.
        /// </summary>
        [TestVariable("c1130e12-502d-4a69-8f8c-f4044b934b75")]
        public string Patente
        {
            get { return _Patente; }
            set { _Patente = value; }
        }

        string _Motor;

        /// <summary>
        /// Gets or sets the value of variable Motor.
        /// </summary>
        [TestVariable("77302f72-e3f4-4a83-a7d4-1cf1a163a15d")]
        public string Motor
        {
            get { return _Motor; }
            set { _Motor = value; }
        }

        string _Chasis;

        /// <summary>
        /// Gets or sets the value of variable Chasis.
        /// </summary>
        [TestVariable("38141e64-20bf-4c4d-bbff-6c39534bf2d3")]
        public string Chasis
        {
            get { return _Chasis; }
            set { _Chasis = value; }
        }

        string _NombreArchivo;

        /// <summary>
        /// Gets or sets the value of variable NombreArchivo.
        /// </summary>
        [TestVariable("09d52e7e-18eb-4e08-b9c2-c97e2259bb92")]
        public string NombreArchivo
        {
            get { return _NombreArchivo; }
            set { _NombreArchivo = value; }
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
        [TestVariable("62ed1435-e143-4ed5-82e9-a1986f5a6dad")]
        public string Anio
        {
            get { return repo.Anio; }
            set { repo.Anio = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable SumaAsegurada.
        /// </summary>
        [TestVariable("b37864ab-29fa-42c1-aff8-b510d0e28ea0")]
        public string SumaAsegurada
        {
            get { return repo.SumaAsegurada; }
            set { repo.SumaAsegurada = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Producto.
        /// </summary>
        [TestVariable("df188455-dedf-4e6b-9919-90f6a20522a4")]
        public string Producto
        {
            get { return repo.Producto; }
            set { repo.Producto = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable NroTransaccion.
        /// </summary>
        [TestVariable("263d55d7-2e4f-4108-beb1-0650fdfb263f")]
        public string NroTransaccion
        {
            get { return repo.NroTransaccion; }
            set { repo.NroTransaccion = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Anio' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Anio'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_AnioInfo, new RecordItemIndex(0));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Anio.PressKeys(Anio);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.item_cboAnio' at CenterLeft.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.item_cboAnioInfo, new RecordItemIndex(1));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.item_cboAnio.Click(Location.CenterLeft);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(2));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Flota.rdo_0Km' at Center.", repo.SURA.PC.Emision.PolizaMotor.Flota.rdo_0KmInfo, new RecordItemIndex(3));
            repo.SURA.PC.Emision.PolizaMotor.Flota.rdo_0Km.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(4));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Anio'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_AnioInfo, new ActionTimeout(30000), new RecordItemIndex(5));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_AnioInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Marca' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Marca'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_MarcaInfo, new RecordItemIndex(6));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Marca.PressKeys(Marca, 10);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(7));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Marca'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_MarcaInfo, new RecordItemIndex(8));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Marca.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(9));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(10));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Marca'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_MarcaInfo, new ActionTimeout(30000), new RecordItemIndex(11));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_MarcaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Modelo' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Modelo'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ModeloInfo, new RecordItemIndex(12));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Modelo.PressKeys(Modelo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(13));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Modelo'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ModeloInfo, new RecordItemIndex(14));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Modelo.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(15));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(16));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Modelo'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ModeloInfo, new ActionTimeout(30000), new RecordItemIndex(17));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ModeloInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ActividadInfo, new RecordItemIndex(18));
            Keyboard.PrepareFocus(repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ActividadInfo, new RecordItemIndex(19));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Actividad' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ActividadInfo, new RecordItemIndex(20));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad.PressKeys(Actividad);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Actividad'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ActividadInfo, new ActionTimeout(30000), new RecordItemIndex(21));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ActividadInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(22));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAseguradaInfo, new RecordItemIndex(23));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAseguradaInfo, new RecordItemIndex(24));
            Keyboard.PrepareFocus(repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$SumaAsegurada' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAseguradaInfo, new RecordItemIndex(25));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada.PressKeys(SumaAsegurada);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(26));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(27));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_SumaAsegurada'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_SumaAseguradaInfo, new ActionTimeout(30000), new RecordItemIndex(28));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_SumaAseguradaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Producto' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Producto'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ProductoInfo, new RecordItemIndex(29));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Producto.PressKeys(Producto);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(30));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Producto'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ProductoInfo, new ActionTimeout(30000), new RecordItemIndex(31));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ProductoInfo.WaitForNotExists(30000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(32));
            
            // --------------------------------Campos Opcionales
            Report.Log(ReportLevel.Info, "Section", "--------------------------------Campos Opcionales", new RecordItemIndex(33));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Patente' with focus on 'SURA.txtbox_Patente'.", repo.SURA.txtbox_PatenteInfo, new RecordItemIndex(34));
            repo.SURA.txtbox_Patente.PressKeys(Patente);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(35));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.Copy_of_txtbox_Patente'", repo.SURA.Copy_of_txtbox_PatenteInfo, new ActionTimeout(30000), new RecordItemIndex(36));
            repo.SURA.Copy_of_txtbox_PatenteInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.txtbox_Motor'.", repo.SURA.txtbox_MotorInfo, new RecordItemIndex(37));
            Keyboard.PrepareFocus(repo.SURA.txtbox_Motor);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'SURA.txtbox_Motor'.", repo.SURA.txtbox_MotorInfo, new RecordItemIndex(38));
            repo.SURA.txtbox_Motor.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Motor' with focus on 'SURA.txtbox_Motor'.", repo.SURA.txtbox_MotorInfo, new RecordItemIndex(39));
            repo.SURA.txtbox_Motor.PressKeys(Motor);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(40));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.Copy_of_txtbox_Motor'", repo.SURA.Copy_of_txtbox_MotorInfo, new ActionTimeout(30000), new RecordItemIndex(41));
            repo.SURA.Copy_of_txtbox_MotorInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.txtbox_Chasis'.", repo.SURA.txtbox_ChasisInfo, new RecordItemIndex(42));
            Keyboard.PrepareFocus(repo.SURA.txtbox_Chasis);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'SURA.txtbox_Chasis'.", repo.SURA.txtbox_ChasisInfo, new RecordItemIndex(43));
            repo.SURA.txtbox_Chasis.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Chasis' with focus on 'SURA.txtbox_Chasis'.", repo.SURA.txtbox_ChasisInfo, new RecordItemIndex(44));
            repo.SURA.txtbox_Chasis.PressKeys(Chasis);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(45));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.Copy_of_txtbox_Chasis'", repo.SURA.Copy_of_txtbox_ChasisInfo, new ActionTimeout(30000), new RecordItemIndex(46));
            repo.SURA.Copy_of_txtbox_ChasisInfo.WaitForNotExists(30000);
            
            // --------------------------Exportar Archivo
            Report.Log(ReportLevel.Info, "Section", "--------------------------Exportar Archivo", new RecordItemIndex(47));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.bttn_Exportar' at 23;9.", repo.SURA.bttn_ExportarInfo, new RecordItemIndex(48));
            repo.SURA.bttn_Exportar.Click("23;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.bttn_ExportarAHojaCalculo' at Center.", repo.SURA.bttn_ExportarAHojaCalculoInfo, new RecordItemIndex(49));
            repo.SURA.bttn_ExportarAHojaCalculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Endosos2.PolicyChangeWizardLOBWizardStepGroupLi1.bttn_DescargarHojaDeCalculo' at Center.", repo.SURA.PC.Endosos2.PolicyChangeWizardLOBWizardStepGroupLi1.bttn_DescargarHojaDeCalculoInfo, new RecordItemIndex(50));
            repo.SURA.PC.Endosos2.PolicyChangeWizardLOBWizardStepGroupLi1.bttn_DescargarHojaDeCalculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'FormDownload.btn_SolicitudDePoliza'", repo.FormDownload.btn_SolicitudDePolizaInfo, new ActionTimeout(30000), new RecordItemIndex(51));
            repo.FormDownload.btn_SolicitudDePolizaInfo.WaitForExists(30000);
            
            fileCheck();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'FormDownload.btn_SolicitudDePoliza' and assigning its value to variable 'NombreArchivo'.", repo.FormDownload.btn_SolicitudDePolizaInfo, new RecordItemIndex(53));
            NombreArchivo = repo.FormDownload.btn_SolicitudDePoliza.Element.GetAttributeValueText("Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'SURA.txt_SolicitudPoliza' and assigning the part of its value captured by '[0-9]+' to variable 'NroTransaccion'.", repo.SURA.txt_SolicitudPolizaInfo, new RecordItemIndex(54));
            NroTransaccion = repo.SURA.txt_SolicitudPoliza.Element.GetAttributeValueText("InnerText", new Regex("[0-9]+"));
            Delay.Milliseconds(0);
            
            // El nombre del archivo es:
            Report.Log(ReportLevel.Info, "User", NombreArchivo, new RecordItemIndex(55));
            
            // El número de solicitud es:
            Report.Log(ReportLevel.Info, "User", NroTransaccion, new RecordItemIndex(56));
            
            // Manejo del excel
            Report.Log(ReportLevel.Info, "Section", "Manejo del excel", new RecordItemIndex(57));
            
            manejarArchivo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.bttn_VolverAVehiculos' at Center.", repo.SURA.bttn_VolverAVehiculosInfo, new RecordItemIndex(59));
            repo.SURA.bttn_VolverAVehiculos.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SURA.txt_Vehiculos'", repo.SURA.txt_VehiculosInfo, new ActionTimeout(30000), new RecordItemIndex(60));
            repo.SURA.txt_VehiculosInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.btn_GuardarBorrador' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.btn_GuardarBorradorInfo, new RecordItemIndex(61));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.btn_GuardarBorrador.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(62));
            Delay.Duration(5000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
