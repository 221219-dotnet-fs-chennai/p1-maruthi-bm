using entity_layer.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_layer
{
    public class erepo : Irepo
    {
        Entities.AssociatesDbContext _context;

        public erepo(Entities.AssociatesDbContext context )
        {
            _context = context;
        }
        //userdetails
        public UserDetail Add(UserDetail user)
        {
            _context.Add(user);
            _context.SaveChanges();
            return user;
        }

        public UserDetail GetUserDetail(int id)
        {
            var item = _context.UserDetails.Where(i => i.TrainerId== id).First();
            return item;
        }
        //skill
        /*public Skill Add(Skill skill)
        {
            _context.Add(skill);
            _context.SaveChanges();
            return skill;
        }
        public List<Skill> GetSkill()
        {
            return _context.Skills.ToList();
        }
        //Education
        public Education Add(Education education)
        {
            _context.Add(education);
            _context.SaveChanges();
            return education;
        }
        public List<Education> GetEducation()
        {
            return _context.Educations.ToList();
        }
        //contact
        public Contact Add(Contact contact)
        {
            _context.Add(contact);
            _context.SaveChanges();
            return contact;
        }
        public List<Contact> GetContact()
        {
            return _context.Contacts.ToList();
        }
        //Company
        public Company Add(Company company) 
        {
            _context.Add(company);
            _context.SaveChanges();
            return company;
        }
        public List<Company> GetCompany()
        {
            return _context.Companies.ToList();
        }*/
        public List<UserDetail> GetAll()
        {
            return _context.UserDetails.ToList();
        }
        public UserDetail Delete(int id)
        {
            var mail = _context.UserDetails.Where(i => i.TrainerId == id).First();
            _context.UserDetails.Remove(mail);
            _context.SaveChanges();
            return mail;
        }

        public UserDetail Update(UserDetail user)
        {
            _context.Update(user);
            _context.SaveChanges();
            return user;
        }

    }
}
