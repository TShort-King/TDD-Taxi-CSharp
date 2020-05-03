using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace TDD_Taxi_CSharp
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        List<string> _resultData;
        public List<string> resultData
        {
            get { return _resultData; }
            set {
                _resultData = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("resultData"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            resultData = new List<string>();
            BindData();
        }

        private void BindData()
        {
            ReadFileManage readManage = new ReadFileManage();
            resultData = readManage.Get_Results(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\", ""), "testData.txt");
        }
    }
}
