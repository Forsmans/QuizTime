﻿#pragma checksum "..\..\..\..\..\..\MVVM\View\DiscoverView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2864420C635F6A9037663626609C0816F4246921"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using QuizGameWPF.MVVM.View;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace QuizGameWPF.MVVM.View {
    
    
    /// <summary>
    /// DiscoverView
    /// </summary>
    public partial class DiscoverView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 267 "..\..\..\..\..\..\MVVM\View\DiscoverView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView TitleList;
        
        #line default
        #line hidden
        
        
        #line 301 "..\..\..\..\..\..\MVVM\View\DiscoverView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Random;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/QuizTime;component/mvvm/view/discoverview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\MVVM\View\DiscoverView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 41 "..\..\..\..\..\..\MVVM\View\DiscoverView.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.SportsBorder_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 66 "..\..\..\..\..\..\MVVM\View\DiscoverView.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.PoliticsBorder_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 94 "..\..\..\..\..\..\MVVM\View\DiscoverView.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MusicBorder_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 122 "..\..\..\..\..\..\MVVM\View\DiscoverView.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Geography_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 151 "..\..\..\..\..\..\MVVM\View\DiscoverView.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.AnimalsBorder_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 178 "..\..\..\..\..\..\MVVM\View\DiscoverView.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.GeneralKnowledge_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 206 "..\..\..\..\..\..\MVVM\View\DiscoverView.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Movies_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 233 "..\..\..\..\..\..\MVVM\View\DiscoverView.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.History_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.TitleList = ((System.Windows.Controls.ListView)(target));
            
            #line 271 "..\..\..\..\..\..\MVVM\View\DiscoverView.xaml"
            this.TitleList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TitleList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Random = ((System.Windows.Controls.Button)(target));
            
            #line 303 "..\..\..\..\..\..\MVVM\View\DiscoverView.xaml"
            this.Random.Click += new System.Windows.RoutedEventHandler(this.RandomButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

