using Infrastructure.Data;
using LegendaryInvention.Entities;
using LegendaryInvention.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Respositories
{
    public class CustomerRepositoryAsync : GenericRepositoryAsync<Customer>, ICustomerRepositoryAsync
    {
        private readonly DbSet<Customer> _customer;

        public CustomerRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _customer = dbContext.Set<Customer>();
        }
    }
}
