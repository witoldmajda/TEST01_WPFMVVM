using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEST01_WPFMVVM.model;

namespace TEST01_WPFMVVM.interfaces
{
    public interface ICustomersService
    {
        void Add(CustomerModel customer);

        void Update(CustomerModel customer);

        void Remove(int id);

        ICollection<CustomerModel> Get();

        CustomerModel Get(int id);

        CustomerModel Get(string name);
    }
}
