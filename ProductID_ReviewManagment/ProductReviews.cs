using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductID_ReviewManagment
{
    public class ProductReviews
    {
        public int productId { get; set; }
        public int userId { get; set; }
        public float rating { get; set; }
        public string review { get; set; }
        public bool isLike { get; set; }
    }
}
