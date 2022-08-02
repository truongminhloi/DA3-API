using DA3.Service.Dto;
using DA3.Service.Request;

namespace DA3.Service.Contract
{
    public interface IProductService
    {
        Task<List<ProductDto>> All();

        Task<bool> Create(CreateProductRequest request);

        Task<bool> Update(UpdateProductRequest request);
    }
}
