﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using System.IO;		// PARA EL FILE
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Sura
{
    public partial class TestCSV
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
            GrabaCSV();

        }


        public void GrabaCSV()
        {
/*
        	//create CSV data connector
		    string connector = "CSVConnector";
		    string csvOutputPath = "C:\\Ranorex\\Test.csv";
		    Ranorex.Core.Data.CsvDataConnector csvConnector = new Ranorex.Core.Data.CsvDataConnector(connector,csvOutputPath,true);
		    csvConnector.SeparatorChar = ',';
		    Ranorex.Core.Data.ColumnCollection propTableColumnsCSV = new Ranorex.Core.Data.ColumnCollection();
		    Ranorex.Core.Data.RowCollection propTableRowsCSV = new Ranorex.Core.Data.RowCollection(propTableColumnsCSV);  
		    //create CSV column headers
		    propTableRowsCSV.Add(new string[3]{"ElementName","ElementIndex","ElementValue"});
		    propTableRowsCSV.Add(new string[3]{"tagName","1","tagValue"});
		    csvConnector.StoreData(propTableColumnsCSV, propTableRowsCSV);
*/
            StreamWriter writer = new StreamWriter(@"C:\Ranorex\Test.csv", true);

            writer.WriteLine("PolicyNumber");
            // writer.WriteLine("");
            writer.Flush();
            writer.Close();

        }
       
    }
}
