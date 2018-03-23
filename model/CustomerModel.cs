using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST01_WPFMVVM.model
{
    public class CustomerModel : BaseModel
    {
        public CustomerModel(String customerName)
        {
            Name = customerName;
        }

        public CustomerModel()
        {
            
        }

        public int Id { get; set; }


        private string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged();
            }
        }

    }
}
