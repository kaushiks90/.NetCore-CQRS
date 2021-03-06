﻿using MediatR;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSMediatr.Notification.ProductSavedNotificationAsync
{
    public class ProductSavedNotificationAsyncFirstHandler : INotificationHandler<ProductSavedNotificationAsync>
    {
        public Task Handle(ProductSavedNotificationAsync notification, CancellationToken cancellationToken)
        {
            return Task.Run(() => Log.Information("ProductSavedNotificationAsyncFirstHandler.Handle(ProductSavedNotificationAsync)"));
        }
    }
}
