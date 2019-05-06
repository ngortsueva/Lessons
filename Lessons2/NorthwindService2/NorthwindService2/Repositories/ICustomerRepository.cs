using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorthwindEntitiesLib;

namespace NorthwindService2.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer> CreateAsync(Customer c);
        Task<IEnumerable<Customer>> RetrieveAllAsync();
        Task<Customer> RetrieveAsync(string id);
        Task<Customer> UpdateAsync(string id, Customer c);
        Task<bool> DeleteAsync(string id);
    }
}
