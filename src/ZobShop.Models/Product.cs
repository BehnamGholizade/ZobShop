﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZobShop.Models
{
    public class Product
    {
        private ICollection<ProductRating> productRatings;

        public Product()
        {
            this.productRatings = new HashSet<ProductRating>();
        }

        public Product(string name, Category category, int quantity, decimal price, double volume, string maker, string imageMimeType, byte[] imageBuffer)
            : this()
        {
            this.Name = name;
            this.Category = category;
            this.Quantity = quantity;
            this.Price = price;
            this.Volume = volume;
            this.Maker = maker;
            this.ImageBuffer = imageBuffer;
            this.ImageMimeType = imageMimeType;
        }

        [Key]
        public int ProductId { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public double Volume { get; set; }

        public string Maker { get; set; }

        public virtual ICollection<ProductRating> ProductRatings
        {
            get { return this.productRatings; }
            set { this.productRatings = value; }
        }

        public string ImageMimeType { get; set; }

        public byte[] ImageBuffer { get; set; }
    }
}
