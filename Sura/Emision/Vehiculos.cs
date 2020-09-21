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
    ///The Vehiculos recording.
    /// </summary>
    [TestModule("a8db0db7-1495-4f4c-82cf-9b7785069bda", ModuleType.Recording, 1)]
    public partial class Vehiculos : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static Vehiculos instance = new Vehiculos();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Vehiculos()
        {
            Anio = "2009";
            Marca = "CHEVROLET";
            Modelo = "ASTRA";
            SumaAsegurada = "400000";
            Producto = "A - Responsabilidad Civil Unicamente";
            Patente = "ZZZ999";
            Motor = "ABH134H8812";
            Chasis = "CA52MN31912";
            Actividad = "Sin Actividad";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Vehiculos Instance
        {
            get { return instance; }
        }

#region Variables

        string _Marca;

        /// <summary>
        /// Gets or sets the value of variable Marca.
        /// </summary>
        [TestVariable("530cc40f-c5ca-499d-8134-cc7de4b9df6a")]
        public string Marca
        {
            get { return _Marca; }
            set { _Marca = value; }
        }

        string _Modelo;

        /// <summary>
        /// Gets or sets the value of variable Modelo.
        /// </summary>
        [TestVariable("ca116355-04ae-4788-a082-c59d2549f9a5")]
        public string Modelo
        {
            get { return _Modelo; }
            set { _Modelo = value; }
        }

        string _Patente;

        /// <summary>
        /// Gets or sets the value of variable Patente.
        /// </summary>
        [TestVariable("e8224fca-8080-4ad3-90af-9cb992c61e30")]
        public string Patente
        {
            get { return _Patente; }
            set { _Patente = value; }
        }

        string _Motor;

        /// <summary>
        /// Gets or sets the value of variable Motor.
        /// </summary>
        [TestVariable("ad7ae700-5483-453a-afb1-ab8843eedf86")]
        public string Motor
        {
            get { return _Motor; }
            set { _Motor = value; }
        }

        string _Chasis;

        /// <summary>
        /// Gets or sets the value of variable Chasis.
        /// </summary>
        [TestVariable("c36048c9-4d5a-4bad-b6b8-658dd965e627")]
        public string Chasis
        {
            get { return _Chasis; }
            set { _Chasis = value; }
        }

        string _Actividad;

        /// <summary>
        /// Gets or sets the value of variable Actividad.
        /// </summary>
        [TestVariable("1584d5c5-17f1-4934-a8ee-6aa46e81b1e3")]
        public string Actividad
        {
            get { return _Actividad; }
            set { _Actividad = value; }
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
        [TestVariable("b33950d6-3d59-43a8-b2e5-3f0f339f77ab")]
        public string Anio
        {
            get { return repo.Anio; }
            set { repo.Anio = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable SumaAsegurada.
        /// </summary>
        [TestVariable("4a0ed49e-feb3-4307-aff7-07782ac32de7")]
        public string SumaAsegurada
        {
            get { return repo.SumaAsegurada; }
            set { repo.SumaAsegurada = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Producto.
        /// </summary>
        [TestVariable("e2cdec4e-22ac-4626-b31e-3efcc29b593c")]
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Anio' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Anio'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_AnioInfo, new RecordItemIndex(0));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Anio.PressKeys(Anio);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(1));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Anio'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_AnioInfo, new ActionTimeout(45000), new RecordItemIndex(2));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_AnioInfo.WaitForNotExists(45000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Marca' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Marca'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_MarcaInfo, new RecordItemIndex(3));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Marca.PressKeys(Marca, 10);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(4));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Marca'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_MarcaInfo, new RecordItemIndex(5));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Marca.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(6));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(7));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(8));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Marca'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_MarcaInfo, new ActionTimeout(45000), new RecordItemIndex(9));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_MarcaInfo.WaitForNotExists(45000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Modelo' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Modelo'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ModeloInfo, new RecordItemIndex(10));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Modelo.PressKeys(Modelo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(11));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Modelo'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ModeloInfo, new RecordItemIndex(12));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Modelo.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(13));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(14));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(15));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Modelo'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ModeloInfo, new ActionTimeout(45000), new RecordItemIndex(16));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ModeloInfo.WaitForNotExists(45000);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ActividadInfo, new RecordItemIndex(17));
            //Keyboard.PrepareFocus(repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad);
            //Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ActividadInfo, new RecordItemIndex(18));
            //repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad.PressKeys("{Back}");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Actividad' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ActividadInfo, new RecordItemIndex(19));
            //repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Actividad.PressKeys(Actividad);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(20));
            //repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Actividad'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ActividadInfo, new ActionTimeout(45000), new RecordItemIndex(21));
            //repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ActividadInfo.WaitForNotExists(45000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAseguradaInfo, new RecordItemIndex(22));
            Keyboard.PrepareFocus(repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$SumaAsegurada' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAseguradaInfo, new RecordItemIndex(23));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_SumaAsegurada.PressKeys(SumaAsegurada);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(24));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(25));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_SumaAsegurada'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_SumaAseguradaInfo, new ActionTimeout(45000), new RecordItemIndex(26));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_SumaAseguradaInfo.WaitForNotExists(45000);
            
            // --------------------------------Campos Opcionales
            Report.Log(ReportLevel.Info, "Section", "--------------------------------Campos Opcionales", new RecordItemIndex(27));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Patente' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Patente'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_PatenteInfo, new RecordItemIndex(28));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Patente.PressKeys(Patente);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(29));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Patente'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_PatenteInfo, new ActionTimeout(45000), new RecordItemIndex(30));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_PatenteInfo.WaitForNotExists(45000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Motor'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_MotorInfo, new RecordItemIndex(31));
            Keyboard.PrepareFocus(repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Motor);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Motor'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_MotorInfo, new RecordItemIndex(32));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Motor.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Motor' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Motor'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_MotorInfo, new RecordItemIndex(33));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Motor.PressKeys(Motor);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(34));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Motor'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_MotorInfo, new ActionTimeout(45000), new RecordItemIndex(35));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_MotorInfo.WaitForNotExists(45000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Chasis'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ChasisInfo, new RecordItemIndex(36));
            Keyboard.PrepareFocus(repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Chasis);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Chasis'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ChasisInfo, new RecordItemIndex(37));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Chasis.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Chasis' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Chasis'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ChasisInfo, new RecordItemIndex(38));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Chasis.PressKeys(Chasis);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(39));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Chasis'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ChasisInfo, new ActionTimeout(45000), new RecordItemIndex(40));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ChasisInfo.WaitForNotExists(45000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(41));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Producto' with focus on 'SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Producto'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_ProductoInfo, new RecordItemIndex(42));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.txtbox_Producto.PressKeys(Producto);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo' at Center.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculoInfo, new RecordItemIndex(43));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.lbl_InfoDelVehiculo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_Producto'", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ProductoInfo, new ActionTimeout(45000), new RecordItemIndex(44));
            repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.Copias.Copy_of_txtbox_ProductoInfo.WaitForNotExists(45000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(45));
            
            // --------------------------------Cambio a Siguiente Pantalla
            Report.Log(ReportLevel.Info, "Section", "--------------------------------Cambio a Siguiente Pantalla", new RecordItemIndex(46));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_SiguienteInfo, new RecordItemIndex(47));
            //repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to exist. Associated repository item: 'SURA.PC.Txt_Validacion.txt_ComisionesDescuentos'", repo.SURA.PC.Txt_Validacion.txt_ComisionesDescuentosInfo, new ActionTimeout(45000), new RecordItemIndex(48));
            //repo.SURA.PC.Txt_Validacion.txt_ComisionesDescuentosInfo.WaitForExists(45000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
