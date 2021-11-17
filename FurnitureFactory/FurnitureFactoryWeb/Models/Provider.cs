using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace FurnitureFactoryWeb
{
    public partial class Provider
    {
        public Provider()
        {
            Materials = new HashSet<Material>();
        }
        //Id поставщика
        [Key]
        [Display(Name = "Код поставщика")]
        public int Id { get; set; }
        //Название поставщика
        [Display(Name = "Поставщик")]
        public string Name { get; set; }

        public virtual ICollection<Material> Materials { get; set; }
    }
}
