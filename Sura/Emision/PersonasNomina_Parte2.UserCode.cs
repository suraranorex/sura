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
    public partial class PersonasNomina_Parte2
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void quitaExt()
        {
            // TODO: Replace the following line with your code implementation.
            //throw new NotImplementedException();
           
            Report.Info("INFO","Se quita la extencion del archivo para utilizarlo en la selección del tipo de documento importado");
           	repo.nomArchivoSinExt = NombreArchivo.Split('.')[0];
           
        }

//       public void buscarNombre()
//        {
//           string archivo = buscarNombreExcel();
//           
//        }
//        
//        public string buscarNombreExcel()
//        {
//        	string path = @"C:\TEMP\Nomina.csv";
//           	
//        	try {
//                  	
//           	string line;
//           	int count=0;
//           	//Lee cada linea hasta el final del archivo y busca que contenga el número de solicitud de la póliza en cuestión
//           	while((line = File.ReadAllLines(path)[count]) != null)
//			{  
//           		if (line.Contains(NumSolicitud))
//           		    {
//    		  			string resultadoLinea = File.ReadAllLines(path)[count];
//    		  			//Lee la linea hasta la coma, separador utilizado en el csv
//        				int indice = resultadoLinea.IndexOf(",");
//        				string nombreArchivo = resultadoLinea.Substring(0, indice);
//        		
//           				Report.Info("Info", nombreArchivo);
//           		
//           				return(nombreArchivo);
//           		    }
//           		 count++;
//           		 
//			}  
//           	return ("No se encuentró el archivo");
//        	} 
//           	catch (Exception) {
//        		Report.Failure("Error", "Error al intentar leer el archivo Nomina.csv");
//        		throw;
//        	}
//        }
//        
//        
//        //Busca el nombre del archivo a importar y lo escribe en la barra inferior de la ventana emergente
//        public void ingresarNombreArchivo()
//        {
//        	string archivo = buscarNombreExcel();
//        	Report.Log(ReportLevel.Info, "Keyboard", "Key sequence.", new RecordItemIndex(8));
//        	Keyboard.Press(archivo);
//        }
    }
}
