using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSMediatr.Queries.ProductByIdQueryAsync
{
    public class ProductByIdQueryAsync:IRequest<ProductByIdQueryAsyncResult>
    {
        public long Id { get; set; }
    }
}
