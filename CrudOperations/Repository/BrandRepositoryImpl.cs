using CrudOperations.Models;
using CrudOperations.Service.command;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CrudOperations.Repository
{
    public class BrandRepositoryImpl : BrandRepository
    {

        private readonly BrandContext _dbContext;

        public BrandRepositoryImpl(BrandContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddBrand(AddBrandCommand command)
        {
            
            _dbContext.Brands.Add(command);

            int res = _dbContext.SaveChanges();

            return res;
        }

        public int DeleteBrand(int id)
        {
            var brand = _dbContext.Brands.Find(id);

            if (brand == null)
            {
                throw new InvalidOperationException("Brand not found.");
            }

            _dbContext.Brands.Remove(brand);
            int res = _dbContext.SaveChanges();
            return res;
        }

        public DbSet<Brand> GetAllBrands()
        {
            return _dbContext.Brands;
        }

        public int updateBrand(Brand brand)
        {
            _dbContext.Entry(brand).State = EntityState.Modified;
            try
            {
                _dbContext.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return 0;
            }
            return 1;
        }
    }
}
