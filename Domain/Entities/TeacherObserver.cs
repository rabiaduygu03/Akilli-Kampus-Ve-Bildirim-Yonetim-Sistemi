using System;
using SmartCampus.Domain.Observer;

namespace SmartCampus.Domain.Entities
{
    public class TeacherObserver : IObserver
    {
        public string Name { get; private set; }

        public TeacherObserver(string name)
        {
            Name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"[Öğretmen Bildirimi] Sayın {Name} Hocam, sistem güncellemesi: {message}");
        }
    }
}