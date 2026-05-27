namespace SmartCampus.Domain.Factory
{
    public interface IAnnouncement
    {
        string Title { get; }
        string Content { get; }
        void Display();
    }
}