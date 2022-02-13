using SaveCars.Business.Interfaces.NotificationHandler;
using SaveCars.Business.Interfaces.ValidationHandler;
using SaveCars.Business.NotificationSettings;
using SaveCars.Domain.Enums;
using SaveCars.Domain.Extention;
using System.Threading.Tasks;

namespace SaveCars.ApplicationService.Services
{
    public abstract class BaseService<TEntity> where TEntity : class
    {
        private readonly INotificationContext _notification;
        private readonly IValidation<TEntity> _validation;

        protected BaseService(INotificationContext notification, IValidation<TEntity> validation)
        {
            this._notification = notification;
            this._validation = validation;
        }

        public async Task<bool> ValidatedAsync(TEntity entity)
        {
            if (this._validation is null)
            {
                this._notification.AddNotification("Invalid", EMessage.ErrorNotConfigured.GetDescription());
            }

            var response = await this._validation.ValidationAsync(entity);

            if (!response.Valid)
            {
                this._notification.AddNotifications(DomainNotification.Create(response.Errors));
            }

            return response.Valid;
        }
    }
}
