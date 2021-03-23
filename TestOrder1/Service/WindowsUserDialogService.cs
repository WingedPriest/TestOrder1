using System;
using System.Collections.Generic;
using System.Text;
using TestOrder1.Models;
using TestOrder1.Views;

namespace TestOrder1.Service
{
    class WindowsUserDialogService
    {
        public bool Edit(object item)
        {
            if (item is null) throw new ArgumentNullException(nameof(item));

            switch (item)
            {
                default: throw new NotSupportedException($"Редактирование объекта типа {item.GetType().Name} не поддерживается");
                case User user:
                    return EditUser(user);
            }
        }

        private static bool EditUser(User user)
        {
            var dlg = new UserEditorWindow
            {
                Login = user.Login,
                Email= user.Email,
                PhoneNumber= user.PhoneNumber,
                Surname= user.Surname,
                NameUser= user.Name,
                Patronymic= user.Patronymic
            };
            

            if (dlg.ShowDialog() != true) return false;

            user.Login = dlg.Login;
            user.Email = dlg.Email;
            user.PhoneNumber = dlg.PhoneNumber;
            user.Surname = dlg.Surname;
            user.Name = dlg.NameUser;
            user.Patronymic = dlg.Patronymic;
            

            return true;
        }
    }
}
