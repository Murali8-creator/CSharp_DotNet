using CrudOperations.Models;
using CrudOperations.Repository;
using Microsoft.EntityFrameworkCore;

namespace CrudOperations.Service.Query
{
    public class GetBrandByIdHandler : IQueryHandler<GetBrandQuery, Brand>
    {

        

        private BrandRepository _brandRepository;

        public GetBrandByIdHandler(BrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public Brand Handle(GetBrandQuery query)
        {
            var brand = _brandRepository.GetAllBrands().Find(query.DeviceId); 
            if (brand == null)
            {
                throw new Exception("Brand not found"); 
            }
            return brand; 
        }
    }
}
