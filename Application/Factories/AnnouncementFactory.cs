using System;
using SmartCampus.Domain.Factory;
using SmartCampus.Domain.Entities;

namespace SmartCampus.Application.Factories
{
    public class AnnouncementFactory
    {
        public static IAnnouncement CreateAnnouncement(string type, string title, string content)
        {
            if (type.ToLower() == "exam")
                return new ExamAnnouncement(title, content);
            else if (type.ToLower() == "event")
                return new EventAnnouncement(title, content);
            else
                throw new ArgumentException("Geçersiz duyuru tipi.");
        }
    }
}