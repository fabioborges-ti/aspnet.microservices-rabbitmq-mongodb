﻿using Play.Inventory.API.Dtos;
using Play.Inventory.API.Entities;

namespace Play.Inventory.API
{
    public static class Extensions
    {
        public static InventoryItemDto AsDto(this InventoryItem item, string name, string description)
        {
            return new InventoryItemDto(item.CatalogItemId, name, description, item.Quantity, item.AcquiredDate);
        }
    }
}
