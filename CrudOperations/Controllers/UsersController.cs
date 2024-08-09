using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CrudOperations.Models;
using CrudOperations.Service.command;
using CrudOperations.Service;
using CrudOperations.Service.Query;
using CrudOperations.Models.DTO;

namespace CrudOperations.Controllers
{
    //[ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private ICommandHandler<AddUserCommand> _commandHandler;

        private IQueryHandler<GetUserQuery, List<UserDTO>> _queryGetHandler;

        private IQueryHandler<GetUserQuery, UserDTO> _queryGetByIdHandler;
        public UsersController(ICommandHandler<AddUserCommand> context, IQueryHandler<GetUserQuery, List<UserDTO>> getQuery,IQueryHandler<GetUserQuery,UserDTO> _queryGetByIdHandler)
        {
            _commandHandler = context;
            _queryGetHandler = getQuery;
            this._queryGetByIdHandler = _queryGetByIdHandler;
        }

        // GET: Users
        [HttpGet]
        public ActionResult<IEnumerable<Brand>> Index()
        {
            GetUserQuery query = new GetUserQuery();
            List<UserDTO> users= _queryGetHandler.Handle(query);

            

            return Ok(users);

        }

        // GET: Users/Details/5
        [HttpGet("id")]
        public UserDTO Details(int id)
        {  
            GetUserQuery query = new GetUserQuery()
            {
                Id = id
            };
            UserDTO user = _queryGetByIdHandler.Handle(query);
            return user;
        }

        [HttpPost]
        public IActionResult SaveUser([FromBody] AddUserCommand user)
        {
            if (user == null)
            {
                return BadRequest("User data is null");
            }
            Console.WriteLine("name"+user.Name);

            if (_commandHandler.Handle(user) == 1)
                return Ok("User saved successfully");
            else
                return BadRequest("User not saved");
        }


    }
}
