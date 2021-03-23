using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;
using TestOrder1.Models.Base;

namespace TestOrder1.Models
{
    class User:ModelBase, IDataErrorInfo
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

        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                switch (columnName)
                {
                    case "Age":
                        if (Login.Length > 50) 
                        {
                            error = "Слишком большая длинна логина";
                        }
                        break;
                    case "Email":
                        string patternEmail = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                                            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
                        if (Email.Length > 50)
                        {
                            error = "Слишком большая длинна адреса электронной почты";
                        }
                        if (Regex.IsMatch(Email, patternEmail, RegexOptions.IgnoreCase))
                        {
                            error = "Не верный формат адреса электронной почты";
                        }
                            break;
                    case "Surname":
                        if (Surname.Length > 50)
                        {
                            error = "Слишком большая длинна фамилии";
                        }
                        break;
                    case "PhoneNumber":
                        string patternPhoneNumber = "^[0-9 ]";
                        if (PhoneNumber.Length > 11)
                        {
                            error = "Слишком большая длинна номера телефона";
                        }
                        if (Regex.IsMatch(PhoneNumber, patternPhoneNumber, RegexOptions.IgnoreCase))
                        {
                            error = "Не верный формат номера телефона";
                        }

                        break;
                    case "Name":
                        if (Name.Length > 50)
                        {
                            error = "Слишком большая длинна имени";
                        }
                        break;
                    case "Patronymic":
                        if (Patronymic.Length > 50)
                        {
                            error = "Слишком большая длинна отчества";
                        }
                        break;
                }
                return error;
            }
        }
        public string Error
        {
            get { throw new NotImplementedException(); }
        }
    }
}
