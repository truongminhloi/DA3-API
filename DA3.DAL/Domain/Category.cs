using DA3.Common;

namespace DA3.DAL.Domain
{
    public class Category : BaseDomain
    {
        public string CategoryName { get; set; }

        public Status Status { get; set; }

        public List<CategoryProduct> CategoryProducts { get; set; } = new List<CategoryProduct>();
    }
}
