using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entity_layer.Entities;


namespace entity_layer
{
    public interface IrepoEducation
    {
        public Education AddEducation(Education education);
        public Education Update(Education education) ;
        public Education Delete(int id);
        public Education GetEducation(int id);
        List<Education> GetAll();
    }
}
