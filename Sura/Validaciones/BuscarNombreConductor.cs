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

namespace Sura.Validaciones
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BuscarNombreConductor recording.
    /// </summary>
    [TestModule("b7ea5ae3-a326-4c2d-ae9e-3cd8e37bcbee", ModuleType.Recording, 1)]
    public partial class BuscarNombreConductor : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static BuscarNombreConductor instance = new BuscarNombreConductor();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BuscarNombreConductor()
        {
            Conductor = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BuscarNombreConductor Instance
        {
            get { return instance; }
        }

#region Variables

        string _Conductor;

        /// <summary>
        /// Gets or sets the value of variable Conductor.
        /// </summary>
        [TestVariable("fcb0ec05-2a7a-43c0-ad42-1ca24e7704cd")]
        public string Conductor
        {
            get { return _Conductor; }
            set { _Conductor = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Endosos.Motor.bttn_PantallaVehiculos' at Center.", repo.SURA.PC.Endosos.Motor.bttn_PantallaVehiculosInfo, new RecordItemIndex(0));
            repo.SURA.PC.Endosos.Motor.bttn_PantallaVehiculos.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 20s to exist. Associated repository item: 'SURA.PC.Txt_Validacion.txt_Vehiculos'", repo.SURA.PC.Txt_Validacion.txt_VehiculosInfo, new ActionTimeout(20000), new RecordItemIndex(1));
            repo.SURA.PC.Txt_Validacion.txt_VehiculosInfo.WaitForExists(20000);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'SURA.PC.Emision.PolizaMotor.Vehiculoss.input_Conductor' and assigning its value to variable 'Conductor'.", repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.input_ConductorInfo, new RecordItemIndex(2));
            Conductor = repo.SURA.PC.Emision.PolizaMotor.Vehiculoss.input_Conductor.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
