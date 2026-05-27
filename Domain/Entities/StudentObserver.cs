using System;
using SmartCampus.Domain.Observer;

namespace SmartCampus.Domain.Entities
{
    public class StudentObserver : IObserver
    {
        public string Name { get; private set; }

        public StudentObserver(string name)
        {
            Name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"[Öğrenci Bildirimi] Sayın {Name}, yeni bir duyuru var: {message}");
        }
    }
}