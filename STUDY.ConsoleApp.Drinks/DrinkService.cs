using System.Net.Http.Json;
using System.Text.Json;

namespace STUDY.ConsoleApp.Drinks;

public class DrinkService
{
    private readonly HttpClient _httpClient = new();
    public async Task<List<Category>> GetAllCategories()
    {
		string apiUrl = "https://www.thecocktaildb.com/api/json/v1/1/list.php?c=list";
        HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);
        String responseBody = await response.Content.ReadAsStringAsync();

        var categories = JsonSerializer.Deserialize<CategoryRoot>(responseBody) ?? new CategoryRoot();
        return categories.Categories;
    }
}