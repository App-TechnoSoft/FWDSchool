public class TutorialSection
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public byte[] Image { get; set; }
    public DateTime LastUpdated { get; set; }
    public string Author { get; set; }
    public int TutorialId { get; set; }
}