using df = entity_layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace business_logic
{
    public interface ILogic
    {
        public df.UserDetail AdduserDetail(model.UserDetails_model userDetails);
        IEnumerable<model.UserDetails_model> GetUserDetails_Models();
        model.UserDetails_model Remove(int id);

        model.UserDetails_model Get(int id);
        model.UserDetails_model UpdateUser(int id, model.UserDetails_model user);

        bool CheckUser(int id, string password);


        public df.Skill AddSkill(model.Skill_model Skills);
        IEnumerable<model.Skill_model> GetSkill_Models();
        model.Skill_model Removes(int id);

        model.Skill_model GetSkill(int id);

        model.Skill_model Updateuser(int id, model.Skill_model skill);


    }
}
