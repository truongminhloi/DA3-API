﻿namespace DA3.DAL.Domain
{
    public class ProductDetail : BaseDomain
    {
        public string ProductId { get; set; }

        public string Screen { get; set; }

        public string System { get; set; }

        public string FrontCamera { get; set; }

        public string RearCamera { get; set; }

        public string Chip { get; set; }

        public string RAM { get; set; }

        public string ROM { get; set; }

        public string SIM { get; set; }

        public string PIN { get; set; }

        public string Memory { get; set; }

        public Product Product { get; set; }
    }
}
