using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace FurnitureFactoryWeb
{
    public partial class Position
    {
        public Position()
        {
            Employees = new HashSet<Employee>();
        }
        //Id должности
        [Key]
        [Display(Name = "Код должности")]
        public int Id { get; set; }
        //Название должности
        [Display(Name = "Должность")]
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
