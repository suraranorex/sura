/*
 * Created by Ranorex
 * User: No Name
 * Date: 27/02/2020
 * Time: 17:40
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace Sura.Generales
{
    /// <summary>
    /// Description of UCM_setStatus.
    /// </summary>
    [TestModule("660F1F4C-2C78-48D8-952D-AE5257272AA2", ModuleType.UserCode, 1)]
    public class UCM_setStatus : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UCM_setStatus()
        {
        	// Do not delete - a parameterless constructor is required!
        }

        string _p_Status = "";
        [TestVariable("0933cd8d-bbf5-47a7-86ff-c9310c174896")]
        public string p_Status
        {
        	get { return _p_Status; }
        	set { _p_Status = value; }
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            p_Status = TestSuite.CurrentTestContainer.Status.ToString();
        }
    }
}
