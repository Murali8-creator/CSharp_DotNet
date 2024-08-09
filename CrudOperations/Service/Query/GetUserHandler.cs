using CrudOperations.Models;
using CrudOperations.Models.DTO;
using CrudOperations.Repository;
using Microsoft.EntityFrameworkCore;


namespace CrudOperations.Service.Query
{
    public class GetUserHandler : IQueryHandler<GetUserQuery, List<UserDTO>>
    {
        private UsersRepository usersRepository;

        public GetUserHandler(UsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }

        public List<UserDTO> Handle(GetUserQuery query)
        {
            List<UserDTO> users = usersRepository.GetAllUsers()
                        .Include(u => u.Brand)
                        .Select(u => new UserDTO
                        {
                            Id = u.Id,
                            Name = u.Name,
                            DeviceId = u.DeviceId,
                            Brand = new BrandSimpleDTO()
                            {
                                DeviceId = u.Brand.DeviceId,
                                Name = u.Brand.Name
                            }

                        })
                        .ToList();
            return users;
        }

        
    }
}
