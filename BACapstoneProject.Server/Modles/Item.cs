namespace BACapstoneProject.Server.Modles
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int InventoryID { get; set; }

        public virtual InventoryCatalog Catalog { get; set; }
    }
}
