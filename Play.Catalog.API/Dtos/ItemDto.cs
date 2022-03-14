﻿using System;

namespace Play.Catalog.Service.Dtos
{
    public class ItemDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTimeOffset CreatedDate { get; set; }

        public ItemDto(Guid id, string name, string description, decimal price, DateTimeOffset createdDate)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            CreatedDate = createdDate;
        }
    }
}
