using System;
using System.Collections.Generic;

#nullable disable

namespace FurnitureFactoryWeb
{
    public partial class SupplyMaterial
    {
        public int Id { get; set; }
        public int? MaterialId { get; set; }
        public int? FurnitureId { get; set; }

        public virtual Furniture Furniture { get; set; }
        public virtual Material Material { get; set; }
    }
}
