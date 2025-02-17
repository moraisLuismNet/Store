﻿using Store.Validators;

namespace Store.DTOs
{
    public class ProductInsertDTO
    {
        public string NameProduct { get; set; } = null!;
        public decimal Price { get; set; }
        public DateOnly? DateUp { get; set; }
        public bool Discontinued { get; set; }
        [WeightFileValidation(MaximumWeightInMegaBytes: 4)]
        [ValidationFileType(groupFileType: GroupFileType.Image)]
        public IFormFile? Fhoto { get; set; }
        public int? CategoryId { get; set; }
    }
}
