using System.ComponentModel.DataAnnotations;

namespace BACapstoneProject.Server.Modles
{
    public class InventoryCatalog
    {
        [Required]
        public int InventoryID { get; set;}
        public string Name { get; set;}
        public string Description { get; set;}

    }
}
