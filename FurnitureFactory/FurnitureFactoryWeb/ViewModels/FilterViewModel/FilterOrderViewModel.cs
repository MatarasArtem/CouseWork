using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureFactoryWeb.ViewModels
{
    public class FilterOrderViewModel
    {
        //Id заказа
        [Display(Name = "Код заказа")]
        public int Id { get; set; }
        //Клиент 
        [Display(Name = "Клиент")]
        public int? CustomerId { get; set; }
        //Сотрудник
        [Display(Name = "Сотрудник")]
        public int? EmployeeId { get; set; }
        //Скидка на заказ
        [Display(Name = "Скидка")]
        public decimal? Discount { get; set; }
        //Оценка за выполнение заказа
        [Display(Name = "Оценка")]
        public int? Evaluation { get; set; }
        //Дата заказа
        [Display(Name = "Дата заказа")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
