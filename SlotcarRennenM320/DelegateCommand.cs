﻿using System.Windows.Input;

namespace SlotcarRennenM320
{
    class DelegateCommand : ICommand
    {
        private readonly Action<object> execute;
        private readonly Predicate<object> canExecute;

        public DelegateCommand(Predicate<object> canExecute, Action<object> execute)
        {
            this.canExecute = canExecute;
            this.execute = execute;
        }

        public DelegateCommand(Action<object> execute) : this(null, execute) { }

        public event EventHandler? CanExecuteChanged;

        public void RaiseCanExecuteChanged()
        {
            this.CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public bool CanExecute(object? parameter)
        {
            return this.canExecute?.Invoke(parameter) ?? true;
        }

        public void Execute(object? parameter)
        {
            this.execute?.Invoke(parameter);
        }
    }
}
