using MediatR;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSMediatr.Commands.ProductsSaveCommandAsync
{
    public class ProductSaveCommandAsyncHandler : RequestHandler<ProductSaveCommandAsync>
    {
        protected override void Handle(ProductSaveCommandAsync request)
        {
          Log.Information("ProductSaveCommandAsyncHandler.Handle(ProductSaveCommandAsyncHandler)");
        }
    }
}
