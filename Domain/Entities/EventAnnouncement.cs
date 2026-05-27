using System;
using SmartCampus.Domain.Factory;

namespace SmartCampus.Domain.Entities
{
    public class EventAnnouncement : IAnnouncement
    {
        public string Title { get; private set; }
        public string Content { get; private set; }

        public EventAnnouncement(string title, string content)
        {
            Title = title;
            Content = content;
        }

        public void Display()
        {
            Console.WriteLine($"--- ETKİNLİK DUYURUSU: {Title} ---\n{Content}");
        }
    }
}