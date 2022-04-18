namespace GreatIdeas.Paystack.SDK.Models.Disputes;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class DisputeResolve
{
    /// <summary>
    /// Dispute resolution. Accepted values, merchant-accepted, declined
    /// </summary>
    [Newtonsoft.Json.JsonProperty("resolution", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Resolution { get; set; }

    /// <summary>
    /// Reason for resolving
    /// </summary>
    [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Message { get; set; }

    /// <summary>
    /// The amount to refund, in kobo if currency is NGN, pesewas, if currency is GHS, and cents, if currency is ZAR
    /// </summary>
    [Newtonsoft.Json.JsonProperty("refund_amount", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Refund_amount { get; set; }

    /// <summary>
    /// Filename of attachment returned via response from the Dispute upload URL
    /// </summary>
    [Newtonsoft.Json.JsonProperty("uploaded_filename", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Uploaded_filename { get; set; }

    /// <summary>
    /// Evidence Id for fraud claims
    /// </summary>
    [Newtonsoft.Json.JsonProperty("evidence", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int Evidence { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}