﻿namespace Store.DTOs
{
    public class ProductFilterDTO
    {
        public string? ProductName { get; set; }
        public int CategoryId { get; set; }
        public bool Discontinued { get; set; }
    }
}
