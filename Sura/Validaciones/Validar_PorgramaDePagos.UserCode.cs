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
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;


namespace Sura.Validaciones
{

}
namespace Sura.Validaciones
{
	public partial class Validar_PorgramaDePagos
	{
		/// <summary>
		/// This method gets called right after the recording has been started.
		/// It can be used to execute recording specific initialization code.
		/// </summary>
		private void Init()
		{
			// Your recording specific initialization code goes here.
		}

		public void validarCantidadCuotas()
		{
			// TODO: Replace the following line with your code implementation.
			//throw new NotImplementedException();

			int filaINT = int.Parse(Fila);
			
			while(filaINT<=int.Parse(CantCuotas)){
				Report.Log(ReportLevel.Info, "Validation", "Validando la fila número...", repo.SURA.Validacion_ProgramaPagos.fila_CuotaInfo, new RecordItemIndex(filaINT));
				Report.Log(ReportLevel.Info, "Validation", Fila, new RecordItemIndex(filaINT+1));
				
				Validate.Exists(repo.SURA.Validacion_ProgramaPagos.fila_CuotaInfo);
				Delay.Milliseconds(0);
				
				filaINT++;
				Fila= filaINT.ToString();
				
			}
			
			Report.Log(ReportLevel.Info, "Info", "No existen más filas en la tabla Programa de Pagos", new RecordItemIndex(filaINT));
			
		}

	}
}
