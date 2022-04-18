namespace GreatIdeas.Paystack.SDK.Models.Subscriptions;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class SubscriptionCreate
{
    /// <summary>
    /// Customer's email address or customer code
    /// </summary>
    [Newtonsoft.Json.JsonProperty("customer", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Customer { get; set; }

    /// <summary>
    /// Plan code
    /// </summary>
    [Newtonsoft.Json.JsonProperty("plan", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Plan { get; set; }

    /// <summary>
    /// If customer has multiple authorizations, you can set the desired authorization you wish to use for this subscription here. 
    /// <br/>If this is not supplied, the customer's most recent authorization would be used
    /// </summary>
    [Newtonsoft.Json.JsonProperty("authorization", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Authorization { get; set; }

    /// <summary>
    /// Set the date for the first debit. (ISO 8601 format) e.g. 2017-05-16T00:30:13+01:00
    /// </summary>
    [Newtonsoft.Json.JsonProperty("start_date", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public DateTime Start_date { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}