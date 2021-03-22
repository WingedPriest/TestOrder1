using System;
using System.Collections.Generic;
using System.Text;

namespace TestOrder1.Models
{
    class Person
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime DateOfChange { get; set; }
    }
}
