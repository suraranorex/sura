/*
 * Created by Ranorex
 * User: No Name
 * Date: 27/02/2020
 * Time: 17:19
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

using System.IO;

namespace Sura.Emision
{
    /// <summary>
    /// Description of UCM_ResetCSV.
    /// </summary>
    [TestModule("54A5FDCB-8D45-439F-9C0A-F80F96E11509", ModuleType.UserCode, 1)]
    public class UCM_ResetCSV : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UCM_ResetCSV()
        {
        	// Do not delete - a parameterless constructor is required!
        }

        string _p_Status = "";
        [TestVariable("cc0e22a3-940e-4946-bb0e-8b30ab1e08c0")]
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
            
            if (p_Status == "Success")
            {
            	Report.Info("I/O","Inicia Reset del archivo .CSV...");
            	
            	//Variables
            	string cabecera = "NROTRANSACCION,PATH,NOMBREARCHIVO" + System.Environment.NewLine;
            	string ejec = TestSuite.CurrentTestContainer.Name.ToString();
            	string filePath = string.Empty;
            	
            	Report.Info("INFO","Se ejecuto el caso: " + ejec);
            	
            	switch (ejec)
            	{
            		case "EmisiónAP_Nomina/Parte2":
            			resetFileCSV(@"R:\TEMP\Nomina.csv", cabecera);
            			break;
            		case "EmisiónMotor_Flota/Parte2":
            			resetFileCSV(@"R:\TEMP\Flota.csv", cabecera);
            			break;
            	}
            }
            
        }
        
        private void resetFileCSV (string filePath, string cabecera)
		{
			try {
				File.WriteAllText(filePath, cabecera);
				Report.Success("I/O","Finaliza Reset del archivo CSV");
			} catch (Exception e) {
				Report.Failure("I/O","No se pudo realizar la operacion\r\nError: " + e);
			}
		}
    }
}
