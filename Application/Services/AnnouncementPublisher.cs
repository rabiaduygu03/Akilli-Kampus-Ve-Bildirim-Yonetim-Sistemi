using System;
using System.Collections.Generic;
using SmartCampus.Domain.Observer;
using SmartCampus.Domain.Factory;
using SmartCampus.Application.Common;

namespace SmartCampus.Application.Services
{
    public class AnnouncementPublisher : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private Logger _logger = Logger.GetInstance();

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
            _logger.LogInfo("Sisteme yeni bir kullanıcı abonesi eklendi.");
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
            _logger.LogInfo("Bir kullanıcı abonesi sistemden çıkarıldı.");
        }

        public void NotifyObservers(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }

        public void PublishAnnouncement(IAnnouncement announcement, INotification notificationChannel)
        {
            _logger.LogInfo($"Yeni kampüs duyurusu işleniyor: {announcement.Title}");
            
            announcement.Display();

            string message = $"{announcement.Title} hakkında yeni bir bilgilendirme yayınlandı.";
            notificationChannel.Send(message);

            NotifyObservers(announcement.Title);
        }
    }
}