using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entity_layer.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace entity_layer
{
    public class repoCompany : IrepoCompany
    {
        Entities.AssociatesDbContext _context;

        public repoCompany(Entities.AssociatesDbContext context )
        { _context = context; }

        public Company AddCompany(Company company )
        {
            _context.Add( company );
            _context.SaveChanges();
            return company; 
        }
        public Company Update(Company company)
        {
            _context.Update( company );
            _context.SaveChanges();
            return company;
        }
        public Company Delete(int id)
        {
            var item = _context.Companies.Where(i => i.TrainerId== id).FirstOrDefault();
            _context.Companies.Remove(item);
            _context.SaveChanges();
            return item;
        }
        public Company GetCompany(int id)
        {
            var item = _context.Companies.Where(i => i.TrainerId== id).FirstOrDefault();
            return item;
        }
        public List<Company> GetAll()
        {
            return _context.Companies.ToList();
        }
    }
}
