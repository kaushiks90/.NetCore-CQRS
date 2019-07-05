using CQRSMediatr;
using CQRSMediatr.Commands.ProductsSaveCommand;
using CQRSMediatr.Commands.ProductsSaveCommandAsync;
using CQRSMediatr.Notification.ProductSavedNotification;
using CQRSMediatr.Notification.ProductSavedNotificationAsync;
using CQRSMediatr.Queries.ProductByIdQuery;
using CQRSMediatr.Queries.ProductByIdQueryAsync;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediatR.Tests
{
    [TestClass]
    public class Tests
    {
        private readonly IMediator _mediator;

        public Tests()
        {
            var services = new ServiceCollection();

            //services.AddMediatR
            //(
            //    typeof(ProductSaveCommandHandler),
            //    typeof(ProductByIdQueryHandler),
            //    typeof(ProductSavedNotification)
            //);
            services.AddMediatR(typeof(Startup));
            _mediator = services.BuildServiceProvider().GetService<IMediator>();
        }

        [TestMethod]
        public void ProductByIdQuery()
        {
            var result = _mediator.Send(new ProductByIdQuery { Id = 1 });
            Assert.IsTrue(result.Result.Id == 1);
        }

        [TestMethod]
        public void ProductByIdQueryAsync()
        {
            var result = _mediator.Send(new ProductByIdQueryAsync { Id = 1 });
            Assert.IsTrue(result.Result.Id == 1);
        }

        [TestMethod]
        public void ProductSaveCommand()
        {
            _mediator.Send(new ProductSaveCommand { Id = 1, Description = "Description 1" });
        }

        [TestMethod]
        public void ProductSaveCommandAsync()
        {
            _mediator.Send(new ProductSaveCommandAsync { Id = 1, Description = "Description 1" });
        }

        [TestMethod]
        public void ProductSavedNotification()
        {
            _mediator.Publish(new ProductSavedNotification());
        }

        [TestMethod]
        public void ProductSavedNotificationAsync()
        {
            _mediator.Publish(new ProductSavedNotificationAsync());
        }
    }
}
