namespace GreatIdeas.Paystack.SDK.Models.Customers;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomerValidation
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
    /// Predefined types of identification.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Type { get; set; }

    /// <summary>
    /// Two-letter country code of identification issuer
    /// </summary>
    [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Country { get; set; }

    /// <summary>
    /// Customer's Bank Verification Number
    /// </summary>
    [Newtonsoft.Json.JsonProperty("bvn", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Bvn { get; set; }

    /// <summary>
    /// You can get the list of bank codes by calling the List Banks endpoint (https://api.paystack.co/bank).
    /// </summary>
    [Newtonsoft.Json.JsonProperty("bank_code", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Bank_code { get; set; }

    /// <summary>
    /// Customer's bank account number.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("account_number", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Account_number { get; set; }

    /// <summary>
    /// Customer's identification number. Required if type is bvn
    /// </summary>
    [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Value { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}