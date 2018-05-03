using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DataManager
    {
        public IEnumerable<Resturant> GetResturants()
        {
            IEnumerable<Resturant> result;

            using (var dbcontext = new ResturantDBEntities())
            {
                int i = 0;
                var entities = dbcontext.Resturants.ToList();
                foreach (var ent in dbcontext.Resturants)
                {
                    entities[i].Reviews = ent.Reviews.ToList();
                    i++;
                }
                result = entities.ToList();
            }
            return result.ToList();

        }

        public void addResturant(Resturant model)
        {
            using (var dbcontext = new ResturantDBEntities())
            {
                //dbcontext.Resturants.Add(model);
                //dbcontext.SaveChanges();
            }
        }

        public void updateResturant(Resturant model)
        {
            using (var dbcontext = new ResturantDBEntities())
            {
                foreach (var res in dbcontext.Resturants)
                {
                    if(res.rs_id == model.rs_id)
                    {
                        res.Name = model.Name;
                        res.Address = model.Address;
                        res.City = model.City;
                        res.State = model.State;
                        res.FoodType = model.FoodType;
                    }
                }
                dbcontext.SaveChanges();
            }
        }

        public void deleteResturant(Resturant model)
        {
            using (var dbcontext = new ResturantDBEntities())
            {
                dbcontext.Resturants.Remove(model);
                dbcontext.SaveChanges();
            }
        }

        //Mapping


    }
}
