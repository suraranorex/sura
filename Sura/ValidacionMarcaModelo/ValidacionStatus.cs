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
    ///The ValidacionStatus recording.
    /// </summary>
    [TestModule("2c92ee0e-bf60-4f22-a58a-07defed5cf16", ModuleType.Recording, 1)]
    public partial class ValidacionStatus : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static ValidacionStatus instance = new ValidacionStatus();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidacionStatus()
        {
            Status = "";
            ID = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidacionStatus Instance
        {
            get { return instance; }
        }

#region Variables

        string _Status;

        /// <summary>
        /// Gets or sets the value of variable Status.
        /// </summary>
        [TestVariable("89f8b764-6464-42c2-84a9-a97eaea7d925")]
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        string _ID;

        /// <summary>
        /// Gets or sets the value of variable ID.
        /// </summary>
        [TestVariable("1e01f4df-2da5-4923-b275-d2463815d81b")]
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
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

            Report.Log(ReportLevel.Info, "User", Status, new RecordItemIndex(0));
            
            GrabaExcel();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
