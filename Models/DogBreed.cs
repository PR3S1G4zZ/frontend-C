using System.Text.Json.Serialization;

namespace ConsumoAPI2.Wasm.Models
{
    public class DogBreed
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("breed_group")]
        public string BreedGroup { get; set; } = string.Empty;

        [JsonPropertyName("origin")]
        public string Origin { get; set; } = string.Empty;

        [JsonPropertyName("image")]
        public DogImage? Image { get; set; }
    }

    public class DogImage
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;
    }
}
