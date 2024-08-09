using CrudOperations.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperationsTestProject
{
    public class TestBase
    {
        private BrandContext _brandContext;

        public BrandContext TestDbContext
        {
            get
            {
                var builder = new DbContextOptionsBuilder<BrandContext>()
                    .UseSqlServer("Data Source=DESKTOP-TDK64FE;Persist Security Info=False;Database=brandDB;Trusted_Connection=True;TrustServerCertificate=True;Connection Timeout=600;");


                _brandContext = new BrandContext(builder.Options);
                return _brandContext;
            }
        }
    }
}
