using SaveCars.Domain.Enums;
using System.ComponentModel;

namespace SaveCars.Domain.Extention
{
    public static class MessageExtention
    {
        public static string GetDescription(this EMessage message)
        {
            var type = message.GetType();
            var memberInfo = type.GetMember(message.ToString());
            var attributes = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

            return ((DescriptionAttribute)attributes[0]).Description;
        }
    }
}
