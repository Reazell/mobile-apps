using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel.Security;
using System.Text;
using System.Windows.Input;

namespace ClassLibrary1
{
    public class MainViewModel
    {
        private int x = 1;
        public ObservableCollection<int> myList { get; set; } = new ObservableCollection<int>();

        public void AddItem()
        {
            myList.Add(x);
            x++;
        }

        public ICommand addItemCommand => new Command(AddItem);
    }

    public class Command : ICommand
    {
        private readonly Action _byleco;

        public Command(Action byleco)
        {
            _byleco = byleco;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _byleco.Invoke();
        }

        public event EventHandler CanExecuteChanged;
    }
}
