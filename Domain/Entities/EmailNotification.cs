using System;
using SmartCampus.Domain.Factory;

namespace SmartCampus.Domain.Entities
{
    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"[E-Posta Kanalı] {message}");
        }
    }
}