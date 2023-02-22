using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entity_layer.Entities;

namespace entity_layer
{
    public interface IrepoCompany
    {
        public Company AddCompany(Company company);
        public Company Update(Company company);
        public Company Delete(int id);
        public Company GetCompany(int id);

        List<Company> GetAll();


    }
}
