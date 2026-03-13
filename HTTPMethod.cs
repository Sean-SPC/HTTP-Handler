using System.Text.Json.Serialization;

public class HTTPMethod
{
    [JsonPropertyName("Method")]
    public string[] Methods { get; set; }
}