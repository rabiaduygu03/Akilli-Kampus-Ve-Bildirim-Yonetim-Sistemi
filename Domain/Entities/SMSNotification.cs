using System;
using SmartCampus.Domain.Factory;

namespace SmartCampus.Domain.Entities
{
    public class SMSNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"[SMS Kanalı] {message}");
        }
    }
}