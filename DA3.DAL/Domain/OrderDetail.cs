namespace DA3.DAL.Domain
{
    public class OrderDetail : BaseDomain
    {
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int Amount { get; set; }

        public double PricePerProduct { get; set; }

        public double PricePerAllProducts { get; set; }

        public Order Order { get; set; }
    }
}
