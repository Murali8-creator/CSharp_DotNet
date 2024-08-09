using CrudOperations.Models;
using CrudOperations.Repository;
using Microsoft.EntityFrameworkCore;

namespace CrudOperations.Service.command
{
    public class PutBrandHandler : ICommandHandler<PutBrandCommand>
    {
        private BrandRepository _brandRepository;

        public PutBrandHandler(BrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public int Handle(PutBrandCommand brand)
        {
            int res = _brandRepository.updateBrand(brand);
            return res;
        }


    }
}
