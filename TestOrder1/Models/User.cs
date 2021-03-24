using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;
using TestOrder1.Models.Base;

namespace TestOrder1.Models
{
    class User:ModelBase
    {
        #region Идентификатор

        /// <summary>Идентификатор</summary>
        private int _Id;

        /// <summary>Идентификатор</summary>
        public int Id { get => _Id; set => Set(ref _Id, value); }

        #endregion

        #region Логин

        /// <summary>Логин</summary>
        private string _Login;

        /// <summary>Логин</summary>
        public string Login { get => _Login; set => Set(ref _Login, value); }

        #endregion

        #region Адрес электронной почты

        /// <summary>Адрес электронной почты</summary>
        private string _Email;

        /// <summary>Адрес электронной почты</summary>
        public string Email { get => _Email; set => Set(ref _Email, value); }

        #endregion

        #region Номер телефона

        /// <summary>Номер телефона</summary>
        private string _PhoneNumber;

        /// <summary>Номер телефона</summary>
        public string PhoneNumber { get => _PhoneNumber; set => Set(ref _PhoneNumber, value); }

        #endregion

        #region Фамилия

        /// <summary>Фамилия</summary>
        private string _Surname;

        /// <summary>Фамилия</summary>
        public string Surname { get => _Surname; set => Set(ref _Surname, value); }

        #endregion

        #region Имя

        /// <summary>Имя</summary>
        private string _Name;

        /// <summary>Имя</summary>
        public string Name { get => _Name; set => Set(ref _Name, value); }

        #endregion

        #region Отчество

        /// <summary>Отчество</summary>
        private string _Patronymic;

        /// <summary>Отчество</summary>
        public string Patronymic { get => _Patronymic; set => Set(ref _Patronymic, value); }

        #endregion

        #region Дата создания

        /// <summary>Дата создания</summary>
        private DateTime _DateOfCreation;

        /// <summary>Дата создания</summary>
        public DateTime DateOfCreation { get => _DateOfCreation; set => Set(ref _DateOfCreation, value); }

        #endregion

        #region Дата последнего редактирования

        /// <summary>Дата создания</summary>
        private DateTime _DateOfChange;

        /// <summary>Дата создания</summary>
        public DateTime DateOfChange { get => _DateOfChange; set => Set(ref _DateOfChange, value); }

        #endregion
 
    }
}
