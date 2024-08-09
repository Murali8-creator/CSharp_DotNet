using CrudOperations.Models;
using CrudOperations.Repository;
using CrudOperations.Service.command;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperationsTestProject.BrandTest
{
    [TestFixture]
    public class PutBrandTest : TestBase
    {
        private BrandRepository _brandRepository;

        private PutBrandHandler _brandHandler;

        [SetUp]
        public void SetUp()
        {
            _brandRepository = new BrandRepositoryImpl(TestDbContext);
            _brandHandler = new PutBrandHandler(_brandRepository);
        }

        [Test]
        public void PutBrandHandlerTest()
        {
            //arrange
            var brand = new PutBrandCommand()
            {
                DeviceId = 18,
                Name = "samsung"
            };

            //act
            _brandHandler.Handle(brand);

            var modifiedBrand = TestDbContext.Brands.Find(brand.DeviceId);

            //assert
            Assert.That(modifiedBrand.Name, Is.EqualTo("samsung"));

        }
    }
}
