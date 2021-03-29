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
    ///The CargaVehiculos recording.
    /// </summary>
    [TestModule("6a1dc262-3de5-4b8d-9179-beb405045f72", ModuleType.Recording, 1)]
    public partial class CargaVehiculos : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sura.SuraRepository repository.
        /// </summary>
        public static global::Sura.SuraRepository repo = global::Sura.SuraRepository.Instance;

        static CargaVehiculos instance = new CargaVehiculos();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CargaVehiculos()
        {
            idEjecucion = "";
            idEjecucionTC = "";
            Actividad = "";
            Ambiente = "";
            Anio = "";
            Es0km = "";
            Marca = "";
            Modelo = "";
            Patente = "";
            Chasis = "";
            Motor = "";
            SumaAsegurada = "";
            Producto = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CargaVehiculos Instance
        {
            get { return instance; }
        }

#region Variables

        string _idEjecucion;

        /// <summary>
        /// Gets or sets the value of variable idEjecucion.
        /// </summary>
        [TestVariable("1a2fde4f-3417-437f-8e2e-87fd8f12b078")]
        public string idEjecucion
        {
            get { return _idEjecucion; }
            set { _idEjecucion = value; }
        }

        string _idEjecucionTC;

        /// <summary>
        /// Gets or sets the value of variable idEjecucionTC.
        /// </summary>
        [TestVariable("386c47bd-07c3-4bd4-8818-267fc14d8ab4")]
        public string idEjecucionTC
        {
            get { return _idEjecucionTC; }
            set { _idEjecucionTC = value; }
        }

        string _Actividad;

        /// <summary>
        /// Gets or sets the value of variable Actividad.
        /// </summary>
        [TestVariable("8fec2d60-d0e4-43da-b91a-2c9c94c78437")]
        public string Actividad
        {
            get { return _Actividad; }
            set { _Actividad = value; }
        }

        string _Es0km;

        /// <summary>
        /// Gets or sets the value of variable Es0km.
        /// </summary>
        [TestVariable("5602739d-de21-49d8-be6b-609b751c4b2e")]
        public string Es0km
        {
            get { return _Es0km; }
            set { _Es0km = value; }
        }

        string _Patente;

        /// <summary>
        /// Gets or sets the value of variable Patente.
        /// </summary>
        [TestVariable("edffc1db-04d0-4dda-a544-cc15406bc7fb")]
        public string Patente
        {
            get { return _Patente; }
            set { _Patente = value; }
        }

        string _Chasis;

        /// <summary>
        /// Gets or sets the value of variable Chasis.
        /// </summary>
        [TestVariable("6fe2e435-e538-4aeb-b5ad-14c01f3eb9f9")]
        public string Chasis
        {
            get { return _Chasis; }
            set { _Chasis = value; }
        }

        string _Motor;

        /// <summary>
        /// Gets or sets the value of variable Motor.
        /// </summary>
        [TestVariable("c09d8c80-061d-4b83-9dfd-9627241dea10")]
        public string Motor
        {
            get { return _Motor; }
            set { _Motor = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Ambiente.
        /// </summary>
        [TestVariable("4e6207b8-e9ec-4876-be2d-03b0c9444c04")]
        public string Ambiente
        {
            get { return repo.Ambiente; }
            set { repo.Ambiente = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Anio.
        /// </summary>
        [TestVariable("c265343f-4ab2-4cfc-9cf7-3b5dcfa6ec36")]
        public string Anio
        {
            get { return repo.Anio; }
            set { repo.Anio = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Marca.
        /// </summary>
        [TestVariable("79a82207-fbf2-4252-a3c0-783aae4f56ba")]
        public string Marca
        {
            get { return repo.Marca; }
            set { repo.Marca = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Modelo.
        /// </summary>
        [TestVariable("20a01dd1-1376-4057-8dfd-aa40bc355fa6")]
        public string Modelo
        {
            get { return repo.Modelo; }
            set { repo.Modelo = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable SumaAsegurada.
        /// </summary>
        [TestVariable("b1a96acc-017d-42e9-a9ff-124cde615b2a")]
        public string SumaAsegurada
        {
            get { return repo.SumaAsegurada; }
            set { repo.SumaAsegurada = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Producto.
        /// </summary>
        [TestVariable("cf437050-2366-4da8-933f-5d79163a31a8")]
        public string Producto
        {
            get { return repo.Producto; }
            set { repo.Producto = value; }
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

            //seleccionaVehiculos();
            //Delay.Milliseconds(0);
            
            seleccionaVehiculos2();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}