namespace GreatIdeas.Paystack.SDK.Models.Customers;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomerUpdate
{
    /// <summary>
    /// Customer's first name
    /// </summary>
    [Newtonsoft.Json.JsonProperty("first_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string First_name { get; set; }

    /// <summary>
    /// Customer's last name
    /// </summary>
    [Newtonsoft.Json.JsonProperty("last_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Last_name { get; set; }

    /// <summary>
    /// Customer's phone number
    /// </summary>
    [Newtonsoft.Json.JsonProperty("phone", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Phone { get; set; }

    /// <summary>
    /// Stringified JSON object of custom data
    /// </summary>
    [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Metadata { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}