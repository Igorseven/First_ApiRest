using FluentValidation.Results;
using SaveCars.Business.Interfaces.NotificationHandler;
using System.Collections.Generic;
using System.Linq;

namespace SaveCars.Business.NotificationSettings
{
    public class NotificationContext : INotificationContext
    {
        private Dictionary<string, string> _notifications;

        public NotificationContext()
        {
            this._notifications = new Dictionary<string, string>();
        }

        public Dictionary<string, string> GetNotifications() => this._notifications;

        public bool HasNotification() => this._notifications.Any();


        public void AddNotification(Notification notification)
        {
            this._notifications.Add(notification.Key, notification.Value);
        }

        public void AddNotification(string key, string value)
        {
            this._notifications.Add(key, value);
        }

        public void AddNotifications(IList<Notification> notifications)
        {
            foreach(var error in notifications)
            {
                this._notifications.Add(error.Key, error.Value);
            }
        }

        public void AddNotifications(ValidationResult validationResult)
        {
            foreach(var error in validationResult.Errors)
            {
                this._notifications.Add(error.ErrorCode, error.ErrorMessage);
            }
        }
    }
}
