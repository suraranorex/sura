/*
 * Created by Ranorex
 * User: No Name
 * Date: 19/02/2020
 * Time: 11:51
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace Sura.Emision
{
	/// <summary>
	/// Description of UCM_FinalizacionArchivos.
	/// </summary>
	[TestModule("E978B635-51A1-484F-9DD3-A3B94E157C0E", ModuleType.UserCode, 1)]
	public class UCM_FinalizacionArchivos : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public UCM_FinalizacionArchivos()
		{
			// Do not delete - a parameterless constructor is required!
		}

		string _NOMBREARCHIVO = "Solicitud_de_Póliza_0060789931_Personas_Aseguradas_20241018-1350.xlsx";
		[TestVariable("cee5455c-8e3c-448d-971f-a39f50d1d5e1")]
		public string NOMBREARCHIVO
		{
			get { return _NOMBREARCHIVO; }
			set { _NOMBREARCHIVO = value; }
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
			
			Report.Info("I/O","Inicia backup de Solicitudes de Poliza...");
			
			//PreCondiciones
			verificaDirectorio(@"C:\TEMP\SolicitudesRealizadas");
			
			//Variables
			bool existe = File.Exists(@"C:\TEMP\SolicitudesRealizadas\" + NOMBREARCHIVO);
			
			try {
				if (existe)
				{
					File.Delete(@"C:\TEMP\" + NOMBREARCHIVO);
				} else {
					File.Move(@"C:\TEMP\" + NOMBREARCHIVO,@"C:\TEMP\SolicitudesRealizadas\" + NOMBREARCHIVO);
				}
				Report.Success("I/O","Finaliza backup de Solicitudes de Poliza");
			} catch (Exception e) {
				Report.Failure("I/O","No se pudo realizar la operacion\r\nError: " + e);
			}
			
//			Report.Info("I/O","Inicia Reset del archivo Nomina.csv...");
//			
//			//Variables
//			string cabecera = "NROTRANSACCION,PATH,NOMBREARCHIVO" + System.Environment.NewLine;
//			string ejec = TestSuite.CurrentTestContainer.Name.ToString();
//			string filePath = string.Empty;
//			
//			switch (ejec)
//			{
//				case "ImportarExcelAP":
//					filePath = @"C:\TEMP\Nomina.csv";
//					resetFileCSV(filePath,cabecera);
//					break;
//				case "ImportaExcelMOTOR":
//					filePath = @"C:\TEMP\Flota.csv";
//					resetFileCSV(filePath,cabecera);
//					break;
//			}
			
		}
		
		private void verificaDirectorio (string path)
		{
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
		}
		
//		private void resetFileCSV (string filePath, string cabecera)
//		{
//			try {
//				File.WriteAllText(filePath,cabecera);
//				Report.Success("I/O","Finaliza Reset del archivo CSV");
//			} catch (Exception e) {
//				Report.Failure("I/O","No se pudo realizar la operacion\r\nError: " + e);
//			}
//		}
	}
}
