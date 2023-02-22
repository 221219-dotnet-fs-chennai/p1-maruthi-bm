using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Azure;
using entity_layer.Entities;
using model;
using TrainerData = entity_layer.Entities;
namespace business_logic
{
    public class Mapper
    {
        //model to entity
        public static TrainerData.UserDetail mapUserDetail(UserDetails_model valu)
        {
            return new TrainerData.UserDetail()
            {
                TrainerId = valu.TrainerId,
                Name = valu.Name,
                Address = valu.Address,
                Age = valu.Age,
                Password = valu.Password,
                Gender = valu.Gender,
                Location = valu.Location,
                Domain = valu.Domain,
            };
        }
        public  static TrainerData.Skill Skill(Skill_model vals) 
        {
            return new TrainerData.Skill()
            {
                TrainerId = vals.TrainerId,
                SkillsId = vals.SkillsId,
                Skills1 = vals.Skills1,
                Skills2 = vals.Skills2,
                Certificate = vals.Certificate,
            };
        }
        public static TrainerData.Education Education(Education_model vale)
        {
            return new TrainerData.Education()
            {
                TrainerId = vale.TrainerId,
                EducationId = vale.EducationId,
                Degree = vale.Degree,
                InstituteName = vale.InstituteName,
                StartDate = vale.StartDate,
                EndDate = vale.EndDate,
                Grade = vale.Grade,
                Cgpa = vale.Cgpa
            };
        }
        public static  TrainerData.Contact Contact(Contact_model valc) 
        {
            return new TrainerData.Contact()
            {
                TrainerId = valc.TrainerId,
                ContactId = valc.ContactId,
                Email = valc.Email,
                Website = valc.Website,
                PhoneNo = valc.PhoneNo,
                SocialMedia = valc.SocialMedia
            };
        }
        public  static TrainerData.Company Company(Company_model valco)
        {
            return new TrainerData.Company()
            {
                TrainerId = valco.TrainerId,
                CompanyId = valco.CompanyId,
                TrainerCompany = valco.TrainerCompany,
                Industry = valco.Industry,
                StratDate = valco.StratDate,
                EndDate = valco.EndDate
            };
        }

       // entity to model
        public static UserDetails_model MapUserDetails_model(TrainerData.UserDetail valmu)
        {
            return new model.UserDetails_model()
            {
                TrainerId = valmu.TrainerId,
                Name = valmu.Name,
                Address = valmu.Address,
                Age = valmu.Age,
                Password = valmu.Password,
                Gender = valmu.Gender,
                Location = valmu.Location,
                Domain = valmu.Domain,
            };
        }

        public static IEnumerable<UserDetails_model> MapUserDetails_model(IEnumerable<UserDetail> userDetails)
        {
            return userDetails.Select(MapUserDetails_model);
            //throw new NotImplementedException();
        }


        public static Skill_model MapSkill_model(TrainerData.Skill valms)
        {
            return new model.Skill_model()
            {
                TrainerId = valms.TrainerId,
                SkillsId = valms.SkillsId,
                Skills1 = valms.Skills1,
                Skills2 = valms.Skills2,
                Certificate = valms.Certificate,
            };
        }

        public static IEnumerable<Skill_model> MapSkill_model(IEnumerable<Skill> Skill)
        {
            return Skill.Select(MapSkill_model);
            //throw new NotImplementedException();
        }
        public  static Education_model MapEducation_model(TrainerData.Education valme)
        {
            return new model.Education_model()
            {
                TrainerId = valme.TrainerId,
                EducationId = valme.EducationId,
                Degree = valme.Degree,
                InstituteName = valme.InstituteName,
                StartDate = valme.StartDate,
                EndDate = valme.EndDate,
                Grade = valme.Grade,
                Cgpa = valme.Cgpa
            };
        }
        public static IEnumerable<Education_model> MapEducation_model(IEnumerable<Education> education)
        {
            return education.Select(MapEducation_model);
            //throw new NotImplementedException();
        }

        public static Contact_model MapContact_model(TrainerData.Contact valmc)
        {
            return new model.Contact_model()
            {
                TrainerId = valmc.TrainerId,
                ContactId = valmc.ContactId,
                Email = valmc.Email,
                Website = valmc.Website,
                PhoneNo = valmc.PhoneNo,
                SocialMedia = valmc.SocialMedia
            };
        }
        public static Company_model MapCompany_model(TrainerData.Company valmco)
        {
            return new model.Company_model()
            {
                TrainerId = valmco.TrainerId,
                CompanyId = valmco.CompanyId,
                TrainerCompany = valmco.TrainerCompany,
                Industry = valmco.Industry,
                StratDate = valmco.StratDate,
                EndDate = valmco.EndDate
            };
        }
        public static IEnumerable<Company_model> MapCompany_model(IEnumerable<Company> company)
        {
            return company.Select(MapCompany_model);
            //throw new NotImplementedException();
        }


    }
    
      
    
}
