﻿#pragma checksum "..\..\..\..\Pages\AdminPanel\PageCreateTest.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "441D18DDF58E1FEDD96115ABC65905A3808524EE0A7E2E2BE3747862A5AE9A60"
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
    /// PageCreateTest
    /// </summary>
    public partial class PageCreateTest : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\Pages\AdminPanel\PageCreateTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CmbBoxSpeciality;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Pages\AdminPanel\PageCreateTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbName;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Pages\AdminPanel\PageCreateTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbTheory;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Pages\AdminPanel\PageCreateTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbCost;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Pages\AdminPanel\PageCreateTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbQuestion;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Pages\AdminPanel\PageCreateTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxbAnswer;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\..\..\Pages\AdminPanel\PageCreateTest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxbQuestionsAnswers;
        
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
            System.Uri resourceLocater = new System.Uri("/TelegramBot;component/pages/adminpanel/pagecreatetest.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\AdminPanel\PageCreateTest.xaml"
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
            return;
            case 2:
            this.TxbName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TxbTheory = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TxbCost = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TxbQuestion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.TxbAnswer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 55 "..\..\..\..\Pages\AdminPanel\PageCreateTest.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnClickSaveQuestion);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 88 "..\..\..\..\Pages\AdminPanel\PageCreateTest.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnClickSave);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 111 "..\..\..\..\Pages\AdminPanel\PageCreateTest.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnClickGoBack);
            
            #line default
            #line hidden
            return;
            case 10:
            this.TxbQuestionsAnswers = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

