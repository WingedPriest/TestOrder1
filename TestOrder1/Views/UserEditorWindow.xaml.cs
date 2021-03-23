using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TestOrder1.Views
{
    /// <summary>
    /// Логика взаимодействия для UserEditorWindow.xaml
    /// </summary>
    public partial class UserEditorWindow : Window, IDataErrorInfo
    {

        #region Login

        public static readonly DependencyProperty LoginProperty =
            DependencyProperty.Register(
                nameof(Login),
                typeof(string),
                typeof(UserEditorWindow),
                new PropertyMetadata(null));
        public string Login { get => (string)GetValue(LoginProperty); set => SetValue(LoginProperty, value); }

        #endregion

        #region Email

        public static readonly DependencyProperty EmailProperty =
            DependencyProperty.Register(
                nameof(Email),
                typeof(string),
                typeof(UserEditorWindow),
                new PropertyMetadata(null));
        public string Email { get => (string)GetValue(EmailProperty); set => SetValue(EmailProperty, value); }

        #endregion

        #region PhoneNumber

        public static readonly DependencyProperty PhoneNumberProperty =
            DependencyProperty.Register(
                nameof(PhoneNumber),
                typeof(string),
                typeof(UserEditorWindow),
                new PropertyMetadata(null));
        public string PhoneNumber { get => (string)GetValue(PhoneNumberProperty); set => SetValue(PhoneNumberProperty, value); }

        #endregion

        #region Surname

        public static readonly DependencyProperty SurnameProperty =
            DependencyProperty.Register(
                nameof(Surname),
                typeof(string),
                typeof(UserEditorWindow),
                new PropertyMetadata(null));
        public string Surname { get => (string)GetValue(SurnameProperty); set => SetValue(SurnameProperty, value); }

        #endregion

        #region Name

        public static readonly DependencyProperty NameUserProperty =
            DependencyProperty.Register(
                nameof(NameUser),
                typeof(string),
                typeof(UserEditorWindow),
                new PropertyMetadata(null));
        public string NameUser { get => (string)GetValue(NameUserProperty); set => SetValue(NameUserProperty, value); }

        #endregion

        #region Patronymic

        public static readonly DependencyProperty PatronymicProperty =
            DependencyProperty.Register(
                nameof(Patronymic),
                typeof(string),
                typeof(UserEditorWindow),
                new PropertyMetadata(null));
        public string Patronymic { get => (string)GetValue(PatronymicProperty); set => SetValue(PatronymicProperty, value); }

        #endregion

        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                switch (columnName)
                {
                    case "Login":
                        if ((Login!=null)&&(Login.Length > 50))
                        {
                            error = "Слишком большая длинна логина";
                        }
                        break;
                    case "Email":
                        string patternEmail = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                                            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
                        if ((Email != null) && (Email.Length > 50))
                        {
                            error = "Слишком большая длинна адреса электронной почты";
                        }
                        if(Email != null) { bool a = Regex.IsMatch(Email, patternEmail, RegexOptions.IgnoreCase); }
                        if ((Email != null) && (!Regex.IsMatch(Email, patternEmail, RegexOptions.IgnoreCase)))
                        {
                            error = "Не верный формат адреса электронной почты";
                        }
                        break;
                    case "Surname":
                        if ((Surname != null) && (Surname.Length > 50))
                        {
                            error = "Слишком большая длинна фамилии";
                        }
                        break;
                    case "PhoneNumber":
                        string patternPhoneNumber = "^[0-9 ]";
                        if ((PhoneNumber != null) && (PhoneNumber.Length > 11))
                        {
                            error = "Слишком большая длинна номера телефона";
                        }
                        if ((PhoneNumber != null) && (!Regex.IsMatch(PhoneNumber, patternPhoneNumber, RegexOptions.IgnoreCase)))
                        {
                            error = "Не верный формат номера телефона";
                        }

                        break;
                    case "Name":
                        if ((Name != null) && (Name.Length > 50))
                        {
                            error = "Слишком большая длинна имени";
                        }
                        break;
                    case "Patronymic":
                        if ((Patronymic != null) && (Patronymic.Length > 50))
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

        public UserEditorWindow()
        {
            InitializeComponent();
        }
    }
}
