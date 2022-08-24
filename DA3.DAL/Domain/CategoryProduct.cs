using DA3.Common;

namespace DA3.DAL.Domain
{
    public class CategoryProduct : BaseDomain
    {
        public string CategoryName { get; set; }

        public Status Status { get; set; }

        public Category Category { get; set; }
    }
}
