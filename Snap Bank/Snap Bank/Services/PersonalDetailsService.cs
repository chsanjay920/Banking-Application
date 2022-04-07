using Snap_Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Snap_Bank.Services
{
    public class PersonalDetailsService : IPersonalDetailsService
    {
        SnapDbContext snapDbContext;

        public PersonalDetailsService()
        {
            snapDbContext = new SnapDbContext();
        }

        public List<PersonalDetails> Get()
        {
            return snapDbContext.personalDetails.ToList();
        }

        public List<PersonalDetails> Post(PersonalDetails personalDetail)
        {
            using (var dbContext = new SnapDbContext())
            {
                dbContext.personalDetails.Add(personalDetail);
                dbContext.SaveChanges();
            }
            return Get();
        }
        public List<PersonalDetails> Delete(int id)
        {
            using (var ent = new SnapDbContext())
            {
                var user = ent.personalDetails.Where(s => s.UserId == id).FirstOrDefault();
                if (user != null)
                {
                    ent.personalDetails.Remove(user);
                    ent.SaveChanges();
                }
                return Get();
            }
        }
        public List<PersonalDetails> Put(PersonalDetails personalDetail)
        {
            using (var ent = new SnapDbContext())
            {
                var temp = ent.personalDetails.Find(personalDetail.UserId);
                if (temp != null)
                {
                    temp.FirstName = personalDetail.FirstName;
                    temp.LastName = personalDetail.LastName;
                    temp.DateOfBirth = personalDetail.DateOfBirth;
                    temp.Gender = personalDetail.Gender;
                    temp.Gmail = personalDetail.Gmail;
                    temp.MobileNumber = personalDetail.MobileNumber;
                }
                ent.SaveChanges();
            }
            return Get();
        }
    }
}