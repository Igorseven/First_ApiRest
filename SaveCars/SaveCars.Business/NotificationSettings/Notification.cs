namespace SaveCars.Business.NotificationSettings
{
    public class Notification
    {
        public string Key { get; private set; }
        public string Value { get; private set; }

        public Notification(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}
