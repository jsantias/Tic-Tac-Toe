﻿#pragma checksum "..\..\..\Views\TicTacToeMainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "162094697457BC8A9FF0E3D13AF3684EC16898BD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using QUT;
using ReactiveUI;
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


namespace QUT {
    
    
    /// <summary>
    /// TicTacToeMainWindow
    /// </summary>
    public partial class TicTacToeMainWindow : ReactiveUI.ReactiveWindow<QUT.TicTacToeViewModel>, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Views\TicTacToeMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu Menu;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\TicTacToeMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem NewGame2x2;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Views\TicTacToeMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem NewGame3x3;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Views\TicTacToeMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem NewGame4x4;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Views\TicTacToeMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox GameEngine;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Views\TicTacToeMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox HumanFirst;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Views\TicTacToeMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TimeElapsed;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Views\TicTacToeMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label MessageLabel;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Views\TicTacToeMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl Board;
        
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
            System.Uri resourceLocater = new System.Uri("/TicTacToeWPF;component/views/tictactoemainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\TicTacToeMainWindow.xaml"
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
            this.Menu = ((System.Windows.Controls.Menu)(target));
            return;
            case 2:
            this.NewGame2x2 = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 3:
            this.NewGame3x3 = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 4:
            this.NewGame4x4 = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 5:
            this.GameEngine = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.HumanFirst = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.TimeElapsed = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.MessageLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.Board = ((System.Windows.Controls.ItemsControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

