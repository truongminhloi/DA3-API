namespace DA3.DAL.Domain
{
    public class Store : BaseDomain
    {
        public string StoreName { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
