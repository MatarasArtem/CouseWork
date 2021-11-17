using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureFactoryWeb
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }
        //Id Клиента
        [Key]
        [Display(Name = "Код клиента")]
        public int Id { get; set; }
        //Номер клиента
        [Display(Name = "Номер телефона")]
        public string Phone { get; set; }
        //Адрес клиента
        [Display(Name = "Адрес")]
        public string Address { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
