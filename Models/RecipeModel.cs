using System.Text.Json.Serialization;

namespace KitchenBuddy.Models;
public class RecipeModel
{
    [JsonPropertyName("recipeId")]
    public int Id { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("ingredients")]
    public List<Ingredient> Ingredients  { get; set; }
    
    [JsonPropertyName("steps")] 
    public string[] Steps { get; set; }

    [JsonPropertyName("time")] //Minutes
    public int Time { get; set; }
    
    [JsonPropertyName("dificulty")] //Hard, Medium, Easy
    public string Dificulty { get; set; }
    
    [JsonPropertyName("origin")] //Italian, Spain, Argentinian
    public string Origin { get; set; }
    
    [JsonPropertyName("base")]  //Pasta, Chicken, Meat, Salad
    public string Base { get; set; }
}

public class Ingredient
{
    
    // [JsonPropertyName("ingredientId")]
    // public int Id { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("quantity")]
    public string Quantity { get; set; }
}