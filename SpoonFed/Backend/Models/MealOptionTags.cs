public class MealOptionTags
{
    public Guid Id { get; set; }
    public Guid MealOptionId { get; set; }              // 1:1 with MealOption

    public List<string> Allergens { get; set; }          // e.g. "peanuts", "gluten", "dairy" — flagged as PRESENT, not absent (see note below)
    public bool? GoodForGroups { get; set; }
    public int? CustomPriceBucket { get; set; }           // your own price scale, if you want it to differ from provider's

    public string? TaggedByUserId { get; set; }           // who curated this — useful once tagging is opened up beyond your team
    public DateTime TaggedAt { get; set; }
}