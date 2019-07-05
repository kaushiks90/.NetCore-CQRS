using MediatR;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSMediatr.Notification.ProductSavedNotification
{
    public class ProductSavedNotificationSecondHandler : NotificationHandler<ProductSavedNotification>
    {
        protected override void Handle(ProductSavedNotification notification)
        {
            Log.Information("ProductSavedNotificationFirstHandler.Handle(ProductSavedNotification)");
        }
    }
}
