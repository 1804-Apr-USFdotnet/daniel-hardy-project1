using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IResturantRepository : IDisposable
    {
        IEnumerable<DataLayer.Resturant> GetResturants();
        DataLayer.Resturant GetResturantID(int id);
        void AddResturant(DataLayer.Resturant resturant);
        void DeleteResturant(DataLayer.Resturant resturant);
        void UpdateResturant(DataLayer.Resturant resturant);
        void SaveChanges();
    }
}
