using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestAPI.Models;
using TestAPI.DAL;

namespace TestAPI.Models
{
    public class UserFunctions
    {
        public static TestDBEntities db = new TestDBEntities();
        public static bool CheckUnitDuplicate(string name)
        {
            bool worked = false;            
            var units = db.Units.Where(m => m.UnitName == name).FirstOrDefault();
            if (units == null)
            {
                worked = true;
            }
            return worked;
        }

        public static bool InsertUnit(string name)
        {
            bool worked = false;
            try
            {
                using (TestDBEntities db = new TestDBEntities())
                {
                    DAL.Unit entity = new DAL.Unit
                    {
                        UnitName = name,
                        DateCreated = DateTime.UtcNow,
                        UserCreated = "Test User"
                    };
                    db.Units.Add(entity);
                    db.SaveChanges();
                    worked = true;
                }
            }
            catch (Exception)
            {

            }
            return worked;
        }

        public static bool UpdateUnit(int id, string name)
        {
            bool worked = false;
            try
            {
                var entity = db.Units.Find(id);
                entity.UnitName = name;
                entity.ModifiedBy = "Test User2";
                entity.DateModified = DateTime.UtcNow;
                db.SaveChanges();

                worked = true;
            }
            catch (Exception)
            {

            }
            return worked;
        }

    }
}