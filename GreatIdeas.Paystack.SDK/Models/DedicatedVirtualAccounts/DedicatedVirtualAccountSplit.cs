namespace GreatIdeas.Paystack.SDK.Models.DedicatedVirtualAccounts;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class DedicatedVirtualAccountSplit
{
    /// <summary>
    /// Valid Dedicated virtual account
    /// </summary>
    [Newtonsoft.Json.JsonProperty("account_number", Required = Newtonsoft.Json.Required.Always)]
    [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    public string Account_number { get; set; }

    /// <summary>
    /// Subaccount code of the account you want to split the transaction with
    /// </summary>
    [Newtonsoft.Json.JsonProperty("subaccount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Subaccount { get; set; }

    /// <summary>
    /// Split code consisting of the lists of accounts you want to split the transaction with
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