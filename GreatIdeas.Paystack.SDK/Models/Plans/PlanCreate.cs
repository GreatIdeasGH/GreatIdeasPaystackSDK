namespace GreatIdeas.Paystack.SDK.Models.Plans;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class PlanCreate
{
    /// <summary>
    /// Name of plan
    /// </summary>
    [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Name { get; set; }

    /// <summary>
    /// Amount should be in kobo if currency is NGN, pesewas, if currency is GHS, and cents, if currency is ZAR
    /// </summary>
    [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Always)]
    public int Amount { get; set; }

    /// <summary>
    /// Interval in words. Valid intervals are daily, weekly, monthly,biannually, annually
    /// </summary>
    [Newtonsoft.Json.JsonProperty("interval", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Interval { get; set; }

    /// <summary>
    /// A description for this plan
    /// </summary>
    [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool Description { get; set; }

    /// <summary>
    /// Set to false if you don't want invoices to be sent to your customers
    /// </summary>
    [Newtonsoft.Json.JsonProperty("send_invoices", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool Send_invoices { get; set; }

    /// <summary>
    /// Set to false if you don't want text messages to be sent to your customers
    /// </summary>
    [Newtonsoft.Json.JsonProperty("send_sms", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool Send_sms { get; set; }

    /// <summary>
    /// Currency in which amount is set. Allowed values are NGN, GHS, ZAR or USD
    /// </summary>
    [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Currency { get; set; }

    /// <summary>
    /// Number of invoices to raise during subscription to this plan. 
    /// <br/>Can be overridden by specifying an invoice_limit while subscribing.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("invoice_limit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int Invoice_limit { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}