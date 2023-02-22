using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;
using entity_layer.Entities;
using entity_layer;

namespace business_logic
{
    public class LogicEducation : ILogicEducation
    {
        IrepoEducation _irepoEducation;
        public LogicEducation(IrepoEducation irepoEducation)
        {
            _irepoEducation = irepoEducation;
        }
        public Education AddEducation(model.Education_model education)
        {
            return _irepoEducation.AddEducation(Mapper.Education(education));
        }
        public IEnumerable<model.Education_model> GetEducation_Models()
        {
            return Mapper.MapEducation_model(_irepoEducation.GetAll());
        }
        public model.Education_model Remove(int id)
        {
            var mail = (from e in _irepoEducation.GetAll()
                        where e.TrainerId== id  
                        select e).FirstOrDefault();
            return Mapper.MapEducation_model(_irepoEducation.Delete(id));
        }
        public model.Education_model Update(int id,model.Education_model education)
        {
            var mail = (from e in _irepoEducation.GetAll()
                        where e.TrainerId== id
                        select e).FirstOrDefault();
            if (mail != null)
            {
                mail.InstituteName= education.InstituteName;
                mail.StartDate= education.StartDate;
                mail.EndDate= education.EndDate;
                mail.Degree= education.Degree;
                mail.Cgpa= education.Cgpa;
                mail.Degree=education.Degree;
                mail = _irepoEducation.Update(mail);

            }
            return Mapper.MapEducation_model(mail);
        }
        public model.Education_model GetEducation(int id)
        {
            return Mapper.MapEducation_model(_irepoEducation.GetEducation(id));
        }

    }
}
