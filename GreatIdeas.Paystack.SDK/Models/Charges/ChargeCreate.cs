namespace GreatIdeas.Paystack.SDK.Models.Charges;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class ChargeCreate
{
    /// <summary>
    /// Customer's email address
    /// </summary>
    [Newtonsoft.Json.JsonProperty("email", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Email { get; set; }

    /// <summary>
    /// Amount should be in kobo if currency is NGN, pesewas, if currency is GHS, and cents, if currency is ZAR
    /// </summary>
    [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Amount { get; set; }

    /// <summary>
    /// An authorization code to charge.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("authorization_code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Authorization_code { get; set; }

    /// <summary>
    /// 4-digit PIN (send with a non-reusable authorization code)
    /// </summary>
    [Newtonsoft.Json.JsonProperty("pin", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Pin { get; set; }

    /// <summary>
    /// Unique transaction reference. Only -, .`, = and alphanumeric characters allowed.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("reference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Reference { get; set; }

    /// <summary>
    /// The customer's birthday in the format YYYY-MM-DD e.g 2017-05-16
    /// </summary>
    [Newtonsoft.Json.JsonProperty("birthday", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public DateTime Birthday { get; set; }

    /// <summary>
    /// This is the unique identifier of the device a user uses in making payment. 
    /// <br/>Only -, .`, = and alphanumeric characters are allowed.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("device_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Device_id { get; set; }

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