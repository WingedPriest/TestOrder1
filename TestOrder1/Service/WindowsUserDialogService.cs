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
                case Person person:
                    return EditPerson(person);
            }
        }

        private static bool EditPerson(Person person)
        {
            var dlg = new UserEditorWindow
            {
                Login = person.Name,
                Email=person.Email,
                PhoneNumber=person.PhoneNumber,
                Surname=person.Surname,
                NameUser=person.Name,
                Patronymic=person.Patronymic
            };
            

            if (dlg.ShowDialog() != true) return false;

            person.Login = dlg.Login;
            person.Email = dlg.Email;
            person.PhoneNumber = dlg.PhoneNumber;
            person.Surname = dlg.Surname;
            person.Name = dlg.Name;
            person.Patronymic = dlg.Patronymic;

            return true;
        }
    }
}
