using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSMediatr.Queries.ProductByIdQuery
{
    public class ProductByIdQueryResult
    {
        public long Id { get; set; }

        public string Description { get; set; }
    }
}
