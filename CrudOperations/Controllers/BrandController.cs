using CrudOperations.Models;
using CrudOperations.Models.DTO;
using CrudOperations.Service;
using CrudOperations.Service.command;
using CrudOperations.Service.Query;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CrudOperations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private ICommandHandler<AddBrandCommand> _icommandHandler;

        private IQueryHandler<GetBrandQuery, List<BrandDTO>> _iqueryHandler;

        private IQueryHandler<GetBrandQuery, Brand> _iquerybyIdHandler;

        private ICommandHandler<PutBrandCommand> _iputcommandHandler; 

        private ICommandHandler<DeleteBrandCommand> _ideletecommandHandler;




        public BrandController(ICommandHandler<AddBrandCommand> commandHandler, IQueryHandler<GetBrandQuery, List<BrandDTO>> iqueryHandler,IQueryHandler<GetBrandQuery, Brand> iqueryByIdHandler, ICommandHandler<PutBrandCommand> iputcommandHandler, ICommandHandler<DeleteBrandCommand> deletecommandHandler)
        {
            _icommandHandler = commandHandler;
            _iqueryHandler = iqueryHandler;
            _iquerybyIdHandler = iqueryByIdHandler;
            _iputcommandHandler = iputcommandHandler;
            _ideletecommandHandler = deletecommandHandler;
        }


        [HttpGet]
        public ActionResult<IEnumerable<BrandDTO>> GetBrands()
        {
            GetBrandQuery query = new GetBrandQuery();

            List<BrandDTO> BrandsList = _iqueryHandler.Handle(query);

            return BrandsList;
        }

        [HttpGet("{id:int}")]
        public ActionResult<Brand> GetBrandById(int id)
        { 
            GetBrandQuery query = new GetBrandQuery() { 
                DeviceId = id
            };
            Console.WriteLine(query);
            var brand = _iquerybyIdHandler.Handle(query);
            return brand;
        }


        [HttpPost]
        public  ActionResult<Brand> postBrand([FromBody] AddBrandCommand brand)
        {
            _icommandHandler.Handle(brand);
            //Console.WriteLine(nameof(GetBrandById));
            return CreatedAtAction(nameof(GetBrandById), new { id = brand.DeviceId }, brand);
        }

        [HttpPut]
        public ActionResult<Brand> PutBrand(int id, [FromBody] PutBrandCommand brand)
        {
            if (id != brand.DeviceId)
            {
                return BadRequest();
            }

            _iputcommandHandler.Handle(brand);

             return Ok();

        }




        [HttpDelete("{id}")]
        public IActionResult DeleteBrand(int id)
        {
            DeleteBrandCommand brand = new DeleteBrandCommand() { DeviceId = id };


            _ideletecommandHandler.Handle(brand);

            return Ok();
        }
    }
}
