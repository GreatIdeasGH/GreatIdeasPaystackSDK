namespace GreatIdeas.Paystack.SDK.Models.PaymentRequests;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class PaymentRequestUpdate
{
    /// <summary>
    /// Customer id or code
    /// </summary>
    [Newtonsoft.Json.JsonProperty("customer", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Customer { get; set; }

    /// <summary>
    /// Payment request amount. Only useful if line items and tax values are ignored. 
    /// <br/>The endpoint will throw a friendly warning if neither is available.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int Amount { get; set; }

    /// <summary>
    /// Specify the currency of the invoice. Allowed values are NGN, GHS, ZAR and USD. Defaults to NGN
    /// </summary>
    [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Currency { get; set; }

    /// <summary>
    /// ISO 8601 representation of request due date
    /// </summary>
    [Newtonsoft.Json.JsonProperty("due_date", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public DateTime Due_date { get; set; }

    /// <summary>
    /// A short description of the payment request
    /// </summary>
    [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Description { get; set; }

    /// <summary>
    /// Array of line items
    /// </summary>
    [Newtonsoft.Json.JsonProperty("line_items", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public ICollection<object> Line_items { get; set; }

    /// <summary>
    /// Array of taxes
    /// </summary>
    [Newtonsoft.Json.JsonProperty("tax", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public ICollection<object> Tax { get; set; }

    /// <summary>
    /// Indicates whether Paystack sends an email notification to customer. Defaults to true
    /// </summary>
    [Newtonsoft.Json.JsonProperty("send_notification", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool Send_notification { get; set; }

    /// <summary>
    /// Indicate if request should be saved as draft. Defaults to false and overrides send_notification
    /// </summary>
    [Newtonsoft.Json.JsonProperty("draft", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool Draft { get; set; }

    /// <summary>
    /// Set to true to create a draft invoice (adds an auto incrementing invoice number if none is provided) 
    /// <br/>even if there are no line_items or tax passed
    /// </summary>
    [Newtonsoft.Json.JsonProperty("has_invoice", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool Has_invoice { get; set; }

    /// <summary>
    /// Numeric value of invoice. Invoice will start from 1 and auto increment from there. This field is to help 
    /// <br/>override whatever value Paystack decides. Auto increment for subsequent invoices continue from this point.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("invoice_number", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public int Invoice_number { get; set; }

    /// <summary>
    /// The split code of the transaction split.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("split_code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Split_code { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}