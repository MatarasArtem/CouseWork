using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace FurnitureFactoryWeb
{
    public partial class Furniture
    {
        public Furniture()
        {
            OrderRecords = new HashSet<OrderRecord>();
            SupplyMaterials = new HashSet<SupplyMaterial>();
        }
        //Id мебели
        [Key]
        [Display(Name = "Код мебели")]
        public int Id { get; set; }
        //Название мебели
        [Display(Name = "Название мебели")]
        public string Name { get; set; }
        //Описание мебели
        [Display(Name = "Описание")]
        public string Description { get; set; }
        //Цена мебели
        [Display(Name = "Цена")]
        public decimal? Price { get; set; }
        //Кодичество мебели
        [Display(Name = "Количество")]
        public int? Number { get; set; }

        public virtual ICollection<OrderRecord> OrderRecords { get; set; }
        public virtual ICollection<SupplyMaterial> SupplyMaterials { get; set; }
    }
}
