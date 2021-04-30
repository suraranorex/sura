/*
 * Created by Ranorex
 * User: Irina Storozuk
 * Date: 30/04/2021
 * Time: 11:48 a. m.
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace Sura.Generales
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class UC_Generales
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void fileCheck()
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
        
        
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        
        public static void buscarContenidoEnArchivo(string pathArchivo, string pathCarpeta, string contenidoBuscado)
        {
        	string text = string.Empty;
			string line = string.Empty;
			//Elimino, si las hay, los espacios al inicio del nombre de archivo porque puede romper la ruta completar
			pathArchivo = pathArchivo.TrimStart(' ');
			string ruta = pathCarpeta+pathArchivo;
			
			bool encontrado=false;
			
			//Instancio el PdfReader
			PdfReader Reader = new PdfReader(ruta);
			//Asigno la pagina 1 (Si quiero todas las paginas tengo que hacer un ciclo for) a la variable text
			text = PdfTextExtractor.GetTextFromPage(Reader,1);
			//Cierro el archivo PDF
			Reader.Close();
			
			//Instancio un StringReader para leer el texto obtenido de la pagina 1
			StringReader sr = new StringReader(text);
		
			
			//Recorro linea a linea el contenido del texto
			while ((line=sr.ReadLine())!= null)
			{
				//Si la linea contiene...
				if (line.Contains(contenidoBuscado)){
					encontrado=true;
					Report.Log(ReportLevel.Success,"Se ha encontrado el contenido " + contenidoBuscado + " en el archivo.");
				}				
			}
			
			if(!encontrado)
				Report.Log(ReportLevel.Failure,"No se ha encontrado el contenido " + contenidoBuscado + " en el archivo.");
		}
    }
}
