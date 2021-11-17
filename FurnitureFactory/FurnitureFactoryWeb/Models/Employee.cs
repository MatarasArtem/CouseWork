using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FurnitureFactoryWeb
{
    public partial class Employee
    {
        public Employee()
        {
            Orders = new HashSet<Order>();
        }
        //Id сотрудника
        [Key]
        [Display(Name = "Код сотрудника")]
        public int Id { get; set; }
        //Фамилия сотрудника
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }
        //Имя сотрудника
        [Display(Name = "Имя")]
        public string Name { get; set; }
        //Отчество сотрудника
        [Display(Name = "Отчество")]
        public string MiddleName { get; set; }
        //Образование сотрудника
        [Display(Name = "Образование")]
        public string Education { get; set; }
        //Должность сотрудника
        [Display(Name = "Должность")]
        public int PositionId { get; set; }
        //ссылка на должности
        public virtual Position Position { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
