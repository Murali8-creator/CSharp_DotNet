using CrudOperations.Models;
using CrudOperations.Repository;

namespace CrudOperations.Service.command
{
    public class AddUserHandler : ICommandHandler<AddUserCommand>
    {
        private UsersRepository _userRepository;

        public AddUserHandler(UsersRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public int Handle(AddUserCommand command)
        {
            var user = new User
            {
                Name = command.Name,
                DeviceId = command.DeviceId
            };

            int res = _userRepository.AddUser(user);
            
            return res;
        }
    }
}
