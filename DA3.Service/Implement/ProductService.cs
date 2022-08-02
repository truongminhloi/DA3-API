using AutoMapper;
using DA3.DAL.Domain;
using DA3.DAL.Repository;
using DA3.Service.Contract;
using DA3.Service.Dto;
using DA3.Service.Request;

namespace DA3.Service.Implement
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductDto>> All()
        {
            var allProducts = await _productRepository.All();
            return _mapper.Map<List<Product>, List<ProductDto>>(allProducts);
        }

        public async Task<bool> Create(CreateProductRequest request)
        {
            try
            {
                var productEntity = _mapper.Map<CreateProductRequest, Product>(request);
                await _productRepository.Add(productEntity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public async Task<bool> Update(UpdateProductRequest request)
        {
            try
            {
                var productEntity = _mapper.Map<UpdateProductRequest, Product>(request);
                await _productRepository.Update(productEntity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
