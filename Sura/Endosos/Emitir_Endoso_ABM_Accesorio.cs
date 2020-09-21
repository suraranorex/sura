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
    ///The Emitir_Endoso_ABM_Accesorio recording.
    /// </summary>
    [TestModule("b46ec1a7-df94-4487-a7e4-87572a8240ce", ModuleType.Recording, 1)]
    public partial class Emitir_Endoso_ABM_Accesorio : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static Emitir_Endoso_ABM_Accesorio instance = new Emitir_Endoso_ABM_Accesorio();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Emitir_Endoso_ABM_Accesorio()
        {
            NumSolicitudEndoso = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Emitir_Endoso_ABM_Accesorio Instance
        {
            get { return instance; }
        }

#region Variables

        string _NumSolicitudEndoso;

        /// <summary>
        /// Gets or sets the value of variable NumSolicitudEndoso.
        /// </summary>
        [TestVariable("d580cb84-c736-4670-ad78-bc7847ff0bb4")]
        public string NumSolicitudEndoso
        {
            get { return _NumSolicitudEndoso; }
            set { _NumSolicitudEndoso = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Endosos.Generales.bttn_EmitirEndoso' at 16;5.", repo.SURA.PC.Endosos.Generales.bttn_EmitirEndosoInfo, new RecordItemIndex(0));
            repo.SURA.PC.Endosos.Generales.bttn_EmitirEndoso.Click("16;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Aceptar' at 11;4.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_AceptarInfo, new RecordItemIndex(1));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Aceptar.Click("11;4");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 45s to exist. Associated repository item: 'SURA.PC.Endosos.Txt_Validacion.txt_SolicitudDeEndosoEmitida'", repo.SURA.PC.Endosos.Txt_Validacion.txt_SolicitudDeEndosoEmitidaInfo, new ActionTimeout(45000), new RecordItemIndex(2));
            //repo.SURA.PC.Endosos.Txt_Validacion.txt_SolicitudDeEndosoEmitidaInfo.WaitForExists(45000);
            
            //Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(3));
            
            //Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'SURA.PC.Endosos.Txt_Validacion.txt_NumeroSolicitudEndoso' and assigning the part of its value captured by '[0-9]{10}' to variable 'NumSolicitudEndoso'.", repo.SURA.PC.Endosos.Txt_Validacion.txt_NumeroSolicitudEndosoInfo, new RecordItemIndex(4));
            //NumSolicitudEndoso = repo.SURA.PC.Endosos.Txt_Validacion.txt_NumeroSolicitudEndoso.Element.GetAttributeValueText("InnerText", new Regex("[0-9]{10}"));
            //Delay.Milliseconds(0);
            
            // El número de endoso emitido es:
            //Report.Log(ReportLevel.Info, "Section", "El número de endoso emitido es:", new RecordItemIndex(5));
            
            //Report.Log(ReportLevel.Info, "User", NumSolicitudEndoso, new RecordItemIndex(6));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
