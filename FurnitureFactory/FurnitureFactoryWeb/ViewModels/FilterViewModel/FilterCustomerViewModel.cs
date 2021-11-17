using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureFactoryWeb.ViewModels.FilterViewModel
{
    public class FilterCustomerViewModel
    {
        public IEnumerable<Customer> Customers { get; set; }
        //Id Клиента
        [Display(Name = "Код клиента")]
        public int Id { get; set; }
        //Номер клиента
        [Display(Name = "Номер телефона")]
        public string Phone { get; set; }
        //Адрес клиента
        [Display(Name = "Адрес")]
        public string Address { get; set; }
        //Свойство для навигации по страницам
        public PageViewModel PageViewModel { get; set; }
        // Порядок сортировки
        public SortViewModel SortViewModel { get; set; }
    }
}
