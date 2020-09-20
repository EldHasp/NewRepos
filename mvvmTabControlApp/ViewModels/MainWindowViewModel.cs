using mvvmTabControlApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using mvvmTabControlApp.Commands;
using System.Collections.Specialized;
using mvvmTabControlApp.Models;

namespace mvvmTabControlApp.ViewModels
{
    public class MainWindowViewModel
    {
        private readonly ModelClass model = new ModelClass();
        private readonly ObservableCollection<ITab> tabs;
        public MainWindowViewModel()
        {
            //NewTabCommand = new ActionCommand(p => NewTab());
            NewTabCommand = new ActionCommand(p => NewDateTab());
            NewTabCommand1 = new ActionCommand(p => NewOneTab());
            NewTabCommand2 = new ActionCommand(p => NewTwoTab());
            tabs = new ObservableCollection<ITab>();
            tabs.CollectionChanged += Tabs_CollectionChanged;
            Tabs = tabs;
        }

        public ICommand NewTabCommand { get; }
        public ICommand NewTabCommand1 { get; }
        public ICommand NewTabCommand2 { get; }
        public ICollection<ITab> Tabs { get; }

        //private void NewTab()
        //{
        //    Tabs.Add(new DateTab());
        //}

        private void NewDateTab()
        {
            Tabs.Add(new DateTab("СПИСОК ЛЮДИШКИ", model.GetPeople()));
        }

        private void NewOneTab()
        {
            Tabs.Add(new OneTab());
        }

        private void NewTwoTab()
        {
            Tabs.Add(new TwoTab());
        }

        private void Tabs_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            ITab tab;
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    tab = (ITab)e.NewItems[0];
                    tab.CloseRequested += OnTabCloseRequested;
                    break;
                case NotifyCollectionChangedAction.Remove:
                    tab = (ITab)e.OldItems[0];
                    tab.CloseRequested += OnTabCloseRequested;
                    break;
            }
        }

        private void OnTabCloseRequested(object sender, EventArgs e)
        {
            Tabs.Remove((ITab)sender);
        }
    }
}
