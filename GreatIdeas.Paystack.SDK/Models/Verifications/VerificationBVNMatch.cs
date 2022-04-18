namespace GreatIdeas.Paystack.SDK.Models.Verifications;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class VerificationBVNMatch
{
    /// <summary>
    /// Bank Account Number
    /// </summary>
    [Newtonsoft.Json.JsonProperty("account_number", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Account_number { get; set; }

    /// <summary>
    /// You can get the list of banks codes by calling the List Bank endpoint
    /// </summary>
    [Newtonsoft.Json.JsonProperty("bank_code", Required = Newtonsoft.Json.Required.Always)]
    public int Bank_code { get; set; }

    /// <summary>
    /// 11 digits Bank Verification Number
    /// </summary>
    [Newtonsoft.Json.JsonProperty("bvn", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Bvn { get; set; }

    /// <summary>
    /// Customer's first name
    /// </summary>
    [Newtonsoft.Json.JsonProperty("first_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string First_name { get; set; }

    /// <summary>
    /// Customer's middle name
    /// </summary>
    [Newtonsoft.Json.JsonProperty("middle_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Middle_name { get; set; }

    /// <summary>
    /// Customer's last name
    /// </summary>
    [Newtonsoft.Json.JsonProperty("last_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Last_name { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}