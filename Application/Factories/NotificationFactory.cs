using System;
using SmartCampus.Domain.Factory;
using SmartCampus.Domain.Entities;

namespace SmartCampus.Application.Factories
{
    public class NotificationFactory
    {
        public static INotification CreateNotification(string type)
        {
            if (type.ToLower() == "email")
                return new EmailNotification();
            else if (type.ToLower() == "sms")
                return new SMSNotification();
            else
                throw new ArgumentException("Geçersiz bildirim tipi.");
        }
    }
}