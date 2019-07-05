using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRSMediatr.Commands.ProductsSaveCommand;
using CQRSMediatr.Commands.ProductsSaveCommandAsync;
using CQRSMediatr.Notification.ProductSavedNotification;
using CQRSMediatr.Notification.ProductSavedNotificationAsync;
using CQRSMediatr.Queries.ProductByIdQuery;
using CQRSMediatr.Queries.ProductByIdQueryAsync;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSMediatr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ValuesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("productbyidquery")]
        public async Task<ProductByIdQueryResult> ProductByIdQuery()
        {
            var query = new ProductByIdQuery { Id = 1 };
            var plastico = await _mediator.Send(query);

            return plastico;
        }

        [HttpGet("productbyidqueryasync")]
        public async Task<ProductByIdQueryAsyncResult> ProductByIdQueryAsync()
        {
            var query = new ProductByIdQueryAsync { Id = 1 };
            var plastico = await _mediator.Send(query);

            return plastico;
        }
        [HttpPost("ProductSaveCommand")]
        public void ProductSaveCommand()
        {
            _mediator.Send(new ProductSaveCommand { Id = 1, Description = "Description 1" });
        }

        [HttpPost("ProductSaveCommandAsync")]
        public void ProductSaveCommandAsync()
        {
            _mediator.Send(new ProductSaveCommandAsync { Id = 1, Description = "Description 1" });
        }

        [HttpPost("ProductSavedNotification")]
        public void ProductSavedNotification()
        {
            _mediator.Publish(new ProductSavedNotification());
        }

        [HttpPost("ProductSavedNotificationAsync")]
        public void ProductSavedNotificationAsync()
        {
            _mediator.Publish(new ProductSavedNotificationAsync());
        }

    }
}
