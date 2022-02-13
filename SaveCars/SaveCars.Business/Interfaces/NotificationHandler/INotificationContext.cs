using FluentValidation.Results;
using SaveCars.Business.NotificationSettings;
using System.Collections.Generic;

namespace SaveCars.Business.Interfaces.NotificationHandler
{
    public interface INotificationContext
    {
       List<DomainNotification> GetNotifications();
        bool HasNotification();
        void AddNotification(DomainNotification notification);
        void AddNotification(string key, string value);
        void AddNotifications(IEnumerable<DomainNotification> notifications);
        void AddNotifications(ValidationResult validationResult);
    }
}
