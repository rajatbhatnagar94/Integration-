﻿#pragma checksum "C:\Users\Rajat\documents\visual studio 2012\Projects\Integration2\Integration2\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D798BB4774653497F35FB2489E9BE465"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Integration2 {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Controls.Pivot piv;
        
        internal Microsoft.Phone.Controls.PivotItem Calculator;
        
        internal System.Windows.Controls.TextBlock result;
        
        internal System.Windows.Controls.Button Cancel;
        
        internal System.Windows.Controls.Button Delete;
        
        internal System.Windows.Controls.Button Variable;
        
        internal System.Windows.Controls.Button Divide;
        
        internal System.Windows.Controls.Button seven;
        
        internal System.Windows.Controls.Button eight;
        
        internal System.Windows.Controls.Button nine;
        
        internal System.Windows.Controls.Button multiply;
        
        internal System.Windows.Controls.Button four;
        
        internal System.Windows.Controls.Button five;
        
        internal System.Windows.Controls.Button six;
        
        internal System.Windows.Controls.Button subtract;
        
        internal System.Windows.Controls.Button one;
        
        internal System.Windows.Controls.Button two;
        
        internal System.Windows.Controls.Button three;
        
        internal System.Windows.Controls.Button plus;
        
        internal System.Windows.Controls.Button zero;
        
        internal System.Windows.Controls.Button point;
        
        internal System.Windows.Controls.Button equals;
        
        internal Microsoft.Phone.Controls.PivotItem Advanced;
        
        internal System.Windows.Controls.TextBlock result1;
        
        internal System.Windows.Controls.Button Lower;
        
        internal System.Windows.Controls.Button Upper;
        
        internal System.Windows.Controls.Button Cancel1;
        
        internal System.Windows.Controls.Button Delete1;
        
        internal System.Windows.Controls.Button Divide1;
        
        internal System.Windows.Controls.Button PI;
        
        internal System.Windows.Controls.Button Sin;
        
        internal System.Windows.Controls.Button Cos;
        
        internal System.Windows.Controls.Button Tan;
        
        internal System.Windows.Controls.Button multiply1;
        
        internal System.Windows.Controls.Button Asin;
        
        internal System.Windows.Controls.Button Acos;
        
        internal System.Windows.Controls.Button Atan;
        
        internal System.Windows.Controls.Button Pow;
        
        internal System.Windows.Controls.Button Log10;
        
        internal System.Windows.Controls.Button Loge;
        
        internal System.Windows.Controls.Button e;
        
        internal System.Windows.Controls.Button Variable1;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Integration2;component/MainPage.xaml", System.UriKind.Relative));
            this.piv = ((Microsoft.Phone.Controls.Pivot)(this.FindName("piv")));
            this.Calculator = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("Calculator")));
            this.result = ((System.Windows.Controls.TextBlock)(this.FindName("result")));
            this.Cancel = ((System.Windows.Controls.Button)(this.FindName("Cancel")));
            this.Delete = ((System.Windows.Controls.Button)(this.FindName("Delete")));
            this.Variable = ((System.Windows.Controls.Button)(this.FindName("Variable")));
            this.Divide = ((System.Windows.Controls.Button)(this.FindName("Divide")));
            this.seven = ((System.Windows.Controls.Button)(this.FindName("seven")));
            this.eight = ((System.Windows.Controls.Button)(this.FindName("eight")));
            this.nine = ((System.Windows.Controls.Button)(this.FindName("nine")));
            this.multiply = ((System.Windows.Controls.Button)(this.FindName("multiply")));
            this.four = ((System.Windows.Controls.Button)(this.FindName("four")));
            this.five = ((System.Windows.Controls.Button)(this.FindName("five")));
            this.six = ((System.Windows.Controls.Button)(this.FindName("six")));
            this.subtract = ((System.Windows.Controls.Button)(this.FindName("subtract")));
            this.one = ((System.Windows.Controls.Button)(this.FindName("one")));
            this.two = ((System.Windows.Controls.Button)(this.FindName("two")));
            this.three = ((System.Windows.Controls.Button)(this.FindName("three")));
            this.plus = ((System.Windows.Controls.Button)(this.FindName("plus")));
            this.zero = ((System.Windows.Controls.Button)(this.FindName("zero")));
            this.point = ((System.Windows.Controls.Button)(this.FindName("point")));
            this.equals = ((System.Windows.Controls.Button)(this.FindName("equals")));
            this.Advanced = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("Advanced")));
            this.result1 = ((System.Windows.Controls.TextBlock)(this.FindName("result1")));
            this.Lower = ((System.Windows.Controls.Button)(this.FindName("Lower")));
            this.Upper = ((System.Windows.Controls.Button)(this.FindName("Upper")));
            this.Cancel1 = ((System.Windows.Controls.Button)(this.FindName("Cancel1")));
            this.Delete1 = ((System.Windows.Controls.Button)(this.FindName("Delete1")));
            this.Divide1 = ((System.Windows.Controls.Button)(this.FindName("Divide1")));
            this.PI = ((System.Windows.Controls.Button)(this.FindName("PI")));
            this.Sin = ((System.Windows.Controls.Button)(this.FindName("Sin")));
            this.Cos = ((System.Windows.Controls.Button)(this.FindName("Cos")));
            this.Tan = ((System.Windows.Controls.Button)(this.FindName("Tan")));
            this.multiply1 = ((System.Windows.Controls.Button)(this.FindName("multiply1")));
            this.Asin = ((System.Windows.Controls.Button)(this.FindName("Asin")));
            this.Acos = ((System.Windows.Controls.Button)(this.FindName("Acos")));
            this.Atan = ((System.Windows.Controls.Button)(this.FindName("Atan")));
            this.Pow = ((System.Windows.Controls.Button)(this.FindName("Pow")));
            this.Log10 = ((System.Windows.Controls.Button)(this.FindName("Log10")));
            this.Loge = ((System.Windows.Controls.Button)(this.FindName("Loge")));
            this.e = ((System.Windows.Controls.Button)(this.FindName("e")));
            this.Variable1 = ((System.Windows.Controls.Button)(this.FindName("Variable1")));
        }
    }
}

