using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureFactoryWeb.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Education { get; set; }
        public int? PositionId { get; set; }

        public virtual Position Position { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}