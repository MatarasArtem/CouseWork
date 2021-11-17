using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace FurnitureFactoryWeb
{
    public partial class Order
    {
        public Order()
        {
            OrderRecords = new HashSet<OrderRecord>();
        }
        //Id заказа
        [Key]
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
        //ссылка на клиентов
        public virtual Customer Customer { get; set; }
        //ссылка на сотрудников
        public virtual Employee Employee { get; set; }
        public virtual ICollection<OrderRecord> OrderRecords { get; set; }
    }
}
