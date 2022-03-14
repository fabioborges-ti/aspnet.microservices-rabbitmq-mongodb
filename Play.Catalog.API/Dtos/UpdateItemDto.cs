using System.ComponentModel.DataAnnotations;

namespace Play.Catalog.Service.Dtos
{
    public class UpdateItemDto
    {
        [Required]
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        [Range(0, 1000)]
        public decimal Price { get; set; }

        public UpdateItemDto(string name, string description, decimal price)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }
    }
}
