using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{
    
    public class BusinessLibrary
    {
        
        DataLayer.DataManager data;

        public BusinessLibrary()
        {
            data = new DataLayer.DataManager();
        }

        public void addResturant(Models.Resturant modelRes)
        {
            DataLayer.Resturant dataRes = ModelToData(modelRes);
            data.addResturant(dataRes);
            
        }

        public void deleteResturant(Models.Resturant modelRes)
        {
            DataLayer.Resturant dataRes = ModelToData(modelRes);
            data.deleteResturant(dataRes);

        }

        public void updateResturant(Models.Resturant modelRes)
        {
            DataLayer.Resturant dataRes = ModelToData(modelRes);
            data.updateResturant(dataRes);
        }
        public List<Models.Resturant> getAllResturants()
        {
            List<DataLayer.Resturant> res = data.GetResturants().ToList();
            List<Models.Resturant> results = res.Select(x => DataToModel(x)).ToList();
            return results;
        }

        public List<Models.Resturant> getTopResturants()
        {
            List<DataLayer.Resturant> tmp = data.GetResturants().ToList();
            List<Models.Resturant> results = tmp.Select(x => DataToModel(x)).ToList();
            List<Models.Resturant> res = results.OrderByDescending(x => x.getAverageRating()).Take(3).ToList();
            return res;
        }

        public List<Models.Resturant> getResturantsbyState()
        {
            List<DataLayer.Resturant> tmp = data.GetResturants().ToList();
            List<DataLayer.Resturant> res = tmp.OrderBy(x => x.State).ToList();
            List<Models.Resturant> results = res.Select(x => DataToModel(x)).ToList();
            return results;
        }

        public List<Models.Resturant> SearchRestutants(string partial)
        {
            List<DataLayer.Resturant> tmp = data.GetResturants().ToList();
            List<DataLayer.Resturant> res = tmp.Where(x => x.Name.Contains(partial)).ToList();
            List<Models.Resturant> results = res.Select(x => DataToModel(x)).ToList();
            return results;
        }

        public Models.Resturant GetResturantByID(int id)
        {
            List<DataLayer.Resturant> tmp = data.GetResturants().ToList();
            List<DataLayer.Resturant> res = tmp.Where(x => x.rs_id == id).ToList();
            DataLayer.Resturant dataRes = res.FirstOrDefault();
            return DataToModel(dataRes);
        }
        public List<Models.Resturant> getResturantsbyName()
        {
            List<DataLayer.Resturant> tmp = data.GetResturants().ToList();
            List<DataLayer.Resturant> res = tmp.OrderBy(x => x.Name).ToList();
            List<Models.Resturant> results = res.Select(x => DataToModel(x)).ToList();
            return results;
        }

        public static DataLayer.Resturant ModelToData(Models.Resturant model)
        {
            DataLayer.Resturant r = new DataLayer.Resturant();
            r.rs_id = model.rs_id;
            r.Name = model.Name;
            r.Address = model.Address;
            r.City = model.City;
            r.State = model.State;
            r.FoodType = model.FoodType;
            foreach (var rev in model.Reviews)
            {
                var tmp = new DataLayer.Review
                {
                    Author = rev.Author,
                    Rating = rev.Rating,
                    Comment = rev.Comment
                };
                r.Reviews.Add(tmp);
            }

            return r;
        }

        public static Models.Resturant DataToModel(DataLayer.Resturant data)
        {
            Models.Resturant r = new Models.Resturant();
            r.rs_id = data.rs_id;
            r.Name = data.Name;
            r.Address = data.Address;
            r.City = data.City;
            r.State = data.State;
            r.FoodType = data.FoodType;
            r.Reviews = new List<Models.Review>();
            foreach (var rev in data.Reviews)
            {
                var tmp = new Models.Review
                {
                    Author = rev.Author,
                    Rating = rev.Rating,
                    Comment = rev.Comment
                };
                r.Reviews.Add(tmp);
            }

            return r;
        }
    }
}
