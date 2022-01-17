using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFApp.Utlis;

namespace WPFApp.ViewModel
{
    internal class MainViewModel : ViewModelBase
    {
        #region Binding properties

        public ActionCommand TestCommand
        {
            get;
            set;
        }

        private string _testProperty;

        public string TestProperty
        {
            get
            {
                return _testProperty;
            }
            set
            {
                _testProperty = value;
                NotifyPropertyChanged();
            }
        }



        #endregion Binding properties

        #region properties

        #endregion properties

        public MainViewModel()
        {
            TestCommand = new ActionCommand(Test, CanExecuteTest);

        }

        public void Test(object parameter)
        {
            MessageBox.Show($"Eingegebener Text: {TestProperty}");
            TestProperty = "";
        }

        public bool CanExecuteTest(object parameter)
        {
            return true;
        }


    }
}
