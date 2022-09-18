using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CalculatorApp1.ViewModels
{
    internal class RelayCommand : ICommand
    {
        private readonly Action<object> execute;
        private readonly Func<object, bool> canexecute;
        public event EventHandler CanExecuteChanged
        {
            add=>CommandManager.RequerySuggested += value; 
            remove=> CommandManager.RequerySuggested -= value;
        }

        public RelayCommand(Action<object> Execute, Func<object, bool>  CanExecute)
        {
            execute = Execute;
            canexecute = CanExecute;
        }

        public bool CanExecute(object parameter) => canexecute(parameter);
      
        public void Execute(object parameter) => execute(parameter);
    }
}
 