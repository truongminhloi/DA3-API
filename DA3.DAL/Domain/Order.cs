namespace DA3.DAL.Domain
{
    public class Order : BaseDomain
    {
        public int UserId { get; set; }
        
        public double TotalPrice { get; set; }

        public DateTime CreateDate { get; set; }

        public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
