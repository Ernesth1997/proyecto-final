﻿#pragma checksum "..\..\..\Cliente\winAdmCliente.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5C74641BD4922766DBBDA58285DC5EFCB79F340E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using ElectroSoftWPF.Cliente;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using RootLibrary.WPF.Localization;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace ElectroSoftWPF.Cliente {
    
    
    /// <summary>
    /// winAdmCliente
    /// </summary>
    public partial class winAdmCliente : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\Cliente\winAdmCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Cliente\winAdmCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNit;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Cliente\winAdmCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRazonSocial;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Cliente\winAdmCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGuardar;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Cliente\winAdmCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelar;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Cliente\winAdmCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnInsertar;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Cliente\winAdmCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnModificar;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Cliente\winAdmCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminar;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Cliente\winAdmCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBuscar;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Cliente\winAdmCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSelecCliente;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Cliente\winAdmCliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgvDatos;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ElectroSoftWPF;component/cliente/winadmcliente.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Cliente\winAdmCliente.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 16 "..\..\..\Cliente\winAdmCliente.xaml"
            ((ElectroSoftWPF.Cliente.winAdmCliente)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\Cliente\winAdmCliente.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtNit = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\..\Cliente\winAdmCliente.xaml"
            this.txtNit.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txtNit_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtRazonSocial = ((System.Windows.Controls.TextBox)(target));
            
            #line 51 "..\..\..\Cliente\winAdmCliente.xaml"
            this.txtRazonSocial.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtRazonSocial_TextChanged);
            
            #line default
            #line hidden
            
            #line 51 "..\..\..\Cliente\winAdmCliente.xaml"
            this.txtRazonSocial.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txtRazonSocial_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnGuardar = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\Cliente\winAdmCliente.xaml"
            this.btnGuardar.Click += new System.Windows.RoutedEventHandler(this.btnGuardar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\Cliente\winAdmCliente.xaml"
            this.btnCancelar.Click += new System.Windows.RoutedEventHandler(this.btnCancelar_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnInsertar = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\Cliente\winAdmCliente.xaml"
            this.btnInsertar.Click += new System.Windows.RoutedEventHandler(this.btnInsertar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnModificar = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\Cliente\winAdmCliente.xaml"
            this.btnModificar.Click += new System.Windows.RoutedEventHandler(this.btnModificar_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnEliminar = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\Cliente\winAdmCliente.xaml"
            this.btnEliminar.Click += new System.Windows.RoutedEventHandler(this.btnEliminar_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.txtBuscar = ((System.Windows.Controls.TextBox)(target));
            
            #line 64 "..\..\..\Cliente\winAdmCliente.xaml"
            this.txtBuscar.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtBuscar_TextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.BtnSelecCliente = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\Cliente\winAdmCliente.xaml"
            this.BtnSelecCliente.Click += new System.Windows.RoutedEventHandler(this.BtnSelecCliente_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.dgvDatos = ((System.Windows.Controls.DataGrid)(target));
            
            #line 69 "..\..\..\Cliente\winAdmCliente.xaml"
            this.dgvDatos.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgvDatos_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
