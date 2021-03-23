using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using TestOrder1.Infrastructure.Commnds;
using TestOrder1.Models;
using TestOrder1.Service;
using TestOrder1.ViewModel.Base;

namespace TestOrder1.ViewModel
{
    class MainWindowViewModel : ViewModelBase
    {
        DBContext db;
        public ObservableCollection<User> UserList { get; set; }

        private readonly WindowsUserDialogService _UserDialog;

        #region Выбраный юзер
        /// <summary>Выбраное юзер</summary>
        private User _selectedUser;

        /// <summary>Выбраное юзер</summary>
        public User selectedUser { get => _selectedUser; set => Set(ref _selectedUser, value); }

        #endregion

        #region Команды

        #region EditUserCommand - Команда редактирования юзера

        private ICommand _EditUserCommand;

        /// <summary>Команда редактирования юзера</summary>
        public ICommand EditUserCommand => _EditUserCommand ??= new LambdaCommand(OnEditUserCommandExecuted, CanEditUserCommandExecute);

        private static bool CanEditUserCommandExecute(object p) => p is User;

        private void OnEditUserCommandExecuted(object p)
        {
            if (_UserDialog.Edit(p))
            {
                ((User)p).DateOfChange = DateTime.Now;
                db.SaveChanges();
                UserList = db.User.Local.ToObservableCollection();
                OnPropertyChanged(nameof(UserList));
            }
        }

        #endregion

        #region Command CreateNewUserCommand - Создание нового юзера

        /// <summary>Создание нового юзера</summary>
        private ICommand _CreateNewUserCommand;

        /// <summary>Создание нового юзера</summary>
        public ICommand CreateNewUserCommand => _CreateNewUserCommand
            ??= new LambdaCommand(OnCreateNewUserCommandExecuted, CanCreateNewUserCommandExecute);

        /// <summary>Проверка возможности выполнения - Создание нового юзера</summary>
        private static bool CanCreateNewUserCommandExecute(object p) => true;

        /// <summary>Логика выполнения - Создание нового юзера</summary>
        private void OnCreateNewUserCommandExecuted(object p)
        {

            var user = new User()
            {
                DateOfCreation = DateTime.Now,
                DateOfChange=DateTime.Now
            };

            if (_UserDialog.Edit(user))
            {
                db.User.Add(user);
                db.SaveChanges();
                UserList = db.User.Local.ToObservableCollection();
                OnPropertyChanged(nameof(UserList));
                return;
            }
        }

        #endregion

        #region Command DeletewUserCommand - Создание нового юзера

        /// <summary>Создание нового юзера</summary>
        private ICommand _DeleteUserCommand;

        /// <summary>Создание нового юзера</summary>
        public ICommand DeleteUserCommand => _DeleteUserCommand
            ??= new LambdaCommand(OnDeleteUserCommandExecuted, CanDeleteUserCommandExecute);

        /// <summary>Проверка возможности выполнения - Создание нового юзера</summary>
        private static bool CanDeleteUserCommandExecute(object p) => p is User;

        /// <summary>Логика выполнения - Создание нового юзера</summary>
        private void OnDeleteUserCommandExecuted(object p)
        {

            db.User.Remove((User)p);
            db.SaveChanges();
            UserList = db.User.Local.ToObservableCollection();
            OnPropertyChanged(nameof(UserList));
        }

        #endregion

        #endregion
        public MainWindowViewModel()
        {
            _UserDialog = new WindowsUserDialogService();
            db = new DBContext();
            db.User.Load();
            UserList = db.User.Local.ToObservableCollection();
        }
    }
}
