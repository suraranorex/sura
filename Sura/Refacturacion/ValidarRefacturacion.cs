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

namespace Sura.Refacturacion
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ValidarRefacturacion recording.
    /// </summary>
    [TestModule("fa2cd4b0-301b-42fa-bf1d-f51addd752af", ModuleType.Recording, 1)]
    public partial class ValidarRefacturacion : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static ValidarRefacturacion instance = new ValidarRefacturacion();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidarRefacturacion()
        {
            NroPoliza = "04104013800";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidarRefacturacion Instance
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
        /// Gets or sets the value of variable NroPoliza.
        /// </summary>
        [TestVariable("7f21a146-b56c-4b8b-84a6-3fad8d4c0caa")]
        public string NroPoliza
        {
            get { return repo.NroPoliza; }
            set { repo.NroPoliza = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'SURA.PC.txt_Refacturacion'.", repo.SURA.PC.txt_RefacturacionInfo, new RecordItemIndex(0));
            Validate.Exists(repo.SURA.PC.txt_RefacturacionInfo);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.PC.TransaccionesPoliza, false, new RecordItemIndex(1));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}