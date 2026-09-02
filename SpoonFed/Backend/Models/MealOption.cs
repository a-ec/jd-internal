using NetTopologySuite.Geometries;

public class MealOption
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }

    public Point Location { get; set; } = null!;   // replaces Latitude/Longitude
    public string? Address { get; set; }

    public string Category { get; set; } = null!;
    public int? PriceLevel { get; set; }

    public double? AverageRating { get; set; }
    public int ReviewCount { get; set; }

    public DateTime LastRefreshedAt { get; set; }

    public List<MealOptionSource> Sources { get; set; } = new();
    public MealOptionTags? Tags { get; set; }
    public List<Review> Reviews { get; set; } = new();
}