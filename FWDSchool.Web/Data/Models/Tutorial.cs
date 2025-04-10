using System.ComponentModel.DataAnnotations.Schema;

public class Tutorial
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public TutorialType Type { get; set; }
    public DateTime Published { get; set; }
    public string Author { get; set; }

    public string ImagePath { get; set; }

    [NotMapped]
    public IFormFile File { get; set; }
}