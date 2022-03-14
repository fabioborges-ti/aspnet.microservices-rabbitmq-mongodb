using System;

namespace Play.Inventory.API.Dtos
{
    public class InventoryItemDto
    {
        public Guid CatalogItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public DateTimeOffset AcquiredDate { get; set; }

        public InventoryItemDto(Guid catalogItemId, string name, string description, int quantity, DateTimeOffset acquiredDate)
        {
            this.CatalogItemId = catalogItemId;
            this.Name = name;
            this.Description = description;
            this.Quantity = quantity;
            this.AcquiredDate = acquiredDate;
        }
    }
}
