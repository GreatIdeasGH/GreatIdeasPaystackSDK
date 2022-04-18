using Newtonsoft.Json;

namespace GreatIdeas.Paystack.SDK.Models;

public class Response
{
    [JsonProperty("status", Required = Required.DisallowNull)]
    public bool Status { get; set; }

    [JsonProperty("message", Required = Required.DisallowNull)]
    public string? Message { get; set; }
}



