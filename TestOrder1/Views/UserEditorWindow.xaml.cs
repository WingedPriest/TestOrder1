using System;
using System.Collections.Generic;
using System.Text;
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
    public partial class UserEditorWindow : Window
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

        public UserEditorWindow()
        {
            InitializeComponent();
        }
    }
}
