namespace GreatIdeas.Paystack.SDK.Models.TransfersRecipients;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class TransferRecipientCreate
{
    /// <summary>
    /// Recipient Type (Only nuban at this time)
    /// </summary>
    [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Type { get; set; }

    /// <summary>
    /// Recipient's name
    /// </summary>
    [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Name { get; set; }

    /// <summary>
    /// Recipient's bank account number
    /// </summary>
    [Newtonsoft.Json.JsonProperty("account_number", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Account_number { get; set; }

    /// <summary>
    /// Recipient's bank code. You can get the list of Bank Codes by calling the List Banks endpoint
    /// </summary>
    [Newtonsoft.Json.JsonProperty("bank_code", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Bank_code { get; set; }

    /// <summary>
    /// A description for this recipient
    /// </summary>
    [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Description { get; set; }

    /// <summary>
    /// Currency for the account receiving the transfer
    /// </summary>
    [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Currency { get; set; }

    /// <summary>
    /// An authorization code from a previous transaction
    /// </summary>
    [Newtonsoft.Json.JsonProperty("authorization_code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Authorization_code { get; set; }

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