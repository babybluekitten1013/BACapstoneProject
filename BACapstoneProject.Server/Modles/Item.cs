using System.ComponentModel.DataAnnotations;

namespace BACapstoneProject.Server.Modles
{
    public class Item
    {
        [Required]
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int InventoryID { get; set; }

        public virtual InventoryCatalog Catalog { get; set; }
    }
}
