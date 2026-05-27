using System;
using SmartCampus.Domain.Factory;

namespace SmartCampus.Domain.Entities
{
    public class ExamAnnouncement : IAnnouncement
    {
        public string Title { get; private set; }
        public string Content { get; private set; }

        public ExamAnnouncement(string title, string content)
        {
            Title = title;
            Content = content;
        }

        public void Display()
        {
            Console.WriteLine($"--- SINAV DUYURUSU: {Title} ---\n{Content}");
        }
    }
}