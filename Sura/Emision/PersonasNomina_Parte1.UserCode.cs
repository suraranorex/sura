﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Sura.Emision
{
    public partial class PersonasNomina_Parte1
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void manejarArchivo()
        {
            verificarDirectorio();
      		guardarDatos();
        	moverArchivo();
        }

       public void fileCheck()
		{
			Report.Info("Info","Esperando la descarga del archivo");
			
			while (repo.FormDownload.btn_SolicitudDePolizaInfo.Exists(1000))
			{
				if (repo.FormDownload.btn_SolicitudDePoliza.Element.GetAttributeValueText("Text").Contains("KB"))
					Delay.Milliseconds(500);
				else
					break;
			}
			
			Report.Info("Info","Descarga finalizada");
		}
        
        public void verificarDirectorio(){
        	Report.Info("Info","Verificando la existencia del directorio destino");
			
        	if (!Directory.Exists(@"C:\TEMP\"))
			{
				Report.Info("Info","No se encontro el directorio, comienza la creacion del directorio...");
				Directory.CreateDirectory(@"C:\TEMP\");
				Report.Info("Info","Creacion del directorio finalizada.");
			}
			Report.Info("Info","Verificacion finalizada");
        }
        
        public void guardarDatos(){
        	string path = @"C:\TEMP\Nomina.csv";
			bool exist = File.Exists(path);
			
			string cabecera = "NROTRANSACCION,PATH,NOMBREARCHIVO" + System.Environment.NewLine;
			string datos = NroTransaccion + @",C:\TEMP\," + NombreArchivo + System.Environment.NewLine;
		
			datos=datos.Replace(" ","");
			
			
			if(exist){
				try {
					File.AppendAllText(path,datos);
					Report.Info("Info", "El archivo Nomina.csv ya existía previamente");
					Report.Success("Info", "Los datos han sido guardados correctamente");
				} catch (Exception e) {
					Report.Failure("Fail", "Error al guardar los datos\r\nError: " + e);
					throw;
				}
			} else {
				try {
					Report.Info("Info", "Se creó el archivo Nomina.csv");
					File.WriteAllText(path,cabecera);
					File.AppendAllText(path,datos);
					Report.Success("Info", "Los datos han sido guardados correctamente");
				} catch (Exception e) {
					Report.Failure("Fail", "Error al crear el archivo o guardar los datos\r\nError: " + e);
					throw;
				}	
			}
        }
        
        //Método para mover el archivo excel descargado al directorio creado para poder luego importarlo desde allí
        public void moverArchivo() {
        	
        	string userRoot = System.Environment.GetEnvironmentVariable("USERPROFILE");
            string downloadFolder = Path.Combine(userRoot, @"Downloads\");
            
            string origen = downloadFolder + NombreArchivo.TrimStart();
        	string destino = @"C:\TEMP\" + NombreArchivo.TrimStart();
        	      
        	try {
	        	File.Move(origen, destino);
	        	Report.Success("Info", "El archivo se ha movido correctamente");
	        } catch (Exception e) {
	        	Report.Failure("Fail", "Error al mover el archivo\r\nError: " + e);
	        	throw;
	        }	
        }

    }
}
