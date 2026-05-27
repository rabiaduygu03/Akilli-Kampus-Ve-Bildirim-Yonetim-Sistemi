using System;
using SmartCampus.Domain.Entities;
using SmartCampus.Domain.Factory;
using SmartCampus.Domain.Observer;
using SmartCampus.Application.Factories;
using SmartCampus.Application.Services;
using SmartCampus.Application.Common;

namespace SmartCampus.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Singleton Logger Testi
            Logger logger = Logger.GetInstance();
            logger.LogInfo("Akıllı Kampüs Sistemi başlatıldı.");

            // 2. Observer - Yayıncı (Publisher) Nesnesi
            AnnouncementPublisher publisher = new AnnouncementPublisher();

            // 3. Observer - Abonelerin (Öğrenci ve Öğretmen) Sisteme Eklenmesi
            IObserver ogrenci1 = new StudentObserver("Ahmet Yılmaz");
            IObserver ogrenci2 = new StudentObserver("Ayşe Demir");
            IObserver ogretmen1 = new TeacherObserver("Deniz Kılınç");

            publisher.RegisterObserver(ogrenci1);
            publisher.RegisterObserver(ogrenci2);
            publisher.RegisterObserver(ogretmen1);

            Console.WriteLine("\n--- 1. SENARYO: SINAV DUYURUSU VE SMS BİLDİRİMİ ---");
            
            // 4. Factory Tasarımı ile Nesne Üretimi
            IAnnouncement sinavDuyurusu = AnnouncementFactory.CreateAnnouncement("exam", "Yazılım Mimarisi Final Sınavı", "Final sınavı 2 Haziran Salı günü saat 10:00'da yapılacaktır.");
            INotification smsKanali = NotificationFactory.CreateNotification("sms");

            // 5. Olayın Tetiklenmesi
            publisher.PublishAnnouncement(sinavDuyurusu, smsKanali);

            Console.WriteLine("\n--- 2. SENARYO: ETKİNLİK DUYURUSU VE E-POSTA BİLDİRİMİ ---");
            
            // Farklı nesnelerle sistemin esnekliğini test ediyoruz
            IAnnouncement etkinlikDuyurusu = AnnouncementFactory.CreateAnnouncement("event", "Teknoloji Günleri Zirvesi", "Kampüs kültür merkezinde siber güvenlik paneli düzenlenecektir.");
            INotification epostaKanali = NotificationFactory.CreateNotification("email");

            publisher.PublishAnnouncement(etkinlikDuyurusu, epostaKanali);

            Console.WriteLine("\n[SİSTEM] Gösterim senaryoları başarıyla tamamlandı.");
            Console.ReadLine();
        }
    }
}