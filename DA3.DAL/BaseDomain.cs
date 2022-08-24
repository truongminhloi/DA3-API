namespace DA3.DAL
{
    public class BaseDomain
    {
        public Guid Id { get; set; }

        public string CreateBy { get; set; }

        public string UpdateBy { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}
