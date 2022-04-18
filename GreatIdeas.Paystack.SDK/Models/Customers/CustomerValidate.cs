namespace GreatIdeas.Paystack.SDK.Models.Customers;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomerValidate
{
    /// <summary>
    /// Customer's first name
    /// </summary>
    [Newtonsoft.Json.JsonProperty("first_name", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string First_name { get; set; }

    /// <summary>
    /// Customer's last name
    /// </summary>
    [Newtonsoft.Json.JsonProperty("last_name", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Last_name { get; set; }

    /// <summary>
    /// Predefined types of identification. e.g. (BVN)
    /// </summary>
    [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Type { get; set; }

    /// <summary>
    /// Customer's identification number
    /// </summary>
    [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Value { get; set; }

    /// <summary>
    /// 2 letter country code of identification issuer
    /// </summary>
    [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Country { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}