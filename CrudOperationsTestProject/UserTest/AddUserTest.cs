using CrudOperations.Models;
using CrudOperations.Repository;
using CrudOperations.Service.command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CrudOperationsTestProject.UserTest
{
    [TestFixture]
    public class AddUserTest : TestBase
    {
        private UsersRepository _usersRepository;
        private AddUserHandler _addUserHandler;

        [SetUp()]
        public void SetUp()
        {
            _usersRepository = new UsersRepositoryImpl(TestDbContext);
            _addUserHandler = new AddUserHandler(_usersRepository);
        }

        [Test]
        public void HandleAddUserTest() 
        {
            //arrange
            var user = new AddUserCommand
            {
                Name = "test",
                DeviceId = 18
            };


            //act
            _addUserHandler.Handle(user);

            //assert
            var AddedUser = TestDbContext.Users.FirstOrDefault(user => user.DeviceId == 18 && user.Name == "test");

            Assert.That(user.DeviceId, Is.EqualTo(AddedUser.DeviceId));
            Assert.That(user.Name, Is.EqualTo(AddedUser.Name));
        }


    }
}
