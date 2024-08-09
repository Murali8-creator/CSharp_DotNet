using CrudOperations.Models;
using CrudOperations.Repository;
using Microsoft.EntityFrameworkCore;

namespace CrudOperations.Service.command
{
    public class DeleteBrandHandler : ICommandHandler<DeleteBrandCommand>
    {
        private BrandRepository _brandRepository;

        public DeleteBrandHandler(BrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public int Handle(DeleteBrandCommand command)
        {
            int res = _brandRepository.DeleteBrand(command.DeviceId);
            return res;
        }
    }
}
