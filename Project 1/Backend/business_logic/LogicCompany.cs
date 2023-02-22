using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entity_layer;
using entity_layer.Entities;
using model;

namespace business_logic
{
    public class LogicCompany : ILogicCompany
    {
        IrepoCompany _irepoCompany;
        public LogicCompany(IrepoCompany irepoCompany)
        {
            _irepoCompany = irepoCompany;
        }

        public Company AddCompany(model.Company_model company)
        {
            return _irepoCompany.AddCompany(Mapper.Company(company));
        }
        public IEnumerable<model.Company_model> GetCompany_Models()
        {
            return Mapper.MapCompany_model(_irepoCompany.GetAll());
        }
        public model.Company_model Remove(int id)
        {
            var mail = (from e in _irepoCompany.GetAll()
                        where e.TrainerId== id
                        select e).FirstOrDefault();
            return Mapper.MapCompany_model(_irepoCompany.Delete(id));
        }
        public model.Company_model Update(int d,model.Company_model company)
        {
            var mail = (from e in _irepoCompany.GetAll()
                         where e.TrainerId== d
                         select e).FirstOrDefault();
            if(mail != null)
            {
                mail.TrainerCompany = company.TrainerCompany;
                mail.Industry= company.Industry;
                mail.StratDate= company.StratDate;
                mail.EndDate= company.EndDate;
                mail = _irepoCompany.Update(mail);
            }
            return Mapper.MapCompany_model(mail);
        }
        public model.Company_model GetCompany(int id)
        {
            return Mapper.MapCompany_model(_irepoCompany.GetCompany(id));
        }
    }
}
