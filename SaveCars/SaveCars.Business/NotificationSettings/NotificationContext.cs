using FluentValidation.Results;
using SaveCars.Business.Interfaces.NotificationHandler;
using System.Collections.Generic;
using System.Linq;

namespace SaveCars.Business.NotificationSettings
{
    public class NotificationContext : INotificationContext
    {
        private List<DomainNotification> _notifications;

        public NotificationContext()
        {
            this._notifications = new List<DomainNotification>();
        }



        List<DomainNotification> INotificationContext.GetNotifications() => this._notifications;

        public bool HasNotification() => this._notifications.Any();


        public void AddNotification(DomainNotification notification)
        {
            this._notifications.Add(notification);
        }

        public void AddNotification(string key, string value)
        {
            this._notifications.Add(new DomainNotification(key, value));
        }

        public void AddNotifications(IEnumerable<DomainNotification> notifications)
        {
            this._notifications.AddRange(notifications);
        }

        public void AddNotifications(ValidationResult validationResult)
        {
            foreach(var error in validationResult.Errors)
            {
                this._notifications.Add(new DomainNotification(error.ErrorCode, error.ErrorMessage));
            }
        }

        
    }
}
