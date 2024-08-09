using CrudOperations.Repository;
using CrudOperations.Service.command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperationsTestProject.BrandTest
{

    [TestFixture]
    public class DeleteBrandTest : TestBase
    {
        private DeleteBrandHandler _deleteBrandHandler;

        private BrandRepositoryImpl _brandRepository;

        [SetUp()]
        public void SetUp()
        {
            _brandRepository = new BrandRepositoryImpl(TestDbContext);
            _deleteBrandHandler = new DeleteBrandHandler(_brandRepository);
            

        }

        [Test]
        public void HandleDeleteBrandTest()
        {
            //arrange
            DeleteBrandCommand brand = new DeleteBrandCommand() { DeviceId = 17 };
            

            //act
            _deleteBrandHandler.Handle(brand);

            //assert
            var DeletedBrand = TestDbContext.Brands.Find(brand.DeviceId);

            Assert.IsNull(DeletedBrand);

        }

    }
}
