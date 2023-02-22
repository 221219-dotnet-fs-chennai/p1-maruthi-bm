using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entity_layer.Entities;

namespace entity_layer
{
    public class repoEducation : IrepoEducation
    {
        Entities.AssociatesDbContext _context;
        public repoEducation(AssociatesDbContext context)
        {
            _context = context;
        }
        public Education AddEducation(Education education)
        {
            _context.Add(education);
            _context.SaveChanges();
            return education;

        }
        public Education Update(Education education)
        {
            _context.Update(education);
            _context.SaveChanges();
            return education;
        }
        public Education Delete(int id )
        {
            var item = _context.Educations.Where(i => i.TrainerId == id).FirstOrDefault();
            _context.Educations.Remove(item);
            _context.SaveChanges();
            return item;
        }
        public Education GetEducation(int id)
        {
            var item = _context.Educations.Where(i => i.TrainerId == id).FirstOrDefault();
            return item;
        }
        public List<Education> GetAll()
        {
            return _context.Educations.ToList();
        }
    }
}
