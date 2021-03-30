using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pokedex
{
    public class CommandImpl : ICommand
    {
        public Action ExecutorMethod { get; set; }
        public Func<bool> CanExecuteMethod { get; set; }
        public CommandImpl(Action executor, Func<bool> canExecute) 
        {
            ExecutorMethod = executor;
            CanExecuteMethod = canExecute;
        }
    
        public CommandImpl(Action executor)
        {
            ExecutorMethod = executor;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

       
        public bool CanExecute(object parameter)
        {
            if (CanExecuteMethod != null)
            {
                return CanExecuteMethod();
            }
            else if(ExecutorMethod != null)
            {
                return true;
            }
            return false;
        }

        public void Execute(object parameter)
        {
            ExecutorMethod?.Invoke();
        }
    }
}
