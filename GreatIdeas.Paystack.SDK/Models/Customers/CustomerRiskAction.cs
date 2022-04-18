namespace GreatIdeas.Paystack.SDK.Models.Customers;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomerRiskAction
{
    /// <summary>
    /// Customer's code, or email address
    /// </summary>
    [Newtonsoft.Json.JsonProperty("customer", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Customer { get; set; }

    /// <summary>
    /// One of the possible risk actions [ default, allow, deny ]. allow to whitelist. 
    /// <br/>deny to blacklist. Customers start with a default risk action.
    /// <br/>
    /// </summary>
    [Newtonsoft.Json.JsonProperty("risk_action", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Risk_action { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}