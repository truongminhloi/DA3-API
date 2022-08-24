﻿using DA3.Common;

namespace DA3.DAL.Domain
{
    public class Product : BaseDomain
    {
        public string ProductName { get; set; }

        public string CategoryId { get; set; }

        public Category Category { get; set; }

        public string Url { get; set; }

        public double Price { get; set; }

        public string Describe { get; set; }

        public string Color { get; set; }

        public Status Status { get; set; }

        public ProductDetail ProductDetail { get; set; }
    }
}
