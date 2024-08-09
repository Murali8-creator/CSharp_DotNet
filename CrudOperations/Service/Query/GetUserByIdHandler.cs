using CrudOperations.Models;
using CrudOperations.Models.DTO;
using CrudOperations.Repository;

namespace CrudOperations.Service.Query
{
    public class GetUserByIdHandler : IQueryHandler<GetUserQuery, UserDTO>
    {

        private UsersRepository _usersRepository;

        public GetUserByIdHandler(UsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }


        UserDTO IQueryHandler<GetUserQuery, UserDTO>.Handle(GetUserQuery query)
        {
            User user = _usersRepository.GetAllUsers().Find(query.Id);

            UserDTO userDTO = new UserDTO()
            {
                Id = user.Id,
                Name = user.Name,
                DeviceId = user.DeviceId,
                Brand = null
            };

            return userDTO;
        }
    }
}
