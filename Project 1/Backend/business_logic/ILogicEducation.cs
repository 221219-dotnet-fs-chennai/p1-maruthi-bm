using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using df = entity_layer.Entities;

namespace business_logic
{
    public interface ILogicEducation
    {
        public df.Education AddEducation(model.Education_model education);
        IEnumerable<model.Education_model> GetEducation_Models();

        model.Education_model Remove(int id);
        model.Education_model GetEducation(int id);
        model.Education_model Update(int id, model.Education_model education);

    }
}
