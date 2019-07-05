using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSMediatr.Commands.ProductsSaveCommand
{
    public class ProductSaveCommand:IRequest
    {
        public long Id { get; set; }
        public string Description { get; set; }
    }
}
