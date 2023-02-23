using System.Text.Json.Serialization;

namespace FirstApp.Models;


public record NasaResponse{
        [JsonPropertyName("copyright")]
        public string copyright {get; set;}

        [JsonPropertyName("date")]
        public string date {get; set;}
        
        [JsonPropertyName("explanation")]
        public string explanation {get; set;}
        
        [JsonPropertyName("hdurl")]
        public string hdurl {get; set;}
        
        [JsonPropertyName("media_type")]
        public string mediaType {get; set;}
        
        [JsonPropertyName("url")]
        public string url {get; set;}
        
        [JsonPropertyName("service_version")]
        public string serviceVersion {get; set;}
        
        [JsonPropertyName("title")]
public string title {get; set;}
}

