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

        public IEnumerable<SecurityQuestions> Get()
        {
            return snapDbContext.securityQuestions.ToList();
        }

        public bool Post(SecurityQuestions securityQuestion)
        {
            using (var dbContext = new SnapDbContext())
            {
                dbContext.securityQuestions.Add(securityQuestion);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            using (var ent = new SnapDbContext())
            {
                var user = ent.securityQuestions.Where(s => s.UserId == id).FirstOrDefault();
                if (user != null)
                {
                    ent.securityQuestions.Remove(user);
                    ent.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        public bool Put(SecurityQuestions securityQuestion)
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
                return true;
            }
            return false;
        }
    }
}