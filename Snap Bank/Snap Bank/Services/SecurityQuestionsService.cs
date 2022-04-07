using Snap_Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Snap_Bank.Services
{
    public class SecurityQuestionsService : ISecurityQuestionsService
    {
        SnapDbContext snapDbContext;

        public SecurityQuestionsService()
        {
            snapDbContext = new SnapDbContext();
        }

        public List<SecurityQuestions> Get()
        {
            return snapDbContext.securityQuestions.ToList();
        }

        public List<SecurityQuestions> Post(SecurityQuestions securityQuestion)
        {
            using (var dbContext = new SnapDbContext())
            {
                dbContext.securityQuestions.Add(securityQuestion);
                dbContext.SaveChanges();
            }
            return Get();
        }
        public List<SecurityQuestions> Delete(int id)
        {
            using (var ent = new SnapDbContext())
            {
                var user = ent.securityQuestions.Where(s => s.UserId == id).FirstOrDefault();
                if (user != null)
                {
                    ent.securityQuestions.Remove(user);
                    ent.SaveChanges();
                }
                return Get();
            }
        }
        public List<SecurityQuestions> Put(SecurityQuestions securityQuestion)
        {
            using (var ent = new SnapDbContext())
            {
                var temp = ent.securityQuestions.Find(securityQuestion.UserId);
                if (temp != null)
                {
                    temp.BirthPlace = securityQuestion.BirthPlace;
                    temp.PetName = securityQuestion.PetName;
                    temp.FavouriteFood = securityQuestion.FavouriteFood;
                }
                ent.SaveChanges();
            }
            return Get();
        }
    }
}