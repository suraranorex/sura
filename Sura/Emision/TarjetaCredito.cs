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

namespace Sura.Emision
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The TarjetaCredito recording.
    /// </summary>
    [TestModule("a3d84a58-e992-4cc8-b590-f8de666c9b00", ModuleType.Recording, 1)]
    public partial class TarjetaCredito : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static TarjetaCredito instance = new TarjetaCredito();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TarjetaCredito()
        {
            TipoTarjeta = "Huilen";
            NumTarjetaCred = "6281015855047101";
            FechaVencimiento = "05/2024";
            TCTrue = "La tarjeta de crédito que inteta registrar ya existe en la cuenta";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TarjetaCredito Instance
        {
            get { return instance; }
        }

#region Variables

        string _TipoTarjeta;

        /// <summary>
        /// Gets or sets the value of variable TipoTarjeta.
        /// </summary>
        [TestVariable("c0724723-8849-4422-bc10-5f4ba5e835c3")]
        public string TipoTarjeta
        {
            get { return _TipoTarjeta; }
            set { _TipoTarjeta = value; }
        }

        string _NumTarjetaCred;

        /// <summary>
        /// Gets or sets the value of variable NumTarjetaCred.
        /// </summary>
        [TestVariable("5dea6bb3-16ee-43e6-8622-1f2cfa38a7f9")]
        public string NumTarjetaCred
        {
            get { return _NumTarjetaCred; }
            set { _NumTarjetaCred = value; }
        }

        string _FechaVencimiento;

        /// <summary>
        /// Gets or sets the value of variable FechaVencimiento.
        /// </summary>
        [TestVariable("c8f191f9-2bc5-42bd-a1a3-eff8a4975324")]
        public string FechaVencimiento
        {
            get { return _FechaVencimiento; }
            set { _FechaVencimiento = value; }
        }

        string _TCTrue;

        /// <summary>
        /// Gets or sets the value of variable TCTrue.
        /// </summary>
        [TestVariable("bb058290-3eec-4522-b038-ada6851f8f3b")]
        public string TCTrue
        {
            get { return _TCTrue; }
            set { _TCTrue = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Menu.menu_InformacionDelPago' at Center.", repo.SURA.PC.Menu.menu_InformacionDelPagoInfo, new RecordItemIndex(0));
            repo.SURA.PC.Menu.menu_InformacionDelPago.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'SURA.PC.Emision.Generales.InformacionDePago.bttn_Agregar'", repo.SURA.PC.Emision.Generales.InformacionDePago.bttn_AgregarInfo, new ActionTimeout(30000), new RecordItemIndex(1));
            repo.SURA.PC.Emision.Generales.InformacionDePago.bttn_AgregarInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePago.bttn_Agregar' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePago.bttn_AgregarInfo, new RecordItemIndex(2));
            repo.SURA.PC.Emision.Generales.InformacionDePago.bttn_Agregar.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_TipoTarjeta' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_TipoTarjetaInfo, new RecordItemIndex(3));
            repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_TipoTarjeta.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_TipoTarjeta'.", repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_TipoTarjetaInfo, new RecordItemIndex(4));
            repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_TipoTarjeta.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$TipoTarjeta' with focus on 'SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_TipoTarjeta'.", repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_TipoTarjetaInfo, new RecordItemIndex(5));
            repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_TipoTarjeta.PressKeys(TipoTarjeta);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePago.lbl_NuevoMetodoDePago' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePago.lbl_NuevoMetodoDePagoInfo, new RecordItemIndex(6));
            repo.SURA.PC.Emision.Generales.InformacionDePago.lbl_NuevoMetodoDePago.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to not exist. Associated repository item: 'SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.Copy_of_txtbox_TipoTarjeta'", repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.Copy_of_txtbox_TipoTarjetaInfo, new ActionTimeout(10000), new RecordItemIndex(7));
            repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.Copy_of_txtbox_TipoTarjetaInfo.WaitForNotExists(10000);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$NumTarjetaCred' on item 'SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_NumTarjetaCred'.", repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_NumTarjetaCredInfo, new RecordItemIndex(8));
            repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_NumTarjetaCred.Element.SetAttributeValue("TagValue", NumTarjetaCred);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NumTarjetaCred' with focus on 'SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_NumTarjetaCred'.", repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_NumTarjetaCredInfo, new RecordItemIndex(9));
            //repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_NumTarjetaCred.PressKeys(NumTarjetaCred);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePago.lbl_NuevoMetodoDePago' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePago.lbl_NuevoMetodoDePagoInfo, new RecordItemIndex(10));
            repo.SURA.PC.Emision.Generales.InformacionDePago.lbl_NuevoMetodoDePago.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.Copy_of_txtbox_NumTarjetaCred'", repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.Copy_of_txtbox_NumTarjetaCredInfo, new ActionTimeout(30000), new RecordItemIndex(11));
            repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.Copy_of_txtbox_NumTarjetaCredInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_FechaVencimiento' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_FechaVencimientoInfo, new RecordItemIndex(12));
            repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_FechaVencimiento.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_FechaVencimiento'.", repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_FechaVencimientoInfo, new RecordItemIndex(13));
            repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_FechaVencimiento.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$FechaVencimiento' with focus on 'SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_FechaVencimiento'.", repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_FechaVencimientoInfo, new RecordItemIndex(14));
            repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.txtbox_FechaVencimiento.PressKeys(FechaVencimiento);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePago.lbl_NuevoMetodoDePago' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePago.lbl_NuevoMetodoDePagoInfo, new RecordItemIndex(15));
            repo.SURA.PC.Emision.Generales.InformacionDePago.lbl_NuevoMetodoDePago.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.Copy_of_txtbox_FechaVencimiento'", repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.Copy_of_txtbox_FechaVencimientoInfo, new ActionTimeout(30000), new RecordItemIndex(16));
            repo.SURA.PC.Emision.Generales.InformacionDePago.TarjetaDeCredito.Copy_of_txtbox_FechaVencimientoInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePago.bttn_InfoContratante' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePago.bttn_InfoContratanteInfo, new RecordItemIndex(17));
            repo.SURA.PC.Emision.Generales.InformacionDePago.bttn_InfoContratante.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(18));
            Delay.Duration(2000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Self, false, new RecordItemIndex(19));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.PC.Emision.Generales.InformacionDePago.bttn_Actualizar' at Center.", repo.SURA.PC.Emision.Generales.InformacionDePago.bttn_ActualizarInfo, new RecordItemIndex(20));
            repo.SURA.PC.Emision.Generales.InformacionDePago.bttn_Actualizar.Click();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 10s to exist. Associated repository item: 'SURA_ContinueOnFail.Copy_of_lbl_TCExistente'", repo.SURA_ContinueOnFail.Copy_of_lbl_TCExistenteInfo, new ActionTimeout(10000), new RecordItemIndex(21));
                repo.SURA_ContinueOnFail.Copy_of_lbl_TCExistenteInfo.WaitForExists(10000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(21)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'SURA_ContinueOnFail.Copy_of_btn_COF_CancelarTC' at Center.", repo.SURA_ContinueOnFail.Copy_of_btn_COF_CancelarTCInfo, new RecordItemIndex(22));
                repo.SURA_ContinueOnFail.Copy_of_btn_COF_CancelarTC.Click();
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(22)); }
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'SURA.PC.Endosos2.ModifCoberturas.title_InformacionDelPago'", repo.SURA.PC.Endosos2.ModifCoberturas.title_InformacionDelPagoInfo, new ActionTimeout(5000), new RecordItemIndex(23));
            repo.SURA.PC.Endosos2.ModifCoberturas.title_InformacionDelPagoInfo.WaitForExists(5000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
