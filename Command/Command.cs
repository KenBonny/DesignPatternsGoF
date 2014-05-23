using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Command
{
    public class Command : ICommand
    {
        private readonly List<Action> _actions = new List<Action>();

        public void Add(Action action)
        {
            if (CanExecuteChanged != null)
                CanExecuteChanged(this, null);
            _actions.Add(action);
        }

        private void ExecuteQueue()
        {
            foreach (var action in _actions)
            {
                action();
            }
        }

        private void ExecuteQueueAsync()
        {
            foreach (var action in _actions)
            {
                Task.Factory.StartNew(action);
            }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.GetType() == typeof (bool) && (bool) parameter)
            {
                ExecuteQueueAsync();
                return;
            }

            ExecuteQueue();
        }

        public event EventHandler CanExecuteChanged;
    }
}