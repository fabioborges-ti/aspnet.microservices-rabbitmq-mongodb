using System;

namespace Play.Inventory.API.Dtos
{
    public class CatalogItemDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
