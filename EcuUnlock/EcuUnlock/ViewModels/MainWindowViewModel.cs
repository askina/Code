using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;


namespace EcuUnlock.ViewModels
{
    class MainWindowViewModel:NotificationObject
    {
        private string op10ProductSerialNmuber;

        public string Op10ProductSerialNumber
        {
            get { return op10ProductSerialNmuber; }
            set {
                op10ProductSerialNmuber = value;
                this.RaisePropertyChanged("Op10ProductSerialNumber");
            }
        }
        private Brush operationResultColor = new SolidColorBrush(Colors.LightGreen);

        public Brush OperationResultColor
        {
            get { return operationResultColor; }
            set { operationResultColor = value;
                RaisePropertyChanged("OperationResultColor");
               
            }
        }

        public void Op10Count()
        {
            int i = 0;
            Action action1 = (() => this.ColorResult(i));
            while (true)
            {
                i++;
                Op10ProductSerialNumber = Convert.ToString(i);
                OperationResultColor.Dispatcher.BeginInvoke(action1);
                System.Threading.Thread.Sleep(500);
            }
        }
        public void ColorResult(int i)
        {
            this.OperationResultColor = (i % 2 == 0) ? new SolidColorBrush(Colors.Red) : new SolidColorBrush(Colors.LightGreen);
        }

        public MainWindowViewModel()
        {
            Task.Run(() => { this.Op10Count(); });
          
        }

    }
}
