using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureFactoryWeb.ViewModels
{
    public class CustomerViewModel
    {
        public List<Customer> Customers { get; set; }
        public List<int> Ids { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public string FilterPhone { get; set; }
        public string FilterAddress { get; set; }
        [Display(Name  = "Id")]
        public int Id { get; set; }
        [Display(Name = "Номер телефона")]
        public string Phone { get; set; }
        [Display(Name = "Адрес")]
        public string Address { get; set; }
    }
}
