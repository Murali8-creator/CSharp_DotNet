using CrudOperations.Models;
using CrudOperations.Models.DTO;
using CrudOperations.Repository;
using Microsoft.EntityFrameworkCore;


namespace CrudOperations.Service.Query
{
    public class GetBrandHandler : IQueryHandler<GetBrandQuery, List<BrandDTO>>
    {
        private BrandRepository _brandRepository;

        public GetBrandHandler(BrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public List<BrandDTO> Handle(GetBrandQuery query)
        {
            
            List<UserSimpleDTO> usersList = new List<UserSimpleDTO>();

            List<BrandDTO> brands = _brandRepository.GetAllBrands()
                .Include(b => b.Users)
                .Select(b => new BrandDTO
                {
                    DeviceId = b.DeviceId,
                    Name = b.Name,
                    Users = b.Users.Select(u => new UserSimpleDTO
                    {
                        Id = u.Id,
                        Name = u.Name
                    }).ToList()
                })
                .ToList();

            return brands;
        }
    }
}
