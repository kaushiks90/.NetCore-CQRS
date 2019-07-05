using MediatR;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSMediatr.Commands.ProductsSaveCommand
{
    public class ProductSaveCommandHandler : RequestHandler<ProductSaveCommand>
    {
        protected override void Handle(ProductSaveCommand request)
        {
            Log.Information("ProductSaveCommandHandler.Handle(ProductSaveCommand)");
        }
    }
}
