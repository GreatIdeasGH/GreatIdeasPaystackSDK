namespace GreatIdeas.Paystack.SDK.Models.Refunds;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class RefundCreate
{
    /// <summary>
    /// Transaction reference or id
    /// </summary>
    [Newtonsoft.Json.JsonProperty("transaction", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Transaction { get; set; }

    /// <summary>
    /// Amount ( in kobo if currency is NGN, pesewas, if currency is GHS, and cents, if currency is ZAR ) to be refunded to the customer. 
    /// <br/>Amount cannot be more than the original transaction amount
    /// </summary>
    [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int Amount { get; set; }

    /// <summary>
    /// Three-letter ISO currency. Allowed values are NGN, GHS, ZAR or USD
    /// </summary>
    [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Currency { get; set; }

    /// <summary>
    /// Customer reason
    /// </summary>
    [Newtonsoft.Json.JsonProperty("customer_note", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Customer_note { get; set; }

    /// <summary>
    /// Merchant reason
    /// </summary>
    [Newtonsoft.Json.JsonProperty("merchant_note", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Merchant_note { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}