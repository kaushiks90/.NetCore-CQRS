using MediatR;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSMediatr.Queries.ProductByIdQuery
{
    public class ProductByIdQueryHandler : RequestHandler<ProductByIdQuery, ProductByIdQueryResult>
    {
        protected override ProductByIdQueryResult Handle(ProductByIdQuery request)
        {
            Log.Information("ProductByIdQueryHandler.Handle(ProductByIdQuery)");
            var res=  new ProductByIdQueryResult { Id = request.Id, Description = $"Description {request.Id}" };

            return  res;
        }
    }
}
