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

namespace Sura.GestionDocumental
{
    public partial class VerFormulario_Emitida
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void manejarFormulario()
        {
            verificarDirectorio();
      		moverArchivo();
            //throw new NotImplementedException();
        }

        public void fileCheck()
        {
        	Report.Info("Info","Esperando la descarga del archivo");
        	
        	while (repo.Chrome.bttn_FormularioPDFInfo.Exists(1000))
        	{
        		if (repo.Chrome.bttn_FormularioPDF.Element.GetAttributeValueText("Text").Contains("KB"))
        			Delay.Milliseconds(500);
        		else
        			break;
        	}
        	
        	Report.Info("Info","Descarga finalizada");
        }
        
        public void verificarDirectorio(){
        	Report.Info("Info","Verificando la existencia del directorio destino");
        	
        	if (!Directory.Exists(@"R:\TEMP\Formularios\"+ NumeroPoliza.TrimStart()))
        	{
        		Report.Info("Info","No se encontro el directorio, comienza la creacion del directorio...");
        		Directory.CreateDirectory(@"R:\TEMP\Formularios\" + NumeroPoliza.TrimStart());
        		Report.Info("Info","Creacion del directorio finalizada.");
        	}
        	Report.Info("Info","Verificacion finalizada");
        }
        
        public void moverArchivo(){
        	
        	string userRoot = System.Environment.GetEnvironmentVariable("USERPROFILE");
        	string downloadFolder = Path.Combine(userRoot, @"Downloads\");
        	
        	string origen = downloadFolder + NombreArchivo.TrimStart();
        	string destino = @"R:\TEMP\Formularios\" + NumeroPoliza.TrimStart() +"\\" + NombreArchivo.TrimStart();
      
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
