using CrudOperations.Models;
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
    public class AddBrandTest : TestBase
    {
        private BrandRepository _brandRepository;
        private AddBrandHandler _addBrandHandler;

        [SetUp]
        public void Setup()
        {
            _brandRepository = new BrandRepositoryImpl(TestDbContext);

            _addBrandHandler = new AddBrandHandler(_brandRepository);


        }

        [Test]
        public void HandleAddToDatabase()
        {
            //arrange
            AddBrandCommand brand = new AddBrandCommand()
            {
                Name = "nokia",
                Users = null,
            };

            //act
            _addBrandHandler.Handle(brand);

            //assert
            var addedBrand = TestDbContext.Brands.First(b => b.Name == "nokia");

            Assert.That(addedBrand.Name, Is.EqualTo(brand.Name));


        }

    }
}
