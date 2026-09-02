public class MealOption
{
    public Guid Id { get; set; }                     // your internal ID — everything else keys off this

    public string Name { get; set; }
    public string? Description { get; set; }          // short blurb for the results card
    public string? ImageUrl { get; set; }

    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string? Address { get; set; }

    public string Category { get; set; }               // maps to Quick Pick categories: Burger, Sandwiches, Turkey, Soups, Broad
    public int? PriceLevel { get; set; }                // 1-4 ($ to $$$$), nullable since not every provider has it

    public double? AverageRating { get; set; }          // computed from your own Reviews, not the provider's rating
    public int ReviewCount { get; set; }                // denormalized count, updated when reviews are added

    public DateTime LastRefreshedAt { get; set; }       // when provider data was last pulled — drives your caching logic

    public List<MealOptionSource> Sources { get; set; }  // which provider(s) contributed to this record
    public MealOptionTags? Tags { get; set; }             // your own curated data, nullable until someone tags it
    public List<Review> Reviews { get; set; }
}

public class MealOptionSource
{
    public Guid Id { get; set; }
    public Guid MealOptionId { get; set; }
    public string Provider { get; set; }                // "Yelp" | "Foursquare" | "OSM"
    public string ProviderPlaceId { get; set; }          // that provider's own ID, for re-fetching/refresh
}