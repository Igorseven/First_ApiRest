using System.Collections.Generic;

namespace SaveCars.Business.NotificationSettings
{
    public class DomainNotification
    {
        public string Key { get; private set; }
        public string Value { get; private set; }

        public DomainNotification(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }

        public static IEnumerable<DomainNotification> Create(Dictionary<string, string> errors)
        {
            foreach (var error in errors)
                yield return new DomainNotification(error.Key, error.Value);
        }
    }
}
