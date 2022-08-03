using AutoMapper;
using DA3.DAL.Contract;
using DA3.DAL.Domain;
using DA3.DAL.Repository;
using DA3.Service.Contract;
using DA3.Service.Dto;
using DA3.Service.Request;

namespace DA3.Service.Implement
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IApplicationDbContext _dbContext;

        public ProductService(IMapper mapper, IApplicationDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<List<ProductDto>> All()
        {
            // var allProducts = await _productRepository.All();
            //return _mapper.Map<List<Product>, List<ProductDto>>(allProducts);
            return new List<ProductDto>();
        }

        public async Task<bool> Create(CreateProductRequest request, CancellationToken cancellationToken = default)
        {
            try
            {
                var productEntity = _mapper.Map<CreateProductRequest, Product>(request);

                await _dbContext.Products.AddAsync(productEntity, cancellationToken);
                await _dbContext.SaveChangesAsync(cancellationToken);
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
                //await _productRepository.Update(productEntity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
