namespace GreatIdeas.Paystack.SDK.Models.Disputes;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class DisputeEvidence
{
    /// <summary>
    /// Customer email
    /// </summary>
    [Newtonsoft.Json.JsonProperty("customer_email", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Customer_email { get; set; }

    /// <summary>
    /// Customer name
    /// </summary>
    [Newtonsoft.Json.JsonProperty("customer_name", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Customer_name { get; set; }

    /// <summary>
    /// Customer mobile number
    /// </summary>
    [Newtonsoft.Json.JsonProperty("customer_phone", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Customer_phone { get; set; }

    /// <summary>
    /// Details of service offered
    /// </summary>
    [Newtonsoft.Json.JsonProperty("service_details", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Service_details { get; set; }

    /// <summary>
    /// Delivery address
    /// </summary>
    [Newtonsoft.Json.JsonProperty("delivery_address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Delivery_address { get; set; }

    /// <summary>
    /// ISO 8601 representation of delivery date (YYYY-MM-DD)
    /// </summary>
    [Newtonsoft.Json.JsonProperty("delivery_date", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public DateTime Delivery_date { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}