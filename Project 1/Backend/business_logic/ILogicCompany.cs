using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using df = entity_layer.Entities;
using Microsoft.EntityFrameworkCore.Infrastructure;


namespace business_logic
{
    public interface ILogicCompany
    {
        public df.Company AddCompany(model.Company_model company);

        IEnumerable<model.Company_model> GetCompany_Models();

        model.Company_model Remove(int id);

        model.Company_model GetCompany(int id);

        model.Company_model Update(int id,model.Company_model company);
    }
}
