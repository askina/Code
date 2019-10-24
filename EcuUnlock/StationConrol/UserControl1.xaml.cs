using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StationConrol
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            DataContext = this;
        }
        //ProductSerialNmuber_tb
        public static readonly DependencyProperty ProductSerialNumberProperty = DependencyProperty.Register("ProductSerialNumber", typeof(string), typeof(UserControl1));
        public string ProductSerialNumber
        {
            get { return (string)GetValue(ProductSerialNumberProperty); }
            set { SetValue(ProductSerialNumberProperty, value); }
        }
        //ECUSerialNumber1_tb
        public static readonly DependencyProperty EcuSerialNumber1Property = DependencyProperty.Register("EcuSerialNumber1", typeof(string), typeof(UserControl1));
        public string EcuSerialNumber1 {
            get { return (string)GetValue(EcuSerialNumber1Property); }
            set { SetValue(EcuSerialNumber1Property, value); } }
        //EcuSerialNumber2_tb
        public static readonly DependencyProperty EcuSerialNumber2Property = DependencyProperty.Register("EcuSerialNumber2", typeof(string), typeof(UserControl1));
        public string EcuSerialNumber2 { get { return (string)GetValue(EcuSerialNumber2Property); }
            set { SetValue(EcuSerialNumber2Property, value); } }
        //EcuMessage
        public static readonly DependencyProperty EcuMessageProperty = DependencyProperty.Register("EcuMessage", typeof(string), typeof(UserControl1));
        public string EcuMessage {
            get { return (string)GetValue(EcuMessageProperty); }
            set { SetValue(EcuMessageProperty, value); } }
        //OperationResultText
        public static readonly DependencyProperty OperationResultTextProperty = DependencyProperty.Register("OperationResultText", typeof(string), typeof(UserControl1));
        public string OperationResultText {
            get { return (string)GetValue(OperationResultTextProperty); }
            set { SetValue(OperationResultTextProperty, value); } }
        //OperationResultColor
        public static readonly DependencyProperty OperationResultColorProperty = DependencyProperty.Register("OperationResultColor", typeof(Brush), typeof(UserControl1));
        public Brush OperationResultColor {
            get { return (Brush)GetValue(OperationResultColorProperty); }
            set { SetValue(OperationResultColorProperty, value); } }
    }
    

}

