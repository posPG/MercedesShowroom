﻿#pragma checksum "..\..\Menu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20008CAEB8C754484B88D21C0EBA01E2EA9B786D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProjectApp;
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


namespace ProjectApp {
    
    
    /// <summary>
    /// Menu
    /// </summary>
    public partial class Menu : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label mercedes1;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image amga454matic_small_jpg;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label mercedes2;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image amggt_small_jpg;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label mercedes3;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image clacoupe_small_jpg;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button config1;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button config2;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button config3;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjectApp;component/page1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Menu.xaml"
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
            this.mercedes1 = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.amga454matic_small_jpg = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.mercedes2 = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.amggt_small_jpg = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.mercedes3 = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.clacoupe_small_jpg = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.config1 = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\Menu.xaml"
            this.config1.Click += new System.Windows.RoutedEventHandler(this.toFirstCarConfig);
            
            #line default
            #line hidden
            return;
            case 8:
            this.config2 = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\Menu.xaml"
            this.config2.Click += new System.Windows.RoutedEventHandler(this.toSecondCarConfig);
            
            #line default
            #line hidden
            return;
            case 9:
            this.config3 = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\Menu.xaml"
            this.config3.Click += new System.Windows.RoutedEventHandler(this.toThirdCarConfig);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

