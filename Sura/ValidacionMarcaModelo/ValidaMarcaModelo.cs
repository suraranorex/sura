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

namespace Sura.ValidacionMarcaModelo
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidaMarcaModelo recording.
    /// </summary>
    [TestModule("103649b8-d4a2-4a04-a3dc-0791228b7980", ModuleType.Recording, 1)]
    public partial class ValidaMarcaModelo : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static ValidaMarcaModelo instance = new ValidaMarcaModelo();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidaMarcaModelo()
        {
            Marca = "SIN MARCA";
            Modelo = "TRAILER ZUMUVA";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidaMarcaModelo Instance
        {
            get { return instance; }
        }

#region Variables

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
        /// Gets or sets the value of variable Marca.
        /// </summary>
        [TestVariable("d8ed3c76-9dca-4386-96c3-80018452fb87")]
        public string Marca
        {
            get { return repo.Marca; }
            set { repo.Marca = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Modelo.
        /// </summary>
        [TestVariable("d125edff-9547-4ed1-8db7-d5efe4d96753")]
        public string Modelo
        {
            get { return repo.Modelo; }
            set { repo.Modelo = value; }
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

            //Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SURA.PC.Emision.PolizaMotor.ValidacionMarcaModelo.Marca'.", repo.SURA.PC.Emision.PolizaMotor.ValidacionMarcaModelo.MarcaInfo, new RecordItemIndex(0));
            //Validate.Exists(repo.SURA.PC.Emision.PolizaMotor.ValidacionMarcaModelo.MarcaInfo);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SURA.PC.Emision.PolizaMotor.ValidacionMarcaModelo.Modelo'.", repo.SURA.PC.Emision.PolizaMotor.ValidacionMarcaModelo.ModeloInfo, new RecordItemIndex(1));
            //Validate.Exists(repo.SURA.PC.Emision.PolizaMotor.ValidacionMarcaModelo.ModeloInfo);
            //Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText=$Marca) on item 'SURA.PC.Emision.PolizaMotor.ValidacionMarcaModelo.Copy_of_Marca'.", repo.SURA.PC.Emision.PolizaMotor.ValidacionMarcaModelo.Copy_of_MarcaInfo, new RecordItemIndex(2));
                Validate.AttributeEqual(repo.SURA.PC.Emision.PolizaMotor.ValidacionMarcaModelo.Copy_of_MarcaInfo, "InnerText", Marca, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText=$Modelo) on item 'SURA.PC.Emision.PolizaMotor.ValidacionMarcaModelo.Copy_of_Modelo'.", repo.SURA.PC.Emision.PolizaMotor.ValidacionMarcaModelo.Copy_of_ModeloInfo, new RecordItemIndex(3));
                Validate.AttributeEqual(repo.SURA.PC.Emision.PolizaMotor.ValidacionMarcaModelo.Copy_of_ModeloInfo, "InnerText", Modelo, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}