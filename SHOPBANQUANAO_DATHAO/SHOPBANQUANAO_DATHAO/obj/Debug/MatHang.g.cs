﻿#pragma checksum "..\..\MatHang.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0E2459E04736DCE7B1CF1E1138C123A56213662B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.IconPacks;
using SHOPBANQUANAO_DATHAO;
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


namespace SHOPBANQUANAO_DATHAO {
    
    
    /// <summary>
    /// MatHang
    /// </summary>
    public partial class MatHang : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\MatHang.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid KhuonChuaPTThuoc;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MatHang.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock STTHang;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\MatHang.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tenHang;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\MatHang.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SoLuongHang;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\MatHang.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DonGia;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\MatHang.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ThanhTien;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MatHang.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button XoaThuoc;
        
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
            System.Uri resourceLocater = new System.Uri("/SHOPBANQUANAO_DATHAO;component/mathang.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MatHang.xaml"
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
            this.KhuonChuaPTThuoc = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.STTHang = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.tenHang = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.SoLuongHang = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.DonGia = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.ThanhTien = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.XoaThuoc = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\MatHang.xaml"
            this.XoaThuoc.Click += new System.Windows.RoutedEventHandler(this.XoaThuoc_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
