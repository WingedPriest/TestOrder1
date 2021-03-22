using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using TestOrder1.Models;
using TestOrder1.ViewModel.Base;

namespace TestOrder1.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        DBContext db;
        public ObservableCollection<Person> PersonList { get; set; }

        #region Выбраный юзер
        /// <summary>Выбраное юзер</summary>
        private Person _selectedPerson;

        /// <summary>Выбраное юзер</summary>
        public Person selectedPerson { get => _selectedPerson; set => Set(ref _selectedPerson, value); }

        #endregion
        public MainWindowViewModel()
        {
            db = new DBContext();
            db.User.Load();
            PersonList = db.User.Local.ToObservableCollection();
        }
    }
}
