using System.Text.Json.Serialization;

namespace dotnet7_outputcache;

public class Customer : CustomerDto
{
    [JsonPropertyOrder(98)]
    public DateTime CreatedOn { get; set; }

    [JsonPropertyOrder(99)]
    public DateTime? ModifiedOn { get; set; }
}