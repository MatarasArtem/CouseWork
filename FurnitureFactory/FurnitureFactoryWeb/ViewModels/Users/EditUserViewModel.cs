using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureFactoryWeb.ViewModels.Users
{
    public class EditUserViewModel
    {
        public string Id { get; set; }
        [Display(Name = "Имя")]
        public string UserName { get; set; }
        [EmailAddress(ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }
        [Display(Name = "Дата регистрации")]
        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }

        [Display(Name = "Роль")]
        public string UserRole { get; set; }
        public EditUserViewModel()
        {
            UserRole = "user";
        }
    }
}
