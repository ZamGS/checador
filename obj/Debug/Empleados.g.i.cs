﻿#pragma checksum "..\..\Empleados.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60625417B5D90384CEF7E6868F6287AFD893DD67"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Checador;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Checador {
    
    
    /// <summary>
    /// Empleados
    /// </summary>
    public partial class Empleados : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\Empleados.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgEmpleados;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Empleados.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNombre;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Empleados.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbApellidos;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Empleados.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNumero;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Empleados.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgFoto;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Empleados.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnFoto;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Empleados.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCaptura;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\Empleados.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGuardar;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\Empleados.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbUrlFoto;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Empleados.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgVerHuella;
        
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
            System.Uri resourceLocater = new System.Uri("/Checador;component/empleados.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Empleados.xaml"
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
            
            #line 9 "..\..\Empleados.xaml"
            ((Checador.Empleados)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dgEmpleados = ((System.Windows.Controls.DataGrid)(target));
            
            #line 16 "..\..\Empleados.xaml"
            this.dgEmpleados.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgEmpleados_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbApellidos = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbNumero = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.imgFoto = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.btnFoto = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\Empleados.xaml"
            this.btnFoto.Click += new System.Windows.RoutedEventHandler(this.btnFoto_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnCaptura = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\Empleados.xaml"
            this.btnCaptura.Click += new System.Windows.RoutedEventHandler(this.btnCaptura_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnGuardar = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\Empleados.xaml"
            this.btnGuardar.Click += new System.Windows.RoutedEventHandler(this.btnGuardar_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.tbUrlFoto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.imgVerHuella = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

