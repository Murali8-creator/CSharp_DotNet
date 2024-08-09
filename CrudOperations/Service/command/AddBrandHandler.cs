using CrudOperations.Models;
using CrudOperations.Repository;

namespace CrudOperations.Service.command
{
    public class AddBrandHandler : ICommandHandler<AddBrandCommand>
    {
        private BrandRepository _brandRepository;

        public AddBrandHandler(BrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public int Handle(AddBrandCommand command)
        {
           int res = _brandRepository.AddBrand(command);
           return res;
        }

    }
}
