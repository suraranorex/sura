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
    public partial class CotizarPolizaHogar
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void guardarNumSolicitud()
        {
           	verificarDirectorio();
			string path = @"C:\TEMP\Solicitudes\solicitudesHogar.csv";
			bool exist = File.Exists(path);
			
			string cabecera = "NumSolicitud,NumCuenta" + System.Environment.NewLine;
			string datos = NumSolicitud + "," + ValidateNroCuenta + System.Environment.NewLine;
		
			if(exist) {
				try {
					File.AppendAllText(path,datos);
					Report.Info("Info", "El archivo solicitudesHogar.csv ya existía previamente");
					Report.Success("Info", "Los datos han sido guardados correctamente");
				} catch (Exception e) {
					Report.Failure("Fail", "Error al guardar los datos\r\nError: " + e);
					throw;
				}
			} else {
				try {
					Report.Info("Info", "Se creó el archivo solicitudesHogar.csv");
					File.WriteAllText(path,cabecera);
					File.AppendAllText(path,datos);
					Report.Success("Info", "Los datos han sido guardados correctamente");
				} catch (Exception e) {
					Report.Failure("Fail", "Error al crear el archivo o guardar los datos\r\nError: " + e);
					throw;
				}
        }
        }
        
        public void verificarDirectorio(){
        	Report.Info("Info","Verificando la existencia del directorio destino");
			
        	if (!Directory.Exists(@"C:\TEMP\Solicitudes"))
			{
				Report.Info("Info","No se encontro el directorio, comienza la creacion del directorio...");
				Directory.CreateDirectory(@"C:\TEMP\Solicitudes");
				Report.Info("Info","Creacion del directorio finalizada.");
			}
			Report.Info("Info","Verificacion finalizada");
        }

    }
}
