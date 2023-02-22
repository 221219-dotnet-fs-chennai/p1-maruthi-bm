using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entity_layer.Entities;

namespace entity_layer
{
    public interface IrepoSkill
    {
        public Skill Add(Skill skill);
        public Skill GetSkill(int id);

        List<Skill> GetAll();

        public Skill Update(Skill skill);

        public Skill Delete(int id);
    }
}
