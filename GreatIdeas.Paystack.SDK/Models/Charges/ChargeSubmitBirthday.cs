namespace GreatIdeas.Paystack.SDK.Models.Charges;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class ChargeSubmitBirthday
{
    /// <summary>
    /// Customer's birthday in the format YYYY-MM-DD e.g 2016-09-21
    /// </summary>
    [Newtonsoft.Json.JsonProperty("birthday", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Birthday { get; set; }

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