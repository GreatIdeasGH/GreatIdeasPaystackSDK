namespace GreatIdeas.Paystack.SDK.Models.Charges;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class ChargeSubmitAddress
{
    /// <summary>
    /// Customer's address
    /// </summary>
    [Newtonsoft.Json.JsonProperty("address", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Address { get; set; }

    /// <summary>
    /// Customer's city
    /// </summary>
    [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string City { get; set; }

    /// <summary>
    /// Customer's state
    /// </summary>
    [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string State { get; set; }

    /// <summary>
    /// Customer's zipcode
    /// </summary>
    [Newtonsoft.Json.JsonProperty("zipcode", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Zipcode { get; set; }

    /// <summary>
    /// The reference of the ongoing transaction
    /// </summary>
    [Newtonsoft.Json.JsonProperty("reference", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Reference { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}