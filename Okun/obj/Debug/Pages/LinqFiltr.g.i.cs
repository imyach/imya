﻿#pragma checksum "..\..\..\Pages\LinqFiltr.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A1737D4928F229356E8BE3A1AE576CB172894DCFC881C3371A7F8E82C4FC1E25"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Okun.Pages;
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


namespace Okun.Pages {
    
    
    /// <summary>
    /// LinqFiltr
    /// </summary>
    public partial class LinqFiltr : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Pages\LinqFiltr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView AccountingLV;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Pages\LinqFiltr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTxt;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Pages\LinqFiltr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SortCmb;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\LinqFiltr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FiltrCmb;
        
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
            System.Uri resourceLocater = new System.Uri("/Okun;component/pages/linqfiltr.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\LinqFiltr.xaml"
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
            this.AccountingLV = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.SearchTxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\..\Pages\LinqFiltr.xaml"
            this.SearchTxt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTxt_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SortCmb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 27 "..\..\..\Pages\LinqFiltr.xaml"
            this.SortCmb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SortTxt_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FiltrCmb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 28 "..\..\..\Pages\LinqFiltr.xaml"
            this.FiltrCmb.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FiltrCmb_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

