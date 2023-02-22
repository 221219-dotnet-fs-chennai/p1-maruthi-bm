using entity_layer;
using entity_layer.Entities;
using model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_logic
{
    public class Logic : ILogic
    {
        AssociatesDbContext _context;
        Irepo _repo;
        IrepoSkill _irepoSkill;
        public Logic(Irepo repo, IrepoSkill irepoSkill,AssociatesDbContext context)
        {
            _repo = repo;
            _irepoSkill = irepoSkill;
            _context = context;

        }

        public UserDetail AdduserDetail(model.UserDetails_model userDetails)
        {
            return _repo.Add(Mapper.mapUserDetail(userDetails));
        }

        public IEnumerable<model.UserDetails_model> GetUserDetails_Models()
        {
            return Mapper.MapUserDetails_model(_repo.GetAll());
        }
        public model.UserDetails_model UpdateUser(int id, model.UserDetails_model user)
        {
            var mail = (from e in _repo.GetAll()
                        where e.TrainerId == id select e).First();
            if (mail != null)
            {
                mail.Address = user.Address;
                mail.Age = user.Age;
                //mail.TrainerId = id;
                mail.Gender = user.Gender;
                mail.Password = user.Password;
                mail.Location = user.Location;
                mail.Domain = user.Domain;
                mail.Name = user.Name;
                
                mail = _repo.Update(mail);
            }
            return Mapper.MapUserDetails_model(mail);
        }

        public model.UserDetails_model Get(int id)
        {
            return Mapper.MapUserDetails_model(_repo.GetUserDetail(id));
        }
        public model.UserDetails_model Remove(int id)
        {
            var mail = (from e in _repo.GetAll()
                        where e.TrainerId == id 
                        select e).FirstOrDefault();
            return Mapper.MapUserDetails_model(_repo.Delete(id));
        }

        //Logic for Skill table
        public Skill AddSkill(model.Skill_model skills)
        {
            return _irepoSkill.Add(Mapper.Skill(skills));
        }
        public IEnumerable<model.Skill_model> GetSkill_Models()
        {
            return Mapper.MapSkill_model(_irepoSkill.GetAll());
        }
        public model.Skill_model Removes(int id)
        {
            var mail = (from e in _irepoSkill.GetAll()
                        where e.TrainerId == id
                        select e).FirstOrDefault();
            return Mapper.MapSkill_model(_irepoSkill.Delete(id));
        }
        public model.Skill_model Updateuser(int id , model.Skill_model skill)
        {
            var mail = (from e in _irepoSkill.GetAll()
                        where e.TrainerId == id
                        select e).First();
            if(mail!= null)
            {
                mail.Skills1=skill.Skills1;
                mail.Skills2=skill.Skills2;
                mail.Certificate=skill.Certificate;
                mail = _irepoSkill.Update(mail);
            }
            return Mapper.MapSkill_model(mail);
        }
        public model.Skill_model GetSkill(int id)
        {
            return Mapper.MapSkill_model(_irepoSkill.GetSkill(id));
        }

        //login
        public bool CheckUser(int id,string password)
        {
            try
            {
                var mail=_context.UserDetails.Where(i=>i.TrainerId == id).First();
                if(mail.TrainerId == id && mail.Password == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }


    }

}
