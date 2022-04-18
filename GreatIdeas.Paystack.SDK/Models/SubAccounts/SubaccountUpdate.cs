namespace GreatIdeas.Paystack.SDK.Models.SubAccounts;

[System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v13.0.0.0))")]
public class SubaccountUpdate
{
    /// <summary>
    /// Name of business for subaccount
    /// </summary>
    [Newtonsoft.Json.JsonProperty("business_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Business_name { get; set; }

    /// <summary>
    /// Bank code for the bank. You can get the list of Bank Codes by calling the List Banks endpoint.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("settlement_bank", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Settlement_bank { get; set; }

    /// <summary>
    /// Bank account number
    /// </summary>
    [Newtonsoft.Json.JsonProperty("account_number", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Account_number { get; set; }

    /// <summary>
    /// Activate or deactivate a subaccount
    /// </summary>
    [Newtonsoft.Json.JsonProperty("active", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public bool Active { get; set; }

    /// <summary>
    /// Customer's phone number
    /// </summary>
    [Newtonsoft.Json.JsonProperty("percentage_charge", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public float Percentage_charge { get; set; }

    /// <summary>
    /// A description for this subaccount
    /// </summary>
    [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Description { get; set; }

    /// <summary>
    /// A contact email for the subaccount
    /// </summary>
    [Newtonsoft.Json.JsonProperty("primary_contact_email", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Primary_contact_email { get; set; }

    /// <summary>
    /// The name of the contact person for this subaccount
    /// </summary>
    [Newtonsoft.Json.JsonProperty("primary_contact_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Primary_contact_name { get; set; }

    /// <summary>
    /// A phone number to call for this subaccount
    /// </summary>
    [Newtonsoft.Json.JsonProperty("primary_contact_phone", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Primary_contact_phone { get; set; }

    /// <summary>
    /// Stringified JSON object of custom data
    /// </summary>
    [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
    public string Metadata { get; set; }

    private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

    [Newtonsoft.Json.JsonExtensionData]
    public IDictionary<string, object> AdditionalProperties
    {
        get { return _additionalProperties; }
        set { _additionalProperties = value; }
    }

}