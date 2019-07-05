using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSMediatr.Queries.ProductByIdQuery
{
    public class ProductByIdQuery: IRequest<ProductByIdQueryResult>
    {
        public long Id { get; set; }
    }
}
