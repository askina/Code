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
            Action<int> action1 = ((qi) => this.OperationResultColor = new SolidColorBrush(Colors.LightGreen));
            Action action2 = (() => this.OperationResultColor = new SolidColorBrush(Colors.Red));
            while (true)
            {
                i++;
                Op10ProductSerialNumber = Convert.ToString(i);
                if (i%2==0)
                {
                    if (this.OperationResultColor.Dispatcher!=null)
                    {
                        this.OperationResultColor.Dispatcher.BeginInvoke(action1);
                    }
                   
                }
                else
                {
                    if (this.OperationResultColor.Dispatcher != null)
                    {
                        this.OperationResultColor.Dispatcher.BeginInvoke(action2);
                    }
                }
                System.Threading.Thread.Sleep(500);
            }
        }

        public MainWindowViewModel()
        {
            Task.Run(() => { this.Op10Count(); });
          
        }

    }
}
