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
    ///The Producto recording.
    /// </summary>
    [TestModule("049c3d9f-6afa-4967-aa60-496be1286bb8", ModuleType.Recording, 1)]
    public partial class Producto : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static Producto instance = new Producto();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Producto()
        {
            Oferta = "AP Total";
            Extension = "Jornada Laboral";
            Ambito = "República Argentina";
            TomadorComoBenef = "No";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Producto Instance
        {
            get { return instance; }
        }

#region Variables

        string _Oferta;

        /// <summary>
        /// Gets or sets the value of variable Oferta.
        /// </summary>
        [TestVariable("2f9771f4-d42a-4516-ae6b-bc637eba8d1c")]
        public string Oferta
        {
            get { return _Oferta; }
            set { _Oferta = value; }
        }

        string _Extension;

        /// <summary>
        /// Gets or sets the value of variable Extension.
        /// </summary>
        [TestVariable("ee26d163-a9f7-49eb-8c2c-f8584a2c6ef5")]
        public string Extension
        {
            get { return _Extension; }
            set { _Extension = value; }
        }

        string _Ambito;

        /// <summary>
        /// Gets or sets the value of variable Ambito.
        /// </summary>
        [TestVariable("e4716c08-ed17-4fb9-8242-a85fc04ecb8e")]
        public string Ambito
        {
            get { return _Ambito; }
            set { _Ambito = value; }
        }

        string _TomadorComoBenef;

        /// <summary>
        /// Gets or sets the value of variable TomadorComoBenef.
        /// </summary>
        [TestVariable("c9ebcd1a-573b-455c-a2cb-be24e91ed663")]
        public string TomadorComoBenef
        {
            get { return _TomadorComoBenef; }
            set { _TomadorComoBenef = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Oferta' with focus on 'SURA.PC.Emision.PolizaAP.Producto.txtbox_SeleccionDeOfertas'.", repo.SURA.PC.Emision.PolizaAP.Producto.txtbox_SeleccionDeOfertasInfo, new RecordItemIndex(0));
            repo.SURA.PC.Emision.PolizaAP.Producto.txtbox_SeleccionDeOfertas.PressKeys(Oferta);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaAP.Producto.Pantalla' at CenterRight.", repo.SURA.PC.Emision.PolizaAP.Producto.PantallaInfo, new RecordItemIndex(1));
            repo.SURA.PC.Emision.PolizaAP.Producto.Pantalla.Click(Location.CenterRight);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaAP.Producto.Copy_of_txtbox_SeleccionDeOfertas'", repo.SURA.PC.Emision.PolizaAP.Producto.Copy_of_txtbox_SeleccionDeOfertasInfo, new ActionTimeout(15000), new RecordItemIndex(2));
            repo.SURA.PC.Emision.PolizaAP.Producto.Copy_of_txtbox_SeleccionDeOfertasInfo.WaitForNotExists(15000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Extension' with focus on 'SURA.PC.Emision.PolizaAP.Producto.txtbox_ExtensionDeCobertura'.", repo.SURA.PC.Emision.PolizaAP.Producto.txtbox_ExtensionDeCoberturaInfo, new RecordItemIndex(3));
            repo.SURA.PC.Emision.PolizaAP.Producto.txtbox_ExtensionDeCobertura.PressKeys(Extension);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaAP.Producto.Pantalla' at CenterRight.", repo.SURA.PC.Emision.PolizaAP.Producto.PantallaInfo, new RecordItemIndex(4));
            repo.SURA.PC.Emision.PolizaAP.Producto.Pantalla.Click(Location.CenterRight);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaAP.Producto.Copy_of_txtbox_ExtensionDeCobertura'", repo.SURA.PC.Emision.PolizaAP.Producto.Copy_of_txtbox_ExtensionDeCoberturaInfo, new ActionTimeout(15000), new RecordItemIndex(5));
            repo.SURA.PC.Emision.PolizaAP.Producto.Copy_of_txtbox_ExtensionDeCoberturaInfo.WaitForNotExists(15000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Ambito' with focus on 'SURA.PC.Emision.PolizaAP.Producto.txtbox_AmbitoDeCobertura'.", repo.SURA.PC.Emision.PolizaAP.Producto.txtbox_AmbitoDeCoberturaInfo, new RecordItemIndex(6));
            repo.SURA.PC.Emision.PolizaAP.Producto.txtbox_AmbitoDeCobertura.PressKeys(Ambito);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaAP.Producto.Pantalla' at CenterRight.", repo.SURA.PC.Emision.PolizaAP.Producto.PantallaInfo, new RecordItemIndex(7));
            repo.SURA.PC.Emision.PolizaAP.Producto.Pantalla.Click(Location.CenterRight);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaAP.Producto.Copy_of_txtbox_AmbitoDeCobertura'", repo.SURA.PC.Emision.PolizaAP.Producto.Copy_of_txtbox_AmbitoDeCoberturaInfo, new ActionTimeout(15000), new RecordItemIndex(8));
            repo.SURA.PC.Emision.PolizaAP.Producto.Copy_of_txtbox_AmbitoDeCoberturaInfo.WaitForNotExists(15000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.PC.Emision.PolizaAP.Producto.txtbox_TomadorComoBeneficiario'.", repo.SURA.PC.Emision.PolizaAP.Producto.txtbox_TomadorComoBeneficiarioInfo, new RecordItemIndex(9));
            Keyboard.PrepareFocus(repo.SURA.PC.Emision.PolizaAP.Producto.txtbox_TomadorComoBeneficiario);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$TomadorComoBenef' with focus on 'SURA.PC.Emision.PolizaAP.Producto.txtbox_TomadorComoBeneficiario'.", repo.SURA.PC.Emision.PolizaAP.Producto.txtbox_TomadorComoBeneficiarioInfo, new RecordItemIndex(10));
            repo.SURA.PC.Emision.PolizaAP.Producto.txtbox_TomadorComoBeneficiario.PressKeys(TomadorComoBenef);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.PolizaAP.Producto.Pantalla' at CenterRight.", repo.SURA.PC.Emision.PolizaAP.Producto.PantallaInfo, new RecordItemIndex(11));
            repo.SURA.PC.Emision.PolizaAP.Producto.Pantalla.Click(Location.CenterRight);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to not exist. Associated repository item: 'SURA.PC.Emision.PolizaAP.Producto.Copy_of_txtbox_TomadorComoBeneficiario'", repo.SURA.PC.Emision.PolizaAP.Producto.Copy_of_txtbox_TomadorComoBeneficiarioInfo, new ActionTimeout(15000), new RecordItemIndex(12));
            repo.SURA.PC.Emision.PolizaAP.Producto.Copy_of_txtbox_TomadorComoBeneficiarioInfo.WaitForNotExists(15000);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(13));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_SiguienteInfo, new RecordItemIndex(14));
            repo.SURA.PC.Emision.Generales.InformacionDePoliza.Botones.bttn_Siguiente.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 20s to exist. Associated repository item: 'SURA.PC.Txt_Validacion.txt_Personas'", repo.SURA.PC.Txt_Validacion.txt_PersonasInfo, new ActionTimeout(20000), new RecordItemIndex(15));
            repo.SURA.PC.Txt_Validacion.txt_PersonasInfo.WaitForExists(20000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
