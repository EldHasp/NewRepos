using mvvmTabControlApp.Commands;
using System;
using System.Windows.Input;

namespace mvvmTabControlApp.ViewModels
{
    public abstract class Tab : OnPropertyChangedClass, ITab
    {
        public Tab()
        {
            CloseCommand = new ActionCommand(p => CloseRequested?.Invoke(this, EventArgs.Empty));
        }
        public string Name { get; set; }
        public ICommand CloseCommand { get; }
        public event EventHandler CloseRequested;
    }
}
