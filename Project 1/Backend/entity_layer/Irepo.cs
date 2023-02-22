using entity_layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_layer
{
    public interface Irepo
    {
        public UserDetail Add(UserDetail user);
        UserDetail GetUserDetail(int t);
        /*public Skill Add(Skill user);
        List<Skill> GetSkill();
        public Contact Add(Contact user);
        List<Contact> GetContact();
        public Company Add(Company user);
        List<Company> GetCompany();
        public Education Add(Education user);
        List<Education> GetEducation();*/
        List<UserDetail> GetAll();
        UserDetail Delete(int t);

        UserDetail Update(UserDetail user);
    }
}
