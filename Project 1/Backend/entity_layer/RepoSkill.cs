using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entity_layer.Entities;

namespace entity_layer
{
    public class RepoSkill : IrepoSkill
    {
        Entities.AssociatesDbContext _context;
        
        public RepoSkill(Entities.AssociatesDbContext context )
        {
            _context = context;
        }
        public Skill Add(Skill skill)
        {
            _context.Add(skill);
            _context.SaveChanges();
            return skill;

        }
        public Skill GetSkill(int id)
        {
            var item = _context.Skills.Where(i => i.TrainerId == id).FirstOrDefault();
            return item;
        }
        public List<Skill> GetAll()
        {
            return _context.Skills.ToList();
        }
        public Skill Delete(int id)
        {
            var item = _context.Skills.Where(i => i.TrainerId==id).FirstOrDefault();
            _context.Skills.Remove(item);
            _context.SaveChanges();
            return item;
        }
        public Skill Update(Skill skill)
        {
            _context.Update(skill);
            _context.SaveChanges();
            return skill;
        }
    }
}
