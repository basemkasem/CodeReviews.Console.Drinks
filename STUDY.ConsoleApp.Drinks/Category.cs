using System.Text.Json.Serialization;

namespace STUDY.ConsoleApp.Drinks;

public record Category(
    [property: JsonPropertyName("strCategory")]
    string CategoryName);

public record CategoryRoot
{
    [JsonPropertyName("drinks")] 
    public List<Category> Categories { get; init; } = new();
}