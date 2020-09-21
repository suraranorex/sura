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
    ///The Endoso_ModifDatos recording.
    /// </summary>
    [TestModule("bcc962ae-b01b-4f3d-bf2c-b044af48ea3f", ModuleType.Recording, 1)]
    public partial class Endoso_ModifDatos : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static Endoso_ModifDatos instance = new Endoso_ModifDatos();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Endoso_ModifDatos()
        {
            TipoPoliza_Endoso = "";
            EmailPrincipal = "prueba@gmail.com";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Endoso_ModifDatos Instance
        {
            get { return instance; }
        }

#region Variables

        string _TipoPoliza_Endoso;

        /// <summary>
        /// Gets or sets the value of variable TipoPoliza_Endoso.
        /// </summary>
        [TestVariable("5b9d751e-145c-4050-9e57-419a48d25c9b")]
        public string TipoPoliza_Endoso
        {
            get { return _TipoPoliza_Endoso; }
            set { _TipoPoliza_Endoso = value; }
        }

        string _EmailPrincipal;

        /// <summary>
        /// Gets or sets the value of variable EmailPrincipal.
        /// </summary>
        [TestVariable("4898e993-475c-44e6-b620-b703930840c8")]
        public string EmailPrincipal
        {
            get { return _EmailPrincipal; }
            set { _EmailPrincipal = value; }
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
        /// Gets or sets the value of variable POLIZADIGITAL.
        /// </summary>
        [TestVariable("a6f52be0-9367-4e3a-b2b1-ce8ddaad9e70")]
        public string POLIZADIGITAL
        {
            get { return repo.POLIZADIGITAL; }
            set { repo.POLIZADIGITAL = value; }
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

            Report.Screenshot(ReportLevel.Info, "User", "Información original", repo.SURA.Self, false, new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item 'SURA.PC.Endosos.Generales.rb_PolizaDigital'.", repo.SURA.PC.Endosos.Generales.rb_PolizaDigitalInfo, new RecordItemIndex(1));
            repo.SURA.PC.Endosos.Generales.rb_PolizaDigital.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Endosos.Generales.Copy_of_rb_PolizaDigital'", repo.SURA.PC.Endosos.Generales.Copy_of_rb_PolizaDigitalInfo, new ActionTimeout(30000), new RecordItemIndex(2));
            repo.SURA.PC.Endosos.Generales.Copy_of_rb_PolizaDigitalInfo.WaitForNotExists(30000);
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey 'Ctrl+A' Press with focus on 'SURA.PC.Endosos.Generales.txtbox_EmailPrincipal'.", repo.SURA.PC.Endosos.Generales.txtbox_EmailPrincipalInfo, new RecordItemIndex(3));
                Keyboard.PrepareFocus(repo.SURA.PC.Endosos.Generales.txtbox_EmailPrincipal);
                Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey sequence from variable '$EmailPrincipal' with focus on 'SURA.PC.Endosos.Generales.txtbox_EmailPrincipal'.", repo.SURA.PC.Endosos.Generales.txtbox_EmailPrincipalInfo, new RecordItemIndex(4));
                repo.SURA.PC.Endosos.Generales.txtbox_EmailPrincipal.PressKeys(EmailPrincipal);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to not exist. Associated repository item: 'SURA.PC.Endosos.Generales.Copy_of_txtbox_EmailPrincipal'", repo.SURA.PC.Endosos.Generales.Copy_of_txtbox_EmailPrincipalInfo, new ActionTimeout(15000), new RecordItemIndex(5));
            repo.SURA.PC.Endosos.Generales.Copy_of_txtbox_EmailPrincipalInfo.WaitForNotExists(15000);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(6));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Modificación producida por el endoso", repo.SURA.Self, false, new RecordItemIndex(7));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
