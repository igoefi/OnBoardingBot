﻿#pragma checksum "..\..\..\..\Pages\AdminPanel\PageChangeTest.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F2E658EE3CAE3D340E1E2D1C91AE7F82B80DEBAEB75599CACBB6EB3C7747DB77"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using TelegramBot.Pages.AdminPanel;


namespace TelegramBot.Pages.AdminPanel {
    
    
    /// <summary>
    /// PageChangeTest
    /// </summary>
    public partial class PageChangeTest : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\..\Pages\AdminPanel\PageChangeTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbBoxSpeciality;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Pages\AdminPanel\PageChangeTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbBoxTest;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Pages\AdminPanel\PageChangeTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbName;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Pages\AdminPanel\PageChangeTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbTheory;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Pages\AdminPanel\PageChangeTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbBalls;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Pages\AdminPanel\PageChangeTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbBoxQuestions;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\Pages\AdminPanel\PageChangeTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbQuestion;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Pages\AdminPanel\PageChangeTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbAnswere;
        
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
            System.Uri resourceLocater = new System.Uri("/TelegramBot;component/pages/adminpanel/pagechangetest.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\AdminPanel\PageChangeTest.xaml"
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
            this.CmbBoxSpeciality = ((System.Windows.Controls.ComboBox)(target));
            
            #line 27 "..\..\..\..\Pages\AdminPanel\PageChangeTest.xaml"
            this.CmbBoxSpeciality.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbBoxSpecialitySelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CmbBoxTest = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\..\..\Pages\AdminPanel\PageChangeTest.xaml"
            this.CmbBoxTest.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CmbBoxTestSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TxbName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TxbTheory = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TxbBalls = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.CmbBoxQuestions = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.TxbQuestion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.TxbAnswere = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 69 "..\..\..\..\Pages\AdminPanel\PageChangeTest.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnClickSaveQuestion);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 100 "..\..\..\..\Pages\AdminPanel\PageChangeTest.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnClickSave);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 123 "..\..\..\..\Pages\AdminPanel\PageChangeTest.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnClickDelete);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 146 "..\..\..\..\Pages\AdminPanel\PageChangeTest.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnClickGoBack);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

