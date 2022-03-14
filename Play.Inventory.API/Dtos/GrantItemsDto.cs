using System;

namespace Play.Inventory.API.Dtos
{
    public class GrantItemsDto
    {
        public Guid UserId { get; set; }
        public Guid CatalogItemId { get; set; }
        public int Quantity { get; set; }

        public GrantItemsDto(Guid userId, Guid catalogItemId, int quantity)
        {
            this.UserId = userId;
            this.CatalogItemId = catalogItemId;
            this.Quantity = quantity;
        }
    }
}
