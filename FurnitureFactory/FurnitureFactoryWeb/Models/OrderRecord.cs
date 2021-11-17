using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace FurnitureFactoryWeb
{
    public partial class OrderRecord
    {
        // Id записи о заказе
        [Display(Name = "Код")]
        public int Id { get; set; }
        //Заказ
        [Display(Name = "Заказ")]
        public int OrderId { get; set; }
        //Мебель
        [Display(Name = "Мебель")]
        public int FurnitureId { get; set; }
        //Полная стоимость заказа
        [Display(Name = "Полная стоимость")]
        public decimal? TotalOrderPrice { get; set; }
        //Заказ на определенную дату
        [Display(Name = "Определенная дата")]
        public int? NumberOrderByDate { get; set; }
        //ссылка на мебель
        public virtual Furniture Furniture { get; set; }
        //сылка на заказы
        public virtual Order Order { get; set; }
    }
}
