using Microsoft.AspNetCore.Mvc.Filters;
using SaveCars.API.Util;
using SaveCars.Business.Interfaces.Context;
using SaveCars.Business.Interfaces.NotificationHandler;

namespace SaveCars.API.Filters
{
    public class UnitOfWorkFilter : ActionFilterAttribute
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly INotificationContext _notification;

        public UnitOfWorkFilter(IUnitOfWork unitOfWork, INotificationContext notification)
        {
            this._unitOfWork = unitOfWork;
            this._notification = notification;
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (MethodExtention.IsMethodGet(context))
            {
                return;
            }

            if (this._notification.HasNotification() == false && context.ModelState.IsValid)
            {
                this._unitOfWork.Commit();
            }
            else
            {
                this._unitOfWork.RollBack();
            }
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (MethodExtention.IsMethodGet(context))
            {
                return;
            }

            this._unitOfWork.BeginTransaction();
        }
    }
}
