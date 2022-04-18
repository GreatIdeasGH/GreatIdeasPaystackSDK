namespace GreatIdeas.Paystack.SDK.Models.BulkCharges;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class BulkChargeInitiate
{
    /// <summary>
    /// Customer's card authorization code
    /// </summary>
    [Newtonsoft.Json.JsonProperty("authorization", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Authorization { get; set; }

    /// <summary>
    /// Amount to charge on the authorization
    /// </summary>
    [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Amount { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}