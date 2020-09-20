using mvvmTabControlApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvmTabControlApp.ViewModels
{
    public class DateTab : Tab
    {

        public ObservableCollection<PersonClass> People { get; } = new ObservableCollection<PersonClass>();
        public DateTab()
        {
            //Name = DateTime.Now.ToString();
            //Name = "Date Tab";
        }
        public DateTab(string name) : this() => Name = name;
        public DateTab(string name, params PersonClass[] people) : this (name)
        {
            foreach (PersonClass person in people)
                People.Add(person);
        }
        public DateTab(string name, IEnumerable<PersonClass> people) : this(name, people.ToArray()) { }
    }
}
