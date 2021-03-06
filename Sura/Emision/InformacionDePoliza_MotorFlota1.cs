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
    ///The InformacionDePoliza_MotorFlota1 recording.
    /// </summary>
    [TestModule("f5e15f90-cde0-4877-a54a-460d88c334e4", ModuleType.Recording, 1)]
    public partial class InformacionDePoliza_MotorFlota1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static InformacionDePoliza_MotorFlota1 instance = new InformacionDePoliza_MotorFlota1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InformacionDePoliza_MotorFlota1()
        {
            CantVehiculos = "5 o más vehículos";
            MetodoDePago = "Cupón";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InformacionDePoliza_MotorFlota1 Instance
        {
            get { return instance; }
        }

#region Variables

        string _CantVehiculos;

        /// <summary>
        /// Gets or sets the value of variable CantVehiculos.
        /// </summary>
        [TestVariable("552958da-c020-4738-b082-48231e703c99")]
        public string CantVehiculos
        {
            get { return _CantVehiculos; }
            set { _CantVehiculos = value; }
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
        /// Gets or sets the value of variable OPCION_PAGOCUOTAS.
        /// </summary>
        [TestVariable("b047dcae-a43e-4341-b82d-66d844bb7960")]
        public string OPCION_PAGOCUOTAS
        {
            get { return repo.OPCION_PAGOCUOTAS; }
            set { repo.OPCION_PAGOCUOTAS = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable MetodoDePago.
        /// </summary>
        [TestVariable("83430755-701e-4aa3-a32c-748d2f0a35df")]
        public string MetodoDePago
        {
            get { return repo.MetodoDePago; }
            set { repo.MetodoDePago = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_CantVehiculos' at Center.", repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_CantVehiculosInfo, new RecordItemIndex(0));
            repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_CantVehiculos.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_CantVehiculos'.", repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_CantVehiculosInfo, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_CantVehiculos);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_CantVehiculos'.", repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_CantVehiculosInfo, new RecordItemIndex(2));
            repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_CantVehiculos.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CantVehiculos' with focus on 'SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_CantVehiculos'.", repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_CantVehiculosInfo, new RecordItemIndex(3));
            repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.list_CantVehiculos.PressKeys(CantVehiculos);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.Pantalla' at UpperRight.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.PantallaInfo, new RecordItemIndex(4));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.Pantalla.Click(Location.UpperRight);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaMotor.InformacionDePoliza.Copy_of_list_CantVehiculos'", repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.Copy_of_list_CantVehiculosInfo, new ActionTimeout(15000), new RecordItemIndex(5));
            repo.SURA.PC.Emision.PolizaMotor.InformacionDePoliza.Copy_of_list_CantVehiculosInfo.WaitForNotExists(15000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$MetodoDePago' with focus on 'SURA.PC.Emision.Generales.InformacionDePoliza.list_MetodoDePago'.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.list_MetodoDePagoInfo, new RecordItemIndex(6));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.list_MetodoDePago.PressKeys(MetodoDePago);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.Pantalla' at UpperRight.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.PantallaInfo, new RecordItemIndex(7));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.Pantalla.Click(Location.UpperRight);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to not exist. Associated repository item: 'SURA.PC.Emision.Generales.InformacionDePoliza.Copy_of_list_MetodoDePago'", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Copy_of_list_MetodoDePagoInfo, new ActionTimeout(15000), new RecordItemIndex(8));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.Copy_of_list_MetodoDePagoInfo.WaitForNotExists(15000);
            
            // NOTA: se comentaron los sig items por la condición de CantCuotas Si o No
            Report.Log(ReportLevel.Info, "Section", "NOTA: se comentaron los sig items por la condición de CantCuotas Si o No", new RecordItemIndex(9));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.rb_PagoCuotas' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.rb_PagoCuotasInfo, new RecordItemIndex(10));
            //repo.SURA.PC.Emision.Generales.InformacionDePoliza.rb_PagoCuotas.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to exist. Associated repository item: 'SURA.PC.Emision.Generales.InformacionDePoliza.option_Pago'", repo.SURA.PC.Emision.Generales.InformacionDePoliza.option_PagoInfo, new ActionTimeout(15000), new RecordItemIndex(11));
            //repo.SURA.PC.Emision.Generales.InformacionDePoliza.option_PagoInfo.WaitForExists(15000);
            
            // --------------------------Capturas de pantalla
            Report.Log(ReportLevel.Info, "Section", "--------------------------Capturas de pantalla", new RecordItemIndex(12));
            
            //Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(13));
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(14));
            //Delay.Duration(1000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_SiguienteInfo, new RecordItemIndex(15));
            //repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente.MoveTo();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_SiguienteInfo, new RecordItemIndex(16));
            //repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SURA.PC.Txt_Validacion.txt_ConductoresPropietarios'", repo.SURA.PC.Txt_Validacion.txt_ConductoresPropietariosInfo, new ActionTimeout(30000), new RecordItemIndex(17));
            //repo.SURA.PC.Txt_Validacion.txt_ConductoresPropietariosInfo.WaitForExists(30000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
