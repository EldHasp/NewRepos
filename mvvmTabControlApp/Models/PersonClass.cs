using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvmTabControlApp.Models
{
    public class PersonClass : OnPropertyChangedClass
    {
        private int _id;
        private string _number;
        private string _fullName;
        private DateTime _birthday;
        private string _receptionPlot;
        private string _адрес;
        private string _accountingStatus;
        private string _gender;
        private string _healthGroup;
        private string _disabilityMark;
        private string _socialRiskGroup;
        private string _age;
        private string _teenOffice;
        private string _imageUrl;

        /// <summary>Идентификатор</summary>
        public int Id { get => _id; set { _id = value; OnPropertyChanged(); } }
        /// <summary>Номер</summary>
        public string Number { get => _number; set { _number = value; OnPropertyChanged(); } }
        /// <summary>Фамилия, Имя, Отчество</summary>
        public string FullName { get => _fullName; set { _fullName = value; OnPropertyChanged(); } }
        /// <summary>Дата рождения"</summary>
        public DateTime Birthday { get => _birthday; set { _birthday = value; OnPropertyChanged(); } }
        /// <summary>Участок</summary>
        public string ReceptionPlot { get => _receptionPlot; set { _receptionPlot = value; OnPropertyChanged(); } }
        /// <summary>Адрес</summary>
        public string  Address{ get => _адрес; set { _адрес = value; OnPropertyChanged(); } }
        /// <summary>Состояние учёта</summary>
        public string AccountingStatus { get => _accountingStatus; set { _accountingStatus = value; OnPropertyChanged(); } }
        /// <summary>Пол</summary>
        public string Gender { get => _gender; set { _gender = value; OnPropertyChanged(); } }
        /// <summary>Группа здоровья</summary>
        public string HealthGroup { get => _healthGroup; set { _healthGroup = value; OnPropertyChanged(); } }
        /// <summary>Инвалидность отметка</summary>
        public string DisabilityMark { get => _disabilityMark; set { _disabilityMark = value; OnPropertyChanged(); } }
        /// <summary>Группа социального риска</summary>
        public string SocialRiskGroup { get => _socialRiskGroup; set { _socialRiskGroup = value; OnPropertyChanged(); } }
        /// <summary>Возраст</summary>
        public string Age { get => _age; set { _age = value; OnPropertyChanged(); } }
        /// <summary>Передан в подростковый кабинет</summary>
        public string TeenOffice { get => _teenOffice; set { _teenOffice = value; OnPropertyChanged(); } }
        /// <summary>Комментарий</summary>
        public string Comment { get => _imageUrl; set { _imageUrl = value; OnPropertyChanged(); } }
        /// <summary>URL изображения</summary>
        public string ImageUrl { get => _imageUrl; set { _imageUrl = value; OnPropertyChanged(); } }

    }
}
