using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSMediatr.Commands.ProductsSaveCommandAsync
{
    public class ProductSaveCommandAsync:IRequest
    {
        public long Id { get; set; }

        public string Description { get; set; }
    }
}
