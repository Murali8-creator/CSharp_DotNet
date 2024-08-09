using CrudOperations.Models;
using CrudOperations.Service.command;
using Microsoft.EntityFrameworkCore;

namespace CrudOperations.Repository
{
    public interface BrandRepository
    {
        public DbSet<Brand> GetAllBrands();

        public int AddBrand(AddBrandCommand command);

        public int DeleteBrand(int id);

        public int updateBrand(Brand brand);

    }
}
