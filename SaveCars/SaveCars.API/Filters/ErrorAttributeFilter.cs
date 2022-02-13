using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SaveCars.API.Util;
using SaveCars.Business.Interfaces.NotificationHandler;

namespace SaveCars.API.Filters
{
    public  class ErrorAttributeFilter : ActionFilterAttribute
    {
        private readonly INotificationContext _notification;

        public ErrorAttributeFilter(INotificationContext notification)
        {
            this._notification = notification;
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (!MethodExtention.IsMethodGet(context) && this._notification.HasNotification())
            {
                context.Result = new BadRequestObjectResult(this._notification.GetNotifications());
            }


            base.OnActionExecuted(context);
        }
    }
}
