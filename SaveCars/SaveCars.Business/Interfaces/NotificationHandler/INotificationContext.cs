using FluentValidation.Results;
using SaveCars.Business.NotificationSettings;
using System.Collections.Generic;

namespace SaveCars.Business.Interfaces.NotificationHandler
{
    public interface INotificationContext
    {
        Dictionary<string, string> GetNotifications();
        bool HasNotification();
        void AddNotification(Notification notification);
        void AddNotification(string key, string value);
        void AddNotifications(IList<Notification> notifications);
        void AddNotifications(ValidationResult validationResult);
    }
}
