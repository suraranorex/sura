﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
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
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Sura.GestionDocumental
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The VerFormulario_Emitida recording.
    /// </summary>
    [TestModule("a814c36b-ccce-4dfa-9a3d-a8c835bd9cbb", ModuleType.Recording, 1)]
    public partial class VerFormulario_Emitida : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static VerFormulario_Emitida instance = new VerFormulario_Emitida();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerFormulario_Emitida()
        {
            NombreArchivo = "";
            NumeroPoliza = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerFormulario_Emitida Instance
        {
            get { return instance; }
        }

#region Variables

        string _NombreArchivo;

        /// <summary>
        /// Gets or sets the value of variable NombreArchivo.
        /// </summary>
        [TestVariable("e97ace66-4793-44b6-83c0-6d0ddf1ef828")]
        public string NombreArchivo
        {
            get { return _NombreArchivo; }
            set { _NombreArchivo = value; }
        }

        string _NumeroPoliza;

        /// <summary>
        /// Gets or sets the value of variable NumeroPoliza.
        /// </summary>
        [TestVariable("dcb2afa7-c137-4f28-a4e0-ef2919b6fc77")]
        public string NumeroPoliza
        {
            get { return _NumeroPoliza; }
            set { _NumeroPoliza = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Ambiente.
        /// </summary>
        [TestVariable("e249a1a2-b157-42ff-9826-60bc615aa12c")]
        public string Ambiente
        {
            get { return repo.Ambiente; }
            set { repo.Ambiente = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(0));
            
            // ----- Cotización Cliente
            Report.Log(ReportLevel.Info, "Section", "----- Cotización Cliente", new RecordItemIndex(1));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.GestionDocumental.bttn_Ver_CotizacionCliente' at Center.", repo.SURA.PC.GestionDocumental.bttn_Ver_CotizacionClienteInfo, new RecordItemIndex(2));
            repo.SURA.PC.GestionDocumental.bttn_Ver_CotizacionCliente.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SURA.PC.GestionDocumental.formularioPDF' at Center.", repo.SURA.PC.GestionDocumental.formularioPDFInfo, new RecordItemIndex(3));
            repo.SURA.PC.GestionDocumental.formularioPDF.Click(System.Windows.Forms.MouseButtons.Right);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Chrome.option_GuardarComo' at Center.", repo.Chrome.option_GuardarComoInfo, new RecordItemIndex(4));
            repo.Chrome.option_GuardarComo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GuardarComo.ButtonGuardar' at Center.", repo.GuardarComo.ButtonGuardarInfo, new RecordItemIndex(5));
            repo.GuardarComo.ButtonGuardar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'Chrome.bttn_FormularioPDF'", repo.Chrome.bttn_FormularioPDFInfo, new ActionTimeout(10000), new RecordItemIndex(6));
            repo.Chrome.bttn_FormularioPDFInfo.WaitForExists(10000);
            
            fileCheck();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'Chrome.bttn_FormularioPDF' and assigning its value to variable 'NombreArchivo'.", repo.Chrome.bttn_FormularioPDFInfo, new RecordItemIndex(8));
            NombreArchivo = repo.Chrome.bttn_FormularioPDF.Element.GetAttributeValueText("Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", NombreArchivo, new RecordItemIndex(9));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'bttn_CerrarPestaniaFormulario' at Center.", repo.bttn_CerrarPestaniaFormularioInfo, new RecordItemIndex(10));
            repo.bttn_CerrarPestaniaFormulario.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'SURA.PC.Emision.PolizaMotor.CoberturasAdicionales.txt_NumPoliza' and assigning its value to variable 'NumeroPoliza'.", repo.SURA.PC.Emision.PolizaMotor.CoberturasAdicionales.txt_NumPolizaInfo, new RecordItemIndex(11));
            NumeroPoliza = repo.SURA.PC.Emision.PolizaMotor.CoberturasAdicionales.txt_NumPoliza.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Chrome.Cerrar' at 17;15.", repo.Chrome.CerrarInfo, new RecordItemIndex(12));
            repo.Chrome.Cerrar.Click("17;15");
            Delay.Milliseconds(0);
            
            manejarFormulario();
            Delay.Milliseconds(0);
            
            // ----- Cotización Productor
            Report.Log(ReportLevel.Info, "Section", "----- Cotización Productor", new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.GestionDocumental.bttn_Ver_CotizacionProductor' at Center.", repo.SURA.PC.GestionDocumental.bttn_Ver_CotizacionProductorInfo, new RecordItemIndex(15));
            repo.SURA.PC.GestionDocumental.bttn_Ver_CotizacionProductor.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SURA.PC.GestionDocumental.formularioPDF' at Center.", repo.SURA.PC.GestionDocumental.formularioPDFInfo, new RecordItemIndex(16));
            repo.SURA.PC.GestionDocumental.formularioPDF.Click(System.Windows.Forms.MouseButtons.Right);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Chrome.option_GuardarComo' at Center.", repo.Chrome.option_GuardarComoInfo, new RecordItemIndex(17));
            repo.Chrome.option_GuardarComo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GuardarComo.ButtonGuardar' at Center.", repo.GuardarComo.ButtonGuardarInfo, new RecordItemIndex(18));
            repo.GuardarComo.ButtonGuardar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'Chrome.bttn_FormularioPDF'", repo.Chrome.bttn_FormularioPDFInfo, new ActionTimeout(10000), new RecordItemIndex(19));
            repo.Chrome.bttn_FormularioPDFInfo.WaitForExists(10000);
            
            fileCheck();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'Chrome.bttn_FormularioPDF' and assigning its value to variable 'NombreArchivo'.", repo.Chrome.bttn_FormularioPDFInfo, new RecordItemIndex(21));
            NombreArchivo = repo.Chrome.bttn_FormularioPDF.Element.GetAttributeValueText("Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", NombreArchivo, new RecordItemIndex(22));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'bttn_CerrarPestaniaFormulario' at Center.", repo.bttn_CerrarPestaniaFormularioInfo, new RecordItemIndex(23));
            repo.bttn_CerrarPestaniaFormulario.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Chrome.Cerrar' at 17;15.", repo.Chrome.CerrarInfo, new RecordItemIndex(24));
            repo.Chrome.Cerrar.Click("17;15");
            Delay.Milliseconds(0);
            
            manejarFormulario();
            Delay.Milliseconds(0);
            
            // ----- Constancia Cobertura Auto
            Report.Log(ReportLevel.Info, "Section", "----- Constancia Cobertura Auto", new RecordItemIndex(26));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.GestionDocumental.bttn_Ver_ConstanciaCoberturaAuto' at Center.", repo.SURA.PC.GestionDocumental.bttn_Ver_ConstanciaCoberturaAutoInfo, new RecordItemIndex(27));
            repo.SURA.PC.GestionDocumental.bttn_Ver_ConstanciaCoberturaAuto.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SURA.PC.GestionDocumental.formularioPDF' at Center.", repo.SURA.PC.GestionDocumental.formularioPDFInfo, new RecordItemIndex(28));
            repo.SURA.PC.GestionDocumental.formularioPDF.Click(System.Windows.Forms.MouseButtons.Right);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Chrome.option_GuardarComo' at Center.", repo.Chrome.option_GuardarComoInfo, new RecordItemIndex(29));
            repo.Chrome.option_GuardarComo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GuardarComo.ButtonGuardar' at Center.", repo.GuardarComo.ButtonGuardarInfo, new RecordItemIndex(30));
            repo.GuardarComo.ButtonGuardar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'Chrome.bttn_FormularioPDF'", repo.Chrome.bttn_FormularioPDFInfo, new ActionTimeout(10000), new RecordItemIndex(31));
            repo.Chrome.bttn_FormularioPDFInfo.WaitForExists(10000);
            
            fileCheck();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'Chrome.bttn_FormularioPDF' and assigning its value to variable 'NombreArchivo'.", repo.Chrome.bttn_FormularioPDFInfo, new RecordItemIndex(33));
            NombreArchivo = repo.Chrome.bttn_FormularioPDF.Element.GetAttributeValueText("Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", NombreArchivo, new RecordItemIndex(34));
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'SURA.PC.Emision.PolizaMotor.CoberturasAdicionales.txt_NumPoliza' and assigning its value to variable 'NumeroPoliza'.", repo.SURA.PC.Emision.PolizaMotor.CoberturasAdicionales.txt_NumPolizaInfo, new RecordItemIndex(35));
            NumeroPoliza = repo.SURA.PC.Emision.PolizaMotor.CoberturasAdicionales.txt_NumPoliza.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Chrome.Cerrar' at 17;15.", repo.Chrome.CerrarInfo, new RecordItemIndex(36));
            repo.Chrome.Cerrar.Click("17;15");
            Delay.Milliseconds(0);
            
            manejarFormulario();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'bttn_CerrarPestaniaFormulario' at Center.", repo.bttn_CerrarPestaniaFormularioInfo, new RecordItemIndex(38));
            repo.bttn_CerrarPestaniaFormulario.Click();
            Delay.Milliseconds(0);
            
            // ----- Factura
            Report.Log(ReportLevel.Info, "Section", "----- Factura", new RecordItemIndex(39));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.GestionDocumental.bttn_Ver_Factura' at Center.", repo.SURA.PC.GestionDocumental.bttn_Ver_FacturaInfo, new RecordItemIndex(40));
            repo.SURA.PC.GestionDocumental.bttn_Ver_Factura.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SURA.PC.GestionDocumental.formularioPDF' at Center.", repo.SURA.PC.GestionDocumental.formularioPDFInfo, new RecordItemIndex(41));
            repo.SURA.PC.GestionDocumental.formularioPDF.Click(System.Windows.Forms.MouseButtons.Right);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Chrome.option_GuardarComo' at Center.", repo.Chrome.option_GuardarComoInfo, new RecordItemIndex(42));
            repo.Chrome.option_GuardarComo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GuardarComo.ButtonGuardar' at Center.", repo.GuardarComo.ButtonGuardarInfo, new RecordItemIndex(43));
            repo.GuardarComo.ButtonGuardar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'Chrome.bttn_FormularioPDF'", repo.Chrome.bttn_FormularioPDFInfo, new ActionTimeout(10000), new RecordItemIndex(44));
            repo.Chrome.bttn_FormularioPDFInfo.WaitForExists(10000);
            
            fileCheck();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'Chrome.bttn_FormularioPDF' and assigning its value to variable 'NombreArchivo'.", repo.Chrome.bttn_FormularioPDFInfo, new RecordItemIndex(46));
            NombreArchivo = repo.Chrome.bttn_FormularioPDF.Element.GetAttributeValueText("Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", NombreArchivo, new RecordItemIndex(47));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Chrome.Cerrar' at 17;15.", repo.Chrome.CerrarInfo, new RecordItemIndex(48));
            repo.Chrome.Cerrar.Click("17;15");
            Delay.Milliseconds(0);
            
            manejarFormulario();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'bttn_CerrarPestaniaFormulario' at Center.", repo.bttn_CerrarPestaniaFormularioInfo, new RecordItemIndex(50));
            repo.bttn_CerrarPestaniaFormulario.Click();
            Delay.Milliseconds(0);
            
            // ----- Tarj. Circ. Tercero Mercosur
            Report.Log(ReportLevel.Info, "Section", "----- Tarj. Circ. Tercero Mercosur", new RecordItemIndex(51));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.GestionDocumental.bttn_Ver_TarjMercosur' at Center.", repo.SURA.PC.GestionDocumental.bttn_Ver_TarjMercosurInfo, new RecordItemIndex(52));
            repo.SURA.PC.GestionDocumental.bttn_Ver_TarjMercosur.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SURA.PC.GestionDocumental.formularioPDF' at Center.", repo.SURA.PC.GestionDocumental.formularioPDFInfo, new RecordItemIndex(53));
            repo.SURA.PC.GestionDocumental.formularioPDF.Click(System.Windows.Forms.MouseButtons.Right);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Chrome.option_GuardarComo' at Center.", repo.Chrome.option_GuardarComoInfo, new RecordItemIndex(54));
            repo.Chrome.option_GuardarComo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GuardarComo.ButtonGuardar' at Center.", repo.GuardarComo.ButtonGuardarInfo, new RecordItemIndex(55));
            repo.GuardarComo.ButtonGuardar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'Chrome.bttn_FormularioPDF'", repo.Chrome.bttn_FormularioPDFInfo, new ActionTimeout(10000), new RecordItemIndex(56));
            repo.Chrome.bttn_FormularioPDFInfo.WaitForExists(10000);
            
            fileCheck();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'Chrome.bttn_FormularioPDF' and assigning its value to variable 'NombreArchivo'.", repo.Chrome.bttn_FormularioPDFInfo, new RecordItemIndex(58));
            NombreArchivo = repo.Chrome.bttn_FormularioPDF.Element.GetAttributeValueText("Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", NombreArchivo, new RecordItemIndex(59));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Chrome.Cerrar' at 17;15.", repo.Chrome.CerrarInfo, new RecordItemIndex(60));
            repo.Chrome.Cerrar.Click("17;15");
            Delay.Milliseconds(0);
            
            manejarFormulario();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'bttn_CerrarPestaniaFormulario' at Center.", repo.bttn_CerrarPestaniaFormularioInfo, new RecordItemIndex(62));
            repo.bttn_CerrarPestaniaFormulario.Click();
            Delay.Milliseconds(0);
            
            // ----- Copia Productor
            //Report.Log(ReportLevel.Info, "Section", "----- Copia Productor", new RecordItemIndex(63));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.GestionDocumental.bttn_Ver_CopiaProductor' at Center.", repo.SURA.PC.GestionDocumental.bttn_Ver_CopiaProductorInfo, new RecordItemIndex(64));
            //repo.SURA.PC.GestionDocumental.bttn_Ver_CopiaProductor.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SURA.PC.GestionDocumental.formularioPDF' at Center.", repo.SURA.PC.GestionDocumental.formularioPDFInfo, new RecordItemIndex(65));
            //repo.SURA.PC.GestionDocumental.formularioPDF.Click(System.Windows.Forms.MouseButtons.Right);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Chrome.option_GuardarComo' at Center.", repo.Chrome.option_GuardarComoInfo, new RecordItemIndex(66));
            //repo.Chrome.option_GuardarComo.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GuardarComo.ButtonGuardar' at Center.", repo.GuardarComo.ButtonGuardarInfo, new RecordItemIndex(67));
            //repo.GuardarComo.ButtonGuardar.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'Chrome.bttn_FormularioPDF'", repo.Chrome.bttn_FormularioPDFInfo, new ActionTimeout(10000), new RecordItemIndex(68));
            //repo.Chrome.bttn_FormularioPDFInfo.WaitForExists(10000);
            
            //fileCheck();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'Chrome.bttn_FormularioPDF' and assigning its value to variable 'NombreArchivo'.", repo.Chrome.bttn_FormularioPDFInfo, new RecordItemIndex(70));
            //NombreArchivo = repo.Chrome.bttn_FormularioPDF.Element.GetAttributeValueText("Text");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "User", NombreArchivo, new RecordItemIndex(71));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Chrome.Cerrar' at 17;15.", repo.Chrome.CerrarInfo, new RecordItemIndex(72));
            //repo.Chrome.Cerrar.Click("17;15");
            //Delay.Milliseconds(0);
            
            //manejarFormulario();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'bttn_CerrarPestaniaFormulario' at Center.", repo.bttn_CerrarPestaniaFormularioInfo, new RecordItemIndex(74));
            //repo.bttn_CerrarPestaniaFormulario.Click();
            //Delay.Milliseconds(0);
            
            // ----- Copia Organizador
            //Report.Log(ReportLevel.Info, "Section", "----- Copia Organizador", new RecordItemIndex(75));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.GestionDocumental.bttn_Ver_CopiaOrganizador' at Center.", repo.SURA.PC.GestionDocumental.bttn_Ver_CopiaOrganizadorInfo, new RecordItemIndex(76));
            //repo.SURA.PC.GestionDocumental.bttn_Ver_CopiaOrganizador.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SURA.PC.GestionDocumental.formularioPDF' at Center.", repo.SURA.PC.GestionDocumental.formularioPDFInfo, new RecordItemIndex(77));
            //repo.SURA.PC.GestionDocumental.formularioPDF.Click(System.Windows.Forms.MouseButtons.Right);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Chrome.option_GuardarComo' at Center.", repo.Chrome.option_GuardarComoInfo, new RecordItemIndex(78));
            //repo.Chrome.option_GuardarComo.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GuardarComo.ButtonGuardar' at Center.", repo.GuardarComo.ButtonGuardarInfo, new RecordItemIndex(79));
            //repo.GuardarComo.ButtonGuardar.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'Chrome.bttn_FormularioPDF'", repo.Chrome.bttn_FormularioPDFInfo, new ActionTimeout(10000), new RecordItemIndex(80));
            //repo.Chrome.bttn_FormularioPDFInfo.WaitForExists(10000);
            
            //fileCheck();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'Chrome.bttn_FormularioPDF' and assigning its value to variable 'NombreArchivo'.", repo.Chrome.bttn_FormularioPDFInfo, new RecordItemIndex(82));
            //NombreArchivo = repo.Chrome.bttn_FormularioPDF.Element.GetAttributeValueText("Text");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "User", NombreArchivo, new RecordItemIndex(83));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Chrome.Cerrar' at 17;15.", repo.Chrome.CerrarInfo, new RecordItemIndex(84));
            //repo.Chrome.Cerrar.Click("17;15");
            //Delay.Milliseconds(0);
            
            //manejarFormulario();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'bttn_CerrarPestaniaFormulario' at Center.", repo.bttn_CerrarPestaniaFormularioInfo, new RecordItemIndex(86));
            //repo.bttn_CerrarPestaniaFormulario.Click();
            //Delay.Milliseconds(0);
            
            // ----- Copia de Póliza Asegurado
            Report.Log(ReportLevel.Info, "Section", "----- Copia de Póliza Asegurado", new RecordItemIndex(87));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.GestionDocumental.bttn_Ver_CopiaPolizaAsegurado' at Center.", repo.SURA.PC.GestionDocumental.bttn_Ver_CopiaPolizaAseguradoInfo, new RecordItemIndex(88));
            repo.SURA.PC.GestionDocumental.bttn_Ver_CopiaPolizaAsegurado.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SURA.PC.GestionDocumental.formularioPDF' at Center.", repo.SURA.PC.GestionDocumental.formularioPDFInfo, new RecordItemIndex(89));
            repo.SURA.PC.GestionDocumental.formularioPDF.Click(System.Windows.Forms.MouseButtons.Right);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Chrome.option_GuardarComo' at Center.", repo.Chrome.option_GuardarComoInfo, new RecordItemIndex(90));
            repo.Chrome.option_GuardarComo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GuardarComo.ButtonGuardar' at Center.", repo.GuardarComo.ButtonGuardarInfo, new RecordItemIndex(91));
            repo.GuardarComo.ButtonGuardar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'Chrome.bttn_FormularioPDF'", repo.Chrome.bttn_FormularioPDFInfo, new ActionTimeout(10000), new RecordItemIndex(92));
            repo.Chrome.bttn_FormularioPDFInfo.WaitForExists(10000);
            
            fileCheck();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'Chrome.bttn_FormularioPDF' and assigning its value to variable 'NombreArchivo'.", repo.Chrome.bttn_FormularioPDFInfo, new RecordItemIndex(94));
            NombreArchivo = repo.Chrome.bttn_FormularioPDF.Element.GetAttributeValueText("Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", NombreArchivo, new RecordItemIndex(95));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Chrome.Cerrar' at 17;15.", repo.Chrome.CerrarInfo, new RecordItemIndex(96));
            repo.Chrome.Cerrar.Click("17;15");
            Delay.Milliseconds(0);
            
            manejarFormulario();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'bttn_CerrarPestaniaFormulario' at Center.", repo.bttn_CerrarPestaniaFormularioInfo, new RecordItemIndex(98));
            repo.bttn_CerrarPestaniaFormulario.Click();
            Delay.Milliseconds(0);
            
            // ----- Cuponera
            Report.Log(ReportLevel.Info, "Section", "----- Cuponera", new RecordItemIndex(99));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.GestionDocumental.bttn_Ver_Cuponera' at Center.", repo.SURA.PC.GestionDocumental.bttn_Ver_CuponeraInfo, new RecordItemIndex(100));
            repo.SURA.PC.GestionDocumental.bttn_Ver_Cuponera.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'SURA.PC.GestionDocumental.formularioPDF' at Center.", repo.SURA.PC.GestionDocumental.formularioPDFInfo, new RecordItemIndex(101));
            repo.SURA.PC.GestionDocumental.formularioPDF.Click(System.Windows.Forms.MouseButtons.Right);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Chrome.option_GuardarComo' at Center.", repo.Chrome.option_GuardarComoInfo, new RecordItemIndex(102));
            repo.Chrome.option_GuardarComo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GuardarComo.ButtonGuardar' at Center.", repo.GuardarComo.ButtonGuardarInfo, new RecordItemIndex(103));
            repo.GuardarComo.ButtonGuardar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'Chrome.bttn_FormularioPDF'", repo.Chrome.bttn_FormularioPDFInfo, new ActionTimeout(10000), new RecordItemIndex(104));
            repo.Chrome.bttn_FormularioPDFInfo.WaitForExists(10000);
            
            fileCheck();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'Chrome.bttn_FormularioPDF' and assigning its value to variable 'NombreArchivo'.", repo.Chrome.bttn_FormularioPDFInfo, new RecordItemIndex(106));
            NombreArchivo = repo.Chrome.bttn_FormularioPDF.Element.GetAttributeValueText("Text");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", NombreArchivo, new RecordItemIndex(107));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Chrome.Cerrar' at 17;15.", repo.Chrome.CerrarInfo, new RecordItemIndex(108));
            repo.Chrome.Cerrar.Click("17;15");
            Delay.Milliseconds(0);
            
            manejarFormulario();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'bttn_CerrarPestaniaFormulario' at Center.", repo.bttn_CerrarPestaniaFormularioInfo, new RecordItemIndex(110));
            repo.bttn_CerrarPestaniaFormulario.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
