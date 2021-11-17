using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace FurnitureFactoryWeb
{
    public partial class Material
    {
        public Material()
        {
            SupplyMaterials = new HashSet<SupplyMaterial>();
        }
        //Id материала
        [Key]
        [Display(Name = "Код материала")]
        public int Id { get; set; }
        //Название материала
        [Display(Name = "Название")]
        public string Name { get; set; }
        //Поставщик материала
        [Display(Name = "Поставщик")]
        public int ProviderId { get; set; }
        //ссылка на поставщиков
        public virtual Provider Provider { get; set; }
        public virtual ICollection<SupplyMaterial> SupplyMaterials { get; set; }
    }
}
