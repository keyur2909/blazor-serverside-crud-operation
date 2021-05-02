using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace blazor_serverside_crud_operation.Models
{
    public partial class Product
    {
        public Guid ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public decimal? ProductPrice { get; set; }
        public decimal? AvailableStock { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
