﻿#pragma checksum "..\..\LoginUI.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7A8BEADC3459BB7AE9B040DF08C054C7BE3C392769D5EE30B0C0D72F218CE157"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
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
using Wookao;


namespace Wookao {
    
    
    /// <summary>
    /// LoginUI
    /// </summary>
    public partial class LoginUI : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 151 "..\..\LoginUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox xUserID;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\LoginUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock xUserIDHint;
        
        #line default
        #line hidden
        
        
        #line 181 "..\..\LoginUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox xPassword;
        
        #line default
        #line hidden
        
        
        #line 188 "..\..\LoginUI.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock xPasswordHint;
        
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
            System.Uri resourceLocater = new System.Uri("/Wookao;component/loginui.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LoginUI.xaml"
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
            this.xUserID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.xUserIDHint = ((System.Windows.Controls.TextBlock)(target));
            
            #line 164 "..\..\LoginUI.xaml"
            this.xUserIDHint.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.xUserIDHint_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.xPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 185 "..\..\LoginUI.xaml"
            this.xPassword.PasswordChanged += new System.Windows.RoutedEventHandler(this.xPassword_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.xPasswordHint = ((System.Windows.Controls.TextBlock)(target));
            
            #line 194 "..\..\LoginUI.xaml"
            this.xPasswordHint.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.xPasswordHint_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

