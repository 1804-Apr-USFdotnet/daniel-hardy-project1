using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IReviewRepository : IDisposable
    {
        IEnumerable<DataLayer.Review> GetReviews();
        DataLayer.Review GetReviewID(int id);
        void AddReview(DataLayer.Review review);
        void DeleteReview(DataLayer.Review review);
        void UpdateReview(DataLayer.Review review);
        void SaveChanges();
    }
}
