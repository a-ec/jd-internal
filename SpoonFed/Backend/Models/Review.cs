public class Review
{
    public Guid Id { get; set; }
    public Guid MealOptionId { get; set; }
    public Guid ProfileId { get; set; }                  // ties to the Profile system (Group / Jared / etc.), not raw User

    public int Rating { get; set; }                       // e.g. 1-5
    public string? Text { get; set; }
    public string? DishName { get; set; }                 // optional — lets a review be about a specific item, not just the restaurant
    public DateTime CreatedAt { get; set; }
}